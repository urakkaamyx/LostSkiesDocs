# WildSkies.AI.SpikeProjectileAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _data | WildSkies.AI.MantaProjectileAttackData | Private |
| _deathHandling | EntityDeathHandling | Private |
| _flyingAgent | WildSkies.AI.BossaFlyingAgent | Private |
| _materialAffector | MantaMaterialAffector | Private |
| _spikedProjectile | UnityEngine.GameObject | Private |
| _firePoint | UnityEngine.Transform | Private |
| _ignoreColliders | UnityEngine.Collider[] | Private |
| _fireRateTask | Cysharp.Threading.Tasks.UniTask | Private |
| _windUpTask | Cysharp.Threading.Tasks.UniTask | Private |
| _fireRateCancellationToken | System.Threading.CancellationTokenSource | Private |
| _windUpCancellationToken | System.Threading.CancellationTokenSource | Private |
| _fireRateTimer | System.Single | Private |
| _hoverBehaviour | WildSkies.AI.HoverBehaviour | Private |
| _spikes | System.Collections.Generic.List`1<AIProjectile> | Private |
| _isFiring | System.Boolean | Private |
| _inPosition | System.Boolean | Private |
| _delayAfterFireMilliseconds | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **Start()**: System.Void (Protected)
- **OnDisable()**: System.Void (Private)
- **OnDeath(UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **OnLostTarget()**: System.Void (Public)
- **OnTargetDeath()**: System.Void (Public)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **WindUp()**: System.Void (Private)
- **InPositionToAttack()**: System.Void (Public)
- **StartAttack()**: System.Void (Private)
- **Attack(UnityEngine.Vector3 position)**: System.Void (Public)
- **EndAttack()**: System.Void (Private)
- **WindUpTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **FireTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **Fire()**: System.Void (Private)
- **ClearParticleEffectOnComplete(ParticleSystemListener listener)**: System.Void (Private)
- **OnFixedUpdate()**: System.Void (Public)
- **Update()**: System.Void (Protected)
- **ClearPool()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

