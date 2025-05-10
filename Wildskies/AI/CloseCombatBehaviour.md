# WildSkies.AI.CloseCombatBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _target | UnityEngine.Transform | Private |
| _agent | WildSkies.AI.BossaGroundAgent | Private |
| _closeCombatSettingsData | AIMovementConfig/CloseCombatSettingsData | Private |
| _targetDistance | System.Single | Private |
| _overshootDistance | System.Single | Private |
| _aggroTimer | System.Single | Private |
| _doAggro | System.Boolean | Private |
| _randomPointAroundPlayer | UnityEngine.Vector3 | Private |
| _physicsMovement | WildSkies.AI.PhysicsMovement | Private |
| AggroComplete | System.Action`1<System.Boolean> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| CloseCombatSettingsData | AIMovementConfig/CloseCombatSettingsData | Public |
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_CloseCombatSettingsData()**: AIMovementConfig/CloseCombatSettingsData (Public)
- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/CloseCombatSettingsData closeCombatSettingsData, AIEvents events)**: System.Void (Public)
- **get_Type()**: MovementBehaviourTypes (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **Aggro()**: System.Void (Public)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **HasPath()**: System.Boolean (Public)

