# WildSkies.Service.LootTableService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _lootTables | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.LootTable> | Private |
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| UseTestAssets | System.Boolean | Public |
| AddressableLocationGameKey | System.String | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| AddressableLocationKey | System.String | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_AddressableLocationKey()**: System.String (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **OnLoadAddressable(LootTableBiomeList lootTableBiomeList)**: System.Void (Private)
- **GetEmptyLootTable()**: LootTableData (Public)
- **TryGetLootTable(System.String lootTableName, WildSkies.Service.LootTable& lootTable)**: System.Boolean (Public)
- **.ctor()**: System.Void (Public)

