// GENERATED AUTOMATICALLY FROM 'Assets/Resources/JoystickController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @JoystickController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @JoystickController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""JoystickController"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""d17dd778-c209-4bde-9283-574b8a3d52dc"",
            ""actions"": [
                {
                    ""name"": ""selectPath"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3b9d7487-4df6-4794-8bba-af505687d79d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""switchState"",
                    ""type"": ""Button"",
                    ""id"": ""1d3cdfeb-cdd9-4731-8437-75c7fdc0d8c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""89403b0b-55b5-4ad7-8261-c8eb37cc2bbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""3333f911-dfaf-4c7e-9ca6-388220bb2bb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""6451b0a1-5e44-413a-87fb-95e8f691fc51"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""selectPathClavier"",
                    ""type"": ""Value"",
                    ""id"": ""6502238b-83e6-4db2-b804-3cb35d0a11de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchStateClavier"",
                    ""type"": ""Button"",
                    ""id"": ""e413981b-0a15-4d8b-a58e-e2e9ec07ecbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireClavier"",
                    ""type"": ""Button"",
                    ""id"": ""ac262d47-e538-4b20-aa01-ed017c7a040d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuClavier"",
                    ""type"": ""Button"",
                    ""id"": ""94ffcf8f-1b02-45a5-8693-034245ea9e79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReplayTuto"",
                    ""type"": ""Button"",
                    ""id"": ""75bb20ca-9d32-4a0e-b2e5-c5d345918d92"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""28dcd7f9-55cd-4417-b0ce-2c25addb66c7"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fad2e720-9d9a-4f55-b970-d3add5492c2a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPath"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5789f852-5135-43b4-a442-f52a3bbbfcc3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7848bcad-c1a7-42de-a922-ed7fb9c906e2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2c3c7017-e48c-47bf-84c6-589b74693839"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b779554e-9126-4d8b-bea1-1f347585507c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPath"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f260910-b3bc-4b75-ab92-48663ed8ee9e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""switchState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""527c3289-ca55-4c5a-904e-079513e2e325"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""switchState"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63bb9c48-3eaa-4237-a0dd-42e3e44035f6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5600356a-93fa-4115-9fb7-c690700bb9c2"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ae27f8d-92e3-4f11-8d84-2744928bcc72"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b2efa6a-a180-48e8-ae0a-7ec23c3ea720"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fcbb1a9-ae06-4cd0-9dcd-a349bb1b2e90"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""648d6d1f-36be-4619-bfa9-df6c50c9a6cb"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b2c57ed-14c9-428c-83a5-a859aeb08451"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""selectPathClavier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3928ac6-225a-4de6-a624-b253b6a079db"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchStateClavier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a07b7c4-9242-48d1-8a49-09e4094447d2"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireClavier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5460851d-3771-4aa5-be1e-274d375b534c"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuClavier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bbe862b-df7e-406e-8021-7eb7ef3b4328"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReplayTuto"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""281d6ce5-c25e-4c6e-a22d-29bbe8695e0c"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""8ce2494a-6a3a-42a6-bccc-de8827bd7d20"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""43c2d286-c205-49d4-9efe-820538fb844d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Validate"",
                    ""type"": ""Button"",
                    ""id"": ""f03ae69c-088a-417f-b2b9-cd00b6a297f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""345f832b-0776-4c10-bbe4-2e7beea659ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""e65cccdb-546b-436c-b139-19645a0ca389"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""64d5f332-d4b1-495b-b2b9-1c6ea60a3907"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6676acf2-d114-4989-9b7e-ca6c632abaf1"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d6700f1-efc6-4757-88de-4bff8bce6947"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe4778bd-3828-40bc-a3e1-9e28b38f73ef"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24b5e19e-2f79-4614-a6a9-0341063f4278"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aadebf5b-ceb3-47b9-93b1-5ed13e6081a6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8948468b-66b7-4862-9878-7593dad68b7a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba516341-0be4-4caa-b465-de0118460adb"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dce4d8a3-837a-4e57-aa9b-40cd70cf4e56"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9cc7b66-2182-4fd4-bf0f-d0ba03439dfe"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4445345-b36f-41c7-b8ac-3925fb9ca6d0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a63dfe3d-4269-4ad1-b92b-0f98d894f03b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""756e420b-10b9-42a6-9795-7e89ab694725"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""language"",
            ""id"": ""610955ce-377a-4bea-a117-47cd8d13aa55"",
            ""actions"": [
                {
                    ""name"": ""up"",
                    ""type"": ""Button"",
                    ""id"": ""8f47b545-0da1-46b9-a0ce-491ef073ccd7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""down"",
                    ""type"": ""Button"",
                    ""id"": ""93fe8bbb-9e0f-4a5d-9056-50146498962e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""validate"",
                    ""type"": ""Button"",
                    ""id"": ""0cab31c4-5eb9-46f8-a90e-9ea7a6665af1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e045e03f-4719-481d-9f3b-e06eb0b22a4c"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d9e9dee-8ddf-48d7-abce-c85730d800b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0454345c-7f5b-4f5e-9223-454bfaa8834c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79685cd8-1b00-4778-9fd2-088524ea787c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""403a23cb-ea84-4d80-9a6b-df78fb197f19"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fa6f374-225f-4857-adbe-f6a50a0ae918"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_selectPath = m_General.FindAction("selectPath", throwIfNotFound: true);
        m_General_switchState = m_General.FindAction("switchState", throwIfNotFound: true);
        m_General_Fire = m_General.FindAction("Fire", throwIfNotFound: true);
        m_General_Menu = m_General.FindAction("Menu", throwIfNotFound: true);
        m_General_Pause = m_General.FindAction("Pause", throwIfNotFound: true);
        m_General_selectPathClavier = m_General.FindAction("selectPathClavier", throwIfNotFound: true);
        m_General_SwitchStateClavier = m_General.FindAction("SwitchStateClavier", throwIfNotFound: true);
        m_General_FireClavier = m_General.FindAction("FireClavier", throwIfNotFound: true);
        m_General_MenuClavier = m_General.FindAction("MenuClavier", throwIfNotFound: true);
        m_General_ReplayTuto = m_General.FindAction("ReplayTuto", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Left = m_Menu.FindAction("Left", throwIfNotFound: true);
        m_Menu_Right = m_Menu.FindAction("Right", throwIfNotFound: true);
        m_Menu_Validate = m_Menu.FindAction("Validate", throwIfNotFound: true);
        m_Menu_Menu = m_Menu.FindAction("Menu", throwIfNotFound: true);
        m_Menu_Up = m_Menu.FindAction("Up", throwIfNotFound: true);
        m_Menu_Down = m_Menu.FindAction("Down", throwIfNotFound: true);
        // language
        m_language = asset.FindActionMap("language", throwIfNotFound: true);
        m_language_up = m_language.FindAction("up", throwIfNotFound: true);
        m_language_down = m_language.FindAction("down", throwIfNotFound: true);
        m_language_validate = m_language.FindAction("validate", throwIfNotFound: true);
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

    // General
    private readonly InputActionMap m_General;
    private IGeneralActions m_GeneralActionsCallbackInterface;
    private readonly InputAction m_General_selectPath;
    private readonly InputAction m_General_switchState;
    private readonly InputAction m_General_Fire;
    private readonly InputAction m_General_Menu;
    private readonly InputAction m_General_Pause;
    private readonly InputAction m_General_selectPathClavier;
    private readonly InputAction m_General_SwitchStateClavier;
    private readonly InputAction m_General_FireClavier;
    private readonly InputAction m_General_MenuClavier;
    private readonly InputAction m_General_ReplayTuto;
    public struct GeneralActions
    {
        private @JoystickController m_Wrapper;
        public GeneralActions(@JoystickController wrapper) { m_Wrapper = wrapper; }
        public InputAction @selectPath => m_Wrapper.m_General_selectPath;
        public InputAction @switchState => m_Wrapper.m_General_switchState;
        public InputAction @Fire => m_Wrapper.m_General_Fire;
        public InputAction @Menu => m_Wrapper.m_General_Menu;
        public InputAction @Pause => m_Wrapper.m_General_Pause;
        public InputAction @selectPathClavier => m_Wrapper.m_General_selectPathClavier;
        public InputAction @SwitchStateClavier => m_Wrapper.m_General_SwitchStateClavier;
        public InputAction @FireClavier => m_Wrapper.m_General_FireClavier;
        public InputAction @MenuClavier => m_Wrapper.m_General_MenuClavier;
        public InputAction @ReplayTuto => m_Wrapper.m_General_ReplayTuto;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void SetCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterface != null)
            {
                @selectPath.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSelectPath;
                @selectPath.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSelectPath;
                @selectPath.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSelectPath;
                @switchState.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSwitchState;
                @switchState.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSwitchState;
                @switchState.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSwitchState;
                @Fire.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFire;
                @Menu.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMenu;
                @Pause.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnPause;
                @selectPathClavier.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSelectPathClavier;
                @selectPathClavier.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSelectPathClavier;
                @selectPathClavier.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSelectPathClavier;
                @SwitchStateClavier.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSwitchStateClavier;
                @SwitchStateClavier.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSwitchStateClavier;
                @SwitchStateClavier.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnSwitchStateClavier;
                @FireClavier.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFireClavier;
                @FireClavier.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFireClavier;
                @FireClavier.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnFireClavier;
                @MenuClavier.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMenuClavier;
                @MenuClavier.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMenuClavier;
                @MenuClavier.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnMenuClavier;
                @ReplayTuto.started -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReplayTuto;
                @ReplayTuto.performed -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReplayTuto;
                @ReplayTuto.canceled -= m_Wrapper.m_GeneralActionsCallbackInterface.OnReplayTuto;
            }
            m_Wrapper.m_GeneralActionsCallbackInterface = instance;
            if (instance != null)
            {
                @selectPath.started += instance.OnSelectPath;
                @selectPath.performed += instance.OnSelectPath;
                @selectPath.canceled += instance.OnSelectPath;
                @switchState.started += instance.OnSwitchState;
                @switchState.performed += instance.OnSwitchState;
                @switchState.canceled += instance.OnSwitchState;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @selectPathClavier.started += instance.OnSelectPathClavier;
                @selectPathClavier.performed += instance.OnSelectPathClavier;
                @selectPathClavier.canceled += instance.OnSelectPathClavier;
                @SwitchStateClavier.started += instance.OnSwitchStateClavier;
                @SwitchStateClavier.performed += instance.OnSwitchStateClavier;
                @SwitchStateClavier.canceled += instance.OnSwitchStateClavier;
                @FireClavier.started += instance.OnFireClavier;
                @FireClavier.performed += instance.OnFireClavier;
                @FireClavier.canceled += instance.OnFireClavier;
                @MenuClavier.started += instance.OnMenuClavier;
                @MenuClavier.performed += instance.OnMenuClavier;
                @MenuClavier.canceled += instance.OnMenuClavier;
                @ReplayTuto.started += instance.OnReplayTuto;
                @ReplayTuto.performed += instance.OnReplayTuto;
                @ReplayTuto.canceled += instance.OnReplayTuto;
            }
        }
    }
    public GeneralActions @General => new GeneralActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Left;
    private readonly InputAction m_Menu_Right;
    private readonly InputAction m_Menu_Validate;
    private readonly InputAction m_Menu_Menu;
    private readonly InputAction m_Menu_Up;
    private readonly InputAction m_Menu_Down;
    public struct MenuActions
    {
        private @JoystickController m_Wrapper;
        public MenuActions(@JoystickController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Left => m_Wrapper.m_Menu_Left;
        public InputAction @Right => m_Wrapper.m_Menu_Right;
        public InputAction @Validate => m_Wrapper.m_Menu_Validate;
        public InputAction @Menu => m_Wrapper.m_Menu_Menu;
        public InputAction @Up => m_Wrapper.m_Menu_Up;
        public InputAction @Down => m_Wrapper.m_Menu_Down;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Left.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnRight;
                @Validate.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnValidate;
                @Validate.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnValidate;
                @Validate.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnValidate;
                @Menu.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMenu;
                @Up.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDown;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Validate.started += instance.OnValidate;
                @Validate.performed += instance.OnValidate;
                @Validate.canceled += instance.OnValidate;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // language
    private readonly InputActionMap m_language;
    private ILanguageActions m_LanguageActionsCallbackInterface;
    private readonly InputAction m_language_up;
    private readonly InputAction m_language_down;
    private readonly InputAction m_language_validate;
    public struct LanguageActions
    {
        private @JoystickController m_Wrapper;
        public LanguageActions(@JoystickController wrapper) { m_Wrapper = wrapper; }
        public InputAction @up => m_Wrapper.m_language_up;
        public InputAction @down => m_Wrapper.m_language_down;
        public InputAction @validate => m_Wrapper.m_language_validate;
        public InputActionMap Get() { return m_Wrapper.m_language; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LanguageActions set) { return set.Get(); }
        public void SetCallbacks(ILanguageActions instance)
        {
            if (m_Wrapper.m_LanguageActionsCallbackInterface != null)
            {
                @up.started -= m_Wrapper.m_LanguageActionsCallbackInterface.OnUp;
                @up.performed -= m_Wrapper.m_LanguageActionsCallbackInterface.OnUp;
                @up.canceled -= m_Wrapper.m_LanguageActionsCallbackInterface.OnUp;
                @down.started -= m_Wrapper.m_LanguageActionsCallbackInterface.OnDown;
                @down.performed -= m_Wrapper.m_LanguageActionsCallbackInterface.OnDown;
                @down.canceled -= m_Wrapper.m_LanguageActionsCallbackInterface.OnDown;
                @validate.started -= m_Wrapper.m_LanguageActionsCallbackInterface.OnValidate;
                @validate.performed -= m_Wrapper.m_LanguageActionsCallbackInterface.OnValidate;
                @validate.canceled -= m_Wrapper.m_LanguageActionsCallbackInterface.OnValidate;
            }
            m_Wrapper.m_LanguageActionsCallbackInterface = instance;
            if (instance != null)
            {
                @up.started += instance.OnUp;
                @up.performed += instance.OnUp;
                @up.canceled += instance.OnUp;
                @down.started += instance.OnDown;
                @down.performed += instance.OnDown;
                @down.canceled += instance.OnDown;
                @validate.started += instance.OnValidate;
                @validate.performed += instance.OnValidate;
                @validate.canceled += instance.OnValidate;
            }
        }
    }
    public LanguageActions @language => new LanguageActions(this);
    public interface IGeneralActions
    {
        void OnSelectPath(InputAction.CallbackContext context);
        void OnSwitchState(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnSelectPathClavier(InputAction.CallbackContext context);
        void OnSwitchStateClavier(InputAction.CallbackContext context);
        void OnFireClavier(InputAction.CallbackContext context);
        void OnMenuClavier(InputAction.CallbackContext context);
        void OnReplayTuto(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnValidate(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
    }
    public interface ILanguageActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnValidate(InputAction.CallbackContext context);
    }
}
