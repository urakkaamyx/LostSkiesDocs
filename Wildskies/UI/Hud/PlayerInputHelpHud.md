# Wildskies.UI.Hud.PlayerInputHelpHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _viewModel | Wildskies.UI.Hud.PlayerInputHelpHudViewModel | Private |
| ModifierString | System.String | Private |
| _inputActionListEntries | System.Collections.Generic.List`1<InputActionListEntry> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Show(IPayload payload)**: System.Void (Public)
- **RefreshActionLists()**: System.Void (Private)
- **CreateEntry(UnityEngine.InputSystem.InputAction action, UnityEngine.Transform parent)**: System.Void (Private)
- **PopulateBindingField(UnityEngine.InputSystem.InputAction action, InputActionListEntry entry)**: System.Void (Private)
- **SetContext()**: System.Void (Private)
- **ClearLists()**: System.Void (Private)
- **CloseAllInputHelpHuds()**: System.Void (Private)
- **OnPanelShown(UISystem.UIPanelType _)**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **IsActionIgnored(UnityEngine.InputSystem.InputAction action)**: System.Boolean (Private)
- **PathIsNotAButton(System.String path)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

