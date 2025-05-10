# WildSkies.Service.InstantiationService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _assetReferences | WildSkies.Service.Instantiation.AssetsLookupModel | Protected |
| _asyncInstantiation | WildSkies.Service.Instantiation.ASyncInstantiation | Private |
| _logToConsole | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| AssetReferences | WildSkies.Service.Instantiation.AssetsLookupModel | Public |
| LogToConsole | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_AssetReferences()**: WildSkies.Service.Instantiation.AssetsLookupModel (Public)
- **set_LogToConsole(System.Boolean value)**: System.Void (Public)
- **get_LogToConsole()**: System.Boolean (Public)
- **.ctor(WildSkies.Service.Instantiation.AssetsLookupModel assetReferences)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Update()**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **LoadAndInstantiate(UnityEngine.AddressableAssets.AssetReference assetRef, WildSkies.Service.Instantiation.AssetLoadRequest request)**: System.Nullable`1<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> (Public)
- **GetAssetReferenceCount(UnityEngine.AddressableAssets.AssetReference assetRef)**: System.Int32 (Public)
- **Instantiate(UnityEngine.GameObject asset, WildSkies.Service.Instantiation.AssetLoadRequest assetLoadRequest)**: UnityEngine.GameObject (Public)
- **InstantiateAsset(UnityEngine.GameObject asset, WildSkies.Service.Instantiation.AssetLoadRequest assetLoadRequest)**: UnityEngine.GameObject (Private)

