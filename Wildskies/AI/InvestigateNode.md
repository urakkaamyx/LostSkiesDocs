# WildSkies.AI.InvestigateNode

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Agent | WildSkies.AI.SharedNavAgent | Public |
| Entity | WildSkies.AI.SharedAIEntity | Public |
| Memory | WildSkies.AI.SharedAIMemory | Public |
| GiveUpOnPlayerSight | System.Boolean | Public |
| GiveUpOnPerceptionChange | System.Boolean | Public |
| Perception | WildSkies.AI.SharedPerception | Public |
| ShipTracking | Micosmo.SensorToolkit.BehaviorDesigner.SharedAIShipTracking | Public |
| CancelAtDistance | System.Boolean | Public |
| CancelDistance | System.Single | Public |
| ApplyTargetEveryFrame | System.Boolean | Public |
| MinRunTime | System.Single | Public |
| Target | BehaviorDesigner.Runtime.SharedGameObject | Public |
| _runTimer | System.Single | Private |
| _lastPerceptionState | WildSkies.AI.EPerceptionState | Private |

## Methods

- **OnUpdate()**: BehaviorDesigner.Runtime.Tasks.TaskStatus (Public)
- **OnStart()**: System.Void (Public)
- **ApplyTarget()**: System.Void (Private)
- **OnEnd()**: System.Void (Public)
- **OnConditionalAbort()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

