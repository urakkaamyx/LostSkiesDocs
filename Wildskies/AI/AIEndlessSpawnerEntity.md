# WildSkies.AI.AIEndlessSpawnerEntity

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _spawner | WildSkies.AI.AIEndlessSpawner | Private |
| _puzzle | WildSkies.Puzzles.EncounterPuzzle | Private |
| _loopingDestructionVFX | UnityEngine.GameObject | Private |
| _aiSpawnerObjectSpawner | AISpawnerObjectSpawner | Private |
| _spawnerPuzzleSync | SpawnerPuzzleSync | Private |
| _healthData | BaseStats | Private |
| _resetTimer | WildSkies.AI.AIResetTimer | Private |
| _deathHandling | EntityDeathHandling | Private |
| _isDestroyed | System.Boolean | Public |
| OnDestroyed | System.Action | Public |
| OnDamaged | System.Action | Public |

## Methods

- **Start()**: System.Void (Private)
- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Private)
- **OnEntityDamaged(System.Single damage, WildSkies.Weapon.DamageType damageType, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Single newNormalizedHealth)**: System.Void (Private)
- **SetAsDestroyed()**: System.Void (Public)
- **ResetSpawner()**: System.Void (Public)
- **SyncDeathState(System.Boolean prev, System.Boolean cur)**: System.Void (Public)
- **NetworkClearEncounter()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

