# WildSkies.Service.FloatingWorldOriginService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| FloatingWorldOriginShifted | System.Action`1<UnityEngine.Vector3> | Public |
| _currentFloatingWorldOrigin | Coherence.Common.Vector3d | Private |
| _objectsToUpdate | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| CurrentFloatingWorldOrigin | Coherence.Common.Vector3d | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_CurrentFloatingWorldOrigin()**: Coherence.Common.Vector3d (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetFloatingWorldOrigin(UnityEngine.Vector3 newFloatingWorldOrigin)**: System.Void (Public)
- **ShiftNonNetworkedObjects(UnityEngine.Vector3 floatingWorldOriginDelta)**: System.Void (Public)
- **RegisterObject(UnityEngine.GameObject gameObject)**: System.Void (Public)
- **UnregisterObject(UnityEngine.GameObject gameObject)**: System.Void (Public)
- **DoesFloatingOriginMatch()**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

