# WildSkies.Entities.Health.EntityHealthDamageComponent

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _vfxType | WildSkies.VfxType | Private |
| _damageTypeSettings | WildSkies.Weapon.DamageTypeOverrideSettings | Private |
| _multiplier | System.Single | Private |
| _entityHealth | WildSkies.Entities.Health.EntityHealth | Private |
| _entityDeathHandling | EntityDeathHandling | Private |
| _playerDeathHandling | PlayerDeathHandling | Private |
| _repairableEntity | RepairableEntity | Private |
| _invincibilityToggle | EntityHealthComponentInvincibilityToggle | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |
| Multiplier | System.Single | Public |
| EntityDeathHandling | EntityDeathHandling | Public |
| PlayerDeathHandling | PlayerDeathHandling | Public |
| InvincibilityToggle | EntityHealthComponentInvincibilityToggle | Public |
| IsRepairable | System.Boolean | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **get_Multiplier()**: System.Single (Public)
- **get_EntityDeathHandling()**: EntityDeathHandling (Public)
- **get_PlayerDeathHandling()**: PlayerDeathHandling (Public)
- **get_InvincibilityToggle()**: EntityHealthComponentInvincibilityToggle (Public)
- **get_IsRepairable()**: System.Boolean (Public)
- **Start()**: System.Void (Private)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **SetMultiplier(System.Single multiplier)**: System.Void (Public)
- **RepairDamage(System.Int32 amount)**: RepairState (Public)
- **AimAtRepairable()**: System.Void (Public)
- **StopAimingAtRepairable()**: System.Void (Public)
- **StartRepair()**: System.Void (Public)
- **EndRepair()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

