# WildSkies.Gameplay.ShipBuilding.HullObjectData

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| SessionService | WildSkies.Service.SessionService | Private |
| ShipPartGameObject | UnityEngine.GameObject | Public |
| ParentId | System.Int32 | Public |
| UpgradeLevel | System.Int32 | Public |
| FaceId | System.Int32 | Public |
| ItemId | System.String | Public |
| CraftingItemIds | System.Collections.Generic.List`1<System.String> | Public |
| HullObjectType | WildSkies.Gameplay.ShipBuilding.HullObjectType | Public |
| LocalPosition | SerializableTypes.SerializableVector3 | Public |
| LocalRotationQuat | SerializableTypes.SerializableQuaternion | Public |
| ComponentDataList | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> | Public |

## Methods

- **.ctor()**: System.Void (Public)
- **.ctor(UnityEngine.GameObject shipPartGameObject, System.Int32 parentId, System.Int32 upgradeLevel, System.Int32 faceId, System.String itemId, System.Collections.Generic.List`1<System.String> craftingItemIds, WildSkies.Gameplay.ShipBuilding.HullObjectType hullObjectType, SerializableTypes.SerializableVector3 localPosition, SerializableTypes.SerializableQuaternion localRotationQuat, System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList)**: System.Void (Public)
- **Reset()**: System.Void (Public)
- **Serialize(System.IO.BinaryWriter writer)**: System.Void (Public)
- **Deserialize(System.IO.BinaryReader reader, System.Int32 version)**: WildSkies.Gameplay.ShipBuilding.HullObjectData (Public)

