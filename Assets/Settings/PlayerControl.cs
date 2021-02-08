// GENERATED AUTOMATICALLY FROM 'Assets/Settings/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""275210fd-5353-4c90-832e-2dfb5a885152"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""cef8009f-8bd4-4267-9b36-cb51a2fa06dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""RestartScene"",
                    ""type"": ""Button"",
                    ""id"": ""f41bc2dc-4932-4f84-9f27-d74b793b41f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardsForce"",
                    ""type"": ""Button"",
                    ""id"": ""5aabee82-756d-4991-91a2-38fd3718015a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardsForceIncrease"",
                    ""type"": ""Button"",
                    ""id"": ""d97ebbcb-aaec-402e-9d72-7ee283d83742"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardsForceDecrease"",
                    ""type"": ""Button"",
                    ""id"": ""81d8e570-4502-4da2-b3cb-da618a06f4c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""d55ef619-2f11-40d5-acdf-7d3420a266d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66063e14-9502-469c-a6c4-5d162a5f467b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceIncrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32129b80-46f6-40cd-b331-738a41aef17b"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceIncrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce96a211-2c2b-4a09-b79e-7258d0d9034e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceDecrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7d8824d-4d51-40c4-a5b9-4088adee56df"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceDecrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""752a3aa4-2ebf-4270-861f-9dc693d3551d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c25f951d-c7e9-47e2-8986-b481e07fe54f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""15dcbe7b-e756-4c56-a088-4d6c8d398e07"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a4b5a59a-cf6a-429f-878b-c92f6e8c8370"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""46dd9826-e05f-4734-8a87-b467a0a9768b"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""8f280fe6-85a9-4109-ae2b-0ea15faf3d18"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e98bb05e-ecd3-4472-b48c-c2cb146deddc"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2c43a8e4-a24a-4f82-8dfb-0742cb838f3d"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""8db11771-53f7-44ab-b030-19420b9d0e65"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4ae7a7b7-ae9f-4964-80f4-2a8e74e6c044"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a9ed060e-1e25-47a8-a4f2-365c3b159fb5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - Right Stick"",
                    ""id"": ""64d5545a-71dc-466c-96b6-0da13ecfac9e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5a3cb088-3722-45f7-b0c9-2bb85afc4c99"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a1b2f509-2f36-43db-ac58-c2d4e0d8e1cf"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - D-Pad"",
                    ""id"": ""d2ccda40-5234-4ce8-bfe8-7aece5f97564"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""50069714-49d9-4b66-951f-41fe5046c9e5"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2925e805-a348-432c-abd2-50142359900e"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboad"",
                    ""id"": ""3d9e4665-32ad-4b9c-86ce-6bfcedb93e83"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f2f5840-de90-400a-8c46-7f1bb89da88b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""90d19e79-1107-4b1a-b5de-74bf61cea401"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""29ce8a3f-444c-471a-8be2-2ff9563989c9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d4a10eb-6e59-4ed7-ad9c-ad350c1c0f06"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - 2 sticks"",
                    ""id"": ""a3bcef43-1261-49d4-b872-2cdb2d430e3b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8859d7f3-3dc6-4793-8354-b8f1de5b1bba"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a699791a-48bc-46c1-a676-732cda20bc17"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2dd278c4-4f93-413f-87e1-de80e56ded71"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3635fd73-e718-4d90-ade5-222079f9e115"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - D-Pad"",
                    ""id"": ""7b72bac6-328e-4efe-9994-379e4f3d45cb"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f89ea6e9-fb04-412b-a696-8ebef3366cca"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""720f969f-25cb-4e86-97d0-22e69d068ec7"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73f2251b-3d9b-4495-ba2d-0a37953ee0da"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""130f5678-bbe4-4763-8fcd-e734634a2b76"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""d13e3344-5a7b-44e0-b976-6fdfaf1ce775"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""46b21d3b-5aa4-4d61-a247-7ae6f6deaf5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""RestartScene"",
                    ""type"": ""Button"",
                    ""id"": ""97d6671a-908d-49ef-b1ef-75dd86e062cb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardsForce"",
                    ""type"": ""Button"",
                    ""id"": ""d5421b57-9b06-4fd9-bbc8-59f63aeaa0ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardsForceIncrease"",
                    ""type"": ""Button"",
                    ""id"": ""d9f56764-b910-47b8-b2f6-ae24aa0a13d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackwardsForceDecrease"",
                    ""type"": ""Button"",
                    ""id"": ""a1961a8a-b30a-43e9-bb3a-9c69877f1005"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""b91c04be-3458-414d-a405-163baf0946a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b232842-a4c7-4564-b94f-a0bcf9771ac4"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceIncrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""709711e1-2fbc-409f-8f7e-7683097359cd"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceIncrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c47a3016-664a-4a92-84f3-508e573591c9"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceDecrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75584fa3-28d8-4caa-8e53-ad712600a508"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForceDecrease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa8e38cb-0453-49b5-b1bb-9ee97bd79f18"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca64e17d-5374-4023-81bf-5f03c7c5f7de"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RestartScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""a33c6399-d68d-4139-9691-b98264630838"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""33af2509-3a71-48e7-b760-e4040e117ee2"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d0c0edcb-9c2f-48fc-91d5-17400ffbaaed"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""405a6575-4c9a-441c-b062-60bd5ea37361"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""aa557cad-0bbc-4483-8b6d-f4d41f9f6297"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dec21dc0-13a0-4779-bb86-b13a61590900"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackwardsForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""24edd1ae-19ef-4aa2-8275-85775e36fd38"",
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
                    ""id"": ""37c5b9c9-9bb1-4729-8fca-ed5035a9a5a5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3b2468dd-92f8-4452-b8a8-2e743629ad94"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - Left Stick"",
                    ""id"": ""046a076b-7457-4af6-9d52-c8c8d5036644"",
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
                    ""id"": ""c449f8c2-3549-4c45-b5fe-bd6d3cdc84e3"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8e9d7cd2-b943-4d49-86a1-11cf82224ea8"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - D-Pad"",
                    ""id"": ""7f81ed21-65d9-42e4-b9a2-318851c604d8"",
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
                    ""id"": ""4a796c2c-dff2-4aad-b85f-b27518841b41"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""96bf39f4-5733-49b5-8780-6d0cd5431a40"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""eebb8b5b-b906-48a0-98d2-ba436348b51b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2d7a05f8-9c67-4725-baa9-1165fa896b8f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""adb39355-76b2-4e65-81dc-84fedb418f6e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - Right Stick"",
                    ""id"": ""14e30b0e-785b-4a34-90b1-586837ca1fcd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f1f1b242-89b3-488b-95a1-1b510d0c118e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e2e325b4-806f-4e7f-a7cd-805d8acd9f8d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad - D-Pad"",
                    ""id"": ""942529e2-45a0-44e5-aaba-59ba9a518bfc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ce1642ea-987c-4fa6-8a63-6909a9918609"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3d8e0223-233c-4f03-be4c-88977d6a310a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_RestartScene = m_Player.FindAction("RestartScene", throwIfNotFound: true);
        m_Player_BackwardsForce = m_Player.FindAction("BackwardsForce", throwIfNotFound: true);
        m_Player_BackwardsForceIncrease = m_Player.FindAction("BackwardsForceIncrease", throwIfNotFound: true);
        m_Player_BackwardsForceDecrease = m_Player.FindAction("BackwardsForceDecrease", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Move = m_Player2.FindAction("Move", throwIfNotFound: true);
        m_Player2_RestartScene = m_Player2.FindAction("RestartScene", throwIfNotFound: true);
        m_Player2_BackwardsForce = m_Player2.FindAction("BackwardsForce", throwIfNotFound: true);
        m_Player2_BackwardsForceIncrease = m_Player2.FindAction("BackwardsForceIncrease", throwIfNotFound: true);
        m_Player2_BackwardsForceDecrease = m_Player2.FindAction("BackwardsForceDecrease", throwIfNotFound: true);
        m_Player2_Rotate = m_Player2.FindAction("Rotate", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_RestartScene;
    private readonly InputAction m_Player_BackwardsForce;
    private readonly InputAction m_Player_BackwardsForceIncrease;
    private readonly InputAction m_Player_BackwardsForceDecrease;
    private readonly InputAction m_Player_Rotate;
    public struct PlayerActions
    {
        private @PlayerControl m_Wrapper;
        public PlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @RestartScene => m_Wrapper.m_Player_RestartScene;
        public InputAction @BackwardsForce => m_Wrapper.m_Player_BackwardsForce;
        public InputAction @BackwardsForceIncrease => m_Wrapper.m_Player_BackwardsForceIncrease;
        public InputAction @BackwardsForceDecrease => m_Wrapper.m_Player_BackwardsForceDecrease;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @RestartScene.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestartScene;
                @RestartScene.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestartScene;
                @RestartScene.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestartScene;
                @BackwardsForce.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForce;
                @BackwardsForce.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForce;
                @BackwardsForce.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForce;
                @BackwardsForceIncrease.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForceIncrease;
                @BackwardsForceDecrease.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwardsForceDecrease;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RestartScene.started += instance.OnRestartScene;
                @RestartScene.performed += instance.OnRestartScene;
                @RestartScene.canceled += instance.OnRestartScene;
                @BackwardsForce.started += instance.OnBackwardsForce;
                @BackwardsForce.performed += instance.OnBackwardsForce;
                @BackwardsForce.canceled += instance.OnBackwardsForce;
                @BackwardsForceIncrease.started += instance.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.performed += instance.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.canceled += instance.OnBackwardsForceIncrease;
                @BackwardsForceDecrease.started += instance.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.performed += instance.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.canceled += instance.OnBackwardsForceDecrease;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Move;
    private readonly InputAction m_Player2_RestartScene;
    private readonly InputAction m_Player2_BackwardsForce;
    private readonly InputAction m_Player2_BackwardsForceIncrease;
    private readonly InputAction m_Player2_BackwardsForceDecrease;
    private readonly InputAction m_Player2_Rotate;
    public struct Player2Actions
    {
        private @PlayerControl m_Wrapper;
        public Player2Actions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player2_Move;
        public InputAction @RestartScene => m_Wrapper.m_Player2_RestartScene;
        public InputAction @BackwardsForce => m_Wrapper.m_Player2_BackwardsForce;
        public InputAction @BackwardsForceIncrease => m_Wrapper.m_Player2_BackwardsForceIncrease;
        public InputAction @BackwardsForceDecrease => m_Wrapper.m_Player2_BackwardsForceDecrease;
        public InputAction @Rotate => m_Wrapper.m_Player2_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMove;
                @RestartScene.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRestartScene;
                @RestartScene.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRestartScene;
                @RestartScene.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRestartScene;
                @BackwardsForce.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForce;
                @BackwardsForce.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForce;
                @BackwardsForce.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForce;
                @BackwardsForceIncrease.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForceIncrease;
                @BackwardsForceDecrease.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBackwardsForceDecrease;
                @Rotate.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RestartScene.started += instance.OnRestartScene;
                @RestartScene.performed += instance.OnRestartScene;
                @RestartScene.canceled += instance.OnRestartScene;
                @BackwardsForce.started += instance.OnBackwardsForce;
                @BackwardsForce.performed += instance.OnBackwardsForce;
                @BackwardsForce.canceled += instance.OnBackwardsForce;
                @BackwardsForceIncrease.started += instance.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.performed += instance.OnBackwardsForceIncrease;
                @BackwardsForceIncrease.canceled += instance.OnBackwardsForceIncrease;
                @BackwardsForceDecrease.started += instance.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.performed += instance.OnBackwardsForceDecrease;
                @BackwardsForceDecrease.canceled += instance.OnBackwardsForceDecrease;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRestartScene(InputAction.CallbackContext context);
        void OnBackwardsForce(InputAction.CallbackContext context);
        void OnBackwardsForceIncrease(InputAction.CallbackContext context);
        void OnBackwardsForceDecrease(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRestartScene(InputAction.CallbackContext context);
        void OnBackwardsForce(InputAction.CallbackContext context);
        void OnBackwardsForceIncrease(InputAction.CallbackContext context);
        void OnBackwardsForceDecrease(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
