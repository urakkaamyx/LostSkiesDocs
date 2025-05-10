# WildSkies.Camera.DynamikaCameraRecoil

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _moveAmountForRecoilReset | System.Single | Private |
| _settleSpeed | System.Single | Private |
| _settleSpeedCurve | UnityEngine.AnimationCurve | Private |
| _state | WildSkies.Camera.DynamikaCameraRecoil/State | Private |
| _currentVertical | System.Single | Private |
| _currentHorizontal | System.Single | Private |
| _recoilIntegrator | System.Single | Private |
| _lastRecoilActivation | System.Single | Private |
| _accumulatedVertical | System.Single | Private |
| _lerpTimer | System.Single | Private |
| _decayCurveSpeed | System.Single | Private |
| _maxIntegrator | System.Single | Private |
| _recoilData | WildSkies.Camera.DynamikaCameraRecoil/RecoilData | Private |

## Methods

- **SetRecoilData(WildSkies.Camera.DynamikaCameraRecoil/RecoilData recoilData)**: System.Void (Public)
- **AddRecoil(WildSkies.Camera.DynamikaCameraRecoil/RecoilData recoilData)**: System.Void (Public)
- **ResetRecoilIntegrator()**: System.Void (Private)
- **UpdateInput(Bossa.Cinematika.ICameraInputState iState)**: System.Void (Public)
- **UpdateTransform(UnityEngine.Transform t, System.Boolean translate)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

