//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/InputSystem/DefaultInputController.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @DefaultInputController : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaultInputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultInputController"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f62a4b92-ef5e-4175-8f4c-c9075429d32c"",
            ""actions"": [
                {
                    ""name"": ""Ascend"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7ec1968a-60eb-4a9e-bcf0-558cb8bb5718"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PitchForward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8c16d28e-d93b-4ee7-a78c-36aaa7f7fddf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PitchBackward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""25c918de-5962-4308-a09e-93110b1fd6df"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RollLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95dc2042-d145-4f7c-8dec-6586c64f2acf"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""RollRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""20ea2a98-daad-445b-a615-f7c0a71e1e54"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""YawLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7e6b5d4a-a61e-46d8-b893-28808dd4596b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""YawRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""13969a2c-5917-45a7-96d5-65056194d2fe"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hover"",
                    ""type"": ""PassThrough"",
                    ""id"": ""43d10ce3-60fd-440c-9400-90f62d28c555"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraMode"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7f0e09c0-e4bf-44fe-b947-7777661d445f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""POV"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dfb39479-ae87-4aa9-a5a8-0303ba310667"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CollisionMode"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0e39af03-1f94-477e-bcf9-e22f99b5bc4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad67f667-1145-470c-bc60-5d01fac54305"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cfd57dec-b213-41c4-b420-02c2f47bf2e8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0bd17eed-f515-4cb8-a4d9-2bf3237a1d67"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller;PS4 Controller;Gamepad"",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a235e223-4cea-4cf8-b4e0-62bd89bb0fc2"",
                    ""path"": ""<OculusTouchController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""Ascend"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b760c935-df29-4251-be21-6fbc16a901f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PitchForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc5992aa-ed67-444b-b023-c51e2ec6c6ac"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""PitchForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18b1192a-66b9-4cdb-93db-61f52e11c035"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""PitchForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8de1e29c-f1d0-4509-b421-e391cfb04f32"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PitchBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""febf6e58-a650-441f-86a6-8f2df7b681a7"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""PitchBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee814160-26dc-450e-b168-9e85b390ee7b"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""PitchBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d38ee70-694a-4b04-9696-a2d3808b7259"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""RollLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""050cc6f0-6473-4df4-9194-fa53d412cb88"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""RollLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""211849b3-98a9-4493-ba30-a189a139cc06"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""RollLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6add2b46-b184-406d-b5b2-6c19cb5d1313"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""RollRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e751331-2f78-48ff-b0d8-c37788a91add"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""RollRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b99375d2-fd72-4258-b71c-cfdd5ffb997d"",
                    ""path"": ""<OculusTouchController>{RightHand}/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""RollRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""68c5475e-0bf8-4bfc-b86f-94db9168b397"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""YawLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ac4d87e-7305-4259-afb3-a4cbe36945a2"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""YawLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c15296f-53d5-4c31-8d53-021beda3da78"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""YawLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""533abb7c-b584-4d56-9039-e5195f1054a9"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""YawRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07191789-e06e-4213-bf6c-9e8f8c330818"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""YawRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ea8923a-6982-4fc3-8254-c7024a46c69a"",
                    ""path"": ""<OculusTouchController>{LeftHand}/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""YawRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97e5503a-fa36-44f5-a04c-cf638d07db46"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""140ca5df-33a2-49c1-becf-661ab3a55507"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17521d0e-5897-4097-879b-0861cfc36266"",
                    ""path"": ""<OculusTouchController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""Hover"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5263f54c-994f-40d4-82f0-eae6dd401182"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CameraMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8686a763-e9ad-4ca0-bed7-3b141e0d69c3"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""CameraMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""354fde0e-7dba-46e4-9506-a431eea3dd0e"",
                    ""path"": ""<OculusTouchController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""CameraMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""079a73bb-14f5-4fb5-b946-3c132eb3252f"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""POV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2edbe8a-f58c-4334-86f9-7b45d4988a57"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""POV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a28e8cfb-6615-40cd-b5f2-5483831ae458"",
                    ""path"": ""<OculusTouchController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""POV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83ff3bd8-3a21-4320-881c-4a0818c5adea"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CollisionMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5830fcfd-c9bf-474e-a1f2-735075be71bd"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""CollisionMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f42ba1e9-e52f-452d-acdc-7fe976ef3503"",
                    ""path"": ""<OculusTouchController>{LeftHand}/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""CollisionMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35d78b2a-6c11-459b-84ed-d849bdc05af4"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b68b89d2-d769-4988-adde-fb0d948a0222"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;Xbox Controller;PS4 Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""968743ca-7556-4c5c-96ab-756988ae4c31"",
                    ""path"": ""<OculusTouchController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox Controller"",
            ""bindingGroup"": ""Xbox Controller"",
            ""devices"": []
        },
        {
            ""name"": ""PS4 Controller"",
            ""bindingGroup"": ""PS4 Controller"",
            ""devices"": []
        },
        {
            ""name"": ""XR Controller"",
            ""bindingGroup"": ""XR Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Ascend = m_Player.FindAction("Ascend", throwIfNotFound: true);
        m_Player_PitchForward = m_Player.FindAction("PitchForward", throwIfNotFound: true);
        m_Player_PitchBackward = m_Player.FindAction("PitchBackward", throwIfNotFound: true);
        m_Player_RollLeft = m_Player.FindAction("RollLeft", throwIfNotFound: true);
        m_Player_RollRight = m_Player.FindAction("RollRight", throwIfNotFound: true);
        m_Player_YawLeft = m_Player.FindAction("YawLeft", throwIfNotFound: true);
        m_Player_YawRight = m_Player.FindAction("YawRight", throwIfNotFound: true);
        m_Player_Hover = m_Player.FindAction("Hover", throwIfNotFound: true);
        m_Player_CameraMode = m_Player.FindAction("CameraMode", throwIfNotFound: true);
        m_Player_POV = m_Player.FindAction("POV", throwIfNotFound: true);
        m_Player_CollisionMode = m_Player.FindAction("CollisionMode", throwIfNotFound: true);
        m_Player_Pause = m_Player.FindAction("Pause", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Ascend;
    private readonly InputAction m_Player_PitchForward;
    private readonly InputAction m_Player_PitchBackward;
    private readonly InputAction m_Player_RollLeft;
    private readonly InputAction m_Player_RollRight;
    private readonly InputAction m_Player_YawLeft;
    private readonly InputAction m_Player_YawRight;
    private readonly InputAction m_Player_Hover;
    private readonly InputAction m_Player_CameraMode;
    private readonly InputAction m_Player_POV;
    private readonly InputAction m_Player_CollisionMode;
    private readonly InputAction m_Player_Pause;
    public struct PlayerActions
    {
        private @DefaultInputController m_Wrapper;
        public PlayerActions(@DefaultInputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Ascend => m_Wrapper.m_Player_Ascend;
        public InputAction @PitchForward => m_Wrapper.m_Player_PitchForward;
        public InputAction @PitchBackward => m_Wrapper.m_Player_PitchBackward;
        public InputAction @RollLeft => m_Wrapper.m_Player_RollLeft;
        public InputAction @RollRight => m_Wrapper.m_Player_RollRight;
        public InputAction @YawLeft => m_Wrapper.m_Player_YawLeft;
        public InputAction @YawRight => m_Wrapper.m_Player_YawRight;
        public InputAction @Hover => m_Wrapper.m_Player_Hover;
        public InputAction @CameraMode => m_Wrapper.m_Player_CameraMode;
        public InputAction @POV => m_Wrapper.m_Player_POV;
        public InputAction @CollisionMode => m_Wrapper.m_Player_CollisionMode;
        public InputAction @Pause => m_Wrapper.m_Player_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Ascend.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAscend;
                @Ascend.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAscend;
                @Ascend.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAscend;
                @PitchForward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchForward;
                @PitchForward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchForward;
                @PitchForward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchForward;
                @PitchBackward.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchBackward;
                @PitchBackward.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchBackward;
                @PitchBackward.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPitchBackward;
                @RollLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollLeft;
                @RollLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollLeft;
                @RollLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollLeft;
                @RollRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollRight;
                @RollRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollRight;
                @RollRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRollRight;
                @YawLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYawLeft;
                @YawLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYawLeft;
                @YawLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYawLeft;
                @YawRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYawRight;
                @YawRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYawRight;
                @YawRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnYawRight;
                @Hover.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHover;
                @Hover.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHover;
                @Hover.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHover;
                @CameraMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraMode;
                @CameraMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraMode;
                @CameraMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraMode;
                @POV.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPOV;
                @POV.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPOV;
                @POV.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPOV;
                @CollisionMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollisionMode;
                @CollisionMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollisionMode;
                @CollisionMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCollisionMode;
                @Pause.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Ascend.started += instance.OnAscend;
                @Ascend.performed += instance.OnAscend;
                @Ascend.canceled += instance.OnAscend;
                @PitchForward.started += instance.OnPitchForward;
                @PitchForward.performed += instance.OnPitchForward;
                @PitchForward.canceled += instance.OnPitchForward;
                @PitchBackward.started += instance.OnPitchBackward;
                @PitchBackward.performed += instance.OnPitchBackward;
                @PitchBackward.canceled += instance.OnPitchBackward;
                @RollLeft.started += instance.OnRollLeft;
                @RollLeft.performed += instance.OnRollLeft;
                @RollLeft.canceled += instance.OnRollLeft;
                @RollRight.started += instance.OnRollRight;
                @RollRight.performed += instance.OnRollRight;
                @RollRight.canceled += instance.OnRollRight;
                @YawLeft.started += instance.OnYawLeft;
                @YawLeft.performed += instance.OnYawLeft;
                @YawLeft.canceled += instance.OnYawLeft;
                @YawRight.started += instance.OnYawRight;
                @YawRight.performed += instance.OnYawRight;
                @YawRight.canceled += instance.OnYawRight;
                @Hover.started += instance.OnHover;
                @Hover.performed += instance.OnHover;
                @Hover.canceled += instance.OnHover;
                @CameraMode.started += instance.OnCameraMode;
                @CameraMode.performed += instance.OnCameraMode;
                @CameraMode.canceled += instance.OnCameraMode;
                @POV.started += instance.OnPOV;
                @POV.performed += instance.OnPOV;
                @POV.canceled += instance.OnPOV;
                @CollisionMode.started += instance.OnCollisionMode;
                @CollisionMode.performed += instance.OnCollisionMode;
                @CollisionMode.canceled += instance.OnCollisionMode;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("Xbox Controller");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    private int m_PS4ControllerSchemeIndex = -1;
    public InputControlScheme PS4ControllerScheme
    {
        get
        {
            if (m_PS4ControllerSchemeIndex == -1) m_PS4ControllerSchemeIndex = asset.FindControlSchemeIndex("PS4 Controller");
            return asset.controlSchemes[m_PS4ControllerSchemeIndex];
        }
    }
    private int m_XRControllerSchemeIndex = -1;
    public InputControlScheme XRControllerScheme
    {
        get
        {
            if (m_XRControllerSchemeIndex == -1) m_XRControllerSchemeIndex = asset.FindControlSchemeIndex("XR Controller");
            return asset.controlSchemes[m_XRControllerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnAscend(InputAction.CallbackContext context);
        void OnPitchForward(InputAction.CallbackContext context);
        void OnPitchBackward(InputAction.CallbackContext context);
        void OnRollLeft(InputAction.CallbackContext context);
        void OnRollRight(InputAction.CallbackContext context);
        void OnYawLeft(InputAction.CallbackContext context);
        void OnYawRight(InputAction.CallbackContext context);
        void OnHover(InputAction.CallbackContext context);
        void OnCameraMode(InputAction.CallbackContext context);
        void OnPOV(InputAction.CallbackContext context);
        void OnCollisionMode(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}