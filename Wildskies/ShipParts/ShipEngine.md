# WildSkies.ShipParts.ShipEngine

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Throttle | System.Int32 | Private |
| BaseColor | System.Int32 | Private |
| _engineVfxPrefabs | WildSkies.ShipParts.ShipEngine/EngineVfxPrefabs | Private |
| _engineAudio | ShipEngineAudio | Private |
| _propellerSpeed | System.Single | Private |
| _isTorqueless | System.Boolean | Private |
| _playingLoop | System.Boolean | Private |
| _acceleration | System.Single | Private |
| _power | System.Single | Private |
| _overheatResistance | System.Single | Private |
| _fuelEfficiency | System.Single | Private |
| _prop | UnityEngine.Transform | Private |
| _exhaustAnimators | UnityEngine.Animator[] | Private |
| _propBlur | UnityEngine.ParticleSystem | Private |
| _propBlurMaterial | UnityEngine.Material | Private |
| _propBlurBaseColor | UnityEngine.Color | Private |
| _controlThrottle | System.Single | Private |
| _engineThrottle | System.Single | Private |
| _constantlyUpdateStats | System.Boolean | Private |

## Methods

- **OnEnable()**: System.Void (Public)
- **OnDisable()**: System.Void (Public)
- **UpdateStats()**: System.Void (Protected)
- **SetupReferences(ShipPartSubComponent[] shipParts)**: System.Void (Public)
- **OnShipControlUpdate(WildSkies.Ship.ShipControl/ShipControlState state)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **OnShipControlFixedUpdate()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

