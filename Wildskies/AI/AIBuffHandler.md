# WildSkies.AI.AIBuffHandler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _aiEntity | WildSkies.Entities.AIEntity | Private |
| _activeBuffs | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Stunnable | WildSkies.Entities.IEntityStunnable | Public |
| Movement | IEntityMovement | Public |
| ActiveBuffs | System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> | Public |

## Methods

- **get_Stunnable()**: WildSkies.Entities.IEntityStunnable (Public)
- **get_Movement()**: IEntityMovement (Public)
- **get_ActiveBuffs()**: System.Collections.Generic.List`1<WildSkies.BuffSystem.ActiveBuff> (Public)
- **Init(Bossa.Core.Entity.Entity aiEntity, WildSkies.Service.BuffService buffService)**: System.Void (Public)
- **OnBuffAdded(WildSkies.BuffSystem.ActiveBuff activeBuff)**: System.Void (Protected)
- **OnBuffRemoved(WildSkies.BuffSystem.ActiveBuff activeBuff)**: System.Void (Protected)
- **OnBuffsChanged()**: System.Void (Protected)
- **NetworkAddBuff(System.String buffName)**: System.Void (Public)
- **NetworkRemoveBuff(System.String buffName)**: System.Void (Public)
- **NetworkBuffChanged(System.String buffName, System.Single TimeLeft, System.Int32 StackCount)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

