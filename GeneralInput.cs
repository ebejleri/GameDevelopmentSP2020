// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/GameDevelopmentSP2020/GeneralInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GeneralInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GeneralInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GeneralInput"",
    ""maps"": [
        {
            ""name"": ""KeyboardInput"",
            ""id"": ""89395aec-a3ed-4aea-b647-de7ae139d062"",
            ""actions"": [
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""5eb3bbb6-81a5-4d95-a5a7-eae062ce22ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""type"": ""Value"",
                    ""id"": ""8d4b90a3-b31a-4bb7-9a6e-f8efda1a1540"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e4533ec2-2e7e-4fa3-9151-58f89673a229"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f5cf1a1a-1da4-4450-adf9-34471a157ea8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""17b9ee19-37e5-426a-989c-e934e3080b09"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fe97518e-5d38-4859-951c-6ebec760fa1a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3fa67a43-db1e-4bcc-8c4d-13d49a2ee5d0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f03c9438-c987-4e7d-b590-741926a227b2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a9cb59db-a6ae-40ac-9df8-dd61fafb5ae4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3200a7ad-82dd-4abb-82b7-627521cac39a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""23758c24-a753-44bd-9d6b-99cbc45b3c6a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f36bb1b-dc40-43ea-a43c-4164de87aa60"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cb70f9f4-28d2-40f3-8ca4-07d06ece0b6b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ArrowKeys"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MouseInput"",
            ""id"": ""73f67781-faae-4bf2-a6fe-8a5d309fed11"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""79477346-b0f4-40e6-b74d-8c8975bf0f19"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f376dfb8-3eb3-4eec-b29f-38f6360ee7bd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""e6b0163a-538e-4b85-8442-f04c31606309"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""d86ee77a-61bd-483e-a500-cc02e97ee38e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ae0e7dca-e040-4d21-a76a-16acfa2ac62d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // KeyboardInput
        m_KeyboardInput = asset.FindActionMap("KeyboardInput", throwIfNotFound: true);
        m_KeyboardInput_Space = m_KeyboardInput.FindAction("Space", throwIfNotFound: true);
        m_KeyboardInput_ArrowKeys = m_KeyboardInput.FindAction("ArrowKeys", throwIfNotFound: true);
        // MouseInput
        m_MouseInput = asset.FindActionMap("MouseInput", throwIfNotFound: true);
        m_MouseInput_Newaction = m_MouseInput.FindAction("New action", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // KeyboardInput
    private readonly InputActionMap m_KeyboardInput;
    private IKeyboardInputActions m_KeyboardInputActionsCallbackInterface;
    private readonly InputAction m_KeyboardInput_Space;
    private readonly InputAction m_KeyboardInput_ArrowKeys;
    public struct KeyboardInputActions
    {
        private @GeneralInput m_Wrapper;
        public KeyboardInputActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Space => m_Wrapper.m_KeyboardInput_Space;
        public InputAction @ArrowKeys => m_Wrapper.m_KeyboardInput_ArrowKeys;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardInputActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardInputActions instance)
        {
            if (m_Wrapper.m_KeyboardInputActionsCallbackInterface != null)
            {
                @Space.started -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnSpace;
                @ArrowKeys.started -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnArrowKeys;
                @ArrowKeys.performed -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnArrowKeys;
                @ArrowKeys.canceled -= m_Wrapper.m_KeyboardInputActionsCallbackInterface.OnArrowKeys;
            }
            m_Wrapper.m_KeyboardInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @ArrowKeys.started += instance.OnArrowKeys;
                @ArrowKeys.performed += instance.OnArrowKeys;
                @ArrowKeys.canceled += instance.OnArrowKeys;
            }
        }
    }
    public KeyboardInputActions @KeyboardInput => new KeyboardInputActions(this);

    // MouseInput
    private readonly InputActionMap m_MouseInput;
    private IMouseInputActions m_MouseInputActionsCallbackInterface;
    private readonly InputAction m_MouseInput_Newaction;
    public struct MouseInputActions
    {
        private @GeneralInput m_Wrapper;
        public MouseInputActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_MouseInput_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_MouseInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseInputActions set) { return set.Get(); }
        public void SetCallbacks(IMouseInputActions instance)
        {
            if (m_Wrapper.m_MouseInputActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MouseInputActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MouseInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MouseInputActions @MouseInput => new MouseInputActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @GeneralInput m_Wrapper;
        public UIActions(@GeneralInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IKeyboardInputActions
    {
        void OnSpace(InputAction.CallbackContext context);
        void OnArrowKeys(InputAction.CallbackContext context);
    }
    public interface IMouseInputActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
