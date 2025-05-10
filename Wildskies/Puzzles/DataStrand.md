# WildSkies.Puzzles.DataStrand

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| DataStrandSubObjectName | System.String | Public |
| ShowAllAtOnce | System.String | Public |
| TimerName | System.String | Public |
| AdditionalPickupTime | System.String | Public |
| _targetRadiusCheck | System.Single | Private |
| _targets | WildSkies.Puzzles.DataStrandTarget[] | Private |
| _additionalPickupTime | System.Single | Private |
| _showAllAtOnce | System.Boolean | Private |
| _stayOnPad | System.Boolean | Private |
| _targetTypeIndex | System.Int32 | Private |
| _targetHitVisual | UnityEngine.GameObject | Private |
| _targetsToHit | System.Int32 | Private |
| _targetsHit | System.Int32 | Private |

## Methods

- **SubObjectListChanged(System.String name, UnityEngine.GameObject[] subObjects)**: System.Void (Public)
- **FailedChallenge()**: System.Void (Public)
- **TargetHit(System.Int32 index, UnityEngine.Vector3 position)**: System.Void (Public)
- **BeginChallenge()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **BoolChanged(System.String name, System.Boolean value)**: System.Void (Public)
- **FloatChanged(System.String name, System.Single value)**: System.Void (Public)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

