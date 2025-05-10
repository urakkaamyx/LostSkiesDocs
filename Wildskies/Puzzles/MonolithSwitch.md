# WildSkies.Puzzles.MonolithSwitch

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _damageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Private |
| _materialInactive | UnityEngine.Material | Private |
| _materialIncorrectAngle | UnityEngine.Material | Private |
| _materialCorrectAngle | UnityEngine.Material | Private |
| _renderers | UnityEngine.Renderer[] | Private |
| _rotatingSubObject | UnityEngine.GameObject | Private |
| _targetAngleVisualiser | UnityEngine.GameObject | Private |
| _index | System.Int32 | Private |
| _owner | WildSkies.Puzzles.MonolithPuzzle | Private |
| _dirty | System.Boolean | Private |
| _correctAngle | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| DamageTypeOverrides | WildSkies.Weapon.DamageTypeOverrides | Public |
| RotatingSubObject | UnityEngine.GameObject | Public |
| TargetAngleVisualiser | UnityEngine.GameObject | Public |
| CorrectAngle | System.Boolean | Public |

## Methods

- **get_DamageTypeOverrides()**: WildSkies.Weapon.DamageTypeOverrides (Public)
- **get_RotatingSubObject()**: UnityEngine.GameObject (Public)
- **get_TargetAngleVisualiser()**: UnityEngine.GameObject (Public)
- **get_CorrectAngle()**: System.Boolean (Public)
- **set_CorrectAngle(System.Boolean value)**: System.Void (Public)
- **Damage(System.Single damage, WildSkies.Weapon.DamageType type, WildSkies.Weapon.DamageSrcObjectType srcObjectType, System.Int32 srcObjectUpgradeLevel, UnityEngine.Vector3 damagePoint, System.Int32 damageLevel)**: WildSkies.Weapon.DamageResponse (Public)
- **Init(WildSkies.Puzzles.MonolithPuzzle monolithPuzzle, System.Int32 index)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

