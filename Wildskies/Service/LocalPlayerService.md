# WildSkies.Service.LocalPlayerService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <LocalPlayerRegistered>k__BackingField | System.Action | Private |
| <LocalPlayerUnRegistered>k__BackingField | System.Action | Private |
| _localPlayer | WildSkies.Player.LocalPlayer | Private |
| _localPlayerActive | System.Boolean | Private |
| _playerStomach | WildSkies.BuffSystem.Food.Stomach | Private |
| _cameraSwitch | CameraSwitch | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _staminaController | PlayerStaminaController | Private |
| _localPingController | PlayerPingController | Private |
| _tickBuffCount | System.Int32 | Private |
| _damageTypeOverridesList | System.Collections.Generic.List`1<WildSkies.Weapon.DamageTypeOverrides/DamageTypeOverride> | Private |
| <OnBuffStatChanged>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Private |
| <OnBuffsChanged>k__BackingField | System.Action`1<WildSkies.Entities.IBuffableEntity> | Private |
| <OnBuffAdded>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Private |
| <OnBuffRemoved>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Private |
| <OnBuffEffectAdded>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Private |
| <OnBuffEffectRemoved>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Private |
| <OnSetInitialResourceValues>k__BackingField | System.Action`1<WildSkies.Entities.IBuffableEntity> | Private |
| _activeBuffVFX | System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.PoolableVfx> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| LocalPlayerRegistered | System.Action | Public |
| LocalPlayerUnRegistered | System.Action | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| PlayerStomach | WildSkies.BuffSystem.Food.Stomach | Public |
| LocalPlayer | WildSkies.Player.ILocalPlayer | Public |
| LocalPlayerActive | System.Boolean | Public |
| CameraSwitch | CameraSwitch | Public |
| CameraManager | Bossa.Cinematika.CameraManager | Public |
| Health | WildSkies.Entities.Health.EntityHealth | Public |
| BaseStats | BaseStats | Public |
| Stunnable | WildSkies.Entities.IEntityStunnable | Public |
| Movement | IEntityMovement | Public |
| Transform | UnityEngine.Transform | Public |
| Entity | Bossa.Core.Entity.Entity | Public |
| Stamina | WildSkies.Entities.Stamina.EntityStamina | Public |
| HasTickBuff | System.Boolean | Public |
| ActiveBuffVFX | System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.PoolableVfx> | Public |
| StaminaController | PlayerStaminaController | Public |
| LocalPingController | PlayerPingController | Public |
| _hasTickBuff | System.Boolean | Private |
| OnBuffStatChanged | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffsChanged | System.Action`1<WildSkies.Entities.IBuffableEntity> | Public |
| OnBuffAdded | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Public |
| OnBuffRemoved | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Public |
| OnBuffEffectAdded | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffEffectRemoved | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnSetInitialResourceValues | System.Action`1<WildSkies.Entities.IBuffableEntity> | Public |

## Methods

- **get_LocalPlayerRegistered()**: System.Action (Public)
- **set_LocalPlayerRegistered(System.Action value)**: System.Void (Public)
- **get_LocalPlayerUnRegistered()**: System.Action (Public)
- **set_LocalPlayerUnRegistered(System.Action value)**: System.Void (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_PlayerStomach()**: WildSkies.BuffSystem.Food.Stomach (Public)
- **get_LocalPlayer()**: WildSkies.Player.ILocalPlayer (Public)
- **get_LocalPlayerActive()**: System.Boolean (Public)
- **get_CameraSwitch()**: CameraSwitch (Public)
- **get_CameraManager()**: Bossa.Cinematika.CameraManager (Public)
- **get_Health()**: WildSkies.Entities.Health.EntityHealth (Public)
- **get_BaseStats()**: BaseStats (Public)
- **get_Stunnable()**: WildSkies.Entities.IEntityStunnable (Public)
- **get_Movement()**: IEntityMovement (Public)
- **get_Transform()**: UnityEngine.Transform (Public)
- **get_Entity()**: Bossa.Core.Entity.Entity (Public)
- **get_Stamina()**: WildSkies.Entities.Stamina.EntityStamina (Public)
- **get_HasTickBuff()**: System.Boolean (Public)
- **get_ActiveBuffVFX()**: System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.PoolableVfx> (Public)
- **get_StaminaController()**: PlayerStaminaController (Public)
- **get_LocalPingController()**: PlayerPingController (Public)
- **get__hasTickBuff()**: System.Boolean (Private)
- **get_OnBuffStatChanged()**: System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> (Public)
- **set_OnBuffStatChanged(System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> value)**: System.Void (Public)
- **get_OnBuffsChanged()**: System.Action`1<WildSkies.Entities.IBuffableEntity> (Public)
- **set_OnBuffsChanged(System.Action`1<WildSkies.Entities.IBuffableEntity> value)**: System.Void (Public)
- **get_OnBuffAdded()**: System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> (Public)
- **set_OnBuffAdded(System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> value)**: System.Void (Public)
- **get_OnBuffRemoved()**: System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> (Public)
- **set_OnBuffRemoved(System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> value)**: System.Void (Public)
- **get_OnBuffEffectAdded()**: System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> (Public)
- **set_OnBuffEffectAdded(System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> value)**: System.Void (Public)
- **get_OnBuffEffectRemoved()**: System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> (Public)
- **set_OnBuffEffectRemoved(System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> value)**: System.Void (Public)
- **get_OnSetInitialResourceValues()**: System.Action`1<WildSkies.Entities.IBuffableEntity> (Public)
- **set_OnSetInitialResourceValues(System.Action`1<WildSkies.Entities.IBuffableEntity> value)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RegisterLocalPlayer(WildSkies.Player.ILocalPlayer localPlayer)**: System.Void (Public)
- **AdjustStatValue(BuffEffect buffEffect)**: System.Void (Public)
- **OnTickBuffAdded()**: System.Void (Private)
- **OnTickBuffRemoved()**: System.Void (Private)
- **BuffAdded(WildSkies.BuffSystem.ActiveBuff activeBuff)**: System.Void (Private)
- **BuffRemoved(WildSkies.BuffSystem.ActiveBuff activeBuff)**: System.Void (Private)
- **CalculateBuffedStats()**: System.Void (Protected)
- **OnEntityDeath()**: System.Void (Private)
- **UnregisterPlayer(WildSkies.Player.ILocalPlayer localPlayer)**: System.Void (Public)
- **GetCostMultiplierForAction(StaminaActionType type)**: System.Single (Public)
- **Update()**: System.Void (Public)
- **SetInitialResourceValues()**: System.Void (Private)
- **UpdateCurrentResourceData()**: System.Void (Private)
- **OnEquipItem(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Public)
- **OnUnequipItem(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Public)
- **IgnoreCollisionWithPlayer(UnityEngine.Collider colliderToIgnore, System.Boolean ignoreCollision)**: System.Void (Public)
- **OverrideBaseMaxStamina(System.Int32 amount)**: System.Void (Public)
- **SetInvincible(System.Boolean value)**: System.Void (Public)
- **OverrideBaseMaxHealth(System.Int32 amount)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

