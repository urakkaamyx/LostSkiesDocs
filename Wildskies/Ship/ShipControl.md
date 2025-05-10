# WildSkies.Ship.ShipControl

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <DeltaV>k__BackingField | UnityEngine.Vector3 | Private |
| _connectedFunctionalShipParts | System.Collections.Generic.List`1<WildSkies.Ship.FunctionalShipPart> | Public |
| _vertical | System.Single | Public |
| _xAxis | System.Single | Public |
| _yAxis | System.Single | Public |
| _zAxis | System.Single | Public |
| _throttle | System.Single | Public |
| _brake | System.Boolean | Public |
| _anchorEnabled | System.Boolean | Public |
| _brakeHeld | System.Boolean | Public |
| _swayAmplitudeVsSpeed | UnityEngine.AnimationCurve | Private |
| _swayFrequencyVsSpeed | UnityEngine.AnimationCurve | Private |
| _swayFrequencyZOffset | System.Single | Private |
| _maxSwayAmplitude | System.Single | Private |
| _maxSwayFrequency | System.Single | Private |
| _maxSwaySpeed | System.Single | Private |
| _brakeDamperRampUpSpeed | System.Single | Private |
| _damperForAnchorJoint | UnityEngine.Vector3 | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| _shipBrakeJoint | UnityEngine.ConfigurableJoint | Private |
| _shipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _allSpawnPoints | PlayerSpawnPoint[] | Private |
| _autoDockingMovement | AutoDocking | Private |
| _shipForcesAudio | ShipForcesAudio | Public |
| _shipControlState | WildSkies.Ship.ShipControl/ShipControlState | Private |
| _autoDocking | System.Boolean | Private |
| _dockingDeltaV | UnityEngine.Vector3 | Private |
| _speed | System.Single | Private |
| _currentVelocity | UnityEngine.Vector3 | Private |
| _previousVelocity | UnityEngine.Vector3 | Private |
| _forceAccum | UnityEngine.Vector3 | Private |
| _previousForceAccumulation | UnityEngine.Vector3 | Private |
| _xBrakeDrive | UnityEngine.JointDrive | Private |
| _yBrakeDrive | UnityEngine.JointDrive | Private |
| _zBrakeDrive | UnityEngine.JointDrive | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Speed | System.Single | Public |
| ShipBrakeJoint | UnityEngine.ConfigurableJoint | Public |
| ShipVelocity | UnityEngine.Vector3 | Public |
| PreviousVelocity | UnityEngine.Vector3 | Public |
| DeltaV | UnityEngine.Vector3 | Public |
| AccumulatedForce | UnityEngine.Vector3 | Public |
| PreviousAccumulatedForce | UnityEngine.Vector3 | Public |
| SpawnPoints | PlayerSpawnPoint[] | Public |
| ShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Public |
| ShipRigidbody | UnityEngine.Rigidbody | Public |

## Methods

- **get_Speed()**: System.Single (Public)
- **get_ShipBrakeJoint()**: UnityEngine.ConfigurableJoint (Public)
- **get_ShipVelocity()**: UnityEngine.Vector3 (Public)
- **get_PreviousVelocity()**: UnityEngine.Vector3 (Public)
- **get_DeltaV()**: UnityEngine.Vector3 (Public)
- **set_DeltaV(UnityEngine.Vector3 value)**: System.Void (Private)
- **get_AccumulatedForce()**: UnityEngine.Vector3 (Public)
- **get_PreviousAccumulatedForce()**: UnityEngine.Vector3 (Public)
- **get_SpawnPoints()**: PlayerSpawnPoint[] (Public)
- **get_ShipController()**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **get_ShipRigidbody()**: UnityEngine.Rigidbody (Public)
- **AddFunctionalShipPart(WildSkies.Ship.FunctionalShipPart part)**: System.Void (Public)
- **RemoveFunctionalShipPart(WildSkies.Ship.FunctionalShipPart part)**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **SwayAndTurbulence()**: System.Void (Private)
- **PullIntoShipyard(UnityEngine.Vector3 dockPosition)**: System.Void (Public)
- **AddForce(UnityEngine.Vector3 force)**: System.Void (Public)
- **AddForceAtPosition(UnityEngine.Vector3 force, UnityEngine.Vector3 position)**: System.Void (Public)
- **UpdateAverageTurbulence(System.Single turbulence, System.Single maxTurbulence)**: System.Void (Public)
- **AddRelativeTorque(UnityEngine.Vector3 torque, UnityEngine.ForceMode forceMode)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<SwayAndTurbulence>g__Step|64_0(System.Single edge, System.Single x)**: System.Single (Protected)

