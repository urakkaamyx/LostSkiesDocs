# Wildskies.UI.Hud.ActionsHudControllerBase

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _template | Wildskies.UI.Hud.ContextualInputPromptActionDisplay | Private |
| _layoutItemTemplate | UnityEngine.RectTransform | Private |
| Payload | Wildskies.UI.Hud.ContextualInputPromptHudPayload | Protected |
| _displayingItems | System.Collections.Generic.List`1<Wildskies.UI.Hud.ContextualInputPromptActionDisplay> | Private |
| _poolsInitialized | System.Boolean | Private |

## Methods

- **Awake()**: System.Void (Protected)
- **InitializePool()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Initialize(Wildskies.UI.Hud.ContextualInputPromptHudPayload payload)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **CheckIfNeedsRebuild()**: System.Void (Protected)
- **UpdateDisplayingItems(System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.InputActionData> actionList)**: System.Void (Protected)
- **TryGetInputDisplayByActionData(Wildskies.UI.Hud.InputActionData availableAction, Wildskies.UI.Hud.ContextualInputPromptActionDisplay& shipyardInputActionDisplay)**: System.Boolean (Private)
- **.ctor()**: System.Void (Protected)

