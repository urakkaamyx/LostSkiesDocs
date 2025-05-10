# WildSkies.AI.BossaGroundAgent

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _navAgentConfig | WildSkies.AI.AINavAgentConfig | Private |
| _navRepathSearchRange | System.Single | Private |
| _onPathDistance | System.Single | Private |
| _distanceForRepath | System.Single | Private |
| _newPathSearchIterations | System.Int32 | Private |
| _maxStuckTime | System.Single | Private |
| _stuckDistance | System.Single | Private |
| _stuckSpeed | System.Single | Private |
| _drawNavPaths | System.Boolean | Private |
| _showRoamRadius | System.Boolean | Private |
| cliffSensor | Micosmo.SensorToolkit.ArcSensor | Private |
| Speed | System.Single | Public |
| _currentWanderPath | System.Int32 | Private |
| _currentPath | UnityEngine.AI.NavMeshPath | Private |
| _lastTurnAnimValue | System.Single | Private |
| _virtualAgentPosition | UnityEngine.Vector3 | Private |
| _navmeshAgentPosition | UnityEngine.Vector3 | Private |
| _navFilter | UnityEngine.AI.NavMeshQueryFilter | Private |
| _homePositionCheck | UnityEngine.RaycastHit[] | Private |
| _hit | UnityEngine.AI.NavMeshHit | Private |
| _virtualNavAgentPosition | UnityEngine.Vector3 | Private |
| _navAgentForward | UnityEngine.Vector3 | Private |
| _currentTarget | UnityEngine.Vector3 | Private |
| _stuckTimer | System.Single | Private |
| _lastNavMeshPosition | UnityEngine.Vector3 | Private |
| _searchOptions | UnityEngine.Vector3[] | Private |
| _physicsGroundMovement | WildSkies.AI.PhysicsMovement | Private |
| <IsOffNavMesh>k__BackingField | System.Boolean | Private |
| <TooFarFromPath>k__BackingField | System.Boolean | Private |
| <PathPointTooHigh>k__BackingField | System.Boolean | Private |
| <NotMoving>k__BackingField | System.Boolean | Private |
| <OnStuck>k__BackingField | System.Boolean | Private |
| _tickRate | System.Single | Private |
| _tickTimer | System.Single | Private |
| _nearbyOptions | UnityEngine.Vector3[] | Private |
| _overridePosition | System.Boolean | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| CliffSensor | Micosmo.SensorToolkit.ArcSensor | Public |
| CurrentPath | UnityEngine.AI.NavMeshPath | Public |
| NavFilter | UnityEngine.AI.NavMeshQueryFilter | Public |
| NavAgentConfig | WildSkies.AI.AINavAgentConfig | Public |
| VirtualAgentPosition | UnityEngine.Vector3 | Public |
| LastNavMeshPosition | UnityEngine.Vector3 | Public |
| DirectionToTarget | UnityEngine.Vector3 | Public |
| IsOffNavMesh | System.Boolean | Public |
| TooFarFromPath | System.Boolean | Public |
| PathPointTooHigh | System.Boolean | Public |
| NotMoving | System.Boolean | Public |
| OnStuck | System.Boolean | Public |

## Methods

- **get_CliffSensor()**: Micosmo.SensorToolkit.ArcSensor (Public)
- **get_CurrentPath()**: UnityEngine.AI.NavMeshPath (Public)
- **get_NavFilter()**: UnityEngine.AI.NavMeshQueryFilter (Public)
- **get_NavAgentConfig()**: WildSkies.AI.AINavAgentConfig (Public)
- **get_VirtualAgentPosition()**: UnityEngine.Vector3 (Public)
- **get_LastNavMeshPosition()**: UnityEngine.Vector3 (Public)
- **get_DirectionToTarget()**: UnityEngine.Vector3 (Public)
- **get_IsOffNavMesh()**: System.Boolean (Public)
- **set_IsOffNavMesh(System.Boolean value)**: System.Void (Private)
- **get_TooFarFromPath()**: System.Boolean (Public)
- **set_TooFarFromPath(System.Boolean value)**: System.Void (Private)
- **get_PathPointTooHigh()**: System.Boolean (Public)
- **set_PathPointTooHigh(System.Boolean value)**: System.Void (Private)
- **get_NotMoving()**: System.Boolean (Public)
- **set_NotMoving(System.Boolean value)**: System.Void (Private)
- **get_OnStuck()**: System.Boolean (Public)
- **set_OnStuck(System.Boolean value)**: System.Void (Private)
- **Awake()**: System.Void (Private)
- **Init(AIEvents events, Coherence.Toolkit.CoherenceSync sync, WildSkies.Service.AIGroupService groupService, WildSkies.Entities.IAIGroupMember groupMember, WildSkies.Service.CameraImpulseService cameraImpulseService, WildSkies.Service.FloatingWorldOriginService floatingWorldOriginService)**: System.Void (Public)
- **IsPathing()**: System.Boolean (Public)
- **Update()**: System.Void (Protected)
- **IsAgentNavMesh()**: System.Boolean (Public)
- **IsTargetOnNavMesh(UnityEngine.Vector3 target, System.Single maxDistance)**: System.Boolean (Public)
- **GetNavMeshStatus()**: WildSkies.AI.BossaGroundAgent/NavMeshStatus (Public)
- **GetNewNavMeshPosition(UnityEngine.Vector3& newPosition)**: System.Boolean (Public)
- **GetBestNearbyPoint()**: UnityEngine.Vector3 (Public)
- **SetMovementSpeed(System.Single speed)**: System.Void (Public)
- **SetMovementSpeedAsMultiplier(System.Single multiplier)**: System.Void (Public)
- **ResetPathfinding()**: System.Void (Public)
- **SetHomePositionToCurrentPosition()**: System.Void (Public)
- **SetPath(UnityEngine.AI.NavMeshPath path)**: System.Void (Public)
- **ResetVirtualAgent()**: System.Void (Public)
- **SetVirtualAgentPosition(UnityEngine.Vector3 targetPoint, System.Boolean overridePosition)**: System.Void (Public)
- **UpdateVirtualAgentPosition(UnityEngine.Vector3 targetPoint)**: System.Void (Public)
- **SetLocoTarget(UnityEngine.Vector3 position)**: System.Void (Public)
- **ResetLoco()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

