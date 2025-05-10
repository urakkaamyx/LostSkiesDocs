# WildSkies.Puzzles.PowerPeg

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <ControlPowerState>k__BackingField | System.Boolean | Private |
| <ContactConnectionPoint>k__BackingField | UnityEngine.Vector3 | Private |
| <IsPowered>k__BackingField | System.Boolean | Private |
| _powerTimeout | System.Single | Private |
| _contactVfx | UnityEngine.VFX.VisualEffect | Private |
| _contactVfxContactPoint | UnityEngine.Transform | Private |
| _lightSourceRenderer | UnityEngine.Renderer | Private |
| _onColour | UnityEngine.Color | Private |
| _offColour | UnityEngine.Color | Private |
| _transitionSpeed | System.Single | Private |
| _localConnections | System.Int32 | Private |
| _emissiveMaterial | UnityEngine.Material | Private |
| _audioSource | UnityEngine.AudioSource | Private |
| _pylonPuzzle | WildSkies.Puzzles.PylonPuzzleGenerator | Private |
| _transitionTimeElapsed | System.Single | Private |
| _targetColourReached | System.Boolean | Private |
| _index | System.Int32 | Private |
| _lastPowered | System.Single | Private |
| _showContactVfx | System.Boolean | Private |
| _contactVfxPlaying | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ControlPowerState | System.Boolean | Public |
| ContactConnectionPoint | UnityEngine.Vector3 | Public |
| IsPowered | System.Boolean | Public |

## Methods

- **get_ControlPowerState()**: System.Boolean (Public)
- **set_ControlPowerState(System.Boolean value)**: System.Void (Public)
- **get_ContactConnectionPoint()**: UnityEngine.Vector3 (Public)
- **set_ContactConnectionPoint(UnityEngine.Vector3 value)**: System.Void (Public)
- **get_IsPowered()**: System.Boolean (Public)
- **set_IsPowered(System.Boolean value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **Update()**: System.Void (Protected)
- **SetVfx()**: System.Void (Private)
- **Setup(WildSkies.Puzzles.PylonPuzzleGenerator pylonPuzzle, System.Int32 index)**: System.Void (Public)
- **Power(UnityEngine.Vector3 worldConnectionPoint)**: System.Void (Public)
- **PowerComplete()**: System.Void (Public)
- **SetEmissiveColour()**: System.Void (Private)
- **OnRopeWrap(Services.IRopeTension rope, Services.RopePoint point)**: System.Void (Public)
- **OnRopeUnwrap(Services.IRopeTension rope, Services.RopePoint point)**: System.Void (Public)
- **OnRopeCleared(Services.IRopeTension rope)**: System.Void (Public)
- **OnRopeAttached(Services.IRopeTension rope, Services.RopePoint point)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

