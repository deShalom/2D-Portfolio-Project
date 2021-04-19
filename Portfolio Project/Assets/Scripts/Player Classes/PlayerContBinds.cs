// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player Classes/PlayerCont.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerContBinds : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerContBinds()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerCont"",
    ""maps"": [
        {
            ""name"": ""StandardCont"",
            ""id"": ""1ce7f0b0-2f3d-4bc8-911e-309f3c667e21"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""54dde8a9-8002-43c3-8407-d927654c1526"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""297d70e8-228b-4471-a450-61f701017d49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways"",
                    ""id"": ""80931182-85ec-4d53-a09a-a5bd1cd33918"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""172bb737-ecbd-4b82-9144-7af4c96772df"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3f296854-c89c-4503-8aa5-e276056bb652"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c0e42976-ec2f-4843-9b13-79169d5d85a6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // StandardCont
        m_StandardCont = asset.FindActionMap("StandardCont", throwIfNotFound: true);
        m_StandardCont_Move = m_StandardCont.FindAction("Move", throwIfNotFound: true);
        m_StandardCont_Jump = m_StandardCont.FindAction("Jump", throwIfNotFound: true);
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

    // StandardCont
    private readonly InputActionMap m_StandardCont;
    private IStandardContActions m_StandardContActionsCallbackInterface;
    private readonly InputAction m_StandardCont_Move;
    private readonly InputAction m_StandardCont_Jump;
    public struct StandardContActions
    {
        private @PlayerContBinds m_Wrapper;
        public StandardContActions(@PlayerContBinds wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_StandardCont_Move;
        public InputAction @Jump => m_Wrapper.m_StandardCont_Jump;
        public InputActionMap Get() { return m_Wrapper.m_StandardCont; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(StandardContActions set) { return set.Get(); }
        public void SetCallbacks(IStandardContActions instance)
        {
            if (m_Wrapper.m_StandardContActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_StandardContActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_StandardContActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_StandardContActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_StandardContActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_StandardContActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_StandardContActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_StandardContActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public StandardContActions @StandardCont => new StandardContActions(this);
    public interface IStandardContActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
