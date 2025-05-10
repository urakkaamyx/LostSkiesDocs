# Wildskies.UI.Panel.PopupPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.PopupPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.PopupPanelPayload | Private |
| _uiService | UISystem.IUIService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _defaultConfirmButtonLabel | System.String | Private |
| _defaultCancelButtonLabel | System.String | Private |
| _lastKeyboardSelection | UnityEngine.GameObject | Private |
| _firstKeyboardButton | UnityEngine.UI.Button | Private |
| _cacheSelectedGameObject | UnityEngine.GameObject | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **UpdateInput(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **UpdateGamepadInput()**: System.Void (Private)
- **UpdateKeyboardInput()**: System.Void (Private)
- **IsValidInputText()**: System.Boolean (Private)
- **RefreshButtonsVisuals(System.Boolean isGamepad)**: System.Void (Private)
- **SetText(UnityEngine.Localization.LocalizedString locString, TMPro.TMP_Text label)**: System.Void (Private)
- **OnCancelButtonClicked()**: System.Void (Private)
- **OnConfirmButtonClicked()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

