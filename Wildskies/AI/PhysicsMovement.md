# WildSkies.AI.PhysicsMovement

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <IsEnabled>k__BackingField | System.Boolean | Private |
| <DoingJump>k__BackingField | System.Boolean | Private |
| <IsGrounded>k__BackingField | System.Boolean | Private |
| <IsFalling>k__BackingField | System.Boolean | Private |
| _capsuleCollider | UnityEngine.CapsuleCollider | Private |
| _movingMaterial | UnityEngine.PhysicsMaterial | Private |
| _stationaryMaterial | UnityEngine.PhysicsMaterial | Private |
| _physicsAnimation | WildSkies.AI.PhysicsBasedAnimation | Private |
| _topSpeed | System.Single | Private |
| _maxForce | System.Single | Private |
| _useYInMovement | System.Boolean | Private |
| _stickyForce | System.Single | Private |
| _maxSpeed | System.Single | Private |
| _onlyRotateWhenGrounded | System.Boolean | Private |
| _rotationSpeedLowSpeed | System.Single | Private |
| _rotationSpeedMaxSpeed | System.Single | Private |
| _slowdownTowardsTargetCurve | UnityEngine.AnimationCurve | Private |
| _timeBeforeFalling | System.Single | Private |
| _canJump | System.Boolean | Private |
| _jumpForce | System.Single | Private |
| _overrideJumpSpeed | System.Boolean | Private |
| _jumpSpeedOverride | System.Single | Private |
| _jumpDelay | System.Single | Private |
| _followGroundNormal | System.Boolean | Private |
| _minDpToFollowGround | System.Single | Private |
| _lerpGroundNormalSpeed | System.Single | Private |
| _groundCheckDistance | System.Single | Private |
| _keepOldGroundTargetTime | System.Single | Private |
| _maxGroundDistance | System.Single | Private |
| _groundPredictionVelocityInfluence | System.Single | Private |
| _groundCheckLayerMask | UnityEngine.LayerMask | Private |
| _sidewaysFrictionAmount | System.Single | Private |
| _highFrictionColliderVerticalOffset | System.Single | Private |
| _colliderSkinWidth | System.Single | Private |
| _proportionalForce | System.Single | Private |
| _frictionTransitionSpeed | System.Single | Private |
| _targetSpeed | System.Single | Private |
| _rbTransform | UnityEngine.Transform | Private |
| _standingOnObject | UnityEngine.Rigidbody | Private |
| _movingObjectVelocity | UnityEngine.Vector3 | Private |
| _feetCollider | UnityEngine.CapsuleCollider | Private |
| _dynamicfrictionMaterial | UnityEngine.PhysicsMaterial | Private |
| _previouslyGrounded | System.Boolean | Private |
| _relativeAngularVelocity | UnityEngine.Vector3 | Private |
| _previousRotation | UnityEngine.Quaternion | Private |
| _noGroundingTimer | System.Single | Private |
| _nonGroundedTimer | System.Single | Private |
| _speed | System.Single | Private |
| _velocity | UnityEngine.Vector3 | Private |
| _movingObjectSpeed | System.Single | Private |
| _predictedGroundHit | System.Nullable`1<UnityEngine.RaycastHit> | Private |
| _groundHit | System.Nullable`1<UnityEngine.RaycastHit> | Private |
| _lastKnownGroundNormal | UnityEngine.Vector3 | Private |
| _normalizedVelocity | UnityEngine.Vector3 | Private |
| _hasJustHitGround | System.Boolean | Private |
| _airTime | System.Single | Private |
| _groundedCount | System.Single | Private |
| _groundDistance | System.Single | Private |
| _currentTopSpeed | System.Single | Private |
| _currentRotationSpeedLow | System.Single | Private |
| _currentRotationSpeedMax | System.Single | Private |
| _topSpeedMultiplier | System.Single | Private |
| _isFallingTimer | System.Single | Private |
| _isStunned | System.Boolean | Private |
| _facingTarget | UnityEngine.Transform | Private |
| _forward | UnityEngine.Vector3 | Private |
| OnJump | System.Action | Public |
| OnLand | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsEnabled | System.Boolean | Public |
| DoingJump | System.Boolean | Public |
| IsGrounded | System.Boolean | Public |
| IsFalling | System.Boolean | Public |
| Velocity | UnityEngine.Vector3 | Public |
| VelocityLocalToObject | UnityEngine.Vector3 | Public |
| RelativeAngularVelocity | UnityEngine.Vector3 | Public |
| LastGroundNormal | UnityEngine.Vector3 | Public |
| TopSpeed | System.Single | Public |
| CurrentTopSpeed | System.Single | Public |
| Speed | System.Single | Public |
| CurrentMultiplier | System.Single | Public |
| FeetCollider | UnityEngine.CapsuleCollider | Public |
| AlwaysFaceTarget | System.Boolean | Public |

## Methods

- **get_IsEnabled()**: System.Boolean (Public)
- **set_IsEnabled(System.Boolean value)**: System.Void (Private)
- **get_DoingJump()**: System.Boolean (Public)
- **set_DoingJump(System.Boolean value)**: System.Void (Private)
- **get_IsGrounded()**: System.Boolean (Public)
- **set_IsGrounded(System.Boolean value)**: System.Void (Private)
- **get_IsFalling()**: System.Boolean (Public)
- **set_IsFalling(System.Boolean value)**: System.Void (Private)
- **get_Velocity()**: UnityEngine.Vector3 (Public)
- **get_VelocityLocalToObject()**: UnityEngine.Vector3 (Public)
- **get_RelativeAngularVelocity()**: UnityEngine.Vector3 (Public)
- **get_LastGroundNormal()**: UnityEngine.Vector3 (Public)
- **get_TopSpeed()**: System.Single (Public)
- **get_CurrentTopSpeed()**: System.Single (Public)
- **get_Speed()**: System.Single (Public)
- **get_CurrentMultiplier()**: System.Single (Public)
- **get_FeetCollider()**: UnityEngine.CapsuleCollider (Public)
- **get_AlwaysFaceTarget()**: System.Boolean (Public)
- **Start()**: System.Void (Private)
- **CreateDynamicFrictionCollider()**: System.Void (Private)
- **Move(UnityEngine.Vector3 direction, System.Single targetSpeed, System.Single maxForce, System.Boolean useYInMovement)**: System.Void (Public)
- **RotateTo(UnityEngine.Vector3 direction, System.Single turnSpeedPrimary, System.Boolean ignoreY, UnityEngine.Vector3 upVector, System.Single turnSpeedSecondary)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 targetPosition, System.Boolean ignoreSlowdownTowardsTarget)**: System.Void (Public)
- **Jump(System.Boolean forceJump, System.Single forceMultiplier, System.Boolean relative)**: System.Void (Public)
- **Jump(UnityEngine.Vector3 direction, System.Boolean forceJump, System.Single forceMultiplier, System.Boolean rotateTo)**: System.Void (Public)
- **DoJump(UnityEngine.Vector3 force, System.Single delay, System.Boolean rotateTo)**: System.Collections.IEnumerator (Private)
- **FixedUpdate()**: System.Void (Private)
- **SetTopSpeed(System.Single topSpeed)**: System.Void (Public)
- **SetPhysicsParameters(AIMovementConfig/FlyingPhysicsParameters parameters)**: System.Void (Public)
- **SetReactionParameters(AIMovementConfig/PhysicsReactionParameters parameters)**: System.Void (Public)
- **ResetTopSpeed()**: System.Void (Public)
- **SetBuffSpeedMultiplier(System.Single multiplier)**: System.Void (Public)
- **SetRotationSpeed(System.Single lowSpeed, System.Single maxSpeed)**: System.Void (Public)
- **ResetRotationSpeed()**: System.Void (Public)
- **SetFaceTarget(UnityEngine.Transform target, UnityEngine.Vector3 offset)**: System.Void (Public)
- **ClearFaceTarget()**: System.Void (Public)
- **SetForward(UnityEngine.Vector3 forward)**: System.Void (Public)
- **GroundCheck(UnityEngine.Vector3 groundCheckDirection)**: System.Boolean (Private)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **SetStunned(System.Boolean disabled)**: System.Void (Public)
- **OnYanked(UnityEngine.Vector3 direction)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

