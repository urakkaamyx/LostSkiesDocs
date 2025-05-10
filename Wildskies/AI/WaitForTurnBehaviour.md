# WildSkies.AI.WaitForTurnBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _target | UnityEngine.Transform | Private |
| _agent | WildSkies.AI.BossaGroundAgent | Private |
| _waitForTurnSettingsData | AIMovementConfig/WaitForTurnSettingsData | Private |
| _navFilter | UnityEngine.AI.NavMeshQueryFilter | Private |
| _updateCancellationToken | System.Threading.CancellationTokenSource | Private |
| _updateTimer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **.ctor(WildSkies.AI.BossaNavAgent agent, UnityEngine.AI.NavMeshQueryFilter navFilter, AIMovementConfig/WaitForTurnSettingsData waitForTurnSettingsData, AIEvents events)**: System.Void (Public)
- **get_Type()**: MovementBehaviourTypes (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **OnCancel()**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **HasPath()**: System.Boolean (Public)
- **TryToFindPositionOnNavMesh(UnityEngine.Vector3 target, UnityEngine.Vector3& result)**: System.Boolean (Private)
- **UpdateNavPositionCheckTask()**: Cysharp.Threading.Tasks.UniTask (Private)

