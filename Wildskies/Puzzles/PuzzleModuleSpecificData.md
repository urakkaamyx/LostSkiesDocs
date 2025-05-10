# WildSkies.Puzzles.PuzzleModuleSpecificData

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| OnSubObjectAdded | WildSkies.Puzzles.PuzzleModuleSpecificData/SubObjectAdded | Public |
| OnBeforeInstantiate | System.Action`2<System.String,UnityEngine.GameObject> | Private |
| _data | WildSkies.Puzzles.PuzzleModuleSpecificData/Data | Public |
| _subObjectHandlers | WildSkies.Puzzles.IPuzzleSubObjectHandler[] | Private |
| _subObjectWithParamsHandlers | WildSkies.Puzzles.IPuzzleSubObjectWithParamsHandler[] | Private |
| _boolHandlers | WildSkies.Puzzles.IPuzzleBoolHandler[] | Private |
| _selectionListHandlers | WildSkies.Puzzles.IPuzzleSelectionListHandler[] | Private |
| _floatHandlers | WildSkies.Puzzles.IPuzzleFloatHandler[] | Private |
| _populatedHandlers | System.Boolean | Private |

## Methods

- **add_OnBeforeInstantiate(System.Action`2<System.String,UnityEngine.GameObject> value)**: System.Void (Public)
- **remove_OnBeforeInstantiate(System.Action`2<System.String,UnityEngine.GameObject> value)**: System.Void (Public)
- **Awake()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **SetSubObject(System.String name, System.Int32 index, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot)**: System.Void (Public)
- **AddSubObject(System.String name, UnityEngine.Vector3 pos, UnityEngine.Vector3 rot)**: System.Int32 (Public)
- **RemoveSubObject(System.String name, System.Int32 index, System.Boolean immediate)**: System.Void (Public)
- **RemoveSubObjectLinks(WildSkies.Puzzles.PuzzleModuleSpecificData/PuzzleSubObjectList value, System.Int32 index)**: System.Void (Private)
- **SetBoolValue(System.String name, System.Boolean value)**: System.Void (Public)
- **SetSelectionListValue(System.String selectionListName, System.Int32 value)**: System.Void (Public)
- **SetFloatValue(System.String name, System.Single value)**: System.Void (Public)
- **GetMeta()**: System.String (Public)
- **SetMeta(System.String meta)**: System.Void (Public)
- **ValidateData()**: System.Void (Private)
- **CheckHandlers()**: System.Void (Private)
- **ValidateSubObjects(System.Boolean updateTransforms)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

