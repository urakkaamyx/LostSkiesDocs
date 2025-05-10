# WildSkies.Ship.ShipProjectileCollision

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _shipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _layersToIgnore | UnityEngine.LayerMask | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _largeMessageService | WildSkies.Service.LargeMessageService | Private |
| _shipPartHealthSetup | System.Boolean | Private |
| _shipParts | WildSkies.Ship.ShipPart[] | Private |
| _collisionPartsDictionary | System.Collections.Generic.Dictionary`2<UnityEngine.Collider,WildSkies.Ship.ShipPart> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ShipParts | WildSkies.Ship.ShipPart[] | Public |

## Methods

- **get_ShipParts()**: WildSkies.Ship.ShipPart[] (Public)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Setup()**: System.Void (Public)
- **RestoreShipPartsHealth()**: System.Void (Public)
- **DealDamage(UnityEngine.Vector3 hitDir, UnityEngine.Vector3 hitPoint, UnityEngine.Collider partCollider, System.Single damage, System.Single hitForce)**: System.Boolean (Public)
- **OwnerDamage(System.Int32 shipPartId, System.Int32 damageType, UnityEngine.Vector3 hitDir, UnityEngine.Vector3 hitPoint, System.Single damage, System.Single hitForce)**: System.Void (Public)
- **NonOwnerDamage(System.Int32 shipPartId, System.Int32 damageType, System.Single damage, UnityEngine.Vector3 hitPoint)**: System.Void (Public)
- **RepairDamage(System.Int32 amount, UnityEngine.Collider partCollider)**: System.Boolean (Public)
- **OwnerRepair(System.Int32 shipPartId, System.Int32 damageType, System.Int32 amount)**: System.Void (Public)
- **NonOwnerRepair(System.Int32 shipPartId, System.Int32 damageType, System.Int32 amount)**: System.Void (Public)
- **GetShipPartFromDamageTypeAndId(System.Int32 shipPartId, WildSkies.Ship.ShipPart/ShipPartDamageType damageType)**: WildSkies.Ship.ShipPart (Private)
- **GetShipPartHealth()**: System.Collections.Generic.List`1<ShipPartHealth> (Public)
- **SetupShipPartHealth(System.Collections.Generic.List`1<ShipPartHealth> shipPartHealths)**: System.Void (Private)
- **RequestShipPartHealth()**: System.Void (Private)
- **OwnerRequestShipPartHealth()**: System.Void (Public)
- **OnLargeMessageReceived(WildSkies.Service.LargeMessageType messageType, System.Byte[] messageContents)**: System.Void (Private)
- **DealRandomDamage()**: System.Void (Private)
- **DestroyCore()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

