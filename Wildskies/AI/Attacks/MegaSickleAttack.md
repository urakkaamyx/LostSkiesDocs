# WildSkies.AI.Attacks.MegaSickleAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _megaLogic | WildSkies.Enemies.MegaLogic | Private |
| _sickleAttack | WildSkies.Enemies.SickleAttackLogic | Private |
| _debugState | WildSkies.AI.Attacks.AIAttack/AttackState | Private |
| _active | System.Boolean | Private |
| _stateStartTime | System.Single | Private |
| _currentCooldown | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **Start()**: System.Void (Protected)
- **OnDestroy()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **Update()**: System.Void (Protected)
- **Cooldown()**: System.Void (Private)
- **OnFixedUpdate()**: System.Void (Public)
- **AimAt_target()**: System.Void (Private)
- **OnSickleFired()**: System.Void (Private)
- **OnSickleAttackEnd()**: System.Void (Private)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

