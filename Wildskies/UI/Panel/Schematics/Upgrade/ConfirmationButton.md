# Wildskies.UI.Panel.Schematics.Upgrade.ConfirmationButton

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| GamepadHoldToPrefix | System.String | Private |
| HoldTime | System.Single | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _mnkButton | UnityEngine.UI.Button | Private |
| _mnkButtonLabel | TMPro.TMP_Text | Private |
| _gamepadButton | UnityEngine.GameObject | Private |
| _gamepadButtonLabel | TMPro.TMP_Text | Private |
| _gamepadButtonFill | UnityEngine.UI.Image | Private |
| _gamepadDisabledFade | System.Single | Private |
| _gamepadCanvasGroup | UnityEngine.CanvasGroup | Private |
| _holdTimer | System.Single | Private |
| _holdTriggered | System.Boolean | Private |
| _canInteract | System.Boolean | Private |
| OnConfirmationButtonClicked | System.Action | Public |

## Methods

- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **Init(System.String label)**: System.Void (Public)
- **SetInteractable(System.Boolean canInteract)**: System.Void (Public)
- **ButtonClicked()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **ResetGamepadHold()**: System.Void (Private)
- **SetButtonLabel(System.String label)**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isGamepad)**: System.Void (Private)
- **GetHoldTime()**: System.Single (Private)
- **.ctor()**: System.Void (Public)

