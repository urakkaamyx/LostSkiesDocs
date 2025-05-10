# WildSkies.AI.LimpetCritter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _limpetSettings | WildSkies.AI.LimpetCritter/LimpetSettings | Private |
| _shipTracking | AIShipTracking | Private |
| _grappledPerceptionHandler | GrappledPerceptionHandler | Private |
| _limpetAnimation | LimpetAnimation | Private |
| _shipHitDetection | Micosmo.SensorToolkit.RaySensor | Private |
| _movementCollider | UnityEngine.SphereCollider | Private |
| _healthComponents | WildSkies.Entities.Health.EntityHealthDamageComponent[] | Private |
| _ignoreColliderLayers | ColliderIgnoreLayers[] | Private |
| _renderers | UnityEngine.SkinnedMeshRenderer[] | Private |
| _deathVfx | WildSkies.VfxType | Private |
| _debugState | WildSkies.AI.LimpetCritter/LimpetStates | Private |
| _vfxPoolService | WildSkies.Service.VfxPoolService | Private |
| _disposalService | WildSkies.Service.DisposalService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _ignoreCollisions | System.Boolean | Public |
| _targetPart | UnityEngine.Transform | Private |
| _targetShip | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _targetDamageable | Entities.Weapons.IDamageable | Private |
| _states | System.Collections.Generic.Dictionary`2<WildSkies.AI.LimpetCritter/LimpetStates,WildSkies.AI.AILimpetState> | Private |
| _currentState | WildSkies.AI.AILimpetState | Private |
| _offset | UnityEngine.Vector3 | Private |
| _onDespawn | System.Action`1<WildSkies.AI.LimpetCritter> | Private |

## Methods

- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Protected)
- **Init(WildSkies.Gameplay.ShipBuilding.ConstructedShipController shipController, UnityEngine.Vector3 offset, System.Action`1<WildSkies.AI.LimpetCritter> onDespawn)**: System.Void (Public)
- **Start()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **LateUpdate()**: System.Void (Private)
- **OnAuthorityChange()**: System.Void (Public)
- **OnFloatingWorldOriginShifted(UnityEngine.Vector3 origin)**: System.Void (Private)
- **OnIgnoreCollisionsSynced(System.Boolean previousValue, System.Boolean newValue)**: System.Void (Private)
- **UpdateIgnoreCollisions()**: System.Void (Private)
- **OnHitDetected(UnityEngine.GameObject detectedObj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **TryFindNearestFace(WildSkies.Gameplay.ShipBuilding.ConstructedShipController shipController, UnityEngine.Transform& face)**: System.Boolean (Private)
- **OnTargetShipDestroyed()**: System.Void (Private)
- **OnKillEntity()**: System.Void (Public)
- **OnDisposeEntity()**: System.Void (Public)
- **NextState()**: System.Void (Private)
- **SetState(WildSkies.AI.LimpetCritter/LimpetStates state)**: System.Void (Private)
- **FindNewShipFaceTarget()**: System.Void (Private)
- **OnDamageAtPoint(System.Single damage, WildSkies.Weapon.DamageType damageType, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 position, System.Single newNormalizedHealth)**: System.Void (Private)
- **OnYanked(UnityEngine.Vector3 direction)**: System.Void (Private)
- **OnGrappled(UnityEngine.Vector3 obj)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

