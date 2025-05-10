# WildSkies.Puzzles.DamageableSwitch

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <DamageTypeOverrides>k__BackingField | WildSkies.Weapon.DamageTypeOverrides | Private |
| _switch | WildSkies.Puzzles.Switch | Private |
| _stateChangeDelay | System.Single | Private |
| _inStateChange | System.Boolean | Private |
| _timer | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |
| ShouldGrappleDisconnect | System.Boolean | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **get_ShouldGrappleDisconnect()**: System.Boolean (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **Update()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

