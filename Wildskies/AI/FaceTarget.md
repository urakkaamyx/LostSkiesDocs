# WildSkies.AI.FaceTarget

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _data | AIMovementConfig/TurnToFaceTargetSettingsData | Private |
| FacingTarget | System.Action | Public |
| _rotationEpsilon | System.Single | Private |
| _maxLookAtRotationDelta | System.Single | Private |
| _ignoreY | System.Boolean | Private |
| _target | UnityEngine.Transform | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| _usePhysicsMovement | System.Boolean | Private |
| _agent | WildSkies.AI.BossaNavAgent | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/TurnToFaceTargetSettingsData data, AIEvents events)**: System.Void (Public)
- **get_Type()**: MovementBehaviourTypes (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **SetRotationValues(UnityEngine.Transform target, System.Single rotationEpsilon, System.Single maxLookAtRotation, System.Boolean ignoreY, System.Boolean useRigidBody, UnityEngine.Rigidbody rigidbody)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **GetTargetRotation()**: UnityEngine.Quaternion (Private)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **HasPath()**: System.Boolean (Public)

