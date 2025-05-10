# Wildskies.UI.Hud.ContextualInputPromptHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Hud.ContextualInputPromptHudViewModel | Private |
| _payload | Wildskies.UI.Hud.ContextualInputPromptHudPayload | Private |
| _actionsHudControllers | Wildskies.UI.Hud.ActionsHudControllerBase[] | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _dynamikaCharacter | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _hasDoneInitialSetup | System.Boolean | Private |
| _gliderCachedState | System.Boolean | Private |
| _cachedMove | System.Boolean | Private |
| _cachedCrouch | System.Boolean | Private |
| _cachedHasObjectPicked | System.Boolean | Private |
| _followMouseSmoothFactor | System.Single | Private |
| NorthButtonString | System.String | Private |
| EastButtonString | System.String | Private |
| SouthButtonString | System.String | Private |
| _previousControlContext | WildSkies.Player.LocalPlayer/ControlContext | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **IsActionValidForInput(UnityEngine.InputSystem.InputAction action, System.String compareString)**: System.Boolean (Private)
- **SetupPrompts()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

