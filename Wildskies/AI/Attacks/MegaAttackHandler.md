# WildSkies.AI.Attacks.MegaAttackHandler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _attacks | WildSkies.AI.Attacks.AIAttack[] | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _rigidbody | UnityEngine.Rigidbody | Private |
| ActiveAttackIndex | System.Int32 | Public |
| _attackTypeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.AI.Attacks.AIAttackType,AttackTokenHandler/AttackTokenType> | Private |
| _events | AIEvents | Private |

## Methods

- **Start()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **SetUp(WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.DisposalService disposalService)**: System.Void (Public)
- **InitAttacks()**: System.Void (Private)
- **SetActiveAttack(System.Int32 attackIndex)**: System.Void (Public)
- **SetActiveAttack(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Void (Public)
- **SetAttackTarget(UnityEngine.Transform target, WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType attackTargetType)**: System.Void (Public)
- **GetAttackIndex(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Int32 (Private)
- **GetActiveAttack()**: WildSkies.AI.Attacks.AIAttack (Public)
- **GetAttackMaxDistance(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Single (Public)
- **GetAttackState(WildSkies.AI.Attacks.AIAttackType aIAttackType, WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

