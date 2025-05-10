# WildSkies.AI.Attacks.SkyBossTurretAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _skyBossLogic | WildSkies.Enemies.SkyBoss | Private |
| _turretData | MegaTurretData | Private |
| _currentHeightDifference | System.Single | Private |
| _currentSideAngle | System.Single | Private |
| _matchAttackCriteria | System.Boolean | Private |
| _inCooldown | System.Boolean | Private |
| _inAttack | System.Boolean | Private |
| _currentCooldown | System.Single | Private |
| _currentAttackDuration | System.Single | Private |
| _turrets | System.Collections.Generic.List`1<MegaTurret> | Private |
| _debugState | WildSkies.AI.Attacks.AIAttack/AttackState | Private |
| _attackDisabled | System.Boolean | Private |
| _debugLabelOffset | UnityEngine.Vector3 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | WildSkies.AI.Attacks.AIAttackType | Public |

## Methods

- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **AddTurret(MegaTurret turret)**: System.Void (Public)
- **Init(WildSkies.AI.Attacks.AttackHandlerBase attackHandler, AgentAnimation animation, UnityEngine.Rigidbody rigidbody, AIEvents events)**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **ToggleAttack(System.Boolean value)**: System.Void (Public)
- **Start()**: System.Void (Protected)
- **OnFixedUpdate()**: System.Void (Public)
- **Update()**: System.Void (Protected)
- **SetTurretData(MegaTurretData turretData)**: System.Void (Public)
- **UpdateHeightDifference()**: System.Void (Private)
- **UpdateSideAngle()**: System.Void (Private)
- **MatchAttackCriteria()**: System.Boolean (Public)
- **UpdateDuration()**: System.Void (Private)
- **UpdateCooldown()**: System.Void (Private)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **ToggleTurrests(System.Boolean value)**: System.Void (Private)
- **ResetAttackTimer()**: System.Void (Private)
- **ResetCooldown()**: System.Void (Private)
- **SendNetworkedWindupStart(MegaTurret turret)**: System.Void (Public)
- **ReceiveNetworkWindupStart(System.Int32 turretId)**: System.Void (Public)
- **SendNetworkedWindupStop(MegaTurret turret)**: System.Void (Public)
- **ReceiveNetworkWindupStop(System.Int32 turretId)**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **IsShipToRight()**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

