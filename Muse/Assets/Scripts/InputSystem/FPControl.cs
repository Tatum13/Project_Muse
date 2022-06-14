// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem/FPControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @FPControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @FPControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""FPControl"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""7a331268-75ec-484e-aa85-3a4c9770e428"",
            ""actions"": [
                {
                    ""name"": ""Walking"",
                    ""type"": ""Value"",
                    ""id"": ""02f3fbc5-d24a-4ea3-83df-030612f0ae02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0e0da7d2-0f13-4ac6-8225-16d33e13d7a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""779d9708-78b6-44a2-9e57-eb3485731655"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartRotating"",
                    ""type"": ""Button"",
                    ""id"": ""4ec3fd81-7f81-4758-81e7-479f3b27b8fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.4,pressPoint=0.5)""
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""c6fa52a9-9351-482b-8c47-729be427ab57"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.4,pressPoint=0.5)""
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""36dc7e55-2354-40d9-aed2-b5dbad95c15b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gravity"",
                    ""type"": ""Button"",
                    ""id"": ""7a2472e6-e15b-40cf-88f6-15fcfccabd53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RotateZ"",
                    ""type"": ""Button"",
                    ""id"": ""a31a4dea-8ee3-4332-b1b4-39fe992dcbe2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""PauseGame"",
                    ""type"": ""Button"",
                    ""id"": ""1661a559-f710-4840-b7a4-f032828d8b6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""aca564a6-9d5d-4edb-b407-02bf5c96fa6c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a34cc797-0469-45ca-ac09-9fd68fe499ec"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9072620c-26e4-4be3-8049-8841b0cfbdfa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a39d2da7-e970-4222-a65d-d3f2f781da3a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""84584b81-583a-4c3b-8603-73bce7720194"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f8363b69-ba74-4678-9647-2d8c654edafe"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""aea7e7df-a807-4e19-96ea-dc9ed95d2e0f"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad081812-cd36-4980-bb9f-0dbdd69a386e"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""24b52202-acb4-4a7e-8b3b-0be9ed527d70"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""16bc34f3-e95c-4e33-9b3c-69fd36dbb3d4"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5822ed92-3f03-47ca-bbfc-e06fbc013baa"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45e83dc2-4783-4e7b-9809-b8c33c5f9fa9"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f058e8e5-98b6-4361-8665-ff6a04a5345d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartRotating"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56ff7d33-eb51-4175-9578-ce35339290b4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ae81a7b3-a520-4842-9be3-fd474637c95a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3cfd18bd-a09b-4f9f-b3d3-f71e9bdf5bd0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4e7d89be-65c0-43bc-bb74-33696a4caf07"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""04638631-34da-4393-93e6-3c2db328b497"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f8a98aeb-64fe-4c21-bf99-3a82d78e22a1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7375f3c1-9529-4467-865a-21dffe6bf2be"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""eb1cffc1-1a33-4fe4-a220-3b969b6cf82d"",
                    ""path"": ""<DualShockGamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bd172c28-b1fa-4bf9-9e13-9b6f08fd5f02"",
                    ""path"": ""<DualShockGamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8b5e33f9-96bc-4b70-a00e-43f80f1548ad"",
                    ""path"": ""<DualShockGamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2060f913-61e6-4c76-9b30-28d392fb4524"",
                    ""path"": ""<DualShockGamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""05eb58d2-9029-423a-8328-8a1b5923dfae"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bde237c3-b725-4c18-b73e-5053a92609b7"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb4c70f7-df57-4c15-8233-1e1c73950675"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f267b743-2898-4a8b-b67a-d2bb1bf946bc"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3443a9a-81bd-4664-b7de-c33a9db18071"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Walking = m_PlayerControls.FindAction("Walking", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_MousePosition = m_PlayerControls.FindAction("MousePosition", throwIfNotFound: true);
        m_PlayerControls_StartRotating = m_PlayerControls.FindAction("StartRotating", throwIfNotFound: true);
        m_PlayerControls_MouseDelta = m_PlayerControls.FindAction("MouseDelta", throwIfNotFound: true);
        m_PlayerControls_Rotate = m_PlayerControls.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerControls_Gravity = m_PlayerControls.FindAction("Gravity", throwIfNotFound: true);
        m_PlayerControls_RotateZ = m_PlayerControls.FindAction("RotateZ", throwIfNotFound: true);
        m_PlayerControls_PauseGame = m_PlayerControls.FindAction("PauseGame", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Walking;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_MousePosition;
    private readonly InputAction m_PlayerControls_StartRotating;
    private readonly InputAction m_PlayerControls_MouseDelta;
    private readonly InputAction m_PlayerControls_Rotate;
    private readonly InputAction m_PlayerControls_Gravity;
    private readonly InputAction m_PlayerControls_RotateZ;
    private readonly InputAction m_PlayerControls_PauseGame;
    public struct PlayerControlsActions
    {
        private @FPControl m_Wrapper;
        public PlayerControlsActions(@FPControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walking => m_Wrapper.m_PlayerControls_Walking;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @MousePosition => m_Wrapper.m_PlayerControls_MousePosition;
        public InputAction @StartRotating => m_Wrapper.m_PlayerControls_StartRotating;
        public InputAction @MouseDelta => m_Wrapper.m_PlayerControls_MouseDelta;
        public InputAction @Rotate => m_Wrapper.m_PlayerControls_Rotate;
        public InputAction @Gravity => m_Wrapper.m_PlayerControls_Gravity;
        public InputAction @RotateZ => m_Wrapper.m_PlayerControls_RotateZ;
        public InputAction @PauseGame => m_Wrapper.m_PlayerControls_PauseGame;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Walking.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalking;
                @Walking.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalking;
                @Walking.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnWalking;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @MousePosition.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMousePosition;
                @StartRotating.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStartRotating;
                @StartRotating.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStartRotating;
                @StartRotating.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnStartRotating;
                @MouseDelta.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseDelta;
                @MouseDelta.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMouseDelta;
                @Rotate.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotate;
                @Gravity.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnGravity;
                @Gravity.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnGravity;
                @Gravity.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnGravity;
                @RotateZ.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateZ;
                @RotateZ.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateZ;
                @RotateZ.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateZ;
                @PauseGame.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPauseGame;
                @PauseGame.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPauseGame;
                @PauseGame.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPauseGame;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walking.started += instance.OnWalking;
                @Walking.performed += instance.OnWalking;
                @Walking.canceled += instance.OnWalking;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @StartRotating.started += instance.OnStartRotating;
                @StartRotating.performed += instance.OnStartRotating;
                @StartRotating.canceled += instance.OnStartRotating;
                @MouseDelta.started += instance.OnMouseDelta;
                @MouseDelta.performed += instance.OnMouseDelta;
                @MouseDelta.canceled += instance.OnMouseDelta;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Gravity.started += instance.OnGravity;
                @Gravity.performed += instance.OnGravity;
                @Gravity.canceled += instance.OnGravity;
                @RotateZ.started += instance.OnRotateZ;
                @RotateZ.performed += instance.OnRotateZ;
                @RotateZ.canceled += instance.OnRotateZ;
                @PauseGame.started += instance.OnPauseGame;
                @PauseGame.performed += instance.OnPauseGame;
                @PauseGame.canceled += instance.OnPauseGame;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnWalking(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnStartRotating(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnGravity(InputAction.CallbackContext context);
        void OnRotateZ(InputAction.CallbackContext context);
        void OnPauseGame(InputAction.CallbackContext context);
    }
}
