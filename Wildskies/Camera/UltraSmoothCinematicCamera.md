# WildSkies.Camera.UltraSmoothCinematicCamera

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| input | WildSkies.Camera.UltraSmoothCinematicCamera/InputState | Private |
| LookSmoothness | System.Single | Public |
| MoveSmoothness | System.Single | Public |
| VerticalSpeedModifier | System.Single | Public |
| moveSpeeds | System.Single[] | Private |
| dummyTransform | UnityEngine.Transform | Private |
| currentSpeed | System.Int32 | Public |
| _actualFovChange | System.Single | Private |
| _cameraVisualSettings | Bossa.Cinematika.Modules.CameraVisualSettings | Private |

## Methods

- **Enable()**: System.Void (Public)
- **Teleport(UnityEngine.Vector3 newPosition)**: System.Void (Public)
- **OnDisable()**: System.Void (Public)
- **UpdateInput(Bossa.Cinematika.ICameraInputState iState)**: System.Void (Public)
- **UpdateTransform(UnityEngine.Transform t, System.Boolean translate)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

