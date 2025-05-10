# WildSkies.Puzzles.RelayPuzzleSource

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <IsEnabled>k__BackingField | System.Boolean | Private |
| _layerMaskForLasers | UnityEngine.LayerMask | Private |
| _puzzleModule | WildSkies.Puzzles.PuzzleModule | Private |
| _sourceAimIk | RootMotion.FinalIK.AimIK | Private |
| _sourceNode | WildSkies.Puzzles.RelayNode | Private |
| _materialOff | UnityEngine.Material | Private |
| _materialOn | UnityEngine.Material | Private |
| _materialSwitchRenderers | UnityEngine.Renderer[] | Private |
| _relayNodes | System.Collections.Generic.List`1<WildSkies.Puzzles.RelayNode> | Private |
| _receiver | WildSkies.Puzzles.RelayReceiver | Private |
| _powerSourceConnected | System.Boolean | Private |
| _audioSource | UnityEngine.AudioSource | Private |
| _poweredUp | System.Boolean | Private |
| _ordered | System.Boolean | Private |
| _aset | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsEnabled | System.Boolean | Public |

## Methods

- **get_IsEnabled()**: System.Boolean (Public)
- **set_IsEnabled(System.Boolean value)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **SubObjectListChanged(System.String name, UnityEngine.GameObject[] subObjects)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **InitTestMode()**: System.Void (Public)
- **ResetToEditMode()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

