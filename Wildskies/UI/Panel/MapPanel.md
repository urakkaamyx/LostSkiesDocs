# Wildskies.UI.Panel.MapPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _zoomMultiplier | System.Single | Private |
| _panMultiplier | System.Single | Private |
| _viewModel | Wildskies.UI.Panel.MapPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.MapPanelPayload | Private |
| _acceleration | UnityEngine.Vector2 | Private |
| _zoom | System.Single | Private |
| _zoomChange | System.Single | Private |
| _shipCrewEntries | System.Collections.Generic.List`1<Wildskies.UI.Panel.ShipCrewEntry> | Private |
| _cameraFovOverride | Bossa.Cinematika.Modules.FieldOfViewControl/FieldOfViewModifier | Private |
| _selectedShipCrewIndex | System.Int32 | Private |
| _currSelectedShipCrewEntry | Wildskies.UI.Panel.ShipCrewEntry | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **OnInputTypeChanged(System.Boolean isnewinputagamepad)**: System.Void (Private)
- **ChangeMapTarget(UnityEngine.Vector3 position)**: System.Void (Private)
- **RotateV2(UnityEngine.Vector2 v, System.Single delta)**: UnityEngine.Vector2 (Private)
- **Update()**: System.Void (Private)
- **SetShipCrewEntries()**: System.Void (Private)
- **CheckShipCrewNavigation()**: System.Void (Private)
- **SetShipCrewEntrySelection()**: System.Void (Private)
- **ChangeZoom()**: System.Void (Private)
- **ChangePan()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

