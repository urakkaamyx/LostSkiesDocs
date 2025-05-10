# WildSkies.Camera.NetworkCameraImpulses

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _sync | Coherence.Toolkit.CoherenceSync | Private |

## Methods

- **Awake()**: System.Void (Protected)
- **CameraRumble(System.Single magnitude, System.Single decay, UnityEngine.Transform transform, System.Single syncStrength)**: System.Void (Public)
- **ExplosionOrImpact(Bossa.Cinematika.Impulses.ImpulseSpring impulseSpring, System.Single strength, System.Boolean isImpact, UnityEngine.Transform transform, System.Single syncStrength)**: System.Void (Public)
- **ExplosionOrImpact(Bossa.Cinematika.Impulses.ImpulseSpring impulseSpring, System.Single strength, System.Boolean isImpact, UnityEngine.Vector3 position, System.Single syncStrength)**: System.Void (Public)
- **CameraRumbleForFixedTime(System.Single timeUntilDampingStarts, System.Single magnitude, System.Single damping, UnityEngine.Transform transform, System.Single syncStrength)**: System.Void (Public)
- **CameraRumbleCmd(System.Single magnitude, System.Single decay, UnityEngine.Vector3 position)**: System.Void (Public)
- **ExplosionOrImpactCmd(System.Single springRandomMin, System.Single springRandomMax, System.Single springStiffnessIn, System.Single springDampingIn, System.Single springStiffnessOut, System.Single springDampingOut, System.Single inTime, System.Single strength, System.Boolean isImpact, UnityEngine.Vector3 position)**: System.Void (Public)
- **CameraRumbleForFixedTimeCmd(System.Single timeUntilDampingStarts, System.Single magnitude, System.Single damping, UnityEngine.Vector3 position)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

