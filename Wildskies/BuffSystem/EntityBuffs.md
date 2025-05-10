# WildSkies.BuffSystem.EntityBuffs

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _buffSources | System.Collections.Generic.List`1<WildSkies.BuffSystem.IBuffSource> | Private |
| _buffsToRemove | System.Collections.Generic.List`1<BuffDefinitionBase> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| BuffSources | System.Collections.Generic.IReadOnlyCollection`1<WildSkies.BuffSystem.IBuffSource> | Public |

## Methods

- **get_BuffSources()**: System.Collections.Generic.IReadOnlyCollection`1<WildSkies.BuffSystem.IBuffSource> (Public)
- **AddBuffSource(WildSkies.BuffSystem.IBuffSource source)**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)
- **CountDownBuffs()**: System.Void (Private)
- **UpdateTickBuff(TickBuffDefinition tickBuff)**: System.Void (Private)
- **GetDamageTypeOverridesFromBuffs(System.Collections.Generic.List`1<WildSkies.Weapon.DamageTypeOverrides/DamageTypeOverride> damageTypeOverrides)**: System.Collections.Generic.List`1<WildSkies.Weapon.DamageTypeOverrides/DamageTypeOverride> (Public)
- **GetValueFromBuffs(WildSkies.BuffSystem.BuffType buffType, System.Single& additiveValue, System.Single& multiplierValue)**: System.Boolean (Public)
- **GetBuffSource()**: WildSkies.BuffSystem.IBuffSource (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

