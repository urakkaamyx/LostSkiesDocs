# WildSkies.AI.BossaNavAgent

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _steering | Micosmo.SensorToolkit.SteeringSensor | Protected |
| _rigidbody | UnityEngine.Rigidbody | Protected |
| _animation | AgentAnimation | Protected |
| _config | AIMovementConfig | Protected |
| _formationHandler | AIFormationHandler | Protected |
| _physicsMovement | PhysicsMovementBase | Protected |
| _obstacleSensors | Micosmo.SensorToolkit.Sensor[] | Protected |
| _showGizmos | System.Boolean | Protected |
| _baseSpeed | System.Single | Protected |
| _currentMovementBehaviour | MovementBehaviour | Protected |
| _movementBehaviours | System.Collections.Generic.Dictionary`2<MovementBehaviourTypes,MovementBehaviour> | Protected |
| _events | AIEvents | Private |
| _homePositionSet | System.Boolean | Public |
| _homePosition | UnityEngine.Vector3 | Public |
| _groupService | WildSkies.Service.AIGroupService | Private |
| _groupMember | WildSkies.Entities.IAIGroupMember | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |
| SelfDestructVelocity | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ActiveMovementType | MovementBehaviourTypes | Public |
| NavigationState | WildSkies.AI.BossaNavAgent/AINavigationState | Public |
| PhysicsMovement | PhysicsMovementBase | Public |
| SteeringSensor | Micosmo.SensorToolkit.SteeringSensor | Public |
| SteeringDestination | UnityEngine.Vector3 | Public |
| Animation | AgentAnimation | Public |
| FormationHandler | AIFormationHandler | Public |
| GroupService | WildSkies.Service.AIGroupService | Public |
| GroupMember | WildSkies.Entities.IAIGroupMember | Public |
| CameraImpulseService | WildSkies.Service.CameraImpulseService | Public |
| HomePosition | UnityEngine.Vector3 | Public |
| Rigidbody | UnityEngine.Rigidbody | Public |
| BaseSpeed | System.Single | Public |
| HomePositionSet | System.Boolean | Public |
| CurrentMovementBehaviour | MovementBehaviour | Public |
| Config | AIMovementConfig | Public |

## Methods

- **get_ActiveMovementType()**: MovementBehaviourTypes (Public)
- **get_NavigationState()**: WildSkies.AI.BossaNavAgent/AINavigationState (Public)
- **get_PhysicsMovement()**: PhysicsMovementBase (Public)
- **get_SteeringSensor()**: Micosmo.SensorToolkit.SteeringSensor (Public)
- **get_SteeringDestination()**: UnityEngine.Vector3 (Public)
- **get_Animation()**: AgentAnimation (Public)
- **get_FormationHandler()**: AIFormationHandler (Public)
- **get_GroupService()**: WildSkies.Service.AIGroupService (Public)
- **get_GroupMember()**: WildSkies.Entities.IAIGroupMember (Public)
- **get_CameraImpulseService()**: WildSkies.Service.CameraImpulseService (Public)
- **get_HomePosition()**: UnityEngine.Vector3 (Public)
- **get_Rigidbody()**: UnityEngine.Rigidbody (Public)
- **get_BaseSpeed()**: System.Single (Public)
- **get_HomePositionSet()**: System.Boolean (Public)
- **get_CurrentMovementBehaviour()**: MovementBehaviour (Public)
- **get_Config()**: AIMovementConfig (Public)
- **Init(AIEvents events, Coherence.Toolkit.CoherenceSync sync, WildSkies.Service.AIGroupService groupService, WildSkies.Entities.IAIGroupMember groupMember, WildSkies.Service.CameraImpulseService cameraImpulseService, WildSkies.Service.FloatingWorldOriginService floatingWorldOriginService)**: System.Void (Public)
- **OnDestroy()**: System.Void (Public)
- **OnDisable()**: System.Void (Public)
- **SetCurrentMovementBehaviour(MovementBehaviourTypes type)**: System.Void (Public)
- **StartMovementBehaviour(System.Action`1<MovementStatus> onComplete)**: System.Void (Public)
- **EndMovementBehaviour(MovementStatus status)**: System.Void (Public)
- **ResumeMovementBehaviour()**: System.Void (Public)
- **SetMovementBehaviourTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetMovementBehaviourTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **Update()**: System.Void (Protected)
- **SetMovementSpeed(System.Single speed)**: System.Void (Public)
- **SetMovementSpeedAsMultiplier(System.Single multiplier)**: System.Void (Public)
- **SetDesiredDistance(System.Single distance)**: System.Void (Public)
- **SetSteeringActive(System.Boolean enabled)**: System.Void (Public)
- **ResetPathfinding()**: System.Void (Public)
- **SetHomePositionToCurrentPosition()**: System.Void (Public)
- **OnFloatingOriginUpdated(UnityEngine.Vector3 origin)**: System.Void (Private)
- **SelfDestruct()**: System.Void (Private)
- **.ctor()**: System.Void (Protected)

