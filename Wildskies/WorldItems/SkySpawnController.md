# WildSkies.WorldItems.SkySpawnController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _showGizmos | System.Boolean | Private |
| _showNearestEdgeGizmos | System.Boolean | Private |
| _voronoi | HullDelaunayVoronoi.Voronoi.VoronoiMesh2 | Private |
| _worldLoadingComplete | System.Boolean | Private |
| _updatePlayerPosition | System.Boolean | Private |
| _localOrigin | UnityEngine.Vector3 | Private |
| _skySpawnerUpdateIndex | System.Int32 | Private |
| _skySpawnerHeightOffset | UnityEngine.Vector2 | Private |
| _distantLocationForEncounters | UnityEngine.Vector3 | Private |
| _excludedAreas | WildSkies.IslandExport.ContainerBVH`1<UnityEngine.BoundingSphere> | Private |
| _activeSpawnerEdges | System.Collections.Generic.List`1<System.Int32> | Private |
| _skySpawners | System.Collections.Generic.List`1<AISkySpawner> | Private |
| _tempList | System.Collections.Generic.List`1<System.Int32> | Private |
| _playerPositions | System.Collections.Generic.Dictionary`2<System.String,WildSkies.WorldItems.SkySpawnController/PlayerLocation> | Private |
| _aiGroupSpawnerLocations | System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker>> | Private |
| _spawnObjectCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| _playerSearchCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| _scatterTable | WildSkies.Service.ScatterTable | Private |
| _cloudSpawnPointGenerationTask | Cysharp.Threading.Tasks.UniTask | Private |
| _aiSpawnDelay | System.Int32 | Private |
| _smallUpdateDelay | System.Int32 | Private |
| _longUpdateDelay | System.Int32 | Private |
| _scatterTableName | System.String | Private |
| _updatePlayerPositonDistance | System.Single | Private |
| _randomOffset | System.Single | Private |
| _playerExcludeRadius | System.Single | Private |
| OnGridReady | System.Action | Public |
| _islandService | WildSkies.Service.IIslandService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| _aiGroupService | WildSkies.Service.AIGroupService | Private |
| _aiLookUpService | WildSkies.Service.AILookUpService | Private |
| _scatterTableService | WildSkies.Service.IScatterTableService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _skyMapService | SkyMapService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _remotePlayerService | WildSkies.Service.IRemotePlayerService | Private |
| _nearestEdges | System.Collections.Generic.List`1<HullDelaunayVoronoi.Voronoi.VoronoiEdge`1<HullDelaunayVoronoi.Primitives.Vertex2>> | Private |
| _spawnLocations | System.Collections.Generic.List`1<WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| WorldLoadingComplete | System.Boolean | Public |
| SkySpawners | System.Collections.Generic.List`1<AISkySpawner> | Public |
| AIGroupSpawnerLocations | System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker>> | Public |
| ScatterTable | WildSkies.Service.ScatterTable | Public |
| _spawnObjectCancellationToken | System.Threading.CancellationToken | Private |

## Methods

- **get_WorldLoadingComplete()**: System.Boolean (Public)
- **get_SkySpawners()**: System.Collections.Generic.List`1<AISkySpawner> (Public)
- **get_AIGroupSpawnerLocations()**: System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker>> (Public)
- **get_ScatterTable()**: WildSkies.Service.ScatterTable (Public)
- **get__spawnObjectCancellationToken()**: System.Threading.CancellationToken (Private)
- **Start()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnRemotePlayerRegistered(PlayerNetwork playerNetwork)**: System.Void (Private)
- **OnRemotePlayerUnRegistered(PlayerNetwork playerNetwork)**: System.Void (Private)
- **ForceRefreshSpawners()**: System.Void (Public)
- **OnFloatingOriginShifted(UnityEngine.Vector3 newOrigin)**: System.Void (Private)
- **OnWorldLoadingComplete(System.String arg1, System.Int32 arg2, System.Int32 arg3)**: System.Void (Private)
- **ScatterEntities()**: Cysharp.Threading.Tasks.UniTask (Private)
- **UpdatePlayerPosition()**: Cysharp.Threading.Tasks.UniTask (Private)
- **RefreshSpawners()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ScatterAILocations()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ScatterWhaleGroups()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ScatterEncounters()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ScatterEncounters(ScatterAIGroup aiGroup, UnityEngine.GameObject spawnObject)**: Cysharp.Threading.Tasks.UniTask (Private)
- **AddSkySpawnerLocation(ScatterAIGroup aiGroup, System.String scatterTableName)**: Cysharp.Threading.Tasks.UniTask (Private)
- **ScatterWhales(ScatterAIGroup aiGroup)**: Cysharp.Threading.Tasks.UniTask (Private)
- **CreateSkyAIGroup(WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker groupSpawnLocationTracker, UnityEngine.Vector3 location, System.Guid uuid)**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnAIGroupInstantiated(UnityEngine.GameObject entityObject, WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker spawnLocationTracker, System.Guid uuid)**: System.Void (Private)
- **OnAIGroupInstantiated(UnityEngine.GameObject entityObject, WildSkies.Gameplay.AI.AIGroupDefinition groupDefinition, System.Guid uuid)**: System.Void (Private)
- **GetAllSpawnLocations()**: System.Collections.Generic.List`1<WildSkies.WorldItems.SkySpawnController/AIGroupSpawnLocationTracker> (Public)
- **GetScatterTable()**: WildSkies.Service.ScatterTable (Private)
- **SpawnHerald()**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

