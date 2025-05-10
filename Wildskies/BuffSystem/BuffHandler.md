# WildSkies.BuffSystem.BuffHandler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _entity | Bossa.Core.Entity.Entity | Protected |
| _tickBuffCount | System.Int32 | Private |
| _activeBuffVFX | System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.PoolableVfx> | Private |
| _buffService | WildSkies.Service.BuffService | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| Health | WildSkies.Entities.Health.EntityHealth | Public |
| Stamina | WildSkies.Entities.Stamina.EntityStamina | Public |
| BaseStats | BaseStats | Public |
| Stunnable | WildSkies.Entities.IEntityStunnable | Public |
| Movement | IEntityMovement | Public |
| Transform | UnityEngine.Transform | Public |
| Entity | Bossa.Core.Entity.Entity | Public |
| HasTickBuff | System.Boolean | Public |
| ActiveBuffVFX | System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.PoolableVfx> | Public |
| _hasTickBuff | System.Boolean | Private |

## Methods

- **get_Health()**: WildSkies.Entities.Health.EntityHealth (Public)
- **get_Stamina()**: WildSkies.Entities.Stamina.EntityStamina (Public)
- **get_BaseStats()**: BaseStats (Public)
- **get_Stunnable()**: WildSkies.Entities.IEntityStunnable (Public)
- **get_Movement()**: IEntityMovement (Public)
- **get_Transform()**: UnityEngine.Transform (Public)
- **get_Entity()**: Bossa.Core.Entity.Entity (Public)
- **get_HasTickBuff()**: System.Boolean (Public)
- **get_ActiveBuffVFX()**: System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.PoolableVfx> (Public)
- **get__hasTickBuff()**: System.Boolean (Private)
- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Protected)
- **Init(Bossa.Core.Entity.Entity entity, WildSkies.Service.BuffService buffService)**: System.Void (Public)
- **OnBuffTick(BuffEffect buffEffect)**: System.Void (Protected)
- **CalculateBuffedStats()**: System.Void (Protected)
- **OnBuffAdded(WildSkies.BuffSystem.ActiveBuff activeBuff)**: System.Void (Protected)
- **OnBuffRemoved(WildSkies.BuffSystem.ActiveBuff activeBuff)**: System.Void (Protected)
- **OnBuffsChanged()**: System.Void (Protected)
- **OnTickBuffAdded()**: System.Void (Private)
- **OnTickBuffRemoved()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

