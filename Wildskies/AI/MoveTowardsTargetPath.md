# WildSkies.AI.MoveTowardsTargetPath

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _seekSettingsData | AIMovementConfig/SeekSettingsData | Private |
| _fleeSettingsData | AIMovementConfig/FleeSettingsData | Private |
| _chaseSettingsData | AIMovementConfig/ChaseSettingsData | Private |
| _investigateSettingsData | AIMovementConfig/InvestigateSettingsData | Private |
| _refreshTimer | System.Single | Private |
| _hasFreshJumpPoint | System.Boolean | Private |
| _jumpPoint | UnityEngine.Vector3 | Private |
| _fleeLogicTimer | System.Single | Private |
| _maxNavMeshCheckAttempts | System.Int32 | Private |
| _cliffSensorPulseInterval | System.Single | Private |
| _cliffEdgeSpeed | System.Single | Private |
| _fleeAngleIncreaseAmount | System.Single | Private |
| _jumpAtPathSegmentDivision | System.Single | Private |
| _investigateTargetRange | System.Single | Private |
| _randomJumpChance | System.Int32 | Private |
| _fleeNavFilter | UnityEngine.AI.NavMeshQueryFilter | Private |
| _fleeTargetOptions | UnityEngine.Vector3[] | Private |
| _samplePath | UnityEngine.AI.NavMeshPath | Private |
| _bestPaths | UnityEngine.AI.NavMeshPath[] | Private |
| LargeNavMeshAgentID | System.String | Private |
| _bestPathIndex | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(AIMovementConfig/SeekSettingsData seekSettingsData, AIMovementConfig/FleeSettingsData fleeSettingsData, AIMovementConfig/ChaseSettingsData chaseSettingsData, AIMovementConfig/InvestigateSettingsData investigateSettingsData, WildSkies.AI.BossaNavAgent agent, UnityEngine.AI.NavMeshQueryFilter navFilter, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **FleeJumpCheck()**: System.Void (Private)
- **EndPath()**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **RunCurrentPath()**: System.Void (Private)
- **NewPathPoint(UnityEngine.Vector3 point, System.Boolean isFinalPoint)**: System.Void (Protected)
- **TryToFindPositionOnNavMesh(UnityEngine.Vector3 target)**: System.Boolean (Private)
- **TryToFindFleePositionOnNavMesh(UnityEngine.GameObject target)**: System.Boolean (Private)
- **GetFleeTarget(UnityEngine.GameObject fleeObject, System.Int32 attempt)**: UnityEngine.Vector3 (Private)
- **GetRandomPositionInCone(UnityEngine.GameObject fleeObject, System.Single distance, System.Single minAngle, System.Single maxAngle, System.Single dir)**: UnityEngine.Vector3 (Private)

