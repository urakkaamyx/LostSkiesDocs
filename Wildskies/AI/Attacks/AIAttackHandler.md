# WildSkies.AI.Attacks.AIAttackHandler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _attacks | WildSkies.AI.Attacks.AIAttack[] | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _animation | AgentAnimation | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| ActiveAttackIndex | System.Int32 | Public |
| _events | AIEvents | Private |
| _attackDamageOverrides | System.Int32[] | Private |
| _attackTypeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttackType,AttackTokenHandler/AttackTokenType> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ActiveAttack | WildSkies.AI.Attacks.AIAttack | Public |
| AttackCount | System.Int32 | Public |
| AttackTypeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttackType,AttackTokenHandler/AttackTokenType> | Public |

## Methods

- **get_ActiveAttack()**: WildSkies.AI.Attacks.AIAttack (Public)
- **get_AttackCount()**: System.Int32 (Public)
- **get_AttackTypeDictionary()**: System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttackType,AttackTokenHandler/AttackTokenType> (Public)
- **OnDisable()**: System.Void (Private)
- **SetUp(WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.DisposalService disposalService, AIEvents events, WildSkies.Service.CameraImpulseService cameraManager, WildSkies.Service.Interface.ColliderLookupService colliderLookupService, WildSkies.Service.AILevelsService aiLevelsService)**: System.Void (Public)
- **FixedUpdate()**: System.Void (Protected)
- **SetAttackDamageOverride(System.Int32 attackIndex, System.Int32 value)**: System.Void (Public)
- **SetActiveAttack(System.Int32 attackIndex)**: System.Void (Public)
- **SetActiveAttackState(WildSkies.AI.Attacks.AIAttack/AttackState attackState)**: System.Void (Public)
- **SetAttackTarget(UnityEngine.Transform target, WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType targetType)**: System.Void (Public)
- **InitAttacks()**: System.Void (Public)
- **SetActiveAttack(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Void (Public)
- **GetAttackIndex(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Int32 (Private)
- **GetAttackState(WildSkies.AI.Attacks.AIAttackType aIAttackType, WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Boolean (Public)
- **OnTargetDeath(UnityEngine.Vector3 deathVelocity)**: System.Void (Private)
- **OnTargetDeath()**: System.Void (Private)
- **GetActiveAttack()**: WildSkies.AI.Attacks.AIAttack (Public)
- **GetAttackMaxDistance(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Single (Public)
- **.ctor()**: System.Void (Public)

