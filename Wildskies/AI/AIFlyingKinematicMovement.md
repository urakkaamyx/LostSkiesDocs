# WildSkies.AI.AIFlyingKinematicMovement

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _steeringSensor | Micosmo.SensorToolkit.SteeringSensor | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| _physicsrootMotion | PhysicsRootMotion | Private |
| _speed | System.Single | Private |
| _defaultPathRadius | System.Single | Private |
| _pathfindingMinRadius | System.Single | Private |
| _pathfindingMaxRadius | System.Single | Private |
| _rotationSpeed | System.Single | Private |
| _altitudeCheckThreshold | System.Single | Private |
| _path | System.Collections.Generic.List`1<HeraldMovementController/Path> | Private |
| _previousPathPositions | System.Collections.Generic.List`1<UnityEngine.Vector3> | Private |
| _targetYawAmount | System.Single | Private |
| _yawChange | System.Single | Private |
| _lastTargetPosition | UnityEngine.Vector3 | Private |
| _idlePosition | UnityEngine.Vector3 | Private |
| _referencePosition | UnityEngine.Vector3 | Private |
| _closestEdgePoint | UnityEngine.Vector3 | Private |
| _pathfindingTarget | UnityEngine.Vector3 | Private |
| _target | UnityEngine.Vector3 | Private |
| _targetAltitude | System.Single | Private |
| _currentPathIndex | System.Int32 | Private |
| _pathSearchCount | System.Int32 | Private |
| _skyMapService | SkyMapService | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| PhysicsRootMotion | PhysicsRootMotion | Public |

## Methods

- **get_PhysicsRootMotion()**: PhysicsRootMotion (Public)
- **Init(UnityEngine.Vector3 origin, UnityEngine.Vector3 referencePoint)**: System.Void (Public)
- **FindPath(System.Int32 startPathIndex)**: System.Void (Public)
- **OriginShifted(UnityEngine.Vector3 pos)**: System.Void (Public)
- **UpdateMovement()**: System.Void (Public)
- **UpdatePath()**: System.Void (Public)
- **ClearPath(System.Int32 startPathIndex)**: System.Void (Public)
- **SetTargetAltitude(System.Single altitude)**: System.Void (Public)
- **ResetTargetAltitude()**: System.Void (Public)
- **IsAtTargetAltitude()**: System.Boolean (Public)
- **AddPath(UnityEngine.Vector3 position)**: System.Void (Private)
- **FindRandomPosition()**: UnityEngine.Vector3 (Private)
- **SavePreviousPath()**: System.Void (Private)
- **SendToTargetPosition(System.Int32 startPathIndex)**: System.Void (Private)
- **FindClosestEdgePointInWorld()**: System.Void (Private)
- **RetryPathfindingIfNecessary(System.Collections.Generic.List`1<UnityEngine.Vector3> newPath, System.Int32 startPathIndex)**: System.Boolean (Private)
- **FindPathToTarget(UnityEngine.Vector3 target)**: System.Collections.Generic.List`1<UnityEngine.Vector3> (Private)
- **OnDrawGizmosSelected()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

