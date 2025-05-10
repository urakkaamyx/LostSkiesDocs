# WildSkies.AI.TurnToFaceTarget

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Agent | WildSkies.AI.SharedNavAgent | Public |
| Target | BehaviorDesigner.Runtime.SharedGameObject | Public |
| RotationEpsilon | BehaviorDesigner.Runtime.SharedFloat | Public |
| IgnoreY | BehaviorDesigner.Runtime.SharedBool | Public |
| TurnSpeed | BehaviorDesigner.Runtime.SharedFloat | Public |
| UseRigidBody | BehaviorDesigner.Runtime.SharedBool | Public |
| CancelIfLostDetection | System.Boolean | Public |
| Perception | WildSkies.AI.SharedPerception | Public |
| UseTimeout | BehaviorDesigner.Runtime.SharedBool | Public |
| Timeout | BehaviorDesigner.Runtime.SharedFloat | Public |
| SkipIfNoTarget | System.Boolean | Public |
| _facingTarget | System.Boolean | Private |
| _movementBehaviour | WildSkies.AI.FaceTarget | Private |
| _timer | System.Single | Private |

## Methods

- **OnStart()**: System.Void (Public)
- **OnUpdate()**: BehaviorDesigner.Runtime.Tasks.TaskStatus (Public)
- **OnReset()**: System.Void (Public)
- **OnEnd()**: System.Void (Public)
- **OnFacingTarget()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

