# WildSkies.AI.WanderPath

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _target | UnityEngine.Vector3 | Private |
| _origin | UnityEngine.Vector3 | Private |
| _currentWanderPath | System.Int32 | Private |
| _wanderPaths | UnityEngine.AI.NavMeshPath[] | Private |
| _wanderSettings | AIMovementConfig/WanderSettingsData | Private |
| _originalSpeed | System.Single | Private |
| _hasCalculatedPaths | System.Boolean | Private |
| _returningToPath | System.Boolean | Private |
| CountBeforeGiveUpRandomPath | System.Int32 | Private |
| PreCalcNavMeshSampleDistance | System.Single | Private |
| _returnPath | UnityEngine.AI.NavMeshPath | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |
| WanderPaths | UnityEngine.AI.NavMeshPath[] | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **get_WanderPaths()**: UnityEngine.AI.NavMeshPath[] (Public)
- **.ctor(AIMovementConfig/WanderSettingsData wanderSettings, WildSkies.AI.BossaNavAgent agent, UnityEngine.AI.NavMeshQueryFilter navFilter, AIEvents events)**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **EndPath()**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **ResumeBehaviour()**: System.Void (Public)
- **CalculateWanderPaths()**: System.Void (Private)
- **GetPath(UnityEngine.Vector3 start, UnityEngine.Vector3 end, System.Single tolerance)**: UnityEngine.AI.NavMeshPath (Private)
- **SetPath(UnityEngine.AI.NavMeshPath path)**: System.Void (Private)
- **RandomNavmeshLocation(System.Single radius, UnityEngine.Vector3 lastPosition, UnityEngine.AI.NavMeshPath& newPath)**: UnityEngine.Vector3 (Private)
- **HomePositionUpdated(UnityEngine.Vector3 position)**: System.Void (Public)

