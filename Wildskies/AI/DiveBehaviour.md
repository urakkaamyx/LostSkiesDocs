# WildSkies.AI.DiveBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <CurrentTargetHeight>k__BackingField | System.Single | Private |
| _targetAtStart | UnityEngine.Vector3 | Private |
| _target | UnityEngine.Vector3 | Private |
| _groundSensor | Micosmo.SensorToolkit.RaySensor | Private |
| _targetCheckSensor | Micosmo.SensorToolkit.RaySensor | Private |
| _originalMaxAcceleration | System.Single | Private |
| _speedMultiplier | System.Single | Private |
| _maxAccelMultiplier | System.Single | Private |
| _minDistanceAboveTarget | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |
| CurrentTargetHeight | System.Single | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **get_CurrentTargetHeight()**: System.Single (Public)
- **set_CurrentTargetHeight(System.Single value)**: System.Void (Private)
- **.ctor(WildSkies.AI.BossaNavAgent agent, Micosmo.SensorToolkit.RaySensor groundSensor, Micosmo.SensorToolkit.RaySensor targetCheckSensor, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **SetTargetIfBlocked()**: System.Void (Private)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **SetDiveValues(System.Single minDistanceAboveTarget, System.Single maxAccelMultiplier, System.Single speedMultiplier)**: System.Void (Public)
- **SetTargetAtStart()**: System.Void (Private)
- **HasPath()**: System.Boolean (Public)

