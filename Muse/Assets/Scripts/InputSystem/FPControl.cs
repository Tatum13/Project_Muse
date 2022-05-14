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
    public struct PlayerControlsActions
    {
        private @FPControl m_Wrapper;
        public PlayerControlsActions(@FPControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walking => m_Wrapper.m_PlayerControls_Walking;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @MousePosition => m_Wrapper.m_PlayerControls_MousePosition;
        public InputAction @StartRotating => m_Wrapper.m_PlayerControls_StartRotating;
        public InputAction @MouseDelta => m_Wrapper.m_PlayerControls_MouseDelta;
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
    }
}