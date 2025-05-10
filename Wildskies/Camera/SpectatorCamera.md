# WildSkies.Camera.SpectatorCamera

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| MinFov | System.Single | Private |
| MaxFov | System.Single | Private |
| LookSpeed | System.Single | Public |
| MovementSpeed | System.Single | Public |
| VerticalSpeedModifier | System.Single | Public |
| MoveSmoothing | System.Single | Public |
| LookSmoothing | System.Single | Public |
| _limitYAngle | System.Boolean | Private |
| _yAngleLimit | System.Single | Private |
| _defaultAngleX | System.Single | Private |
| _defaultAngleY | System.Single | Private |
| _angleX | System.Single | Private |
| _angleY | System.Single | Private |
| _angleZ | System.Single | Private |
| _orbitDistance | System.Single | Private |
| _moveSpeedX | System.Single | Private |
| _moveSpeedY | System.Single | Private |
| _moveSpeedZ | System.Single | Private |
| _targetAngleX | System.Single | Private |
| _targetAngleY | System.Single | Private |
| _targetMoveSpeedX | System.Single | Private |
| _targetMoveSpeedY | System.Single | Private |
| _targetMoveSpeedZ | System.Single | Private |
| _freezeTargetAngle | System.Boolean | Private |
| _freezeTargetPosition | System.Boolean | Private |
| Move | UnityEngine.Vector3 | Private |
| Look | UnityEngine.Vector2 | Private |
| Dutch | System.Single | Private |
| Boost | System.Single | Private |
| _actualFovChange | System.Single | Private |
| _targetDutchAngle | System.Single | Private |

## Methods

- **Enable()**: System.Void (Public)
- **UpdateInput(Bossa.Cinematika.ICameraInputState inputState)**: System.Void (Public)
- **UpdateTransform(UnityEngine.Transform t, System.Boolean translate)**: System.Void (Public)
- **WrapAngle(System.Single& angle)**: System.Void (Private)
- **ResetDutch()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

