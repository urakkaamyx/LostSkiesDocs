# WildSkies.BuffSystem.TickBuffEffect

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _tickRate | System.Single | Private |
| _timeSinceLastTick | System.Single | Private |
| _buffDefinition | TickBuffDefinition | Private |
| _callback | System.Action`1<BuffEffect> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| TickRate | System.Single | Public |

## Methods

- **get_TickRate()**: System.Single (Public)
- **Initialise(TickBuffDefinition tickBuff, System.Action`1<BuffEffect> callback)**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)
- **Tick()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

