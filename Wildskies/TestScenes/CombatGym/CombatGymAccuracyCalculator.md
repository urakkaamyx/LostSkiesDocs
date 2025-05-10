# WildSkies.TestScenes.CombatGym.CombatGymAccuracyCalculator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <DamageTypeOverrides>k__BackingField | WildSkies.Weapon.DamageTypeOverrides | Private |
| _localPlayerServices | WildSkies.Service.ILocalPlayerService | Private |
| _hitPrefab | UnityEngine.GameObject | Private |
| _ranges | System.Collections.Generic.List`1<UnityEngine.Transform> | Private |
| _hits | System.Collections.Generic.List`1<UnityEngine.GameObject> | Private |
| _lastSpread | UnityEngine.Vector2 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **CleanUp()**: System.Void (Public)
- **SetRange(System.Int32 index)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

