# WildSkies.TestScenes.CombatGym.CombatGymDamageDebugger

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _text | TMPro.TextMeshPro | Private |
| _timerText | TMPro.TextMeshPro | Private |
| _currentSubscribed | System.Collections.Generic.List`1<Utilities.Weapons.WeaponBase> | Private |
| _lastWeaponUsed | Utilities.Weapons.WeaponBase | Private |
| _accumilatedDamage | System.Single | Private |
| _timer | System.Single | Private |
| _startTime | System.Single | Private |
| _currentDPS | System.Single | Private |
| _currentAccuracy | System.Single | Private |
| _totalHits | System.Int32 | Private |
| _totalShots | System.Int32 | Private |
| _started | System.Boolean | Private |
| _reset | System.Boolean | Private |

## Methods

- **Update()**: System.Void (Private)
- **OnDamageResponse(WildSkies.Weapon.DamageResponse dr)**: System.Void (Private)
- **ResetTimer()**: System.Void (Public)
- **WaitForReset()**: System.Collections.IEnumerator (Private)
- **.ctor()**: System.Void (Public)

