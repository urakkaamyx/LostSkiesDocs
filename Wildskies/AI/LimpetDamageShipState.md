# WildSkies.AI.LimpetDamageShipState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _onStateComplete | System.Action | Private |
| _damageRate | System.Single | Private |
| _damageAmount | System.Int32 | Private |
| _damageType | WildSkies.Weapon.DamageType | Private |
| _movement | WildSkies.AI.PhysicsFlyingMovement | Private |
| _limpetTransform | UnityEngine.Transform | Private |
| _animation | LimpetAnimation | Private |
| _healthComponents | WildSkies.Entities.Health.EntityHealthDamageComponent[] | Private |
| _ignoreAgentLayers | UnityEngine.LayerMask | Private |
| _damageable | Entities.Weapons.IDamageable | Private |
| _target | UnityEngine.Transform | Private |
| _shipTransform | UnityEngine.Transform | Private |
| _targetNormal | UnityEngine.Vector3 | Private |
| _targetFace | WildSkies.Gameplay.ShipBuilding.ShipHullFace | Private |
| _offsetMult | System.Single | Private |
| _timer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| State | WildSkies.AI.LimpetCritter/LimpetStates | Public |

## Methods

- **get_State()**: WildSkies.AI.LimpetCritter/LimpetStates (Public)
- **.ctor(WildSkies.AI.LimpetCritter/LimpetSettings settings, WildSkies.AI.PhysicsFlyingMovement movement, WildSkies.Entities.Health.EntityHealthDamageComponent[] healthComponents, UnityEngine.Transform limpetTransform, LimpetAnimation animation, System.Action onComplete)**: System.Void (Public)
- **EnterState()**: System.Void (Public)
- **ExitState()**: System.Void (Public)
- **DisableState()**: System.Void (Public)
- **UpdateState()**: System.Void (Public)
- **LateUpdateState()**: System.Void (Public)
- **UpdatePositionAndRotation()**: System.Void (Private)
- **RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Vector3 angles)**: UnityEngine.Vector3 (Private)
- **SetTarget(Entities.Weapons.IDamageable damageable, UnityEngine.Transform target, UnityEngine.Transform shipTransform)**: System.Void (Public)

