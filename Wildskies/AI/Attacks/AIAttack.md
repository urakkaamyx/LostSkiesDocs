# WildSkies.AI.Attacks.AIAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _rigidbody | UnityEngine.Rigidbody | Protected |
| _entity | Bossa.Core.Entity.Entity | Protected |
| _attackTokenType | AttackTokenHandler/AttackTokenType | Protected |
| <Events>k__BackingField | AIEvents | Private |
| _state | WildSkies.AI.Attacks.AIAttack/AttackState | Protected |
| _animation | AgentAnimation | Protected |
| _attackHandler | WildSkies.AI.Attacks.AttackHandlerBase | Private |
| <AttackDamageOverride>k__BackingField | System.Int32 | Private |
| _maxAttackDistance | System.Single | Protected |
| _sensedCollidersForAttack | System.Collections.Generic.List`1<UnityEngine.Collider> | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |
| State | WildSkies.AI.Attacks.AIAttack/AttackState | Public |
| AttackIsActive | System.Boolean | Public |
| Events | AIEvents | Public |
| MaxAttackDistance | System.Single | Public |
| AttackDamage | System.Int32 | Public |
| AttackTokenType | AttackTokenHandler/AttackTokenType | Public |
| _target | UnityEngine.Transform | Private |
| _targetType | WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _disposalService | WildSkies.Service.DisposalService | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| CurrentLODLevel | System.Int32 | Private |
| AttackDamageOverride | System.Int32 | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **get_State()**: WildSkies.AI.Attacks.AIAttack/AttackState (Public)
- **get_AttackIsActive()**: System.Boolean (Public)
- **get_Events()**: AIEvents (Public)
- **set_Events(AIEvents value)**: System.Void (Private)
- **get_MaxAttackDistance()**: System.Single (Public)
- **get_AttackDamage()**: System.Int32 (Public)
- **get_AttackTokenType()**: AttackTokenHandler/AttackTokenType (Public)
- **get__target()**: UnityEngine.Transform (Protected)
- **get__targetType()**: WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType (Protected)
- **get__instantiationService()**: WildSkies.Service.WildSkiesInstantiationService (Protected)
- **get__disposalService()**: WildSkies.Service.DisposalService (Protected)
- **get__cameraImpulseService()**: WildSkies.Service.CameraImpulseService (Protected)
- **get__colliderLookupService()**: WildSkies.Service.Interface.ColliderLookupService (Protected)
- **get__aiLevelsService()**: WildSkies.Service.AILevelsService (Protected)
- **get_CurrentLODLevel()**: System.Int32 (Protected)
- **get_AttackDamageOverride()**: System.Int32 (Public)
- **set_AttackDamageOverride(System.Int32 value)**: System.Void (Public)
- **Start()**: System.Void (Protected)
- **OnDestroy()**: System.Void (Protected)
- **OnFixedUpdate()**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)
- **SetAttackDamageOverride(System.Int32 value)**: System.Void (Public)
- **OnLostTarget()**: System.Void (Public)
- **OnTargetDeath()**: System.Void (Public)
- **OnDeath(WildSkies.Entities.AIEntity entity, UnityEngine.Vector3 deathVelocity)**: System.Void (Public)
- **OnAttackHitPlayer()**: System.Void (Public)
- **OnAttackMiss()**: System.Void (Public)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **OnInterrupted()**: System.Void (Protected)
- **OnStunEnded()**: System.Void (Protected)
- **Init(WildSkies.AI.Attacks.AttackHandlerBase attackHandler, AgentAnimation animation, UnityEngine.Rigidbody rigidbody, AIEvents events)**: System.Void (Public)
- **TryDamageObject(UnityEngine.GameObject obj, Micosmo.SensorToolkit.Sensor sensor, System.Single hitDamage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel)**: System.Boolean (Protected)
- **TryDamageObject(UnityEngine.GameObject obj, System.Single hitDamage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel)**: System.Boolean (Protected)
- **DoShakeCamera(System.Single shakeMagnitude, System.Single shakeDecay)**: System.Void (Public)
- **DoCameraRumble(System.Single time, System.Single magnitude, System.Single damping)**: System.Void (Public)
- **.ctor()**: System.Void (Protected)

