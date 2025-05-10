# WildSkies.AI.WanderSteering

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _wanderingSettings | AIMovementConfig/WanderSettingsData | Private |
| _agent | WildSkies.AI.BossaNavAgent | Private |
| _physicsSettings | AIMovementConfig/FlyingPhysicsParameters | Private |
| _reactionSettings | AIMovementConfig/PhysicsReactionParameters | Private |
| _startIndex | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(Micosmo.SensorToolkit.RaySensor checkTargetSensor, AIMovementConfig/WanderSettingsData wanderingSettings, AIMovementConfig/FlyingPhysicsParameters physicsSettings, AIMovementConfig/PhysicsReactionParameters reactionSettings, WildSkies.AI.BossaNavAgent agent, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **FloatingOriginUpdated(UnityEngine.Vector3 origin)**: System.Void (Public)
- **ResumeBehaviour()**: System.Void (Public)

