# WildSkies.AI.AIEntityHealth

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _aiLevelsService | WildSkies.Service.AILevelsService | Private |
| _aiEntity | WildSkies.Entities.AIEntity | Private |
| _level | System.Int32 | Private |
| _buffService | WildSkies.Service.BuffService | Private |
| _prevDamageAmount | System.Single | Private |
| _prevDamageType | WildSkies.Weapon.DamageType | Private |
| _prevDamageLevel | System.Int32 | Private |
| _spawnInvincibilityTime | System.Single | Private |
| _isInvincibleToImpactDamage | System.Boolean | Private |
| _hasWokenUp | System.Boolean | Private |
| _invincibilityCancellationToken | System.Threading.CancellationTokenSource | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| PrevDamageAmount | System.Single | Public |
| PrevDamageType | WildSkies.Weapon.DamageType | Public |
| PrevDamageLevel | System.Int32 | Public |
| IsInvincibleToImpactDamage | System.Boolean | Public |

## Methods

- **get_PrevDamageAmount()**: System.Single (Public)
- **get_PrevDamageType()**: WildSkies.Weapon.DamageType (Public)
- **get_PrevDamageLevel()**: System.Int32 (Public)
- **get_IsInvincibleToImpactDamage()**: System.Boolean (Public)
- **Init(WildSkies.Entities.AIEntity aiEntity, WildSkies.Service.AILevelsService aiLevelsService, System.Int32 level)**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **SetLevelHealth(System.Int32 health)**: System.Void (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: System.Single (Public)
- **AuthorityDamage(System.Single damage, System.Int32 type, System.Int32 srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint)**: System.Single (Protected)
- **DelayedInvincibility()**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)

