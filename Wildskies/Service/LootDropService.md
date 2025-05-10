# WildSkies.Service.LootDropService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| RequestItem | System.Action`1<WildSkies.Service.LootDropService/SpawnItemStruct> | Public |
| RequestInstantiation | System.Action`2<WildSkies.Gameplay.Items.ItemDefinition,WildSkies.Service.LootDropService/SpawnItemStruct> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **TrySpawnItem(WildSkies.Service.LootDropService/SpawnItemStruct itemSpawnStruct)**: System.Boolean (Public)
- **GiveItem(WildSkies.Gameplay.Items.ItemDefinition item, WildSkies.Service.LootDropService/SpawnItemStruct itemSpawnStruct)**: System.Void (Protected)
- **.ctor()**: System.Void (Public)

