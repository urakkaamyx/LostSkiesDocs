# WildSkies.AI.VisualPerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _detectedPlayerCache | WildSkies.AI.VisualPerceptionSensor/DetectedPlayerCache | Private |
| _hadDetection | System.Boolean | Private |
| _visionSensor | Micosmo.SensorToolkit.Sensor | Protected |
| _rangeSensor | Micosmo.SensorToolkit.RangeSensor | Protected |
| _perceptionScore | WildSkies.AI.PerceptionSensor/PerceptionScoreData | Protected |
| _targets | System.Collections.Generic.List`1<Micosmo.SensorToolkit.LOSTargets> | Private |
| _tokenables | System.Collections.Generic.List`1<WildSkies.AI.ITokenable> | Private |
| _detectedPlayerObjects | System.Collections.Generic.List`1<UnityEngine.Transform> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DetectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |

## Methods

- **get_DetectedObjs()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **SetUp()**: System.Void (Protected)
- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **SetSensorRef()**: System.Void (Protected)
- **RegisterSensor()**: System.Void (Private)
- **DeregisterSensor()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnPulsed()**: System.Void (Private)
- **OnExit(UnityEngine.GameObject detectionObj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **ResetSensor()**: System.Void (Public)
- **UpdateNearestDetection()**: System.Void (Private)
- **GetDetectedPlayerState()**: PlayerSync/PlayerState (Public)
- **GetDetectedPlayerObjects()**: System.Collections.Generic.List`1<UnityEngine.Transform> (Public)
- **GetConfidence()**: System.Single (Protected)
- **GetDetectedObject()**: UnityEngine.GameObject (Public)
- **GetDetectedPlayerObject()**: UnityEngine.GameObject (Public)
- **GetDetectedPlayerSync()**: PlayerSync (Public)
- **GetNearestDetectedPlayerObj()**: UnityEngine.GameObject (Private)
- **.ctor()**: System.Void (Protected)

