# WildSkies.Ship.ShipPart

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| DamagePropagationThreshold | System.Single | Private |
| _damageTypeOverrides | WildSkies.Weapon.DamageTypeOverrideSettings | Private |
| _shipPartMaterial | WildSkies.Ship.ShipPart/ShipPartMaterial | Private |
| _shipPartDamageType | WildSkies.Ship.ShipPart/ShipPartDamageType | Private |
| _minDamageToRegister | System.Single | Private |
| _minRepairToRegister | System.Single | Private |
| _maxHealth | System.Single | Private |
| _expolsionForce | System.Single | Private |
| _healthBarYOffset | System.Single | Private |
| _statsService | WildSkies.Service.ItemStatsService | Protected |
| _networkFxService | WildSkies.Service.NetworkFxService | Protected |
| _repairFeedbackService | RepairFeedbackService | Protected |
| _buildingService | WildSkies.Service.BuildingService | Protected |
| _itemService | WildSkies.Service.IItemService | Protected |
| _itemStatService | WildSkies.Service.IItemStatService | Protected |
| _buffService | WildSkies.Service.BuffService | Protected |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| _shipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _craftableRendererController | CraftableRendererController | Private |
| _damageLoopingVfx | DamageLoopingVfx | Private |
| _buildableAsset | WildSkies.Gameplay.Building.BuildableAsset | Private |
| _buildableItemDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Private |
| _shipHullObject | WildSkies.Gameplay.ShipBuilding.ShipHullObject | Private |
| _connectedPartList | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _linkedFaces | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _facesToDamage | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _tempChildPartList | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _tempParentPartList | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _currentHealth | System.Single | Private |
| OnHealthUpdated | WildSkies.Ship.ShipPart/UpdateHealth | Private |
| _parentShipPart | WildSkies.Ship.ShipPart | Private |
| _edge | WildSkies.Gameplay.ShipBuilding.ShipHullEdge | Private |
| _shipHullFace | WildSkies.Gameplay.ShipBuilding.ShipHullFace | Private |
| _primaryResourceStatsList | ResourceStatsList | Private |
| _mergedStats | ShipPartStatsList | Private |
| _damageResponse | WildSkies.Weapon.DamageResponse | Private |
| _healthBarActive | System.Boolean | Private |
| _usesBuffs | System.Boolean | Private |
| _shipPartStats | ShipPartStats | Private |
| _shipPartBuffReceiver | WildSkies.Ship.Buffs.ShipPartBuffReceiver | Private |
| _attackToken | AttackTokenHandler/AttackToken | Private |
| _maxStatValue | System.Single | Private |
| _minHeatResistance | System.Single | Private |
| _maxHeatResistance | System.Single | Private |
| _minElectricalConductivity | System.Single | Private |
| _maxElectricalConductivity | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |
| OriginalStats | ShipPartStatsList | Private |
| Stats | ShipPartStatsList | Public |
| PrimaryResourceStatsList | ResourceStatsList | Public |
| IsRepairable | System.Boolean | Public |
| Edge | WildSkies.Gameplay.ShipBuilding.ShipHullEdge | Public |
| Face | WildSkies.Gameplay.ShipBuilding.ShipHullFace | Public |
| ParentShipPart | WildSkies.Ship.ShipPart | Public |
| ShipHullObject | WildSkies.Gameplay.ShipBuilding.ShipHullObject | Public |
| HasParentShipPart | System.Boolean | Public |
| Colliders | UnityEngine.Collider[] | Public |
| CurrentHealth | System.Single | Public |
| MaxHealth | System.Single | Public |
| CraftableRendererController | CraftableRendererController | Public |
| BuildableAsset | WildSkies.Gameplay.Building.BuildableAsset | Public |
| BuildableItemDefinition | WildSkies.Gameplay.Building.BuildableItemDefinition | Public |
| TokenableType | WildSkies.AI.TokenableType | Public |
| TokenableTransform | UnityEngine.Transform | Public |
| CurrentShipPartDamageType | WildSkies.Ship.ShipPart/ShipPartDamageType | Public |
| ShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **add_OnHealthUpdated(WildSkies.Ship.ShipPart/UpdateHealth value)**: System.Void (Public)
- **remove_OnHealthUpdated(WildSkies.Ship.ShipPart/UpdateHealth value)**: System.Void (Public)
- **get_OriginalStats()**: ShipPartStatsList (Private)
- **get_Stats()**: ShipPartStatsList (Public)
- **get_PrimaryResourceStatsList()**: ResourceStatsList (Public)
- **get_IsRepairable()**: System.Boolean (Public)
- **get_Edge()**: WildSkies.Gameplay.ShipBuilding.ShipHullEdge (Public)
- **get_Face()**: WildSkies.Gameplay.ShipBuilding.ShipHullFace (Public)
- **get_ParentShipPart()**: WildSkies.Ship.ShipPart (Public)
- **get_ShipHullObject()**: WildSkies.Gameplay.ShipBuilding.ShipHullObject (Public)
- **get_HasParentShipPart()**: System.Boolean (Public)
- **get_Colliders()**: UnityEngine.Collider[] (Public)
- **get_CurrentHealth()**: System.Single (Public)
- **set_CurrentHealth(System.Single value)**: System.Void (Public)
- **get_MaxHealth()**: System.Single (Public)
- **get_CraftableRendererController()**: CraftableRendererController (Public)
- **get_BuildableAsset()**: WildSkies.Gameplay.Building.BuildableAsset (Public)
- **get_BuildableItemDefinition()**: WildSkies.Gameplay.Building.BuildableItemDefinition (Public)
- **get_TokenableType()**: WildSkies.AI.TokenableType (Public)
- **get_TokenableTransform()**: UnityEngine.Transform (Public)
- **get_CurrentShipPartDamageType()**: WildSkies.Ship.ShipPart/ShipPartDamageType (Public)
- **get_ShipController()**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **Awake()**: System.Void (Protected)
- **UpdateStats()**: System.Void (Protected)
- **Setup(WildSkies.Gameplay.ShipBuilding.ConstructedShipController shipController)**: System.Void (Public)
- **SetHealth(System.Single health)**: System.Void (Public)
- **SetupReferences(ShipPartSubComponent[] parts)**: System.Void (Public)
- **GetBuildableAssetItemDefinition()**: WildSkies.Gameplay.Building.BuildableItemDefinition (Public)
- **GetUpgradeLevel()**: System.Int32 (Public)
- **GetHullObjectData()**: WildSkies.Gameplay.ShipBuilding.HullObjectData (Public)
- **SetupMaterialStats(System.String itemId, System.String schematicId, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Int32 upgradeLevel, System.Boolean mergeStats)**: System.Collections.Generic.Dictionary`2<System.String,System.Single> (Public)
- **GetAllMaterials()**: System.Collections.Generic.List`1<UnityEngine.Material> (Public)
- **SetupMaterialRendererDescriptors(System.String itemId, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Collections.Generic.List`1<UnityEngine.Material> materials)**: System.Void (Public)
- **DisconnectFromParent()**: System.Void (Public)
- **AddChildrenShipPart(WildSkies.Ship.ShipPart targetChildren)**: System.Void (Public)
- **RemoveChildrenShipPart(WildSkies.Ship.ShipPart targetChildren)**: System.Boolean (Public)
- **SetParentShipPart(WildSkies.Ship.ShipPart targetParent)**: System.Void (Private)
- **ClearParentShipPart()**: System.Void (Private)
- **SetShipReference(WildSkies.Gameplay.ShipBuilding.ConstructedShipController shipController)**: System.Void (Public)
- **DealDamage(System.Single amount, UnityEngine.Vector3 hitPoint)**: System.Void (Public)
- **DealDamageOnShipParts(System.Single amount, UnityEngine.Vector3 hitPoint, System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> partsList)**: System.Void (Public)
- **OnDestroy()**: System.Void (Protected)
- **ApplyDamage(System.Single amount, UnityEngine.Vector3 hitPoint)**: System.Void (Private)
- **RepairPart(System.Int32 amount)**: System.Void (Public)
- **RepairPartCompletely()**: System.Void (Public)
- **DestroyPart(System.Single amount, UnityEngine.Vector3 hitPoint, System.Boolean isCrafting, System.Boolean playAudio, System.Boolean shouldDestroyGameObject)**: System.Void (Public)
- **IsRootParent()**: System.Boolean (Private)
- **GetRootParentShipParts()**: System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> (Private)
- **GetChildShipParts(System.Boolean recursive)**: System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> (Private)
- **GetChildDepth()**: System.Int32 (Public)
- **PlayDamageAudio(System.Single amount, UnityEngine.Vector3 hitPoint)**: System.Void (Private)
- **PlayDestroyAudio(System.Single amount, UnityEngine.Vector3 hitPoint)**: System.Void (Private)
- **SetupLinkedFaces()**: System.Void (Private)
- **GetShipPartId()**: System.Int32 (Public)
- **DamageFromDebuff(System.Single damage, WildSkies.Weapon.DamageType type)**: System.Void (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **GetDamageFromStats(WildSkies.Weapon.DamageType damageType, System.Single damage)**: System.Single (Private)
- **TryGetToken(AttackTokenHandler/AttackTokenType type, AttackTokenHandler/AttackToken& attackToken)**: System.Boolean (Public)
- **HasAvailableToken(AttackTokenHandler/AttackTokenType type)**: System.Boolean (Public)
- **DropToken(AttackTokenHandler/AttackToken token)**: System.Void (Public)
- **DebugHealDamage()**: System.Void (Protected)
- **DebugApplyDamage()**: System.Void (Protected)
- **DebugApplySmallDamage()**: System.Void (Protected)
- **RepairDamage(System.Int32 amount)**: RepairState (Public)
- **StartRepair()**: System.Void (Public)
- **EndRepair()**: System.Void (Public)
- **AimAtRepairable()**: System.Void (Public)
- **StopAimingAtRepairable()**: System.Void (Public)
- **ShowHealthBar()**: System.Boolean (Public)
- **GetHealth01()**: System.Single (Public)
- **GetTrackingTransform()**: UnityEngine.Transform (Public)
- **GetWorldSpaceYOffset()**: System.Single (Public)
- **SetOriginalStats(ShipPartStats stats)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

