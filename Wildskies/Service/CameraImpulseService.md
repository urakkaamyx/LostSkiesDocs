# WildSkies.Service.CameraImpulseService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _networkCameraImpulses | WildSkies.Camera.NetworkCameraImpulses | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **CameraRumble(System.Single magnitude, System.Single decay, UnityEngine.Transform transform, System.Single syncStrength)**: System.Void (Public)
- **ExplosionOrImpact(Bossa.Cinematika.Impulses.ImpulseSpring impulseSpring, System.Single strength, System.Boolean isImpact, UnityEngine.Transform transform, System.Single syncStrength)**: System.Void (Public)
- **ExplosionOrImpact(Bossa.Cinematika.Impulses.ImpulseSpring impulseSpring, System.Single strength, System.Boolean isImpact, UnityEngine.Vector3 position, System.Single syncStrength)**: System.Void (Public)
- **CameraRumbleForFixedTime(System.Single timeUntilDampingStarts, System.Single magnitude, System.Single damping, UnityEngine.Transform transform, System.Single syncStrength)**: System.Void (Public)
- **SetNetworkCameraImpulses(WildSkies.Camera.NetworkCameraImpulses networkCameraImpulses)**: System.Void (Public)
- **DestroyNetworkCameraImpulses()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

