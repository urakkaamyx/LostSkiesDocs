# WildSkies.Service.Instantiation.ASyncInstantiation

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _assetRefCount | System.Collections.Generic.Dictionary`2<UnityEngine.AddressableAssets.AssetReference,System.Int32> | Private |
| _activeTickets | System.Collections.Generic.List`1<WildSkies.Service.Instantiation.AssetTicket> | Private |
| _assetReferences | WildSkies.Service.Instantiation.AssetsLookupModel | Private |
| _assetInstantiation | WildSkies.Service.Instantiation.ASyncInstantiation/AssetInstantiation | Private |

## Methods

- **Initialise(WildSkies.Service.Instantiation.AssetsLookupModel assetReferences, WildSkies.Service.Instantiation.ASyncInstantiation/AssetInstantiation assetInstantiation)**: System.Int32 (Public)
- **LoadAssetFromReference(WildSkies.Service.Instantiation.AssetLoadRequest request, UnityEngine.AddressableAssets.AssetReference assetRef)**: System.Nullable`1<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> (Public)
- **FindTicketForAsset(UnityEngine.AddressableAssets.AssetReference assetRef, WildSkies.Service.Instantiation.AssetTicket& ticket)**: System.Boolean (Private)
- **Update()**: System.Void (Public)
- **HandleCompleted(WildSkies.Service.Instantiation.AssetTicket ticket)**: System.Void (Private)
- **InstantiateAsset(UnityEngine.AddressableAssets.AssetReference assetRef, WildSkies.Service.Instantiation.AssetLoadRequest assetLoadRequest)**: System.Void (Private)
- **GetAssetReferenceCount(UnityEngine.AddressableAssets.AssetReference assetRef)**: System.Int32 (Public)
- **AssetDestroyed(UnityEngine.AddressableAssets.AssetReference assetRef)**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

