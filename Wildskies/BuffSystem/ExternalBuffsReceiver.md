# WildSkies.BuffSystem.ExternalBuffsReceiver

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _activeBuffDictionary | System.Collections.Generic.Dictionary`2<BuffDefinitionBase,WildSkies.BuffSystem.ActiveBuff> | Private |
| _activeBuffsList | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> | Public |
| OnBuffAdded | System.Action`1<WildSkies.BuffSystem.ActiveBuff> | Public |
| OnBuffRemoved | System.Action`1<WildSkies.BuffSystem.ActiveBuff> | Public |
| OnStackCountChanged | System.Action`1<WildSkies.BuffSystem.ActiveBuff> | Public |
| OnBuffsChanged | System.Action | Public |
| OnBuffTick | System.Action`1<BuffEffect> | Public |
| OnTickBuffAdded | System.Action | Public |
| OnTickBuffRemoved | System.Action | Public |
| _currentActiveBuffsAux | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| HasAnyBuffs | System.Boolean | Public |
| ActiveBuffDictionary | System.Collections.Generic.Dictionary`2<BuffDefinitionBase,WildSkies.BuffSystem.ActiveBuff> | Public |
| ActiveBuffsList | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> | Public |

## Methods

- **get_HasAnyBuffs()**: System.Boolean (Public)
- **get_ActiveBuffDictionary()**: System.Collections.Generic.Dictionary`2<BuffDefinitionBase,WildSkies.BuffSystem.ActiveBuff> (Public)
- **get_ActiveBuffsList()**: System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> (Public)
- **GetActiveBuffs()**: System.Collections.Generic.IReadOnlyCollection`1<WildSkies.BuffSystem.ActiveBuff> (Public)
- **TryAddBuff(BuffDefinitionBase buffDefinitionBase, WildSkies.BuffSystem.ActiveBuff& activeBuff)**: System.Boolean (Public)
- **AddBuff(BuffDefinitionBase buff)**: WildSkies.BuffSystem.ActiveBuff (Public)
- **RemoveBuff(BuffDefinitionBase buff)**: System.Void (Public)
- **HasBuff(BuffDefinitionBase buff)**: System.Boolean (Public)
- **RenewBuff(BuffDefinitionBase buff)**: System.Void (Private)
- **AddStack(BuffDefinitionBase buff)**: System.Void (Private)
- **CheckBuffForConversion(BuffDefinitionBase buff)**: System.Void (Private)
- **RemoveStack(BuffDefinitionBase buff)**: System.Void (Public)
- **OverrideBuffCountdown(BuffDefinitionBase buff, System.Single deductionPerSecond)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

