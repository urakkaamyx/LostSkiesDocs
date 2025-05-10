# WildSkies.Weapon.WeaponProfile

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| WeaponLevel | System.Int32 | Public |
| AmmoType | WildSkies.Gameplay.Items.ItemDefinition | Public |
| InputFireType | WildSkies.Weapon.InputFireType | Public |
| DamageMethod | WildSkies.Weapon.DamageMethod | Public |
| DamageType | WildSkies.Weapon.DamageType | Public |
| CollisionLayerMask | UnityEngine.LayerMask | Public |
| Damage | System.Single | Public |
| MaxDamage | System.Single | Public |
| RPM | System.Single | Public |
| MaxRPM | System.Single | Public |
| ClipSize | System.Int32 | Public |
| MaxClipSize | System.Int32 | Public |
| ReloadTimeInSeconds | System.Single | Public |
| MaxReloadTimeInSeconds | System.Single | Public |
| MaxRange | System.Single | Public |
| MaximalMaxRange | System.Single | Public |
| BackToIdleTime | System.Single | Public |
| BurstCount | System.Int32 | Public |
| BurstRate | System.Single | Public |
| PalletCount | System.Int32 | Public |
| IsMobileWeapon | System.Boolean | Public |
| Spread | UnityEngine.Vector2 | Public |
| SpreadMoving | UnityEngine.Vector2 | Public |
| SpreadADS | UnityEngine.Vector2 | Public |
| SpreadADSMoving | UnityEngine.Vector2 | Public |
| SpreadAddedPerShot | UnityEngine.Vector2 | Public |
| MaxShootingSpread | UnityEngine.Vector2 | Public |
| SpreadChangeSpeed | System.Single | Public |
| SpreadResetTime | System.Single | Public |
| MaxSpreadCalculated | UnityEngine.Vector2 | Public |
| Recoil | WildSkies.Camera.DynamikaCameraRecoil/RecoilData | Public |
| CameraImpulseStrength | System.Single | Public |
| ImpulseSpringSettings | Bossa.Cinematika.Impulses.ImpulseSpring | Public |
| HasDamageFalloff | System.Boolean | Public |
| DamageAtFurthestDistance | System.Single | Public |
| DistanceFallOffStart | System.Single | Public |
| DistanceFallOffEnd | System.Single | Public |
| KickbackImpulse | System.Single | Public |
| MovementPenaltyWhileFiringOrAds | System.Single | Public |
| MovementPenaltyWhileEquipped | System.Single | Public |
| FovChangeOnAds | System.Single | Public |
| AdsSensitivityModifier | UnityEngine.Vector2 | Public |
| HitPhysicsImpulse | System.Single | Public |
| ProjectileTravelSpeed | System.Single | Public |
| ProjectileDropAmount | System.Single | Public |
| ProjectileDropStartDistance | System.Single | Public |
| _damageString | UnityEngine.Localization.LocalizedString | Private |
| _rpmString | UnityEngine.Localization.LocalizedString | Private |
| _clipSizeString | UnityEngine.Localization.LocalizedString | Private |
| _reloadTimeString | UnityEngine.Localization.LocalizedString | Private |
| _maxRangeString | UnityEngine.Localization.LocalizedString | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| HasBurst | System.Boolean | Public |
| IsShotgun | System.Boolean | Public |

## Methods

- **get_HasBurst()**: System.Boolean (Public)
- **get_IsShotgun()**: System.Boolean (Public)
- **GetLocalizedStringFromVariableName(System.String variableName)**: UnityEngine.Localization.LocalizedString (Public)
- **GetItemParameters()**: System.Collections.Generic.List`1<System.ValueTuple`4<UnityEngine.Localization.LocalizedString,System.String,System.Single,System.Single>> (Public)
- **GetStatData(System.String statVariableName)**: WildSkies.Weapon.StatData (Public)
- **.ctor()**: System.Void (Public)

