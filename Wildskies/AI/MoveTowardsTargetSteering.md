# WildSkies.AI.MoveTowardsTargetSteering

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _target | UnityEngine.Vector3 | Private |
| _yPositionSetting | System.Single | Private |
| _seekSettings | AIMovementConfig/SeekSettingsData | Private |
| _investigatingSettings | AIMovementConfig/InvestigateSettingsData | Private |
| _chaseSettings | AIMovementConfig/ChaseSettingsData | Private |
| _physicsSettings | AIMovementConfig/FlyingPhysicsParameters | Private |
| _reactionSettings | AIMovementConfig/PhysicsReactionParameters | Private |
| _agent | WildSkies.AI.BossaNavAgent | Private |
| _validTargetSensor | Micosmo.SensorToolkit.RaySensor | Private |
| _investigationPoints | UnityEngine.Vector3[] | Private |
| _activeInvestigationPoint | UnityEngine.Vector3 | Private |
| _maxTopSpeed | System.Single | Private |
| _seekTimer | System.Single | Private |
| _investigationIndex | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |
| SeekTimedOut | System.Boolean | Private |
| InvestigateTimeOut | System.Boolean | Public |
| _physicsMovement | WildSkies.AI.PhysicsFlyingMovement | Private |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **get_SeekTimedOut()**: System.Boolean (Private)
- **get_InvestigateTimeOut()**: System.Boolean (Public)
- **get__physicsMovement()**: WildSkies.AI.PhysicsFlyingMovement (Private)
- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/SeekSettingsData seekSettings, AIMovementConfig/InvestigateSettingsData investigatingSettings, AIMovementConfig/ChaseSettingsData chaseSettings, AIMovementConfig/FlyingPhysicsParameters physicsSettings, AIMovementConfig/PhysicsReactionParameters reactionSettings, Micosmo.SensorToolkit.Sensor sensor, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **UpdateChase()**: System.Void (Private)
- **UpdateSeek()**: System.Void (Private)
- **UpdateInvestigate()**: System.Void (Private)
- **OnDetected(UnityEngine.GameObject obj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Protected)
- **OnLostDetection(UnityEngine.GameObject obj, Micosmo.SensorToolkit.Sensor sensor)**: System.Void (Protected)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **HasPath()**: System.Boolean (Public)
- **SetPositionSettings(System.Single xPos, System.Single yPos, System.Single zPos)**: System.Void (Public)
- **SetNavigationState(WildSkies.AI.BossaNavAgent/AINavigationState state)**: System.Void (Public)
- **SetTargetDestination()**: System.Void (Private)
- **SetTargetDestination(UnityEngine.Vector3 target)**: System.Void (Private)
- **HasReachedDestination()**: System.Boolean (Private)

