# WildSkies.AI.VisualObjectPerceptionSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _hadDetection | System.Boolean | Private |
| _visionSensor | Micosmo.SensorToolkit.Sensor | Protected |
| _rangeSensor | Micosmo.SensorToolkit.RangeSensor | Protected |
| _perceptionScore | WildSkies.AI.PerceptionSensor/PerceptionScoreData | Protected |
| _targets | System.Collections.Generic.List`1<Micosmo.SensorToolkit.LOSTargets> | Private |
| _tokenables | System.Collections.Generic.List`1<WildSkies.AI.ITokenable> | Private |

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
- **GetConfidence()**: System.Single (Protected)
- **GetDetectedTokenables()**: System.Collections.Generic.List`1<WildSkies.AI.ITokenable> (Public)
- **.ctor()**: System.Void (Public)

