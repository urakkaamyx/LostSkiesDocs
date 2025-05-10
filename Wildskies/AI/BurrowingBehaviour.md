# WildSkies.AI.BurrowingBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _burrowSettingsData | AIMovementConfig/BurrowSettingsData | Private |
| _burrowTimer | System.Single | Private |
| _burrowCancellationToken | System.Threading.CancellationTokenSource | Private |
| _groundAgent | WildSkies.AI.BossaGroundAgent | Private |
| _navFilter | UnityEngine.AI.NavMeshQueryFilter | Private |
| _physicsMovement | WildSkies.AI.PhysicsMovement | Private |
| OnComplete | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/BurrowSettingsData burrowSettingsData, AIEvents events)**: System.Void (Public)
- **OnCancel()**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **BurrowingTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **HasPath()**: System.Boolean (Public)

