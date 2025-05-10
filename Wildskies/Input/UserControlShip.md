# WildSkies.Input.UserControlShip

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _shipSettings | WildSkies.Input.UserControlShip/Settings | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| <ShipToControl>k__BackingField | WildSkies.Ship.ShipControl | Private |
| _currentRemoteWeapon | WildSkies.ShipParts.ShipWeapon | Private |
| _currentHelm | WildSkies.ShipParts.Helm | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _cameraInputState | Bossa.Cinematika.CameraInputState | Private |
| _localPlayerServices | WildSkies.Service.ILocalPlayerService | Private |
| _lp | WildSkies.Player.ILocalPlayer | Private |
| _dockUndockTimer | System.Single | Private |
| DockUndockHoldTime | System.Single | Private |
| _readyToDock | System.Boolean | Private |
| _currentRemoteTurretId | System.Int32 | Private |
| _isRemoteAiming | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ShipToControl | WildSkies.Ship.ShipControl | Public |
| ReadyToDock | System.Boolean | Public |

## Methods

- **get_ShipToControl()**: WildSkies.Ship.ShipControl (Public)
- **set_ShipToControl(WildSkies.Ship.ShipControl value)**: System.Void (Public)
- **get_ReadyToDock()**: System.Boolean (Public)
- **Start()**: System.Void (Private)
- **SetCamaraManager(Bossa.Cinematika.CameraManager cameraManger)**: System.Void (Public)
- **SetShip(WildSkies.ShipParts.Helm helm)**: System.Void (Public)
- **GetNextAvailableTurret(System.Int32 direction)**: System.Void (Private)
- **SwitchToRemoteWeaponAiming()**: System.Void (Private)
- **StopRemoteAiming()**: System.Void (Private)
- **InputAllowed()**: System.Boolean (Public)
- **DoUpdate()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<GetNextAvailableTurret>g__ChangeRemoteId|24_0(WildSkies.Input.UserControlShip/<>c__DisplayClass24_0& )**: System.Void (Private)

