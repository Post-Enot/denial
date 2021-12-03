// GENERATED AUTOMATICALLY FROM 'Assets/Input Actions/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""1a0894ef-4dc4-4d1d-816f-08701dd15aa3"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""Button"",
                    ""id"": ""096f76e5-7d30-47a8-96fb-086f1f6ea1e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""UpwardMovement"",
                    ""type"": ""Button"",
                    ""id"": ""c2fce578-c3ba-4601-808b-8c557290657e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpecialMovement"",
                    ""type"": ""Button"",
                    ""id"": ""cba1fcd3-5996-4f9c-82a4-6efe3038032a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""cc36b722-5183-44eb-934f-1e9e84799c37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WeaponAction"",
                    ""type"": ""Button"",
                    ""id"": ""6f3ebbd5-fc5a-4bf4-8078-c05753f5b9dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BloodSpell0"",
                    ""type"": ""Button"",
                    ""id"": ""761831f2-0310-4aaa-a119-f2f69cb41d11"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BloodSpell1"",
                    ""type"": ""Button"",
                    ""id"": ""ce0dc04c-7ffc-4d37-827e-bcf6edafb9d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UltimateSpell"",
                    ""type"": ""Button"",
                    ""id"": ""9411dad2-1a75-4c79-8043-ecf5abe9a277"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""77d7e3f0-b2c5-469d-b63e-aa3a8c8e4dd8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""722edd88-8b42-4179-a297-04bd82ef3d4c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f25e0347-c737-4e34-a31e-38ac5d997872"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f3d2310e-78a8-48cb-ae57-a2b394aa8116"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""334acdd1-79d1-40cf-a332-f27d63460bca"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b135fadb-3374-47b7-932f-4ea3ff85cd42"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6df5ccaa-8a16-486c-aad2-221da7ae4291"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b5d67c4-4f02-4051-89f8-24881f781948"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e9ae5d6-0bb5-4f45-a27a-05b386726390"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60dad15c-9868-419a-a215-a9f1a5c564fb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fcd07c7-d138-49c5-8b3a-b43e624cc7ff"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c7c4cd0-f081-49c7-9581-d16218177cc2"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98005744-48e7-4a9c-96bf-6d4c1361b58f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BloodSpell0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac82dfb6-e99f-4ed1-aa58-b0b2c67fb7b5"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BloodSpell1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b44d8a1-98b8-4ad7-abfe-4cfdaf91991b"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UltimateSpell"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_HorizontalMovement = m_Main.FindAction("HorizontalMovement", throwIfNotFound: true);
        m_Main_UpwardMovement = m_Main.FindAction("UpwardMovement", throwIfNotFound: true);
        m_Main_SpecialMovement = m_Main.FindAction("SpecialMovement", throwIfNotFound: true);
        m_Main_Interaction = m_Main.FindAction("Interaction", throwIfNotFound: true);
        m_Main_WeaponAction = m_Main.FindAction("WeaponAction", throwIfNotFound: true);
        m_Main_BloodSpell0 = m_Main.FindAction("BloodSpell0", throwIfNotFound: true);
        m_Main_BloodSpell1 = m_Main.FindAction("BloodSpell1", throwIfNotFound: true);
        m_Main_UltimateSpell = m_Main.FindAction("UltimateSpell", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_HorizontalMovement;
    private readonly InputAction m_Main_UpwardMovement;
    private readonly InputAction m_Main_SpecialMovement;
    private readonly InputAction m_Main_Interaction;
    private readonly InputAction m_Main_WeaponAction;
    private readonly InputAction m_Main_BloodSpell0;
    private readonly InputAction m_Main_BloodSpell1;
    private readonly InputAction m_Main_UltimateSpell;
    public struct MainActions
    {
        private @InputActions m_Wrapper;
        public MainActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Main_HorizontalMovement;
        public InputAction @UpwardMovement => m_Wrapper.m_Main_UpwardMovement;
        public InputAction @SpecialMovement => m_Wrapper.m_Main_SpecialMovement;
        public InputAction @Interaction => m_Wrapper.m_Main_Interaction;
        public InputAction @WeaponAction => m_Wrapper.m_Main_WeaponAction;
        public InputAction @BloodSpell0 => m_Wrapper.m_Main_BloodSpell0;
        public InputAction @BloodSpell1 => m_Wrapper.m_Main_BloodSpell1;
        public InputAction @UltimateSpell => m_Wrapper.m_Main_UltimateSpell;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnHorizontalMovement;
                @UpwardMovement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUpwardMovement;
                @UpwardMovement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUpwardMovement;
                @UpwardMovement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUpwardMovement;
                @SpecialMovement.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSpecialMovement;
                @SpecialMovement.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSpecialMovement;
                @SpecialMovement.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSpecialMovement;
                @Interaction.started -= m_Wrapper.m_MainActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnInteraction;
                @WeaponAction.started -= m_Wrapper.m_MainActionsCallbackInterface.OnWeaponAction;
                @WeaponAction.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnWeaponAction;
                @WeaponAction.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnWeaponAction;
                @BloodSpell0.started -= m_Wrapper.m_MainActionsCallbackInterface.OnBloodSpell0;
                @BloodSpell0.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnBloodSpell0;
                @BloodSpell0.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnBloodSpell0;
                @BloodSpell1.started -= m_Wrapper.m_MainActionsCallbackInterface.OnBloodSpell1;
                @BloodSpell1.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnBloodSpell1;
                @BloodSpell1.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnBloodSpell1;
                @UltimateSpell.started -= m_Wrapper.m_MainActionsCallbackInterface.OnUltimateSpell;
                @UltimateSpell.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnUltimateSpell;
                @UltimateSpell.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnUltimateSpell;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @UpwardMovement.started += instance.OnUpwardMovement;
                @UpwardMovement.performed += instance.OnUpwardMovement;
                @UpwardMovement.canceled += instance.OnUpwardMovement;
                @SpecialMovement.started += instance.OnSpecialMovement;
                @SpecialMovement.performed += instance.OnSpecialMovement;
                @SpecialMovement.canceled += instance.OnSpecialMovement;
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
                @WeaponAction.started += instance.OnWeaponAction;
                @WeaponAction.performed += instance.OnWeaponAction;
                @WeaponAction.canceled += instance.OnWeaponAction;
                @BloodSpell0.started += instance.OnBloodSpell0;
                @BloodSpell0.performed += instance.OnBloodSpell0;
                @BloodSpell0.canceled += instance.OnBloodSpell0;
                @BloodSpell1.started += instance.OnBloodSpell1;
                @BloodSpell1.performed += instance.OnBloodSpell1;
                @BloodSpell1.canceled += instance.OnBloodSpell1;
                @UltimateSpell.started += instance.OnUltimateSpell;
                @UltimateSpell.performed += instance.OnUltimateSpell;
                @UltimateSpell.canceled += instance.OnUltimateSpell;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnUpwardMovement(InputAction.CallbackContext context);
        void OnSpecialMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnWeaponAction(InputAction.CallbackContext context);
        void OnBloodSpell0(InputAction.CallbackContext context);
        void OnBloodSpell1(InputAction.CallbackContext context);
        void OnUltimateSpell(InputAction.CallbackContext context);
    }
}