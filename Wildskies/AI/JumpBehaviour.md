# WildSkies.AI.JumpBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _agent | WildSkies.AI.BossaGroundAgent | Private |
| _physicsMovement | WildSkies.AI.PhysicsMovement | Private |
| _jumpSettings | AIMovementConfig/JumpSettingsData | Private |
| _hasJumped | System.Boolean | Private |
| _jumpWithTarget | System.Boolean | Private |
| _jumpTarget | UnityEngine.Vector3 | Private |
| OnLanded | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/JumpSettingsData jumpSettings, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **HasPath()**: System.Boolean (Public)

