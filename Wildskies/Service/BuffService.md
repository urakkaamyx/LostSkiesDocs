# WildSkies.Service.BuffService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _buffDictionary | System.Collections.Generic.Dictionary`2<System.String,BuffDefinitionBase> | Private |
| _buffReceivers | System.Collections.Generic.Dictionary`2<UnityEngine.Transform,WildSkies.BuffSystem.IBuffReceiver> | Private |
| AddressableGameKey | System.String | Private |
| AddressableTestKey | System.String | Private |
| <OnBuffAdded>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Private |
| <OnBuffRemoved>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Private |
| <OnBuffEffectAdded>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Private |
| <OnBuffEffectRemoved>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Private |
| <OnBuffTick>k__BackingField | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Private |
| <OnBuffsChanged>k__BackingField | System.Action`1<WildSkies.Entities.IBuffableEntity> | Private |
| <OnSetInitialResourceValues>k__BackingField | System.Action`1<WildSkies.Entities.IBuffableEntity> | Private |
| UseTestAssets | System.Boolean | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| OnBuffAdded | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Public |
| OnBuffRemoved | System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> | Public |
| OnBuffEffectAdded | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffEffectRemoved | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffTick | System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> | Public |
| OnBuffsChanged | System.Action`1<WildSkies.Entities.IBuffableEntity> | Public |
| OnSetInitialResourceValues | System.Action`1<WildSkies.Entities.IBuffableEntity> | Public |
| AddressableLocationKey | System.String | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_OnBuffAdded()**: System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> (Public)
- **set_OnBuffAdded(System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> value)**: System.Void (Public)
- **get_OnBuffRemoved()**: System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> (Public)
- **set_OnBuffRemoved(System.Action`2<WildSkies.Entities.IBuffableEntity,WildSkies.VfxType> value)**: System.Void (Public)
- **get_OnBuffEffectAdded()**: System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> (Public)
- **set_OnBuffEffectAdded(System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> value)**: System.Void (Public)
- **get_OnBuffEffectRemoved()**: System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> (Public)
- **set_OnBuffEffectRemoved(System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> value)**: System.Void (Public)
- **get_OnBuffTick()**: System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> (Public)
- **set_OnBuffTick(System.Action`2<WildSkies.Entities.IBuffableEntity,BuffEffect> value)**: System.Void (Public)
- **get_OnBuffsChanged()**: System.Action`1<WildSkies.Entities.IBuffableEntity> (Public)
- **set_OnBuffsChanged(System.Action`1<WildSkies.Entities.IBuffableEntity> value)**: System.Void (Public)
- **get_OnSetInitialResourceValues()**: System.Action`1<WildSkies.Entities.IBuffableEntity> (Public)
- **set_OnSetInitialResourceValues(System.Action`1<WildSkies.Entities.IBuffableEntity> value)**: System.Void (Public)
- **get_AddressableLocationKey()**: System.String (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RegisterBuffReceiver(UnityEngine.Transform transform, WildSkies.BuffSystem.IBuffReceiver buffReceiver)**: System.Boolean (Public)
- **UnregisterBuffReceiver(UnityEngine.Transform transform)**: System.Void (Public)
- **TryGetUniversalBuff(UnityEngine.Transform transform, WildSkies.BuffSystem.IBuffReceiver& buffReceiver)**: System.Boolean (Public)
- **LoadBuffs()**: System.Threading.Tasks.Task (Private)
- **OnBuffLoaded(BuffDefinitionBase buff)**: System.Void (Private)
- **TryGetBuffFromDamageType(WildSkies.Weapon.DamageType damageType, BuffDefinitionBase& buff)**: System.Boolean (Public)
- **TryGetShipPartBuffFromDamageType(WildSkies.Weapon.DamageType damageType, ShipPartBuffs& buff)**: System.Boolean (Public)
- **GetBuff(System.String buffName)**: BuffDefinitionBase (Public)
- **CalculateCurrentBuffedValue(Bossa.Core.Entity.Entity entity, WildSkies.BuffSystem.BuffType type, System.Single baseValue)**: System.Single (Public)
- **GetCurrentBuffValue(Bossa.Core.Entity.Entity entity, WildSkies.BuffSystem.BuffType type, System.Single& additiveValue, System.Single& multiplierValue)**: System.Boolean (Private)
- **GetBuffNames()**: System.String[] (Public)
- **GetFormattedName(WildSkies.BuffSystem.BuffType buffType)**: System.String (Private)
- **.ctor()**: System.Void (Public)

