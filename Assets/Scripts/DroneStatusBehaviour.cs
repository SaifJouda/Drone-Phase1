using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class DroneStatusBehaviour : MonoBehaviour
{
    public GameObject altitudeUI;
    public GameObject StatusUI;

    Animator droneAnimator;
    Rigidbody droneRigidbody;
    private TextMeshProUGUI altitude;

    private bool colliding;
    private bool moving;
    private GameObject airborneStatus;
    private GameObject groundedStatus;
    private GameObject collidingStatus;
    private GameObject hoveringStatus;
    private GameObject CollisionStatus;

    private bool isHovering;
    private bool isXMode;

    DefaultInputController inputController;

    // Start is called before the first frame update
    void Start()
    {
        droneAnimator = GetComponent<Animator>();
        droneRigidbody = GetComponent<Rigidbody>();
        altitude = altitudeUI.transform.GetChild(0).GetComponent<TextMeshProUGUI>();

        airborneStatus = StatusUI.transform.GetChild(1).gameObject;
        groundedStatus = StatusUI.transform.GetChild(2).gameObject;
        collidingStatus = StatusUI.transform.GetChild(3).gameObject;
        hoveringStatus = StatusUI.transform.GetChild(4).gameObject;
        CollisionStatus = StatusUI.transform.GetChild(5).gameObject;

        colliding = false;
        moving = false;
        isHovering = false;
        isXMode = false;
    }

    private void Awake()
    {
        inputController = new DefaultInputController();
        inputController.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        // check if drone is in hoovering mode
        if (Time.deltaTime > 0)
        {
            if (inputController.Player.Hover.triggered && inputController.Player.Hover.ReadValue<float>() == default)
            {
                if (isHovering)
                {
                    isHovering = false;
                }
                else
                {
                    isHovering = true;
                }
            }
            if (inputController.Player.CollisionMode.triggered && inputController.Player.CollisionMode.ReadValue<float>() == default)
            {
                if (isXMode)
                {
                    isXMode = false;
                    colliding = false;
                }
                else
                {
                    isXMode = true;
                }
            }
        }

        // caculate and display altitude (according to y position)
        altitude.text = (transform.position.y).ToString("F2");

        // check if drone is moving
        if (droneRigidbody.velocity.magnitude > 0.25f || inputController.Player.Ascend.ReadValue<float>() > 0)
            moving = true;
        else
            moving = false;

        // drone must be airborned if not colliding with anything or collision is disabled
        if (!colliding || isXMode)
        {
            if (isXMode)
            {
                airborneStatus.SetActive(false);
                groundedStatus.SetActive(false);
                collidingStatus.SetActive(false);
                hoveringStatus.SetActive(false);
                CollisionStatus.SetActive(true);
            }
            else if (isHovering)
            {
                airborneStatus.SetActive(false);
                groundedStatus.SetActive(false);
                collidingStatus.SetActive(false);
                hoveringStatus.SetActive(true);
                CollisionStatus.SetActive(false);
            }
            else
            {
                airborneStatus.SetActive(true);
                groundedStatus.SetActive(false);
                collidingStatus.SetActive(false);
                hoveringStatus.SetActive(false);
                CollisionStatus.SetActive(false);
            }
            
        }
        // drone must be grounded if it is colliding and is not moving
        // else if (colliding && !droneAnimator.GetBool("isFlying"))
        else if (colliding && !moving)
        {
            if (isHovering)
            {
                airborneStatus.SetActive(false);
                groundedStatus.SetActive(false);
                collidingStatus.SetActive(false);
                hoveringStatus.SetActive(true);
                CollisionStatus.SetActive(false);
            }
            else
            {
                airborneStatus.SetActive(false);
                groundedStatus.SetActive(true);
                collidingStatus.SetActive(false);
                hoveringStatus.SetActive(false);
                CollisionStatus.SetActive(false);
            }
        }
        // drone must be colliding if it is colliding and moving
        else
        {
            airborneStatus.SetActive(false);
            groundedStatus.SetActive(false);
            collidingStatus.SetActive(true);
            hoveringStatus.SetActive(false);
            CollisionStatus.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        colliding = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        colliding = false;
    }

    public bool IsGrounded()
    {
        return !moving;
    }
}
