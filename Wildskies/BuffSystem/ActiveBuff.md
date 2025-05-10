# WildSkies.BuffSystem.ActiveBuff

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| BuffDefinition | BuffDefinitionBase | Public |
| BuffEffects | BuffEffect[] | Public |
| TimeLeft | System.Single | Public |
| _stacks | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff/Stack> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| StackCount | System.Int32 | Public |
| Stacks | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff/Stack> | Public |

## Methods

- **get_StackCount()**: System.Int32 (Public)
- **get_Stacks()**: System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff/Stack> (Public)
- **.ctor(BuffDefinitionBase buff)**: System.Void (Public)
- **UpdateTimeLeft()**: System.Void (Public)
- **AddStack()**: System.Void (Public)
- **RemoveStack()**: System.Void (Public)
- **GetTotalDurationRemaining()**: System.Single (Public)
- **GetCurrentStackDuration()**: System.Single (Private)

