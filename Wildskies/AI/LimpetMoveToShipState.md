# WildSkies.AI.LimpetMoveToShipState

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _damageable | Entities.Weapons.IDamageable | Private |
| _target | UnityEngine.Transform | Private |
| _movement | WildSkies.AI.PhysicsFlyingMovement | Private |
| _animation | LimpetAnimation | Private |
| _speed | System.Single | Private |
| _onStateComplete | System.Action | Private |
| _offsetAmount | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| State | WildSkies.AI.LimpetCritter/LimpetStates | Public |

## Methods

- **get_State()**: WildSkies.AI.LimpetCritter/LimpetStates (Public)
- **.ctor(WildSkies.AI.LimpetCritter/LimpetSettings settings, WildSkies.AI.PhysicsFlyingMovement movement, LimpetAnimation animation, System.Action onComplete)**: System.Void (Public)
- **EnterState()**: System.Void (Public)
- **ExitState()**: System.Void (Public)
- **DisableState()**: System.Void (Public)
- **UpdateState()**: System.Void (Public)
- **RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Vector3 angles)**: UnityEngine.Vector3 (Private)
- **SetTarget(Entities.Weapons.IDamageable damageable, UnityEngine.Transform target, UnityEngine.Transform shipTransform)**: System.Void (Public)

