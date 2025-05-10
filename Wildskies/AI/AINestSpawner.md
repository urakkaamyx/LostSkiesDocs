# WildSkies.AI.AINestSpawner

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _colliderInteractionListener | ColliderInteractionListener | Private |
| _onDestroyVFX | WildSkies.VfxType | Private |
| _health | System.Int32 | Private |
| _spawnDelay | System.Single | Private |
| _vfxPoolService | WildSkies.Service.VfxPoolService | Private |
| _entities | System.Collections.Generic.List`1<WildSkies.Entities.AIEntity> | Private |
| _currentHealth | System.Int32 | Private |
| _groupId | System.Int32 | Private |
| _parentAI | WildSkies.Entities.AIEntity | Private |
| _hasBurst | System.Boolean | Private |

## Methods

- **Start()**: System.Void (Private)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **ResetSpawner()**: System.Void (Public)
- **OnYank(UnityEngine.Vector3 direction)**: System.Void (Public)
- **SpawnCreature()**: Cysharp.Threading.Tasks.UniTask (Private)
- **SpawnCreatureAsync()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnDamage(WildSkies.Weapon.DamageResponse damageResponse)**: System.Void (Private)
- **OnCollisionEnter(UnityEngine.Collision other)**: System.Void (Private)
- **NetworkSpawnCreature()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

