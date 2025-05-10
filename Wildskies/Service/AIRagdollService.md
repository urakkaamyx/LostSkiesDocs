# WildSkies.Service.AIRagdollService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <RagdollRequested>k__BackingField | WildSkies.Service.AIRagdollService/RagdollInstantiationRequest | Private |
| _initialised | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| AddressableLocationKey | System.String | Private |
| _ragdollReferenceById | System.Collections.Generic.Dictionary`2<System.UInt32,UnityEngine.GameObject> | Private |
| _critterReferenceById | System.Collections.Generic.Dictionary`2<System.UInt32,UnityEngine.GameObject> | Private |
| _ragdollRequests | System.Collections.Generic.Dictionary`2<System.Guid,WildSkies.Service.AIRagdollService/RequestData> | Private |
| _stringBuilder | System.Text.StringBuilder | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| RagdollRequested | WildSkies.Service.AIRagdollService/RagdollInstantiationRequest | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_RagdollRequested()**: WildSkies.Service.AIRagdollService/RagdollInstantiationRequest (Public)
- **set_RagdollRequested(WildSkies.Service.AIRagdollService/RagdollInstantiationRequest value)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **LoadVisualReferences()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnAddressableLoad(RagdollVisualLookup lookup)**: System.Void (Private)
- **CreateRagdoll(UnityEngine.SkinnedMeshRenderer[] entityRenderers, UnityEngine.Rigidbody entityRigidbody, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, UnityEngine.Vector3 deathVelocity, WildSkies.Entities.AIEntity originalEntity)**: System.Void (Public)
- **CreateRagdoll(UnityEngine.SkinnedMeshRenderer[] entityRenderers, UnityEngine.Rigidbody entityRigidbody, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale, UnityEngine.Vector3 deathVelocity, WildSkies.AI.AdvancedCritter advancedCritter)**: System.Void (Public)
- **SetNewRagdollValues(UnityEngine.GameObject ragdollObj, System.Guid requestId)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

