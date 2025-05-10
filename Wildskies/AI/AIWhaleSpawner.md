# WildSkies.AI.AIWhaleSpawner

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _distFromPlayerToSpawn | System.Single | Private |
| _distToDespawn | System.Single | Private |
| _distToRemove | System.Single | Private |
| _worldBottom | System.Single | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _remotePlayerService | WildSkies.Service.IRemotePlayerService | Private |
| _nearestPlayerDistance | System.Single | Public |
| _isSpawning | System.Boolean | Private |
| _isDespawning | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| SpawnerType | AIGroupSpawner/AISpawnerType | Public |

## Methods

- **get_SpawnerType()**: AIGroupSpawner/AISpawnerType (Public)
- **Update()**: System.Void (Protected)
- **GetNearestPlayerDistance(UnityEngine.Vector3 from)**: System.Single (Private)
- **SpawnEntities()**: System.Void (Private)
- **SpawnAIEntity(UnityEngine.GameObject prefab, UnityEngine.Vector3 spawnPosition)**: System.Void (Protected)
- **DespawnEntities()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

