using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementController : MonoBehaviour {
	private struct Keys {
		// movement
		public bool wKey, aKey, sKey, dKey, spaceKey;

		// rotation
		public bool qKey, eKey;
	}
	private Keys keys;

	private Rigidbody droneRigidbody;
	private BoxCollider droneBoxCollider;
	private Animator droneAnimator;

	private float maxPitch = 25f;
	private float maxRoll = 25f;
	private float yawPower = 2f;
	private float lerpSpeed = 0.6f;
	private float enginePower = 10f;
	private float maxSpeed = 1f;

	private float engineForce, finalEngineForce, yaw, finalPitch, finalRoll, finalYaw;
	private bool hover = false;
	private float hoverHeight;

	DefaultInputController inputController;

	// Start is called before the first frame update
	private void Awake() {
		droneRigidbody = GetComponent<Rigidbody>();
		droneBoxCollider = GetComponent<BoxCollider>();
		droneAnimator = GetComponent<Animator>();

		inputController = new DefaultInputController();
		inputController.Enable();
	}

	// Update is called once per frame
	private void Update() {
		GetInput();
	}

	private void FixedUpdate() {
		Engine();
		Controls();
	}
	void OnEnable()
	{
		keys.spaceKey = false;
	}

	private void GetInput() {
		// collision toggle, could be moved elsewhere
		if (inputController.Player.CollisionMode.triggered && inputController.Player.CollisionMode.ReadValue<float>() == default)
			droneBoxCollider.enabled = !droneBoxCollider.enabled;

		if (inputController.Player.Ascend.triggered && inputController.Player.Ascend.ReadValue<float>() > 0)							// Vertical ascent
			keys.spaceKey = true;
		else if (inputController.Player.Ascend.triggered && keys.spaceKey)							// Slowly stop momentum
		{
			keys.spaceKey = false;
			//droneRigidbody.velocity /= 3;
			//droneRigidbody.angularVelocity /= 3;
		}

		if (inputController.Player.Hover.triggered && inputController.Player.Hover.ReadValue<float>() == default && Time.deltaTime > 0)	// Hover toggle
        {
            if (!hover)
            {
                hover = true;
                hoverHeight = transform.position.y;
            }
            else
            {
                droneRigidbody.velocity = Vector3.zero;
                droneRigidbody.angularVelocity = Vector3.zero;
                hover = false;
            }

		}

		keys.wKey = inputController.Player.PitchForward.ReadValue<float>() > 0.1f;
		keys.aKey = inputController.Player.RollLeft.ReadValue<float>() > 0.1f;
		keys.sKey = inputController.Player.PitchBackward.ReadValue<float>() > 0.1f;
		keys.dKey = inputController.Player.RollRight.ReadValue<float>() > 0.1f;
		keys.qKey = inputController.Player.YawLeft.ReadValue<float>() > 0.1f;
		keys.eKey = inputController.Player.YawRight.ReadValue<float>() > 0.1f;

		bool wKeyUp = inputController.Player.PitchForward.triggered && inputController.Player.PitchForward.ReadValue<float>() == default;
		bool sKeyUp = inputController.Player.PitchBackward.triggered && inputController.Player.PitchBackward.ReadValue<float>() == default;
		bool aKeyUp = inputController.Player.RollLeft.triggered && inputController.Player.RollLeft.ReadValue<float>() == default;
		bool dKeyUp = inputController.Player.RollRight.triggered && inputController.Player.RollRight.ReadValue<float>() == default;

		if (wKeyUp || sKeyUp || aKeyUp || dKeyUp)  // Slowly stop momentum
		{
			droneRigidbody.velocity /= 2;
			droneRigidbody.angularVelocity /= 2;
		}
	}

	private void Engine() {
		if (keys.spaceKey)										// Vertical ascent
		{
			engineForce = enginePower;
			finalEngineForce = Mathf.Lerp(finalEngineForce, engineForce, Time.deltaTime * lerpSpeed);
			droneRigidbody.AddForce(transform.up * finalEngineForce, ForceMode.Force);
			RotateBlades();
		}
		else if (!hover)										// Apply gravity to drone
		{
			droneRigidbody.AddForce(Physics.gravity.magnitude * Vector3.down);
		}

		if (hover) {
			transform.position = new Vector3(transform.position.x, hoverHeight, transform.position.z);
			RotateBlades();
		}
	}

	private void Controls() {
		//float pitch = Input.GetAxisRaw("Vertical") * maxPitch;
		//float roll = -Input.GetAxisRaw("Horizontal") * maxRoll;
		float pitch = (inputController.Player.PitchForward.ReadValue<float>() - inputController.Player.PitchBackward.ReadValue<float>()) * maxPitch;
		float roll = (inputController.Player.RollLeft.ReadValue<float>() - inputController.Player.RollRight.ReadValue<float>()) * maxRoll;

		finalYaw = Mathf.Lerp(finalYaw, yaw, Time.deltaTime * lerpSpeed);
        Quaternion yawRotation = Quaternion.Euler(0, finalYaw, 0);

        if (keys.eKey && !IsGrounded())							// Rotating drone
        {
            yaw += yawPower;
            RotateBlades();
            droneRigidbody.MoveRotation(yawRotation);
        }
        else if (keys.qKey && !IsGrounded())
        {
            yaw -= yawPower;
            RotateBlades();
            droneRigidbody.MoveRotation(yawRotation);
        }

        finalPitch = Mathf.Lerp(finalPitch, pitch, Time.deltaTime * lerpSpeed);
        finalRoll = Mathf.Lerp(finalRoll, roll, Time.deltaTime * lerpSpeed);
        Quaternion droneRotation = Quaternion.Euler(finalPitch, finalYaw, finalRoll);

		bool wKey = inputController.Player.PitchForward.ReadValue<float>() > 0.1f;
		bool sKey = inputController.Player.PitchBackward.ReadValue<float>() > 0.1f;
		bool aKey = inputController.Player.RollLeft.ReadValue<float>() > 0.1f;
		bool dKey = inputController.Player.RollRight.ReadValue<float>() > 0.1f;

		if ((wKey || sKey || aKey || dKey) && !IsGrounded())
		{
            droneRigidbody.AddForce(transform.right * -roll * lerpSpeed);
            droneRigidbody.AddForce(transform.forward * pitch * lerpSpeed);
            RotateBlades();

            droneRigidbody.MoveRotation(droneRotation);
        }
		else if (!IsGrounded())									// Let the drone return to parallel
		{
            droneRigidbody.MoveRotation(droneRotation);
        }
		else if (!keys.spaceKey && IsGrounded())				// Set drone to flat and still if grounded
		{
            droneRigidbody.MoveRotation(yawRotation);
			finalPitch = 0;
			finalRoll = 0;
        }

		if (droneRigidbody.velocity.sqrMagnitude > maxSpeed)	// Set a speed limit for the drone
			droneRigidbody.velocity = Vector3.ClampMagnitude(droneRigidbody.velocity, maxSpeed);
    }

    private void RotateBlades()									// Animate blade rotation
	{
		for (int i = 0; i < this.gameObject.transform.childCount; i++)		// Searching for the blades
		{
			if (this.gameObject.transform.GetChild(i).name == "Blades") {
				for (int j = 0; j < this.gameObject.transform.GetChild(i).childCount; j++)
					this.gameObject.transform.GetChild(i).GetChild(j).transform.Rotate(0, 0, 30f);
			}
		}
		droneAnimator.SetBool("isFlying", true);
	}

	bool IsGrounded() {
		Debug.DrawRay(new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z), Vector3.down, Color.green, 0.05f);
		return Physics.Raycast(new Vector3(transform.position.x, transform.position.y - 0.01f, transform.position.z), Vector3.down, 0.05f);
	}
}
