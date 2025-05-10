# WildSkies.Puzzles.PuzzleModule

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| SyncedValueChanged | System.EventHandler | Private |
| Inputs | System.Collections.Generic.List`1<WildSkies.Puzzles.PuzzleModule> | Public |
| Outputs | System.Collections.Generic.List`1<WildSkies.Puzzles.PuzzleModule> | Public |
| <Id>k__BackingField | System.Guid | Private |
| <InputFlip>k__BackingField | System.Boolean | Private |
| <Complete>k__BackingField | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Id | System.Guid | Public |
| InputFlip | System.Boolean | Public |
| Complete | System.Boolean | Public |
| OutputsAllowed | System.Boolean | Public |
| Active | System.Boolean | Public |

## Methods

- **add_SyncedValueChanged(System.EventHandler value)**: System.Void (Public)
- **remove_SyncedValueChanged(System.EventHandler value)**: System.Void (Public)
- **get_Id()**: System.Guid (Public)
- **set_Id(System.Guid value)**: System.Void (Public)
- **get_InputFlip()**: System.Boolean (Public)
- **set_InputFlip(System.Boolean value)**: System.Void (Public)
- **get_Complete()**: System.Boolean (Public)
- **set_Complete(System.Boolean value)**: System.Void (Public)
- **get_OutputsAllowed()**: System.Boolean (Public)
- **get_Active()**: System.Boolean (Public)
- **AllInputsCompleted()**: System.Boolean (Private)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **OnSyncedValueChanged()**: System.Void (Protected)
- **.ctor()**: System.Void (Protected)

