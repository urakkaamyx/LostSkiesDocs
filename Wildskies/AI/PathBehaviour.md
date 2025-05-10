# WildSkies.AI.PathBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _currentPathPointIndex | System.Int32 | Protected |
| _homePosition | UnityEngine.Vector3 | Protected |
| _agent | WildSkies.AI.BossaGroundAgent | Protected |
| _acceptedDistanceRange | System.Single | Protected |
| _targetDistance | System.Single | Protected |
| _navFilter | UnityEngine.AI.NavMeshQueryFilter | Protected |
| _physicsMovement | WildSkies.AI.PhysicsMovement | Protected |
| _minRepathTimer | System.Single | Private |
| _isRepathing | System.Boolean | Protected |
| _repathPosition | UnityEngine.Vector3 | Protected |
| _dontResetVirtualAgentOnEnd | System.Boolean | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| OverrideTargetDistance | System.Single | Public |
| OverrideAcceptedDistanceRange | System.Single | Public |

## Methods

- **set_OverrideTargetDistance(System.Single value)**: System.Void (Public)
- **set_OverrideAcceptedDistanceRange(System.Single value)**: System.Void (Public)
- **.ctor(WildSkies.AI.BossaNavAgent agent, UnityEngine.AI.NavMeshQueryFilter navFilter, AIEvents events)**: System.Void (Public)
- **OnAgentStuck()**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **UpdatePathMovement()**: System.Void (Private)
- **ResetVirtualAgent()**: System.Void (Protected)
- **EndPath()**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **HasReachedCurrentTarget(UnityEngine.Vector3 target, System.Boolean noY)**: System.Boolean (Private)
- **HasPath()**: System.Boolean (Public)
- **ResetPathfinding()**: System.Void (Public)
- **NewPathPoint(UnityEngine.Vector3 point, System.Boolean isFinalPoint)**: System.Void (Protected)

