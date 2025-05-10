# WildSkies.Puzzles.TargetShootingTarget

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _index | System.Int32 | Private |
| _owner | WildSkies.Puzzles.TargetShooting | Private |
| _idleObject | UnityEngine.GameObject | Private |
| _idleAnim | UnityEngine.Animator | Private |
| _brokenObject | UnityEngine.GameObject | Private |
| _brokenAnim | UnityEngine.Animator | Private |
| _colliderObject | UnityEngine.GameObject | Private |
| _brokenAnimEventReceiver | AnimatorEventReceiver | Private |
| _vfxController | UnityEngine.VFX.VisualEffect | Private |
| _damageTypeOverrides | WildSkies.Weapon.DamageTypeOverrideSettings | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **Init(WildSkies.Puzzles.TargetShooting targetShooting, System.Int32 index)**: System.Void (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **ResetToIdle()**: System.Void (Public)
- **TriggerHitAnim()**: System.Void (Public)
- **OnBrokenAnimEnded(UnityEngine.AnimationEvent animationEvent)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

