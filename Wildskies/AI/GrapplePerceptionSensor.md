# WildSkies.AI.GrapplePerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _collisionPerception | GrappledPerceptionHandler | Private |
| _staggerAmount | System.Int32 | Private |
| _yankStaggerAmount | System.Int32 | Private |
| _estimatedOriginDistance | System.Single | Private |
| _hitRangeSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _physicsMovement | PhysicsMovementBase | Private |
| _isActive | System.Boolean | Private |
| _detectionPosition | UnityEngine.Vector3 | Private |
| _detectionLocation | UnityEngine.Vector3 | Private |
| _sensorDetectionPosition | UnityEngine.Vector3 | Private |
| _sensorHadDetection | System.Boolean | Private |

## Methods

- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **OnGrappled(UnityEngine.Vector3 hitPoint)**: System.Void (Private)
- **OnYanked(UnityEngine.Vector3 direction)**: System.Void (Private)
- **GetDetectionLocation()**: UnityEngine.Vector3 (Public)
- **.ctor()**: System.Void (Public)

