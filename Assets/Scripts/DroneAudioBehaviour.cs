using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class DroneAudioBehaviour : MonoBehaviour
{
    Animator droneAnimator;
    public AudioSource droneSFX;
    public Slider audioSlider;

    private float volume;
    private bool isHovering;
    private bool isVMode;
    private DroneStatusBehaviour checkGrounded;

    DefaultInputController inputController;

    // Start is called before the first frame update
    void Start()
    {
        droneAnimator = GetComponent<Animator>();
        droneSFX.volume = audioSlider.value;
        isHovering = false;
        isVMode = false;

        checkGrounded = GetComponent<DroneStatusBehaviour>();
    }

    private void Awake()
    {
        inputController = new DefaultInputController();
        inputController.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        volume = audioSlider.value;

        // play sound if game not paused
        if (Time.deltaTime > 0) {

            // check if drone is in hoovering mode
            if (inputController.Player.Hover.triggered && inputController.Player.Hover.ReadValue<float>() == default && !isVMode)
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

            // check if drone is in camera mode
            if (inputController.Player.CameraMode.triggered && inputController.Player.CameraMode.ReadValue<float>() == default)
            {
                if (isVMode)
                {
                    isVMode = false;
                }
                else
                {
                    isVMode = true;
                }
            }

            bool wKey = inputController.Player.PitchForward.ReadValue<float>() > 0.1f;
            bool aKey = inputController.Player.RollLeft.ReadValue<float>() > 0.1f;
            bool sKey = inputController.Player.PitchBackward.ReadValue<float>() > 0.1f;
            bool dKey = inputController.Player.RollRight.ReadValue<float>() > 0.1f;
            bool qKey = inputController.Player.YawLeft.ReadValue<float>() > 0.1f;
            bool eKey = inputController.Player.YawRight.ReadValue<float>() > 0.1f;
            bool spaceKey = inputController.Player.Ascend.ReadValue<float>() > 0;

            //play sound if animation is playing
            //if (droneAnimator.GetBool("isFlying"))
            if (spaceKey || wKey || sKey || aKey || dKey || qKey || eKey || isHovering)
            {
                if ((!isVMode && (!checkGrounded.IsGrounded() || spaceKey)) || (!isVMode && isHovering))
                {
                    droneSFX.volume = volume;
                    // higher pitch if drone is ascending
                    if (spaceKey && !isHovering)
                    {
                        droneSFX.pitch = 1.5f;
                    }
                    else
                    {
                        droneSFX.pitch = 1f;
                    }
                }
                
            }
            else
            {
                if (droneSFX.volume > 0)
                {
                    droneSFX.volume -= 3f * Time.deltaTime;
                }
            }

            //if (isVMode)
            if (isVMode || (checkGrounded.IsGrounded() && !isHovering))
            {
                //droneSFX.volume = 0;
                if (droneSFX.volume > 0 && !isVMode)
                {
                    droneSFX.volume -= 3f * Time.deltaTime;
                }
                else
                {
                    droneSFX.volume = 0;
                }
            }
        }
        else
        {
            droneSFX.volume = 0;
        }

    }
}
