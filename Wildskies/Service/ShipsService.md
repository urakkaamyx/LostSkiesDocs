# WildSkies.Service.ShipsService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerShipSpawnOffsetX | System.Single | Private |
| _playerShipSpawnOffsetY | System.Single | Private |
| _playerShipSpawnOffsetZ | System.Single | Private |
| _ships | System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Private |
| _shipwrecks | System.Collections.Generic.HashSet`1<Shipwreck> | Private |
| _playersAtShips | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.HashSet`1<Bossa.Dynamika.Character.DynamikaCharacter>> | Private |
| _playersAtShipwrecks | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.HashSet`1<Bossa.Dynamika.Character.DynamikaCharacter>> | Private |
| _currentSpawnPoint | UnityEngine.Vector3 | Private |
| _shipsSpawned | System.Boolean | Private |
| _shipwrecksSpawned | System.Boolean | Private |
| PlayerAddedToShip | System.Action`2<System.String,Bossa.Dynamika.Character.DynamikaCharacter> | Public |
| PlayerRemovedFromShip | System.Action`2<System.String,Bossa.Dynamika.Character.DynamikaCharacter> | Public |
| PlayerAddedToShipwreck | System.Action`2<System.String,Bossa.Dynamika.Character.DynamikaCharacter> | Public |
| PlayerRemovedFromShipwreck | System.Action`2<System.String,Bossa.Dynamika.Character.DynamikaCharacter> | Public |
| ShipRegistered | System.Action | Public |
| ShipDeregistered | System.Action`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| Ships | System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Public |
| Shipwrecks | System.Collections.Generic.HashSet`1<Shipwreck> | Public |
| ShipsSpawned | System.Boolean | Public |
| ShipwrecksSpawned | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_Ships()**: System.Collections.Generic.HashSet`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> (Public)
- **get_Shipwrecks()**: System.Collections.Generic.HashSet`1<Shipwreck> (Public)
- **get_ShipsSpawned()**: System.Boolean (Public)
- **get_ShipwrecksSpawned()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **RegisterShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **UnregisterShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **RegisterShipwreck(Shipwreck shipwreck)**: System.Void (Public)
- **UnregisterShipwreck(Shipwreck shipwreck)**: System.Void (Public)
- **AddPlayerToShip(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Void (Public)
- **RemovePlayerFromShip(Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Void (Public)
- **DestroyShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Public)
- **AddPlayerToShipwreck(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter player, System.Boolean force)**: System.Void (Public)
- **RemovePlayerFromShipwreck(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Void (Public)
- **OnDestroyShipwreck(Shipwreck shipwreck, Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Void (Public)
- **GetPlayersAssociatedWithShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Collections.Generic.List`1<Bossa.Dynamika.Character.DynamikaCharacter> (Public)
- **CanSpawnOnShip(Bossa.Dynamika.Character.DynamikaCharacter player, UnityEngine.Vector3& position, UnityEngine.Quaternion& rotation)**: System.Boolean (Public)
- **IsPlayerAssociatedWithShip(Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Boolean (Public)
- **GetShipAssociatedWithPlayer(Bossa.Dynamika.Character.DynamikaCharacter player, WildSkies.Gameplay.ShipBuilding.ConstructedShipController& ship)**: System.Boolean (Public)
- **IsPlayerAssociatedWithShipwreck(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Boolean (Public)
- **SetShipsSpawned(System.Boolean shipsSpawned)**: System.Void (Public)
- **SetShipwrecksSpawned(System.Boolean shipwrecksSpawned)**: System.Void (Public)
- **GetShipByUniqueId(System.String uniqueId)**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **.ctor()**: System.Void (Public)

