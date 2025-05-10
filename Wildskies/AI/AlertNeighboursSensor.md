# WildSkies.AI.AlertNeighboursSensor

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _entity | WildSkies.Entities.AIEntity | Private |
| _memoryHandler | AIMemoryHandler | Private |
| _cooldownCancellationToken | System.Threading.CancellationTokenSource | Private |
| _cooldownTimer | System.Single | Private |
| _hasBeenAlerted | System.Boolean | Private |
| _isEnabled | System.Boolean | Private |
| _detectionLocation | UnityEngine.Vector3 | Private |
| _lastPerceptionState | WildSkies.AI.EPerceptionState | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DetectedObjs | System.Collections.Generic.List`1<UnityEngine.GameObject> | Public |

## Methods

- **get_DetectedObjs()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **SetSensorActive(System.Boolean enabled)**: System.Void (Public)
- **OnDetected(UnityEngine.GameObject friend, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Private)
- **OnStateChanged(WildSkies.AI.EPerceptionState state)**: System.Void (Public)
- **OnReceiveAlert(UnityEngine.Vector3 location)**: System.Void (Public)
- **Alert()**: System.Void (Private)
- **ResetSensor()**: System.Void (Public)
- **SetUp()**: System.Void (Protected)
- **CooldownTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **GetDetectionLocation()**: UnityEngine.Vector3 (Public)
- **CheckAlly(WildSkies.AI.PerceptionData/AIAlly ally)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

