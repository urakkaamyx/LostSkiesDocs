# WildSkies.Gameplay.Building.BuildableAsset

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| OnBuildableAssetDeleted | System.Action`1<WildSkies.Gameplay.Building.BuildableAsset> | Public |
| Id | System.String | Public |
| ResourceSpawner | WildSkies.Gameplay.Building.ReturnResourcesOnDestroy | Public |
| InteractionObject | UnityEngine.GameObject | Public |
| CoherenceSync | Coherence.Toolkit.CoherenceSync | Public |
| Colliders | UnityEngine.Collider[] | Public |
| ComponentDataList | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> | Public |
| Stats | ItemStats | Public |
| SchematicLevel | System.Int32 | Public |
| AttachmentPointList | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.AssetAttachmentPoint> | Public |
| _canBeDsimantled | System.Boolean | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _componentDataList | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> | Private |
| _itemCraftMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Private |
| _resetOnReposition | IResetOnReposition[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ItemCraftMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Public |

## Methods

- **get_ItemCraftMethod()**: WildSkies.Gameplay.Crafting.CraftingMethod (Public)
- **CanBeDismantled()**: System.Boolean (Public)
- **CanEdit()**: System.Boolean (Public)
- **Awake()**: System.Void (Protected)
- **Delete(WildSkies.Gameplay.ShipBuilding.HullObjectData hullObjectData)**: System.Void (Public)
- **ReturnResourcesAndDestroy(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ComponentData> componentDataList)**: System.Void (Private)
- **ClearCachedData()**: System.Void (Private)
- **AuthorityDestroy()**: System.Void (Public)
- **SessionOwnerClearData()**: System.Void (Public)
- **ResetOnReposition()**: System.Void (Public)
- **GetAttachmentPoint(UnityEngine.Vector3 targetPosition, System.String buildableItemId)**: WildSkies.Gameplay.Building.AssetAttachmentPoint (Public)
- **.ctor()**: System.Void (Public)
- **<ReturnResourcesAndDestroy>b__22_0()**: System.Boolean (Private)

