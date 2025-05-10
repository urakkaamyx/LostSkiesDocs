# WildSkies.AI.PhysicsFlyingMovement

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _entity | WildSkies.Entities.AIEntity | Private |
| _physicsAnimation | WildSkies.AI.PhysicsMantaAnimation | Private |
| _movementVFX | WildSkies.AI.AIMovementVFX | Private |
| _agentHeadTargeting | WildSkies.AI.AgentHeadTargeting | Private |
| _health | WildSkies.Entities.Health.EntityHealth | Private |
| _wallDetectionLayerMask | UnityEngine.LayerMask | Private |
| _maxForwardSpeed | System.Single | Private |
| _maxStrafeSpeed | System.Single | Private |
| _maxTurnSpeedDegrees | System.Single | Private |
| _maxAccel | System.Single | Private |
| _maxAngularAccelDegrees | System.Single | Private |
| _maxSpeedMultiplier | System.Single | Private |
| _wallCheckRayLength | System.Single | Private |
| _wallCheckRayOffset | System.Single | Private |
| _showDebugRays | System.Boolean | Private |
| _healthyPhysicsParameters | AIMovementConfig/FlyingPhysicsParameters | Private |
| _reactionParameters | AIMovementConfig/PhysicsReactionParameters | Private |
| _maxAngularVelocity | System.Single | Private |
| _shipTracking | AIShipTracking | Private |
| _topCatchUpSpeedMultiplier | System.Single | Private |
| <IsEnabled>k__BackingField | System.Boolean | Private |
| _targetPhysicsParameters | AIMovementConfig/FlyingPhysicsParameters | Private |
| _currentPhysicsParameters | AIMovementConfig/FlyingPhysicsParameters | Private |
| _targetTransform | UnityEngine.Transform | Private |
| _targetDirection | UnityEngine.Vector3 | Private |
| _velocity | UnityEngine.Vector3 | Private |
| _faceTargetOffset | UnityEngine.Vector3 | Private |
| _constrainMotion | System.Boolean | Private |
| _currentSpeedMultiplier | System.Single | Private |
| _buffSpeedMultiplier | System.Single | Private |
| _defaultRotationSpeed | System.Single | Private |
| _wallDetectionSpeedMultiplier | System.Single | Private |
| _ignoreSlowdownTowardsTarget | System.Boolean | Private |
| _maxWallCheckSpeedMultiplier | System.Single | Private |
| _direction | UnityEngine.Vector3 | Private |
| _shipTrackingVector | UnityEngine.Vector3 | Private |
| _dotToShip | System.Single | Private |
| _distToShip | System.Single | Private |
| _isStunned | System.Boolean | Private |
| _sinBobAmount | System.Single | Private |
| _sinBobSpeed | System.Single | Private |
| _sinBobIntegral | System.Single | Private |
| _sinBobAmountMin | System.Single | Private |
| _sinBobAmountMax | System.Single | Private |
| _sinBobSpeedMin | System.Single | Private |
| _sinBobSpeedMax | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsEnabled | System.Boolean | Public |
| Velocity | UnityEngine.Vector3 | Public |
| ShipTracking | AIShipTracking | Public |
| CurrentMultiplier | System.Single | Public |
| _rbTransform | UnityEngine.Transform | Private |
| _attenMaxSpeed | System.Single | Private |
| _attenMaxStrafeSpeed | System.Single | Private |
| _attenMaxTurnSpeed | System.Single | Private |
| TopSpeed | System.Single | Public |
| CurrentTopSpeed | System.Single | Public |
| Speed | System.Single | Public |
| DotToShip | System.Single | Public |
| DistToShip | System.Single | Public |

## Methods

- **get_IsEnabled()**: System.Boolean (Public)
- **set_IsEnabled(System.Boolean value)**: System.Void (Private)
- **get_Velocity()**: UnityEngine.Vector3 (Public)
- **get_ShipTracking()**: AIShipTracking (Public)
- **get_CurrentMultiplier()**: System.Single (Public)
- **get__rbTransform()**: UnityEngine.Transform (Private)
- **get__attenMaxSpeed()**: System.Single (Private)
- **get__attenMaxStrafeSpeed()**: System.Single (Private)
- **get__attenMaxTurnSpeed()**: System.Single (Private)
- **get_TopSpeed()**: System.Single (Public)
- **get_CurrentTopSpeed()**: System.Single (Public)
- **get_Speed()**: System.Single (Public)
- **get_DotToShip()**: System.Single (Public)
- **get_DistToShip()**: System.Single (Public)
- **Awake()**: System.Void (Private)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnDamageAtPoint(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 position, System.Single newNormalizedHealth)**: System.Void (Private)
- **StunEnded()**: System.Void (Private)
- **Stunned()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **OnYanked(UnityEngine.Vector3 direction)**: System.Void (Public)
- **FlyableSeekWithForces(UnityEngine.Rigidbody rb, UnityEngine.Vector3 tpos, UnityEngine.Vector3 tdir, UnityEngine.Vector3 tup)**: System.Void (Private)
- **AccelerateForces(UnityEngine.Rigidbody rb, UnityEngine.Vector3 angularAccel, UnityEngine.Vector3 transAccel)**: System.Void (Private)
- **SetTopSpeed(System.Single topSpeed)**: System.Void (Public)
- **SetRotationSpeed(System.Single lowSpeed, System.Single maxSpeed)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 position, System.Boolean ignoreSlowdownTowardsTarget)**: System.Void (Public)
- **ResetRotationSpeed()**: System.Void (Public)
- **ResetTopSpeed()**: System.Void (Public)
- **SetBuffSpeedMultiplier(System.Single multiplier)**: System.Void (Public)
- **SetFaceTarget(UnityEngine.Vector3 direction)**: System.Void (Public)
- **SetFaceTarget(UnityEngine.Transform target, UnityEngine.Vector3 offset)**: System.Void (Public)
- **ClearFaceTarget()**: System.Void (Public)
- **SetForward(UnityEngine.Vector3 forward)**: System.Void (Public)
- **GetFaceTarget(UnityEngine.Transform forTransform, UnityEngine.Vector3 seekPos)**: UnityEngine.Vector3 (Private)
- **SetPhysicsParameters(AIMovementConfig/FlyingPhysicsParameters parameters)**: System.Void (Public)
- **SetReactionParameters(AIMovementConfig/PhysicsReactionParameters reactionSettings)**: System.Void (Public)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

