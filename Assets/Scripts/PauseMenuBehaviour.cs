using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PauseMenuBehaviour : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenu;
    public GameObject optionSubMenu;
    public GameObject settingSubMenu;
    public GameObject helpSubMenu;
    public GameObject helpSubMenuOptions;
    public GameObject helpSubMenu1;
    public GameObject helpSubMenu2;
    public GameObject helpSubMenu3;
    public GameObject startScreen;
    public GameObject firstSelectBtn;
    public EventSystem eventSystem;

    public PlayerInput playerInput;
    public GameObject VirtualCursor;

    public Rigidbody droneRigidbody;
    private bool inVMode = false;

    public UnityEvent enableInput, disableInput;

    DefaultInputController inputController;

    void Start()
    {
        // Initialize variables; self explanatory
        GamePaused = true;
        Time.timeScale = 0f;
        droneRigidbody.isKinematic = true;
        Cursor.lockState = CursorLockMode.None;
        disableInput?.Invoke();

        playerInput.enabled = true;

    }

    private void Awake()
    {
        inputController = new DefaultInputController();
        inputController.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // If player pressed 'ESC' and the game is not over; Resume game if paused, pause if not.
        if (inputController.Player.Pause.triggered && inputController.Player.Pause.ReadValue<float>() == default)
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {
        // hide and rest the paused menu and resume game
        ResetPausedMenu();
        pauseMenu.SetActive(false);
        startScreen.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;

        if (!inVMode)
        {
            droneRigidbody.isKinematic = false;
            enableInput?.Invoke();
        }

        // lock and hide cursor when not in menu
        playerInput.enabled = false;
        VirtualCursor.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Pause()
    {
        // pause game and show menu
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;

        //var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(firstSelectBtn, new BaseEventData(eventSystem));

        if (droneRigidbody.isKinematic == true)
        {
            inVMode = true;
        }
        else
        {
            inVMode = false;
        }
        droneRigidbody.isKinematic = true;

        if (!inVMode) {
            disableInput?.Invoke();
        }

        // unlock cursor when in menu
        playerInput.enabled = true;
        //VirtualCursor.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    private void ResetPausedMenu()
    {
        optionSubMenu.SetActive(true);
        settingSubMenu.SetActive(false);
        helpSubMenu.SetActive(false);
        helpSubMenuOptions.SetActive(true);
        helpSubMenu1.SetActive(false);
        helpSubMenu2.SetActive(false);
        helpSubMenu3.SetActive(false);
    }

    // Reload Current Game Scene
    public void ReloadCurrentScene()
    {
        // unpause time loading into scene
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Exit Game
    public void ExitGame()
    {
        Debug.Log("Exit Game.");
        Application.Quit();
    }
}
