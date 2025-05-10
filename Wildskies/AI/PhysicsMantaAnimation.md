# WildSkies.AI.PhysicsMantaAnimation

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _animator | UnityEngine.Animator | Private |
| _physicsMovement | WildSkies.AI.PhysicsFlyingMovement | Private |
| _currentSpeed | System.Single | Private |
| _turnSpeed | System.Single | Private |
| _verticalSpeed | System.Single | Private |
| _flapSpeed | System.Single | Private |
| _isInStrafe | System.Boolean | Private |
| _flap | System.Boolean | Private |
| _previousRotation | UnityEngine.Quaternion | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentSpeed | System.Single | Public |
| FlapSpeed | System.Single | Public |
| IsFlapping | System.Boolean | Public |
| IsStrafing | System.Boolean | Public |

## Methods

- **get_CurrentSpeed()**: System.Single (Public)
- **get_FlapSpeed()**: System.Single (Public)
- **get_IsFlapping()**: System.Boolean (Public)
- **get_IsStrafing()**: System.Boolean (Public)
- **OnUpdate()**: System.Void (Public)
- **CalcAngularVelocity()**: System.Single (Private)
- **Strafe(System.Boolean isInStrafe)**: System.Void (Public)
- **Flap()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

