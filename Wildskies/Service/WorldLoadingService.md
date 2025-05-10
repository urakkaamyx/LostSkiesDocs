# WildSkies.Service.WorldLoadingService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| LoadIslandRequest | System.Action`4<System.String,UnityEngine.Vector3,UnityEngine.Quaternion,WildSkies.IslandExport.IslandInstanceMetaData> | Public |
| WorldLoadingComplete | System.Action`3<System.String,System.Int32,System.Int32> | Public |
| _worldInstantiationInProgress | System.Boolean | Private |
| _currentWorldMap | WildSkies.WorldItems.Map | Private |
| _remainingIslandsToLoad | System.Collections.Generic.Queue`1<WildSkies.WorldItems.Island> | Private |
| _remainingWeatherWallsToLoad | System.Collections.Generic.Queue`1<WildSkies.WorldItems.WeatherWall> | Private |
| _numIslandLoads | System.Int32 | Private |
| _successfulIslandLoads | System.Int32 | Private |
| _islandsWithShiftedPositions | System.Collections.Generic.Dictionary`2<WildSkies.WorldItems.Island,UnityEngine.Vector3> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CurrentWorldMap | WildSkies.WorldItems.Map | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| WorldInstantiationInProgress | System.Boolean | Public |
| NumIslandLoads | System.Int32 | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CurrentWorldMap()**: WildSkies.WorldItems.Map (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_WorldInstantiationInProgress()**: System.Boolean (Public)
- **get_NumIslandLoads()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **InstantiateWorld(WildSkies.WorldItems.Map worldMap, Coherence.Common.Vector3d floatingWorldOrigin, WildSkies.Service.ILocalPlayerService localPlayerService)**: System.Void (Public)
- **ResetIslandLoadedCounter()**: System.Void (Public)
- **LoadWeatherWalls()**: System.Void (Private)
- **LoadRemainingIslands(WildSkies.Service.ILocalPlayerService localPlayerService)**: System.Void (Private)
- **NotifyIslandLoadComplete(System.String islandName, System.Boolean success, WildSkies.Service.ILocalPlayerService localPlayerService)**: System.Void (Public)
- **WorldMapLoaded()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

