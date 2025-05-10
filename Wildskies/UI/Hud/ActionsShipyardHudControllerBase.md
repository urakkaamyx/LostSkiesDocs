# Wildskies.UI.Hud.ActionsShipyardHudControllerBase

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _template | Wildskies.UI.Hud.ShipyardInputActionDisplay | Private |
| _layoutItemTemplate | UnityEngine.RectTransform | Private |
| Payload | Wildskies.UI.Hud.ShipyardBuildInputHudPayload | Protected |
| _displayingItems | System.Collections.Generic.List`1<Wildskies.UI.Hud.ShipyardInputActionDisplay> | Private |
| _poolsInitialized | System.Boolean | Private |
| DisplayDelay | System.Single | Private |

## Methods

- **Awake()**: System.Void (Protected)
- **InitializePool()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Initialize(Wildskies.UI.Hud.ShipyardBuildInputHudPayload payload)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **CheckIfNeedsRebuild()**: System.Void (Protected)
- **UpdateDisplayingItems(System.Collections.Generic.IReadOnlyList`1<Wildskies.UI.Hud.ActionData> actionList)**: System.Void (Protected)
- **TryGetInputDisplayByActionData(Wildskies.UI.Hud.ActionData availableAction, Wildskies.UI.Hud.ShipyardInputActionDisplay& shipyardInputActionDisplay)**: System.Boolean (Private)
- **.ctor()**: System.Void (Protected)

