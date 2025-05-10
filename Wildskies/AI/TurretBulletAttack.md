# WildSkies.AI.TurretBulletAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _recoilClip | UnityEngine.AnimationClip | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _turretShootData | WildSkies.AI.TurretShootData | Private |
| _bulletSource | UnityEngine.Transform | Private |
| _multipleBulletSources | UnityEngine.Transform[] | Private |
| _agentHeadTargeting | WildSkies.AI.AgentHeadTargeting | Private |
| _targeting | WildSkies.AI.AITargeting | Private |
| _turretLaser | AITurretLaser | Private |
| _memoryHandler | AIMemoryHandler | Private |
| _shipTracking | AIShipTracking | Private |
| _targetingAimSpeed | System.Single | Private |
| _genericImpactVfx | WildSkies.VfxType | Private |
| _impactVfxSize | WildSkies.VfxSize | Private |
| _shotFx | UnityEngine.ParticleSystem[] | Private |
| _agent | WildSkies.AI.BossaNavAgent | Private |
| _useMovmentBehaviourDuringAttack | System.Boolean | Private |
| _movementBehaviourType | MovementBehaviourTypes | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _currentBulletIndex | System.Int32 | Private |
| _aimTimer | System.Single | Private |
| _fireTimer | System.Single | Private |
| _cooldownTimer | System.Single | Private |
| _targetingTimeoutTimer | System.Single | Private |
| _isAiming | System.Boolean | Private |
| _isFiring | System.Boolean | Private |
| _bulletSourceId | System.Int32 | Private |
| _fireRateTask | Cysharp.Threading.Tasks.UniTask | Private |
| _fireRateCancellationToken | System.Threading.CancellationTokenSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |
| IsAiming | System.Boolean | Public |
| IsFiring | System.Boolean | Public |
| CanSeeTarget | System.Boolean | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **get_IsAiming()**: System.Boolean (Public)
- **get_IsFiring()**: System.Boolean (Public)
- **get_CanSeeTarget()**: System.Boolean (Public)
- **OnFixedUpdate()**: System.Void (Public)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **Attack(UnityEngine.Vector3 position)**: System.Void (Public)
- **EarlyComplete()**: System.Void (Private)
- **FireTask()**: Cysharp.Threading.Tasks.UniTask (Private)
- **OnInterrupted()**: System.Void (Protected)
- **BulletHit(UnityEngine.RaycastHit hitInfo)**: System.Void (Private)
- **OnShotResponse(WildSkies.Weapon.DamageResponse response)**: System.Void (Private)
- **Shoot(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction)**: Cysharp.Threading.Tasks.UniTask (Private)
- **TryGetTrackingTargetingPosition(UnityEngine.Vector3& targetPosition)**: System.Boolean (Private)
- **GetPredictedTargetPositionFromRigidbody(UnityEngine.Rigidbody targetRigidbody)**: UnityEngine.Vector3 (Private)
- **OnDeath(WildSkies.Entities.AIEntity entity, UnityEngine.Vector3 deathVelocity)**: System.Void (Public)
- **OnLostTarget()**: System.Void (Public)
- **OnTargetDeath()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

