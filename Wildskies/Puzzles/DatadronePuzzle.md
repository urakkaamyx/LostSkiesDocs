# WildSkies.Puzzles.DatadronePuzzle

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _datadroneSpeed | System.Single | Public |
| _datadroneLandingHeight | System.Single | Public |
| _datadroneLandingSpeed | System.Single | Public |
| _datadrone | WildSkies.Puzzles.Datadrone | Public |
| _datadroneAnimator | UnityEngine.Animator | Public |
| _datadroneFinalPosition | UnityEngine.GameObject | Public |
| _datadroneObstacleCollisionMask | UnityEngine.LayerMask | Private |
| _materialSwitcher | WildSkies.Puzzles.PuzzleStateMaterialSwitch | Public |
| _waypoints | System.Collections.Generic.List`1<WildSkies.Puzzles.DatadronePuzzle/DatadroneWaypoint> | Private |
| <RunLogic>k__BackingField | System.Boolean | Private |
| OnInitComplete | WildSkies.Puzzles.DatadronePuzzle/InitComplete | Private |
| _state | WildSkies.Puzzles.DatadronePuzzle/PuzzleState | Private |
| _editMode | System.Boolean | Private |
| _curWaypointIdx | System.Int32 | Private |
| _curWaypointT | System.Single | Private |
| _curMovementVelocity | UnityEngine.Vector3 | Private |
| _curRotationVelocity | UnityEngine.Quaternion | Private |
| _curDroneYOffset | System.Single | Private |
| _curDroneZTilt | System.Single | Private |
| _isColliding | System.Boolean | Private |
| _lastCollisionPoint | UnityEngine.Vector3 | Private |
| _animIdMovementSpeed | System.Int32 | Private |
| _animIdZTilt | System.Int32 | Private |
| _animIdIsLanding | System.Int32 | Private |
| _animIdHasLanded | System.Int32 | Private |
| _animIdPlayerIsNear | System.Int32 | Private |
| _animIdScanningAllowed | System.Int32 | Private |
| _animIdActive | System.Int32 | Private |
| _animIdIsColliding | System.Int32 | Private |
| _animIdResetToEditMode | System.Int32 | Private |
| OnStateChanged | System.Action`1<WildSkies.Puzzles.DatadronePuzzle/PuzzleState> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| RunLogic | System.Boolean | Public |
| Complete | System.Boolean | Public |
| State | WildSkies.Puzzles.DatadronePuzzle/PuzzleState | Public |
| CurWaypointIdx | System.Int32 | Public |
| CurWaypointT | System.Single | Public |
| CurMovementVelocity | UnityEngine.Vector3 | Public |
| CurRotationVelocity | UnityEngine.Quaternion | Public |
| CurDroneYOffset | System.Single | Public |

## Methods

- **get_RunLogic()**: System.Boolean (Public)
- **set_RunLogic(System.Boolean value)**: System.Void (Public)
- **add_OnInitComplete(WildSkies.Puzzles.DatadronePuzzle/InitComplete value)**: System.Void (Public)
- **remove_OnInitComplete(WildSkies.Puzzles.DatadronePuzzle/InitComplete value)**: System.Void (Public)
- **get_Complete()**: System.Boolean (Public)
- **get_State()**: WildSkies.Puzzles.DatadronePuzzle/PuzzleState (Public)
- **get_CurWaypointIdx()**: System.Int32 (Public)
- **get_CurWaypointT()**: System.Single (Public)
- **get_CurMovementVelocity()**: UnityEngine.Vector3 (Public)
- **get_CurRotationVelocity()**: UnityEngine.Quaternion (Public)
- **get_CurDroneYOffset()**: System.Single (Public)
- **FloatChanged(System.String name, System.Single value)**: System.Void (Public)
- **OverrideState(WildSkies.Puzzles.DatadronePuzzle/PuzzleState state)**: System.Void (Public)
- **SubObjectListChanged(System.String name, UnityEngine.GameObject[] subObjects, WildSkies.Puzzles.PuzzleModuleSpecificData/PuzzleSubObjectList subObjectList)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **Init()**: System.Void (Private)
- **InvalidateState()**: System.Void (Public)
- **FixedUpdate()**: System.Void (Private)
- **UpdateDroneAnimation()**: System.Void (Private)
- **UpdateDronePosition(System.Boolean snap)**: System.Void (Private)
- **CheckDroneCollision(UnityEngine.Vector3 curPos, UnityEngine.Vector3 destPos)**: System.Void (Private)
- **GetWaypointLinkPoints(System.Int32 waypointIdx)**: System.ValueTuple`2<UnityEngine.Vector3,UnityEngine.Vector3> (Private)
- **GetWaypointPosition(System.Int32 waypointIdx, System.Single t)**: System.ValueTuple`2<UnityEngine.Vector3,UnityEngine.Quaternion> (Private)
- **GetWaypointLength(System.Int32 waypointIdx)**: System.Single (Private)
- **ConvertDistanceToTValue(System.Int32 waypointIdx, System.Single inputDistance)**: System.Single (Private)
- **ConvertTValueToDistance(System.Int32 waypointIdx, System.Single inputT)**: System.Single (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **SetFromSerialisedData(WildSkies.Puzzles.DatadronePuzzle/PuzzleState state, System.Int32 curWaypointIdx, System.Single curWaypointT, UnityEngine.Vector3 curMovementVelocity, UnityEngine.Quaternion curRotationVelocity, System.Single curDroneYOffset)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

