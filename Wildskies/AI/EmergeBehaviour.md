# WildSkies.AI.EmergeBehaviour

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _emergeSettingsData | AIMovementConfig/EmergeSettingsData | Private |
| _target | UnityEngine.Vector3 | Private |
| _faceTarget | UnityEngine.Vector3 | Private |
| _groundAgent | WildSkies.AI.BossaGroundAgent | Private |
| _emergeWaitCancellationToken | System.Threading.CancellationTokenSource | Private |
| _smallRandomRange | System.Single | Private |
| _ungroundedAdjustment | System.Single | Private |
| _emergePositionAttempts | System.Int32 | Private |
| _waitAfterEmergeTimer | System.Single | Private |
| _popUpRange | System.Single | Private |
| _useRandomRotation | System.Boolean | Private |
| _waitingForEmerge | System.Boolean | Private |
| _rayHeight | System.Single | Private |
| _sameLevelDelta | System.Single | Private |
| _hits | UnityEngine.RaycastHit[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | MovementBehaviourTypes | Public |

## Methods

- **get_Type()**: MovementBehaviourTypes (Public)
- **.ctor(WildSkies.AI.BossaNavAgent agent, AIMovementConfig/EmergeSettingsData emergeSettingsData, UnityEngine.AI.NavMeshQueryFilter navFilter, AIEvents events)**: System.Void (Public)
- **OnCancel()**: System.Void (Public)
- **StartBehaviour(System.Action`1<MovementStatus> onStatusChange)**: System.Void (Public)
- **EndBehaviour(MovementStatus status)**: System.Void (Public)
- **UpdateBehaviour()**: System.Void (Public)
- **OnEmerge()**: System.Void (Private)
- **OnEndAnimation(UnityEngine.AnimatorStateInfo obj)**: System.Void (Private)
- **WaitAfterEmergeTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **TryToFindPositionOnNavMesh(UnityEngine.Vector3 target, UnityEngine.Vector3& result)**: System.Boolean (Private)
- **SetTarget(UnityEngine.Transform target)**: System.Void (Public)
- **SetTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **FaceTarget(UnityEngine.Vector3 target)**: System.Void (Public)
- **SetSmallRandomRange()**: System.Void (Public)
- **ResetPopUpRandomRange()**: System.Void (Public)
- **HasPath()**: System.Boolean (Public)

