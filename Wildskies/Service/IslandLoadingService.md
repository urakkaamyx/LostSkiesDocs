# WildSkies.Service.IslandLoadingService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| InteractionIdForPlayerChallenges | System.Int32 | Private |
| IslandLoadedSuccess | System.Action`4<System.String,UnityEngine.GameObject,System.Int32,System.Int32> | Public |
| IslandLoadedFailure | System.Action`2<System.String,System.Int32> | Public |
| IslandServiceInitialisationComplete | System.Action`1<System.Boolean> | Public |
| _catalogDownloaded | System.Boolean | Private |
| _remoteCatalog | System.Boolean | Private |
| _remoteHostURL | System.String | Private |
| _localHostURL | System.String | Private |
| _buildTarget | System.String | Private |
| _resourceLUTs | IslandResourceLookup | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _mainThreadActionQueue | System.Collections.Generic.Queue`1<System.Action> | Private |
| coherenceBridge | Coherence.Toolkit.CoherenceBridge | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |
| HostURL | System.String | Private |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **get_HostURL()**: System.String (Private)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **InstantiateIsland(System.String islandName, UnityEngine.Vector3 worldPosition, UnityEngine.Quaternion worldRotation, WildSkies.IslandExport.IslandInstanceMetaData metaData, UnityEngine.Transform parent)**: System.Void (Public)
- **LoadLocalCatalog(System.String URL)**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadRemoteCatalog(System.String URL)**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadAndInstantiate(System.String islandName, UnityEngine.Vector3 worldPosition, UnityEngine.Quaternion worldRotation, WildSkies.IslandExport.IslandInstanceMetaData metaData, UnityEngine.Transform parent)**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **InstantiateIslandInternal(UnityEngine.GameObject islandPrefab, UnityEngine.Vector3 worldPosition, UnityEngine.Quaternion worldRotation, WildSkies.IslandExport.IslandInstanceMetaData metaData, UnityEngine.Transform parent)**: System.Threading.Tasks.Task`1<UnityEngine.GameObject> (Private)
- **AddIslandObjectsToLODGroup(UnityEngine.GameObject islandPrefab, UnityEngine.GameObject islandInstance, WildSkies.IslandExport.Island exportedIslandData)**: System.Void (Private)
- **InitialiseActiveIslandPartial(World.IslandController islandController)**: Cysharp.Threading.Tasks.UniTask`1<System.Boolean> (Public)
- **DisposeActiveIslandPartial(World.IslandController exportedIslandData)**: System.Boolean (Public)
- **InstantiateIslandObjects(UnityEngine.GameObject islandPrefab, UnityEngine.GameObject islandInstance, WildSkies.IslandExport.Island exportedIslandData)**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **InjectGameObjectWithMetaData(UnityEngine.GameObject resourceObjectInstance, WildSkies.IslandExport.ExportedObjectRef curObjectRef, System.String resourceName, System.Int32 metaIndex)**: System.Void (Public)
- **RegisterUuidForPuzzleObject(System.String guid, UnityEngine.GameObject prefab)**: System.Void (Private)
- **LinkUpPuzzles(System.Collections.Generic.Dictionary`2<System.Guid,WildSkies.Puzzles.PuzzleModuleMeta> puzzleModules)**: System.Void (Private)
- **RemoveIslandObjects(UnityEngine.GameObject islandInstance, WildSkies.IslandExport.Island island)**: System.Void (Public)
- **CheckForIslandInteractables(UnityEngine.GameObject rootObject)**: System.Void (Private)
- **CalculateSizeToLodMapping(UnityEngine.GameObject islandPrefab, WildSkies.IslandExport.Island exportedIslandData)**: System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.ObjectSize,System.Int32> (Private)
- **LoadObjectAsset(System.String objectGUID)**: System.Threading.Tasks.Task`1<UnityEngine.GameObject> (Private)
- **ResolveMaterialReferences(UnityEngine.GameObject islandPrefab, UnityEngine.GameObject islandInstance, WildSkies.IslandExport.Island exportedIslandData)**: System.Threading.Tasks.Task (Private)
- **LoadIslandPrefab(System.String islandName)**: System.Threading.Tasks.Task`1<UnityEngine.GameObject> (Private)
- **.ctor()**: System.Void (Public)

