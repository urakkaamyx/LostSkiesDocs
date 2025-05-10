# WildSkies.Gameplay.ShipBuilding.ConstructedShipController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| InertiaReadyTime | System.Single | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _shipRoot | UnityEngine.Transform | Private |
| _shipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Private |
| _networkShipyard | WildSkies.Gameplay.ShipBuilding.NetworkShipyard | Private |
| _shipControl | WildSkies.Ship.ShipControl | Private |
| _collision | WildSkies.Ship.ShipProjectileCollision | Private |
| _weightPerEdgeMetreScale | System.Single | Private |
| _weightPerPanel | System.Single | Private |
| _showIslandBoundGizmos | System.Boolean | Private |
| _blendAuthorityVelocityTime | System.Single | Private |
| _correctAuthorityPositionTime | System.Single | Private |
| _implosionDelay | System.Single | Private |
| _implosionDuration | System.Single | Private |
| _explosionRadius | System.Single | Private |
| _explosionCenterDamage | System.Single | Private |
| _explosionEdgeDamage | System.Single | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _islandService | WildSkies.Service.IIslandService | Private |
| _skyEncounterService | WildSkies.Service.SkyEncounterService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| _windwallService | WildSkies.Service.WindwallService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _dockedShipBuilderController | WildSkies.Gameplay.ShipBuilding.ShipBuilderController | Private |
| _lastPosition | UnityEngine.Vector3 | Private |
| _lastRWPosition | UnityEngine.Vector3 | Private |
| <ShipWeight>k__BackingField | System.Single | Private |
| <ShipAverageUpgradeLevel>k__BackingField | System.Single | Private |
| <ShipEnergyUsage>k__BackingField | System.Single | Private |
| <ShipPanelsWeight>k__BackingField | System.Single | Private |
| <ProposedShipWeight>k__BackingField | System.Single | Private |
| <ProposedShipEnergyUsage>k__BackingField | System.Single | Private |
| _helm | WildSkies.ShipParts.Helm | Private |
| _shipCore | WildSkies.Ship.ShipCore | Private |
| _shipCoreUpgrades | System.Collections.Generic.HashSet`1<WildSkies.Ship.ShipCoreUpgrade> | Public |
| <IsDocked>k__BackingField | System.Boolean | Private |
| <IsInertiaReady>k__BackingField | System.Boolean | Private |
| _isOnIsland | System.Boolean | Private |
| _isInIslandZone | System.Boolean | Private |
| _isDestroyed | System.Boolean | Private |
| shipName | System.String | Public |
| ShipEnteredIsland | System.Action | Public |
| ShipEnteredIslandZone | System.Action | Public |
| ShipExitedIslandZone | System.Action | Public |
| ShipDestroyed | System.Action | Public |
| _shipParts | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _shipWeapons | System.Collections.Generic.List`1<WildSkies.ShipParts.ShipWeapon> | Private |
| _getPartsList | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Private |
| _recalculateWeightAndEnergyUsage | System.Boolean | Private |
| _bounds | UnityEngine.Vector3 | Private |
| _inertiaReadyTimer | System.Single | Private |
| IslandZoneBuffer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WeightPerEdgeMetreScale | System.Single | Public |
| WeightPerPanel | System.Single | Public |
| ShipRoot | UnityEngine.Transform | Public |
| Helm | WildSkies.ShipParts.Helm | Public |
| ShipCore | WildSkies.Ship.ShipCore | Public |
| ShipCoreUpgrades | System.Collections.Generic.HashSet`1<WildSkies.Ship.ShipCoreUpgrade> | Public |
| IsOnIsland | System.Boolean | Public |
| IsInIslandZone | System.Boolean | Public |
| ShipWeight | System.Single | Public |
| ShipAverageUpgradeLevel | System.Single | Public |
| ShipEnergyUsage | System.Single | Public |
| ShipPanelsWeight | System.Single | Public |
| ProposedShipWeight | System.Single | Public |
| ProposedShipEnergyUsage | System.Single | Public |
| IsDocked | System.Boolean | Public |
| IsInertiaReady | System.Boolean | Public |
| DockedShipBuilderController | WildSkies.Gameplay.ShipBuilding.ShipBuilderController | Public |
| Collision | WildSkies.Ship.ShipProjectileCollision | Public |
| ShipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Public |
| ShipControl | WildSkies.Ship.ShipControl | Public |
| NetworkShipyard | WildSkies.Gameplay.ShipBuilding.NetworkShipyard | Public |
| CoherenceSync | Coherence.Toolkit.CoherenceSync | Public |
| ShipName | System.String | Public |
| Bounds | UnityEngine.Vector3 | Public |
| IsDestroyed | System.Boolean | Public |
| ShipParts | System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> | Public |
| ShipWeapons | System.Collections.Generic.List`1<WildSkies.ShipParts.ShipWeapon> | Public |

## Methods

- **get_WeightPerEdgeMetreScale()**: System.Single (Public)
- **get_WeightPerPanel()**: System.Single (Public)
- **get_ShipRoot()**: UnityEngine.Transform (Public)
- **get_Helm()**: WildSkies.ShipParts.Helm (Public)
- **get_ShipCore()**: WildSkies.Ship.ShipCore (Public)
- **get_ShipCoreUpgrades()**: System.Collections.Generic.HashSet`1<WildSkies.Ship.ShipCoreUpgrade> (Public)
- **get_IsOnIsland()**: System.Boolean (Public)
- **get_IsInIslandZone()**: System.Boolean (Public)
- **get_ShipWeight()**: System.Single (Public)
- **set_ShipWeight(System.Single value)**: System.Void (Public)
- **get_ShipAverageUpgradeLevel()**: System.Single (Public)
- **set_ShipAverageUpgradeLevel(System.Single value)**: System.Void (Public)
- **get_ShipEnergyUsage()**: System.Single (Public)
- **set_ShipEnergyUsage(System.Single value)**: System.Void (Public)
- **get_ShipPanelsWeight()**: System.Single (Public)
- **set_ShipPanelsWeight(System.Single value)**: System.Void (Public)
- **get_ProposedShipWeight()**: System.Single (Public)
- **set_ProposedShipWeight(System.Single value)**: System.Void (Public)
- **get_ProposedShipEnergyUsage()**: System.Single (Public)
- **set_ProposedShipEnergyUsage(System.Single value)**: System.Void (Public)
- **get_IsDocked()**: System.Boolean (Public)
- **set_IsDocked(System.Boolean value)**: System.Void (Private)
- **get_IsInertiaReady()**: System.Boolean (Public)
- **set_IsInertiaReady(System.Boolean value)**: System.Void (Private)
- **get_DockedShipBuilderController()**: WildSkies.Gameplay.ShipBuilding.ShipBuilderController (Public)
- **get_Collision()**: WildSkies.Ship.ShipProjectileCollision (Public)
- **get_ShipFrameBuilder()**: WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder (Public)
- **get_ShipControl()**: WildSkies.Ship.ShipControl (Public)
- **get_NetworkShipyard()**: WildSkies.Gameplay.ShipBuilding.NetworkShipyard (Public)
- **get_CoherenceSync()**: Coherence.Toolkit.CoherenceSync (Public)
- **get_ShipName()**: System.String (Public)
- **get_Bounds()**: UnityEngine.Vector3 (Public)
- **get_IsDestroyed()**: System.Boolean (Public)
- **get_ShipParts()**: System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> (Public)
- **get_ShipWeapons()**: System.Collections.Generic.List`1<WildSkies.ShipParts.ShipWeapon> (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **OnWindwallsInitialised()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **CheckIsShipOrphaned()**: System.Void (Private)
- **ShipPartRemoved(WildSkies.Ship.ShipPart shipPart)**: System.Void (Private)
- **ShipPartAdded(WildSkies.Ship.ShipPart shipPart)**: System.Void (Private)
- **UpdateWeightAndEnergyUsage()**: System.Void (Private)
- **CalculateShipCoreEnergyAndWeight()**: System.Void (Private)
- **CalculateWeightAndEnergyUsage()**: System.Void (Private)
- **SetShipName(System.String sn)**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **OnFloatingOriginShifted(UnityEngine.Vector3 shift)**: System.Void (Private)
- **RequestAuthority()**: System.Void (Public)
- **ShipLaunch()**: System.Void (Public)
- **ShipLaunchCmd()**: System.Void (Public)
- **ShipDock(UnityEngine.GameObject shipBuilderGo)**: System.Void (Public)
- **ShipDockCmd(UnityEngine.GameObject shipBuilderGO)**: System.Void (Public)
- **CheckIsOnIsland()**: System.Void (Private)
- **CheckIsInIslandZone()**: System.Void (Private)
- **DestroyShip()**: System.Void (Public)
- **OnDestroyShip()**: System.Void (Public)
- **ImplodeShip()**: System.Void (Private)
- **OnShipwreckSpawned(UnityEngine.GameObject wreck)**: System.Void (Private)
- **SetShipCore(WildSkies.Ship.ShipCore shipCore)**: System.Void (Public)
- **AddShipCoreUpgrade(WildSkies.Ship.ShipCoreUpgrade shipCoreUpgrade)**: System.Void (Public)
- **RemoveShipCoreUpgrade(WildSkies.Ship.ShipCoreUpgrade shipCoreUpgrade)**: System.Void (Public)
- **SetHelm(WildSkies.ShipParts.Helm helm)**: System.Void (Public)
- **SetDocked(System.Boolean docked)**: System.Void (Public)
- **GetNumberOfPartsType(WildSkies.Gameplay.ShipBuilding.HullObjectType type)**: System.Int32 (Public)
- **GetShipLevel()**: System.Int32 (Public)
- **GetPartsOfType(WildSkies.Gameplay.ShipBuilding.HullObjectType type)**: System.Collections.Generic.List`1<WildSkies.Ship.ShipPart> (Public)
- **GetPartsOfType()**: System.Collections.Generic.List`1<T> (Public)
- **OnDrawGizmosSelected()**: System.Void (Private)
- **MoveAllPlayers(UnityEngine.Vector3 position, System.Single horizontalOffset, System.Single verticalOffset)**: System.Void (Public)
- **MoveAllPlayersCommand(UnityEngine.Vector3 position, System.Single horizontalOffset, System.Single verticalOffset)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<Awake>b__120_0()**: System.Void (Private)
- **<Awake>b__120_1()**: System.Void (Private)
- **<Awake>b__120_2()**: System.Void (Private)
- **<ShipLaunchCmd>b__135_0()**: System.Boolean (Private)

