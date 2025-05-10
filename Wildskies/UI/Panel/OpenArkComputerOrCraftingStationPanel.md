# Wildskies.UI.Panel.OpenArkComputerOrCraftingStationPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _arkComputerService | WildSkies.Service.IArkComputerService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _platformService | PlatformService | Private |
| _conversationService | WildSkies.Service.IConversationService | Private |
| _craftingMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Private |
| _craftingStationIcon | UnityEngine.Sprite | Private |
| _craftingStationName | UnityEngine.Localization.LocalizedString | Private |
| _viewModel | Wildskies.UI.Panel.OpenArkComputerOrCraftingStationPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.OpenArkComputerOrCraftingStationPanelPayload | Private |
| _isPanelOpen | System.Boolean | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _dynamikaCharacter | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _currentCameraTransform | UnityEngine.Transform | Private |
| _cachedPosition | UnityEngine.Vector3 | Private |
| _currentTweenSequence | DG.Tweening.Sequence | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **OnInputTypeChanged(System.Boolean isGamepad)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **ShowArkComputerConversation(System.String conversationId)**: System.Void (Private)
- **ChangeCameraControl()**: System.Void (Private)
- **MoveCameraToComputer()**: System.Void (Private)
- **MoveCameraToOriginalPosition()**: System.Void (Private)
- **RevertCameraView()**: System.Void (Private)
- **ShowMenuSelectionPanel()**: System.Void (Private)
- **OnConversationFinished()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **OnArkComputerSelected()**: System.Void (Private)
- **OnCraftBenchSelected()**: System.Void (Private)
- **OnAnyItemReady()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<MoveCameraToComputer>b__27_0()**: System.Void (Private)
- **<MoveCameraToOriginalPosition>b__28_0()**: System.Void (Private)

