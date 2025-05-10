# Wildskies.UI.Panel.RespawnPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _uiService | UISystem.IUIService | Private |
| _viewModel | Wildskies.UI.Panel.RespawnPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.RespawnPanelPayload | Private |
| _countdown | DG.Tweening.Tween | Private |
| _localisationArgs | System.Object[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **StartTimer()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnConfirm(System.String s)**: System.Void (Private)
- **RevivePlayer()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<Show>b__11_0()**: System.Void (Private)
- **<StartTimer>b__12_0(System.Single value)**: System.Void (Private)
- **<StartTimer>b__12_1()**: System.Void (Private)

