# WildSkies.AI.AIPlayerActivitySpawner

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| GroupEntitySpawned | System.Action`1<WildSkies.Entities.AIEntity> | Public |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _dataContainer | WildSkies.AI.AIPlayerActivityDataContainer | Private |
| _distanceSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _landEncounterService | WildSkies.Service.LandEncounterService | Private |
| _aiGroupService | WildSkies.Service.AIGroupService | Private |
| _currentState | System.Int32 | Public |
| _currentEnounterLevel | System.Single | Public |
| _syncSubBiomeType | System.Int32 | Public |
| _cooldownTimer | System.Single | Public |
| _groupId | System.Int32 | Public |
| _spawnCancellationToken | System.Threading.CancellationTokenSource | Private |
| _cooldownCancellationToken | System.Threading.CancellationTokenSource | Private |
| _encounterLevelCooldownDownCancellationToken | System.Threading.CancellationTokenSource | Private |
| _entities | System.Collections.Generic.List`1<WildSkies.Entities.AIEntity> | Private |
| _playerActivitySpawnerData | WildSkies.AI.PlayerActivitySpawnerData | Private |
| _spawnDelay | System.Int32 | Private |
| _minSpawnDelay | System.Single | Private |
| _pulseInterval | System.Single | Private |
| debugCounter | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| State | LandEncounterState | Public |
| SpawnerType | AIGroupSpawner/AISpawnerType | Public |
| Position | UnityEngine.Vector3 | Public |
| Data | WildSkies.AI.PlayerActivitySpawnerData | Public |

## Methods

- **get_State()**: LandEncounterState (Public)
- **get_SpawnerType()**: AIGroupSpawner/AISpawnerType (Public)
- **get_Position()**: UnityEngine.Vector3 (Public)
- **get_Data()**: WildSkies.AI.PlayerActivitySpawnerData (Public)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **OnUpdate()**: System.Void (Public)
- **Init(WildSkies.Service.AILookUpService aiLookUpService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.AIGroupService groupService, WildSkies.Gameplay.AI.AIGroupDefinition data, System.Int32 region, System.Int32 level, WildSkies.WorldItems.Island/IslandDifficulty difficulty, System.Guid uuid, WildSkies.IslandExport.SubBiomeType subBiomeType)**: System.Void (Public)
- **OnAuthorityChanged()**: System.Void (Public)
- **AttemptToSetLandEncounterState(LandEncounterState state)**: System.Void (Public)
- **IncreaseEncounterChance(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position)**: System.Void (Public)
- **IncreaseEncounterChance(System.Single chance, UnityEngine.Vector3 position)**: System.Void (Public)
- **OnNetworkIncreaseEncounterChance(System.Single chance, UnityEngine.Vector3 position)**: System.Void (Public)
- **OnSpawnGroup()**: System.Void (Public)
- **SpawnEntities(System.Threading.CancellationToken cancellationToken)**: System.Threading.Tasks.Task (Public)
- **DataHasAudioType(System.Int32 index, WildSkies.Audio.AudioType audioType)**: System.Boolean (Private)
- **CooldownForSpawn()**: Cysharp.Threading.Tasks.UniTask (Private)
- **EncounterLevelCooldown()**: Cysharp.Threading.Tasks.UniTask (Private)
- **SpawnAIEntity(UnityEngine.GameObject prefab, UnityEngine.Vector3 spawnPosition)**: System.Void (Private)
- **OnGroupChanged(System.Int32 groupId)**: System.Void (Private)
- **IsInGroup(WildSkies.Entities.AIEntity entity)**: System.Boolean (Public)
- **ResetSpawner()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

