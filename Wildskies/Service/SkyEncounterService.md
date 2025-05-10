# WildSkies.Service.SkyEncounterService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _activeEncounters | System.Collections.Generic.List`1<ISkyEncounter> | Private |
| _playerShips | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Private |
| _shipsInAir | System.Collections.Generic.List`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **RegisterEncounter(ISkyEncounter encounter)**: System.Void (Public)
- **UnregisterEncounter(ISkyEncounter encounter)**: System.Void (Public)
- **RegisterPlayerShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **UnregisterPlayerShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **TryGetShipForEncounter(WildSkies.Gameplay.ShipBuilding.ConstructedShipController& ship)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

