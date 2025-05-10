# WildSkies.AI.AIEndlessSpawner

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _spawnData | WildSkies.AI.AIEndlessSpawnData[] | Private |
| _distanceSensor | Micosmo.SensorToolkit.RangeSensor | Private |
| _spawnPosition | UnityEngine.Transform | Private |
| _entities | System.Collections.Generic.List`1<WildSkies.Entities.AIEntity> | Private |
| _visuals | DroneSpawnerVisuals | Private |
| _damagePoints | UnityEngine.GameObject[] | Private |
| _spawnGraceTimeForCollisions | System.Single | Private |
| _lootContainer | WildSkies.Gameplay.Container.ContainerDefinition | Private |
| _lootDropPosition | UnityEngine.Transform | Private |
| _lootDistanceCheck | System.Single | Private |
| _groupService | WildSkies.Service.AIGroupService | Private |
| _lootDropService | WildSkies.Service.LootDropService | Private |
| _islandService | WildSkies.Service.IIslandService | Private |
| OnOpen | System.Action | Public |
| OnFartOutEntity | System.Action | Public |
| OnPuzzleDisabledEvent | System.Action | Public |
| _frequencyList | System.Collections.Generic.List`1<WildSkies.Gameplay.AI.AIDefinition> | Private |
| _spawnCancellationToken | System.Threading.CancellationTokenSource | Private |
| _spawnerActive | System.Boolean | Private |
| _isPaused | System.Boolean | Private |
| _data | WildSkies.AI.AIEndlessSpawnData | Private |
| _groupId | System.Int32 | Private |
| _weakpointsActive | System.Boolean | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| SpawnerActive | System.Boolean | Public |
| SpawnerType | AIGroupSpawner/AISpawnerType | Public |

## Methods

- **get_SpawnerActive()**: System.Boolean (Public)
- **get_SpawnerType()**: AIGroupSpawner/AISpawnerType (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **PauseSpawner(UnityEngine.GameObject arg0, Micosmo.SensorToolkit.Sensor arg1)**: System.Void (Public)
- **UnpauseSpawner(UnityEngine.GameObject arg0, Micosmo.SensorToolkit.Sensor arg1)**: System.Void (Public)
- **InitNonPuzzleSpawner()**: System.Void (Public)
- **InitialisePuzzleSpawner(WildSkies.Puzzles.EncounterPuzzle/EncounterChallengeLevel challengeLevel)**: System.Void (Public)
- **SetPuzzleSpawnerAwake()**: System.Void (Public)
- **OnPuzzleEnable()**: System.Void (Public)
- **OnPuzzleDisabled()**: System.Void (Public)
- **SetKillVisuals()**: System.Void (Public)
- **Reset()**: System.Void (Public)
- **ResetVisuals()**: System.Void (Public)
- **SpawnEntities(System.Threading.CancellationToken cancellationToken, UnityEngine.Vector3 spawnPosition)**: System.Threading.Tasks.Task (Public)
- **SpawnAIEntity(UnityEngine.GameObject prefab, UnityEngine.Vector3 spawnPosition)**: System.Void (Private)
- **DelayedCollisionDetection(WildSkies.AI.BossaNavAgent agent)**: System.Void (Private)
- **GenerateFrequencyList()**: System.Void (Private)
- **GetRandomDefinitionFromFrequencyList()**: WildSkies.Gameplay.AI.AIDefinition (Private)
- **OnEntityDestroyed(WildSkies.Entities.AIEntity entity, UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **IsInGroup(WildSkies.Entities.AIEntity entity)**: System.Boolean (Public)
- **ResetSpawner()**: System.Void (Public)
- **GetSurfacePoint(UnityEngine.Vector3 origin)**: UnityEngine.Vector3 (Private)
- **NetworkSetPowerVisual(System.Boolean state)**: System.Void (Public)
- **NetworkSetVisual(System.Boolean state)**: System.Void (Public)
- **OnColliderActiveSync(System.Boolean prev, System.Boolean cur)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

