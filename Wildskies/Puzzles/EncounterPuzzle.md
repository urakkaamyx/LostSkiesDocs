# WildSkies.Puzzles.EncounterPuzzle

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _holoDronePrefab | EncounterTarget | Private |
| _spawnPoints | UnityEngine.Transform[] | Private |
| _challengeLevel | WildSkies.Puzzles.EncounterPuzzle/EncounterChallengeLevel | Private |
| _isEncounterActive | System.Boolean | Private |
| _puzzleComplete | System.Boolean | Private |
| _encounterCleared | System.Boolean | Private |
| _initialised | System.Boolean | Private |
| _holoDrones | System.Collections.Generic.List`1<EncounterTarget> | Private |
| OnStartEncounter | System.Action`1<WildSkies.Puzzles.EncounterPuzzle/EncounterChallengeLevel> | Public |
| OnEndEncounter | System.Action | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ChallengeLevel | WildSkies.Puzzles.EncounterPuzzle/EncounterChallengeLevel | Public |
| IsEncounterActive | System.Boolean | Public |
| IsCleared | System.Boolean | Public |
| Complete | System.Boolean | Public |
| IsActiveAndComplete | System.Boolean | Public |
| PuzzleComplete | System.Boolean | Public |

## Methods

- **get_ChallengeLevel()**: WildSkies.Puzzles.EncounterPuzzle/EncounterChallengeLevel (Public)
- **get_IsEncounterActive()**: System.Boolean (Public)
- **get_IsCleared()**: System.Boolean (Public)
- **get_Complete()**: System.Boolean (Public)
- **get_IsActiveAndComplete()**: System.Boolean (Public)
- **get_PuzzleComplete()**: System.Boolean (Public)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **LateUpdate()**: System.Void (Private)
- **StartEncounter()**: System.Void (Public)
- **HoloDroneDestroyed(EncounterTarget drone)**: System.Void (Public)
- **ClearEncounter()**: System.Void (Public)
- **Reset()**: System.Void (Public)
- **SetFromSerialiseData(WildSkies.Puzzles.EncounterPuzzle/EncounterChallengeLevel groupType, System.Boolean isActive, System.Boolean isCleared, System.Boolean puzzleComplete)**: System.Void (Public)
- **SelectionListChanged(System.String name, System.Int32 value)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

