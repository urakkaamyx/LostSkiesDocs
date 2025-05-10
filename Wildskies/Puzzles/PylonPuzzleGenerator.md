# WildSkies.Puzzles.PylonPuzzleGenerator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| OnNodeStateChanged | WildSkies.Puzzles.PylonPuzzleGenerator/NodeStateChanged | Private |
| OnLocalRopeAttached | WildSkies.Puzzles.PylonPuzzleGenerator/LocalRopeAttached | Private |
| OnLocalRopeCleared | WildSkies.Puzzles.PylonPuzzleGenerator/LocalRopeCleared | Private |
| OnPuzzleComplete | WildSkies.Puzzles.PylonPuzzleGenerator/PuzzleComplete | Private |
| Complete | System.Int32 | Private |
| PylonListName | System.String | Private |
| DummyPylonListName | System.String | Private |
| _emissiveMaterials | GenericEmissiveMaterial[] | Private |
| _connectedVfx | UnityEngine.VFX.VisualEffect | Private |
| _connectedVfxContactPoint | UnityEngine.Transform | Private |
| _ropePropertyBinder | RopePropertyBinder | Private |
| _pegs | System.Collections.Generic.List`1<WildSkies.Puzzles.PowerPeg> | Private |
| _dummyPegs | System.Collections.Generic.List`1<WildSkies.Puzzles.PowerPeg> | Private |
| _animator | UnityEngine.Animator | Private |
| _puzzleModule | WildSkies.Puzzles.PuzzleModule | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| <RopesConnected>k__BackingField | System.Collections.Generic.List`1<Services.IRopeTension> | Private |
| _poweredUp | System.Boolean | Private |
| _ordered | System.Boolean | Private |
| _poweredList | System.Collections.Generic.List`1<System.Int32> | Private |
| _connectedVfxPlaying | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| AllPegs | System.Collections.Generic.List`1<WildSkies.Puzzles.PowerPeg> | Public |
| RopesConnected | System.Collections.Generic.List`1<Services.IRopeTension> | Public |
| PrimaryRope | Services.IRopeTension | Public |

## Methods

- **add_OnNodeStateChanged(WildSkies.Puzzles.PylonPuzzleGenerator/NodeStateChanged value)**: System.Void (Public)
- **remove_OnNodeStateChanged(WildSkies.Puzzles.PylonPuzzleGenerator/NodeStateChanged value)**: System.Void (Public)
- **add_OnLocalRopeAttached(WildSkies.Puzzles.PylonPuzzleGenerator/LocalRopeAttached value)**: System.Void (Public)
- **remove_OnLocalRopeAttached(WildSkies.Puzzles.PylonPuzzleGenerator/LocalRopeAttached value)**: System.Void (Public)
- **add_OnLocalRopeCleared(WildSkies.Puzzles.PylonPuzzleGenerator/LocalRopeCleared value)**: System.Void (Public)
- **remove_OnLocalRopeCleared(WildSkies.Puzzles.PylonPuzzleGenerator/LocalRopeCleared value)**: System.Void (Public)
- **add_OnPuzzleComplete(WildSkies.Puzzles.PylonPuzzleGenerator/PuzzleComplete value)**: System.Void (Public)
- **remove_OnPuzzleComplete(WildSkies.Puzzles.PylonPuzzleGenerator/PuzzleComplete value)**: System.Void (Public)
- **get_AllPegs()**: System.Collections.Generic.List`1<WildSkies.Puzzles.PowerPeg> (Public)
- **get_RopesConnected()**: System.Collections.Generic.List`1<Services.IRopeTension> (Public)
- **get_PrimaryRope()**: Services.IRopeTension (Public)
- **SubObjectListChanged(System.String name, UnityEngine.GameObject[] subObjects)**: System.Void (Public)
- **NodeStateChange(System.Int32 index, UnityEngine.Vector3 position, System.Boolean isOn)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **NodePowered(System.Int32 index)**: System.Void (Public)
- **OnRopeWrap(Services.IRopeTension rope, Services.RopePoint point)**: System.Void (Public)
- **OnRopeUnwrap(Services.IRopeTension rope, Services.RopePoint point)**: System.Void (Public)
- **OnRopeCleared(Services.IRopeTension rope)**: System.Void (Public)
- **OnRopeClearedLocal(Services.IRopeTension rope)**: System.Void (Public)
- **OnRopeAttached(Services.IRopeTension rope, Services.RopePoint point)**: System.Void (Public)
- **OnRopeAttachedLocal(Services.IRopeTension rope)**: System.Void (Public)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **BoolChanged(System.String name, System.Boolean value)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

