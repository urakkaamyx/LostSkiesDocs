# WildSkies.AI.OrbitTarget

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _orbitSettings | AIMovementConfig/OrbitSettingsData | Private |
| _targetTransform | UnityEngine.Transform | Private |
| _targetPosition | UnityEngine.Vector3 | Private |
| _orbitOrigin | UnityEngine.Vector3 | Private |
| _dotToIgnoreBehind | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(AIMovementConfig/OrbitSettingsData orbitSettings, Micosmo.SensorToolkit.RaySensor validTargetSensor, WildSkies.AI.BossaNavAgent agent, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)

