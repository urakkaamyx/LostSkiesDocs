# WildSkies.Network.DeadReckoning

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| DeadReckoningPacket | System.Byte[] | Public |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _stayBehindTime | System.Single | Private |
| _updateRateForLocalPoints | System.Single | Private |
| _extrapolationTime | System.Double | Private |
| _customVelocityTimeWhenAuthorityLost | System.Single | Private |
| _doLocalSmoothing | System.Boolean | Private |
| _distanceToTeleportPlayer | System.Single | Private |
| _localSmoothingSpeed | System.Single | Private |
| _customVelocityProvider | Bossa.Dynamika.CustomVelocityProvider | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| _constructedShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _predictedPosition | Coherence.Common.Vector3d | Private |
| _predictedRotation | UnityEngine.Quaternion | Private |
| _predictedVelocity | UnityEngine.Vector3 | Private |
| _extrapolationPoint | WildSkies.Network.ControlPoint | Private |
| _localAuthControlPoints | System.Collections.Generic.List`1<WildSkies.Network.ControlPoint> | Private |
| _controlPoints | System.Collections.Generic.List`1<WildSkies.Network.ControlPoint> | Private |
| _hasAuthority | System.Boolean | Private |
| _nextUpdateTime | System.Double | Private |
| _packetIgnoreCount | System.Int32 | Private |
| _actualLocalSmoothing | System.Single | Private |
| _customVelocityTime | System.Single | Private |
| _firstControlPointReceived | System.Boolean | Private |
| _teleportPlayerIfOnShipNextUpdate | System.Boolean | Private |
| _debugText | System.String | Private |

## Methods

- **Awake()**: System.Void (Private)
- **AuthorityGained()**: System.Void (Private)
- **AuthorityLost()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **ManageControlPoints()**: System.Void (Private)
- **Extrapolate(System.Double now, WildSkies.Network.ControlPoint extrapolateFrom, Coherence.Common.Vector3d& predictedPosition, UnityEngine.Quaternion& predictedRotation)**: System.Void (Public)
- **DeadReckoningPacketReceived(System.Object sampleData, System.Boolean stopped, System.Int64 simulationFrame)**: System.Void (Private)
- **AddControlPoint(WildSkies.Network.ControlPoint newControlPoint)**: System.Void (Private)
- **GetCurrentControlPoint(System.Double currentTime)**: WildSkies.Network.ControlPoint (Private)
- **LogDeadReckoning()**: System.String (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

