# WildSkies.AI.ChaseNode

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Agent | WildSkies.AI.SharedNavAgent | Public |
| Target | BehaviorDesigner.Runtime.SharedGameObject | Public |
| TargetDistance | BehaviorDesigner.Runtime.SharedFloat | Public |
| Sensor | Micosmo.SensorToolkit.BehaviorDesigner.SharedSensor | Public |
| Perception | WildSkies.AI.SharedPerception | Public |
| Memory | WildSkies.AI.SharedAIMemory | Public |
| CancelIfNotThisState | WildSkies.AI.EPerceptionState | Public |
| IgnoreY | System.Boolean | Public |
| TargetUpdateTickRate | System.Single | Public |
| GiveUpOnDistance | System.Boolean | Public |
| GiveUpDistance | System.Single | Public |
| _sensorHasDetection | System.Boolean | Private |
| _tickTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| _useSensor | System.Boolean | Private |
| _usePerception | System.Boolean | Private |

## Methods

- **get__useSensor()**: System.Boolean (Private)
- **get__usePerception()**: System.Boolean (Private)
- **OnUpdate()**: BehaviorDesigner.Runtime.Tasks.TaskStatus (Public)
- **OnStart()**: System.Void (Public)
- **OnTargetInRange(UnityEngine.GameObject arg0, Micosmo.SensorToolkit.Sensor arg1)**: System.Void (Private)
- **OnEnd()**: System.Void (Public)
- **OnConditionalAbort()**: System.Void (Public)
- **OnReset()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

