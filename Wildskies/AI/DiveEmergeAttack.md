# WildSkies.AI.DiveEmergeAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _agent | WildSkies.AI.BossaGroundAgent | Private |
| _explosionHandler | ExplosionHandler | Private |
| _windUpParticles | UnityEngine.GameObject | Private |
| _ignoreColliders | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _data | WildSkies.AI.BurrowAttackData | Private |
| _burrowingBehaviour | WildSkies.AI.BurrowingBehaviour | Private |
| _emergeBehaviour | WildSkies.AI.EmergeBehaviour | Private |
| _cooldownCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| _windUpCancellationTokenSource | System.Threading.CancellationTokenSource | Private |
| _cooldownTimer | System.Single | Private |
| _windUpTimer | System.Single | Private |
| _targetParticlePosition | UnityEngine.Vector3 | Private |
| _windUpPosition | UnityEngine.Vector3 | Public |
| _windUpParticlesActive | System.Boolean | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **OnFixedUpdate()**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **StartWindUp()**: System.Void (Private)
- **OnBurrowComplete()**: System.Void (Private)
- **OnTargetDeath()**: System.Void (Public)
- **UndergroundWindUp()**: Cysharp.Threading.Tasks.UniTask (Private)
- **BurstFromGround()**: System.Void (Private)
- **Cooldown()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnEnd()**: System.Void (Private)
- **SyncWindUp(System.Boolean prev, System.Boolean cur)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

