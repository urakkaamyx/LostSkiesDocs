# Wildskies.UI.Hud.OffScreenIndicatorHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _viewModel | Wildskies.UI.Hud.OffScreenIndicatorHudViewModel | Private |
| _payload | Wildskies.UI.Hud.OffScreenIndicatorHudPayload | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **SwitchCamera(UnityEngine.Camera camera)**: System.Void (Private)
- **AssignHudIndicator(System.String label, UnityEngine.Transform targetTransform)**: System.Void (Private)
- **ClearHudIndicator(UnityEngine.Transform targetTransform)**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **GetAvailableIndicator()**: OffscreenIndicator (Private)
- **.ctor()**: System.Void (Public)

