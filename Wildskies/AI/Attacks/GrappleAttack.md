# WildSkies.AI.Attacks.GrappleAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _enemyGrapple | WildSkies.AI.Attacks.EnemyGrapple | Private |
| _maxAltitude | System.Single | Private |
| _maxAttackTime | System.Single | Private |
| _damageOnGrapple | System.Single | Private |
| _navAgent | WildSkies.AI.BossaNavAgent | Private |
| _ascendSpeed | System.Single | Private |
| _orbitRadius | System.Single | Private |
| _endGrappleTime | System.Single | Private |
| _circleUpwards | WildSkies.AI.CircleUpwards | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **Start()**: System.Void (Protected)
- **OnFixedUpdate()**: System.Void (Public)
- **Attack(UnityEngine.Vector3 position)**: System.Void (Public)
- **OnLostTarget()**: System.Void (Public)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **StartGrapple()**: System.Void (Private)
- **EndGrapple()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

