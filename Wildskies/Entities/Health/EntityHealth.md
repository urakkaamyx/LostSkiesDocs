# WildSkies.Entities.Health.EntityHealth

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _entityRendererService | EntityRendererService | Private |
| _cameraImpulseService | WildSkies.Service.CameraImpulseService | Protected |
| _entity | Bossa.Core.Entity.Entity | Protected |
| _entityRendererController | EntityRendererController | Private |
| _minDamageToRegister | System.Single | Protected |
| _minImpactDamageToRegister | System.Single | Protected |
| _lastDamageAmount | System.Single | Private |
| _currentRegenDelayTimer | System.Single | Private |
| EntityDamaged | System.Action`6<System.Single,WildSkies.Weapon.DamageType,WildSkies.Weapon.DamageSrcObjectType,System.Int32,UnityEngine.Vector3,System.Single> | Public |
| OnEntityHealed | System.Action`1<System.Int32> | Public |
| _impulseOnKill | System.Boolean | Private |
| _impulseSpringOnKill | Bossa.Cinematika.Impulses.ImpulseSpring | Private |
| _impulseStrengthOnKill | System.Single | Private |
| _buffDamageOverridesList | System.Collections.Generic.List`1<WildSkies.Weapon.DamageTypeOverrides/DamageTypeOverride> | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| HasAuthority | System.Boolean | Public |
| CurrentRegenDelayTimer | System.Single | Public |

## Methods

- **get_HasAuthority()**: System.Boolean (Public)
- **get_CurrentRegenDelayTimer()**: System.Single (Public)
- **SetEntityReference(Bossa.Core.Entity.Entity entity)**: System.Void (Public)
- **SetEntityRendererControllerReference(EntityRendererController entityRendererController)**: System.Void (Public)
- **Debug_ApplyDamage()**: System.Void (Private)
- **Debug_Heal()**: System.Void (Private)
- **Awake()**: System.Void (Protected)
- **SetBaseValues(BaseStats stats)**: System.Void (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: System.Single (Public)
- **DealDamage(System.Single damage, System.Int32 type, System.Int32 srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint)**: System.Void (Public)
- **AuthorityDamage(System.Single damage, System.Int32 type, System.Int32 srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint)**: System.Single (Protected)
- **NonAuthorityDamage(System.Single damage)**: System.Single (Protected)
- **Heal(System.Int32 amount)**: System.Void (Public)
- **HealDamage(System.Int32 amount)**: System.Void (Public)
- **AuthorityHeal(System.Int32 amount)**: System.Void (Private)
- **NonAuthorityHeal(System.Int32 amount)**: System.Void (Private)
- **SetDamageTypeOverrides(System.Collections.Generic.List`1<WildSkies.Weapon.DamageTypeOverrides/DamageTypeOverride> damageTypeOverrides)**: System.Void (Public)
- **AdjustCurrentValue(System.Single value)**: System.Void (Public)
- **SetCurrentValue(System.Single value)**: System.Void (Public)
- **ApplyMaxDamage()**: System.Void (Public)
- **SetBaseHealthRegen(System.Single value)**: System.Void (Public)
- **SetBaseRegenDelay(System.Single value)**: System.Void (Public)
- **UpdateRegenDelayTimer()**: System.Void (Public)
- **RestoreMaxHealth()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

