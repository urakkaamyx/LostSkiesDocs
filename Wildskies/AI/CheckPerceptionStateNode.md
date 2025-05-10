# WildSkies.AI.CheckPerceptionStateNode

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| PerceptionStateMachine | WildSkies.AI.SharedPerception | Public |
| Memory | WildSkies.AI.SharedAIMemory | Public |
| StatesToCheck | WildSkies.AI.EPerceptionState[] | Public |
| MustHaveKnownTarget | System.Boolean | Public |
| RandomiseKnownTarget | System.Boolean | Public |
| TargetType | AITargetType | Public |
| UseCheckLevel | System.Boolean | Public |
| CheckAtLevel | System.Single | Public |
| ReturnTarget | BehaviorDesigner.Runtime.SharedGameObject | Public |

## Methods

- **OnUpdate()**: BehaviorDesigner.Runtime.Tasks.TaskStatus (Public)
- **OnReset()**: System.Void (Public)
- **StatesToCheckContains(WildSkies.AI.EPerceptionState state)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

