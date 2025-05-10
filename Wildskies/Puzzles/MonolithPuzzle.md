# WildSkies.Puzzles.MonolithPuzzle

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _activateOnCompletion | UnityEngine.GameObject | Public |
| _materialSwitcher | WildSkies.Puzzles.PuzzleStateMaterialSwitch | Public |
| OnInitComplete | WildSkies.Puzzles.MonolithPuzzle/InitComplete | Private |
| OnRequestMonolithTrigger | WildSkies.Puzzles.MonolithPuzzle/MonolithTriggerRequest | Private |
| _monoliths | System.Collections.Generic.List`1<WildSkies.Puzzles.MonolithPuzzle/Monolith> | Private |
| _state | WildSkies.Puzzles.MonolithPuzzle/PuzzleState | Private |
| _showCorrectAngle | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Complete | System.Boolean | Public |
| State | WildSkies.Puzzles.MonolithPuzzle/PuzzleState | Public |

## Methods

- **add_OnInitComplete(WildSkies.Puzzles.MonolithPuzzle/InitComplete value)**: System.Void (Public)
- **remove_OnInitComplete(WildSkies.Puzzles.MonolithPuzzle/InitComplete value)**: System.Void (Public)
- **add_OnRequestMonolithTrigger(WildSkies.Puzzles.MonolithPuzzle/MonolithTriggerRequest value)**: System.Void (Public)
- **remove_OnRequestMonolithTrigger(WildSkies.Puzzles.MonolithPuzzle/MonolithTriggerRequest value)**: System.Void (Public)
- **get_Complete()**: System.Boolean (Public)
- **get_State()**: WildSkies.Puzzles.MonolithPuzzle/PuzzleState (Public)
- **BoolChanged(System.String name, System.Boolean value)**: System.Void (Public)
- **FloatChanged(System.String name, System.Single value)**: System.Void (Public)
- **SubObjectListChanged(System.String name, UnityEngine.GameObject[] subObjects, WildSkies.Puzzles.PuzzleModuleSpecificData/PuzzleSubObjectList subObjectList)**: System.Void (Public)
- **Awake()**: System.Void (Private)
- **Start()**: System.Void (Private)
- **Init()**: System.Void (Private)
- **SetNonAuthorityPuzzleState()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **RequestMonolithTrigger(System.Int32 index)**: System.Void (Public)
- **TriggerMonolith(System.Int32 index)**: System.Void (Public)
- **TriggerMonolithInternal(System.Int32 index)**: System.Void (Private)
- **UpdateMonolithRotations(System.Boolean snap)**: System.Int32 (Private)
- **AreMonolithsInSolvedOrientation()**: System.Boolean (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **ShowTargetVisualisation(System.Boolean show)**: System.Void (Private)
- **GetMonolithRotations()**: System.Collections.Generic.List`1<System.Single> (Public)
- **SetFromSerialisedData(WildSkies.Puzzles.MonolithPuzzle/PuzzleState state, System.Collections.Generic.List`1<System.Single> rotations)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

