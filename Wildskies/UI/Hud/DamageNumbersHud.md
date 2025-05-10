# Wildskies.UI.Hud.DamageNumbersHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Hud.DamageNumbersHudViewModel | Private |
| _payload | Wildskies.UI.Hud.DamageNumbersHudPayload | Private |
| _index | System.Int32 | Private |
| _damageNumberPool | Wildskies.UI.Hud.DamageNumbersHud/DamageNumber[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **AddDamageNumber(UnityEngine.Vector3 worldPoint, System.Single damageDisplay, WildSkies.Weapon.HitType hitType, System.Boolean forceShow)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **GetNext()**: Wildskies.UI.Hud.DamageNumbersHud/DamageNumber (Private)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

