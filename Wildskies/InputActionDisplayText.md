# WildSkies.InputActionDisplayText

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _inputSpriteService | WildSkies.Service.InputSpriteService | Private |
| _automaticallyUpdateOnInputChange | System.Boolean | Private |
| _hasCachedText | System.Boolean | Private |
| _cachedText | TMPro.TMP_Text | Private |
| _initialized | System.Boolean | Private |
| _displayingInputAction | UnityEngine.InputSystem.InputAction | Private |
| _displayingFormat | System.String | Private |
| _displayingCompositionSeparator | System.String | Private |
| _displayingSpecifiedCompositionParts | System.String[] | Private |
| _onlyFirstHit | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| TMPText | TMPro.TMP_Text | Private |

## Methods

- **get_TMPText()**: TMPro.TMP_Text (Private)
- **Awake()**: System.Void (Protected)
- **Initialize()**: System.Void (Private)
- **OnDestroy()**: System.Void (Protected)
- **OnInputTypeChanged(System.Boolean isNewInputAGamepad)**: System.Void (Private)
- **ShowInputAction(UnityEngine.InputSystem.InputAction inputAction, System.String format, System.String compositionSeparator, System.String[] specifiedCompositionParts, System.Boolean onlyFirstHit)**: System.Void (Public)
- **UpdateDisplayingText()**: System.Void (Private)
- **Clear()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

