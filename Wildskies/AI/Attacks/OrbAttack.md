# WildSkies.AI.Attacks.OrbAttack

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _skyBossLogic | WildSkies.Enemies.SkyBoss | Private |
| _orbAttackLogic | OrbAttackLogic | Private |
| _debugState | WildSkies.AI.Attacks.AIAttack/AttackState | Private |
| _drawDebugLabel | System.Boolean | Private |
| _debugLabelOffset | UnityEngine.Vector3 | Private |
| _cooldownTimerMultiplier | System.Single | Private |
| _cooldownTimer | System.Single | Private |
| _windupTimer | System.Single | Private |
| _attackDisabled | System.Boolean | Private |
| _vfxService | WildSkies.Service.VfxPoolService | Private |
| _audioService | WildSkies.Service.AudioService | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| OrbAttackLogic | OrbAttackLogic | Public |
| AttackDisabled | System.Boolean | Public |
| Type | WildSkies.AI.Attacks.AIAttackType | Public |
| GlobalCooldown | System.Single | Public |

## Methods

- **get_OrbAttackLogic()**: OrbAttackLogic (Public)
- **get_AttackDisabled()**: System.Boolean (Public)
- **get_Type()**: WildSkies.AI.Attacks.AIAttackType (Public)
- **get_GlobalCooldown()**: System.Single (Public)
- **Start()**: System.Void (Protected)
- **OnDestroy()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **ToggleAttack(System.Boolean value)**: System.Void (Public)
- **DisableAttack()**: System.Void (Public)
- **OnFixedUpdate()**: System.Void (Public)
- **Update()**: System.Void (Protected)
- **Windup()**: System.Void (Private)
- **Cooldown()**: System.Void (Private)
- **ShipEnteredRange(WildSkies.Gameplay.ShipBuilding.ConstructedShipController target)**: System.Void (Private)
- **OnOrbsFired()**: System.Void (Private)
- **WindupOrbAttack(System.Boolean resetCooldown)**: System.Void (Public)
- **PerformOrbAttack(System.Boolean resetCooldown)**: System.Void (Public)
- **PickNextOrbAttack()**: System.Void (Public)
- **MoveOrbsIntoPosition()**: System.Void (Private)
- **ResetCooldown()**: System.Void (Private)
- **ResetGlobalCooldown()**: System.Void (Public)
- **ResetSelectedAttack()**: System.Void (Private)
- **PlayWindupFx()**: System.Void (Private)
- **SetAttackState(WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

