# Wildskies.UI.Toolbar.ToolbarPrompts

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _timeTofadeOut | System.Single | Private |
| _fadeOutDuration | System.Single | Private |
| _canvasGroup | UnityEngine.CanvasGroup | Private |
| _genericActionText | TMPro.TMP_Text | Private |
| _aimActionText | TMPro.TMP_Text | Private |
| _genericPromptContainer | UnityEngine.GameObject | Private |
| _aimPromptContainer | UnityEngine.GameObject | Private |
| _shootString | UnityEngine.Localization.LocalizedString | Private |
| _throwString | UnityEngine.Localization.LocalizedString | Private |
| _eatString | UnityEngine.Localization.LocalizedString | Private |
| _useString | UnityEngine.Localization.LocalizedString | Private |
| _scanString | UnityEngine.Localization.LocalizedString | Private |
| _aimString | UnityEngine.Localization.LocalizedString | Private |
| _repairString | UnityEngine.Localization.LocalizedString | Private |
| _toolbarState | Wildskies.UI.Toolbar.ToolbarPrompts/ToolbarState | Private |
| _fadeOutTimer | System.Single | Private |
| _isAiming | System.Boolean | Private |

## Methods

- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnLocaleChanged(UnityEngine.Localization.Locale locale)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **UpdateFadeOutTimer()**: System.Void (Private)
- **HandlePlayerInputUpdate()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **Show(Player.Inventory.IInventoryItem associatedItem)**: System.Void (Public)
- **UpdatePrompt(System.Boolean isAiming)**: System.Void (Private)
- **SetTextAsync(UnityEngine.Localization.LocalizedString locString, TMPro.TMP_Text label)**: System.Void (Private)
- **GetActionString(System.Boolean isAiming)**: System.String (Private)
- **.ctor()**: System.Void (Public)

