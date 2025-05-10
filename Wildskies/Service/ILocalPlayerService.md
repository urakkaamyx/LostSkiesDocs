# WildSkies.Service.ILocalPlayerService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| LocalPlayer | WildSkies.Player.ILocalPlayer | Public |
| PlayerStomach | WildSkies.BuffSystem.Food.Stomach | Public |
| LocalPlayerActive | System.Boolean | Public |
| LocalPlayerRegistered | System.Action | Public |
| LocalPlayerUnRegistered | System.Action | Public |
| CameraManager | Bossa.Cinematika.CameraManager | Public |
| CameraSwitch | CameraSwitch | Public |
| StaminaController | PlayerStaminaController | Public |
| LocalPingController | PlayerPingController | Public |
| OnBuffStatChanged | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffsChanged | System.Action`1<WildSkies.Entities.IBuffableEntity> | Public |
| OnBuffAdded | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Public |
| OnBuffRemoved | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Public |
| OnBuffEffectAdded | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffEffectRemoved | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnSetInitialResourceValues | System.Action`1<WildSkies.Entities.IBuffableEntity> | Public |

## Methods

- **get_LocalPlayer()**: WildSkies.Player.ILocalPlayer (Public)
- **get_PlayerStomach()**: WildSkies.BuffSystem.Food.Stomach (Public)
- **get_LocalPlayerActive()**: System.Boolean (Public)
- **get_LocalPlayerRegistered()**: System.Action (Public)
- **set_LocalPlayerRegistered(System.Action value)**: System.Void (Public)
- **get_LocalPlayerUnRegistered()**: System.Action (Public)
- **set_LocalPlayerUnRegistered(System.Action value)**: System.Void (Public)
- **get_CameraManager()**: Bossa.Cinematika.CameraManager (Public)
- **get_CameraSwitch()**: CameraSwitch (Public)
- **get_StaminaController()**: PlayerStaminaController (Public)
- **get_LocalPingController()**: PlayerPingController (Public)
- **RegisterLocalPlayer(WildSkies.Player.ILocalPlayer localPlayer)**: System.Void (Public)
- **UnregisterPlayer(WildSkies.Player.ILocalPlayer localPlayer)**: System.Void (Public)
- **GetCostMultiplierForAction(StaminaActionType type)**: System.Single (Public)
- **OverrideBaseMaxStamina(System.Int32 amount)**: System.Void (Public)
- **OverrideBaseMaxHealth(System.Int32 amount)**: System.Void (Public)
- **SetInvincible(System.Boolean value)**: System.Void (Public)
- **OnEquipItem(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Public)
- **OnUnequipItem(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Public)
- **IgnoreCollisionWithPlayer(UnityEngine.Collider colliderToIgnore, System.Boolean ignoreCollision)**: System.Void (Public)
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

