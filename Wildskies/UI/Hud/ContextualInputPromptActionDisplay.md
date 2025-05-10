# Wildskies.UI.Hud.ContextualInputPromptActionDisplay

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localisationService | WildSkies.Service.LocalisationService | Private |
| _canvasGroup | UnityEngine.CanvasGroup | Private |
| _inputAssetText | WildSkies.ActionDataDisplayText | Private |
| _actionNameDisplay | TMPro.TMP_Text | Private |
| _localisedFontAsset | UnityEngine.Localization.LocalizedAsset`1<TMPro.TMP_FontAsset> | Private |
| _rectTransform | UnityEngine.RectTransform | Private |
| _animRoot | UnityEngine.RectTransform | Private |
| _followSpeed | System.Single | Private |
| _disabledAlpha | System.Single | Private |
| _isDisabled | System.Boolean | Private |
| _actionData | Wildskies.UI.Hud.InputActionData | Private |
| _followLayoutElement | UnityEngine.RectTransform | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ActionData | Wildskies.UI.Hud.InputActionData | Public |

## Methods

- **get_ActionData()**: Wildskies.UI.Hud.InputActionData (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **Clear()**: System.Void (Public)
- **SetData(Wildskies.UI.Hud.InputActionData availableAction)**: System.Void (Public)
- **UpdateTexts(UnityEngine.Localization.Locale _)**: System.Void (Private)
- **SetDisabled(System.Boolean disabled)**: System.Void (Public)
- **Enter(UnityEngine.RectTransform verticalElement, System.Single delay)**: System.Void (Public)
- **Hide(System.Single delay)**: System.Void (Public)
- **LateUpdate()**: System.Void (Private)
- **SetSiblingIndex(System.Int32 i)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<Hide>b__21_0()**: System.Void (Private)

