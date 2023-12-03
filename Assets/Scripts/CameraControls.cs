using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class CameraControls : MonoBehaviour
{

    public Transform camTarget;
    public Camera camera;
    private int vMode=-1;
    private int thirdView=-1;
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    //public Vector3 thirdParam = new Vector3(0.0f,1.0f,-3.0f);
    public Vector3 firstCameraDistance = new Vector3(0.0f,0.0f,0.04f);
    public Vector3 thridCameraDistance = new Vector3(0.0f,0.1f,-0.5f);
    public float cameraLerp= 0.5f;
    public float firstLensSize=0.01f;
    public float thirdLensSize=0.2f;
    public UnityEvent freeCameraOn, freeCameraOff;

    // drone's ridgidbody
    public Rigidbody droneRigidbody;

    DefaultInputController inputController;

    private void Awake()
    {
        inputController = new DefaultInputController();
        inputController.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // change camera mode only if game not paused
        if (Time.deltaTime > 0)
        {
            // Input.GetKeyDown(KeyCode.V)
            if (inputController.Player.CameraMode.triggered && inputController.Player.CameraMode.ReadValue<float>() == default)
            {
                vMode *= -1;
                if (vMode == 1)
                {
                    freeCameraOn?.Invoke();
                    droneRigidbody.isKinematic = true;
                }
                else
                {
                    freeCameraOff?.Invoke();
                    droneRigidbody.isKinematic = false;
                }
            }
            // Input.GetKeyDown(KeyCode.B)
            if (inputController.Player.POV.triggered && inputController.Player.POV.ReadValue<float>() == default)
                thirdView *= -1;

            if (vMode == -1)
            {
                if (thirdView == -1)
                {
                    transform.position = Vector3.Lerp(transform.position, camTarget.position + camTarget.TransformDirection(firstCameraDistance), cameraLerp);
                    transform.rotation = camTarget.rotation;
                    //GetComponent<Camera>().nearClipPlane= firstLensSize;
                    camera.nearClipPlane = firstLensSize;
                }
                else
                {
                    //transform.position = camTarget.position + camTarget.TransformDirection(thirdParam)
                    transform.position = Vector3.Lerp(transform.position, camTarget.position + camTarget.TransformDirection(thridCameraDistance), cameraLerp);
                    transform.rotation = camTarget.rotation;
                    //GetComponent<Camera>().nearClipPlane= thirdLensSize;
                    camera.nearClipPlane = thirdLensSize;
                }
            }
            else
            {
                //float vert = Input.GetAxis("Vertical") * speed;
                //float horz = Input.GetAxis("Horizontal") * speed;
                float vert = (inputController.Player.PitchForward.ReadValue<float>() - inputController.Player.PitchBackward.ReadValue<float>()) * speed;
                float horz = -(inputController.Player.RollLeft.ReadValue<float>() - inputController.Player.RollRight.ReadValue<float>()) * speed;
                vert *= Time.deltaTime;
                horz *= Time.deltaTime;
                transform.Translate(horz, 0, vert);
            }
        }
    }
}
