# WildSkies.Mediators.WorldLoadingIslandLoadingMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _islandLoadingService | WildSkies.Service.IslandLoadingService | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |

## Methods

- **Initialise(WildSkies.Service.IslandLoadingService islandLoadingService, WildSkies.Service.WorldLoadingService worldLoadingService)**: System.Void (Public)
- **OnLoadIslandRequest(System.String islandName, UnityEngine.Vector3 worldPosition, UnityEngine.Quaternion worldRotation, WildSkies.IslandExport.IslandInstanceMetaData metaData)**: System.Void (Private)
- **OnIslandLoadFailure(System.String islandName, System.Int32 errorCode)**: System.Void (Private)
- **OnIslandLoadSuccess(System.String islandName, UnityEngine.GameObject islandInstance, System.Int32 level, System.Int32 difficulty)**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **ParentIsland(System.String islandName, UnityEngine.GameObject islandInstance, System.Int32 level, System.Int32 difficulty)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

