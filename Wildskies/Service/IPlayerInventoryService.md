# WildSkies.Service.IPlayerInventoryService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| OnItemAddedFailed | System.Action | Public |
| OnInventoryClosed | System.Action | Public |
| OnSavePlayerInventory | System.Action`1<System.String> | Public |
| OnItemInventoryUpdate | System.Action`1<System.String> | Public |
| OnItemAddedToAnyInventory | System.Action`1<System.String> | Public |
| OnItemRemovedFromAnyInventory | System.Action`1<System.String> | Public |
| FetchItemByID | System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> | Public |
| FetchItemByName | System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> | Public |
| EquippedItemsChanged | System.Action | Public |
| OnItemAdded | System.Action`1<Player.Inventory.IInventoryItem> | Public |
| DefaultPlayerInventory | Player.Inventory.DefaultInventory | Public |
| InHandInventory | Player.Inventory.InHandInventory | Public |
| ToolBarInventory | ToolBarInventory | Public |
| BeltPlayerInventory | Player.Inventory.DefaultInventory | Public |
| StashInventory | Player.Inventory.DefaultInventory | Public |
| EquipmentModel | EquipmentModel | Public |
| EquipmentInventories | System.Collections.Generic.Dictionary`2<EquipmentType,Player.Inventory.SingleSlotInventory> | Public |

## Methods

- **get_OnItemAddedFailed()**: System.Action (Public)
- **set_OnItemAddedFailed(System.Action value)**: System.Void (Public)
- **get_OnInventoryClosed()**: System.Action (Public)
- **set_OnInventoryClosed(System.Action value)**: System.Void (Public)
- **get_OnSavePlayerInventory()**: System.Action`1<System.String> (Public)
- **set_OnSavePlayerInventory(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnItemInventoryUpdate()**: System.Action`1<System.String> (Public)
- **set_OnItemInventoryUpdate(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnItemAddedToAnyInventory()**: System.Action`1<System.String> (Public)
- **set_OnItemAddedToAnyInventory(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnItemRemovedFromAnyInventory()**: System.Action`1<System.String> (Public)
- **set_OnItemRemovedFromAnyInventory(System.Action`1<System.String> value)**: System.Void (Public)
- **get_FetchItemByID()**: System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> (Public)
- **set_FetchItemByID(System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> value)**: System.Void (Public)
- **get_FetchItemByName()**: System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> (Public)
- **set_FetchItemByName(System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> value)**: System.Void (Public)
- **get_EquippedItemsChanged()**: System.Action (Public)
- **set_EquippedItemsChanged(System.Action value)**: System.Void (Public)
- **get_OnItemAdded()**: System.Action`1<Player.Inventory.IInventoryItem> (Public)
- **set_OnItemAdded(System.Action`1<Player.Inventory.IInventoryItem> value)**: System.Void (Public)
- **get_DefaultPlayerInventory()**: Player.Inventory.DefaultInventory (Public)
- **set_DefaultPlayerInventory(Player.Inventory.DefaultInventory value)**: System.Void (Public)
- **get_InHandInventory()**: Player.Inventory.InHandInventory (Public)
- **get_ToolBarInventory()**: ToolBarInventory (Public)
- **get_BeltPlayerInventory()**: Player.Inventory.DefaultInventory (Public)
- **set_BeltPlayerInventory(Player.Inventory.DefaultInventory value)**: System.Void (Public)
- **get_StashInventory()**: Player.Inventory.DefaultInventory (Public)
- **set_StashInventory(Player.Inventory.DefaultInventory value)**: System.Void (Public)
- **get_EquipmentModel()**: EquipmentModel (Public)
- **get_EquipmentInventories()**: System.Collections.Generic.Dictionary`2<EquipmentType,Player.Inventory.SingleSlotInventory> (Public)
- **GetEquipmentInventoryOrCreate(EquipmentType type)**: Player.Inventory.SingleSlotInventory (Public)
- **TryDefaultAddItemAtTransform(WildSkies.Gameplay.Items.IItem item, Player.Inventory.InventoryTransform transform)**: System.Boolean (Public)
- **TryDefaultAddItem(WildSkies.Gameplay.Items.IItem item)**: System.Boolean (Public)
- **TryDefaultAddItem(Player.Inventory.IInventoryItem inventoryItem)**: System.Boolean (Public)
- **TryDefaultAddItem(WildSkies.Gameplay.Items.ItemDefinition data)**: WildSkies.Gameplay.Items.Item (Public)
- **TryDefaultAddItem(WildSkies.Gameplay.Items.ItemDefinition data, WildSkies.Gameplay.Items.Item& resultItem)**: System.Boolean (Public)
- **ContainsItem(WildSkies.Gameplay.Items.ItemInventoryComponent itemInventoryData)**: System.Boolean (Public)
- **ConsumeItem(Player.Inventory.IInventoryItem item)**: System.Boolean (Public)
- **ThrowItem(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **RemoveItem(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **CollectItemDefinition(WildSkies.Gameplay.Items.ItemDefinition itemDefinition, WildSkies.Gameplay.Items.Item& item, System.Int32 amount)**: System.Boolean (Public)
- **FetchItem(WildSkies.Gameplay.Items.ItemInventoryComponent itemInventoryData)**: System.Collections.Generic.List`1<Player.Inventory.InventoryItem> (Public)
- **RefreshPlayerInventoryData(System.String itemId)**: System.Void (Public)
- **RefreshPlayerInventoryData(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **DeserializeData(System.String data)**: System.Void (Public)
- **DeserializeData_v0(System.String data)**: System.Void (Public)
- **AddStartingCustomisation()**: System.Void (Public)
- **AddCustomisationSet(System.String name)**: System.Void (Public)
- **GetItemEquipmentType(WildSkies.Gameplay.Items.ItemDefinition itemDefinition)**: EquipmentType (Public)
- **EquipStartingItems()**: System.Void (Public)
- **ClearForTest()**: System.Void (Public)
- **GetCurrentMaxWeaponLevel()**: System.Int32 (Public)
- **RemoveStashItemByID(System.String itemID, System.Int32 amountNeeded, System.Boolean useCallback)**: System.Void (Public)
- **RemoveInventoryItemByID(System.String itemID, System.Int32 amountNeeded, System.Boolean useCallback)**: System.Void (Public)
- **ContainsItemIdOnAnyInventory(System.String itemID, System.Int32& amountHeld)**: System.Boolean (Public)
- **GetAmountHeldOfTypeInAllInventories(WildSkies.Gameplay.Items.ResourceType resourceType)**: System.Int32 (Public)
- **ContainsItemIdOnStash(System.String itemID)**: System.Boolean (Public)
- **ContainsItemOnMainInventory(WildSkies.Gameplay.Items.IItem item)**: System.Boolean (Public)
- **ContainsItemOnBeltInventory(WildSkies.Gameplay.Items.IItem item)**: System.Boolean (Public)
- **GetItemIdByTypeOnAllInventories(WildSkies.Gameplay.Items.ResourceType resourceType)**: System.String (Public)
- **GetAllItemsOfTypeInAllInventories(WildSkies.Gameplay.Items.ItemTypes itemType)**: System.Collections.Generic.IReadOnlyCollection`1<Player.Inventory.IInventoryItem> (Public)

