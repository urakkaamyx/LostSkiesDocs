# WildSkies.Service.PlayerInventoryService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <OnItemAddedFailed>k__BackingField | System.Action | Private |
| <OnInventoryClosed>k__BackingField | System.Action | Private |
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _equipmentModel | EquipmentModel | Private |
| _inHandInventory | Player.Inventory.InHandInventory | Private |
| _toolBarInventory | ToolBarInventory | Private |
| _beltPlayerInventory | Player.Inventory.DefaultInventory | Private |
| _stashInventory | Player.Inventory.DefaultInventory | Private |
| _equipmentInventories | System.Collections.Generic.Dictionary`2<EquipmentType,Player.Inventory.SingleSlotInventory> | Private |
| <OnSavePlayerInventory>k__BackingField | System.Action`1<System.String> | Private |
| <OnItemInventoryUpdate>k__BackingField | System.Action`1<System.String> | Private |
| <OnItemAddedToAnyInventory>k__BackingField | System.Action`1<System.String> | Private |
| <OnItemRemovedFromAnyInventory>k__BackingField | System.Action`1<System.String> | Private |
| <EquippedItemsChanged>k__BackingField | System.Action | Private |
| <OnItemAdded>k__BackingField | System.Action`1<Player.Inventory.IInventoryItem> | Private |
| <FetchItemByID>k__BackingField | System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> | Private |
| <FetchItemByName>k__BackingField | System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> | Private |
| <DefaultPlayerInventory>k__BackingField | Player.Inventory.DefaultInventory | Private |
| DefaultGridDataAddressableKey | System.String | Private |
| BeltGridDataAddressableKey | System.String | Private |
| StashGridDataAddressableKey | System.String | Private |
| customisationSets | System.Collections.Generic.Dictionary`2<System.String,System.String[]> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| OnItemAddedFailed | System.Action | Public |
| OnInventoryClosed | System.Action | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |
| EquipmentModel | EquipmentModel | Public |
| InHandInventory | Player.Inventory.InHandInventory | Public |
| ToolBarInventory | ToolBarInventory | Public |
| BeltPlayerInventory | Player.Inventory.DefaultInventory | Public |
| StashInventory | Player.Inventory.DefaultInventory | Public |
| EquipmentInventories | System.Collections.Generic.Dictionary`2<EquipmentType,Player.Inventory.SingleSlotInventory> | Public |
| OnSavePlayerInventory | System.Action`1<System.String> | Public |
| OnItemInventoryUpdate | System.Action`1<System.String> | Public |
| OnItemAddedToAnyInventory | System.Action`1<System.String> | Public |
| OnItemRemovedFromAnyInventory | System.Action`1<System.String> | Public |
| EquippedItemsChanged | System.Action | Public |
| OnItemAdded | System.Action`1<Player.Inventory.IInventoryItem> | Public |
| FetchItemByID | System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> | Public |
| FetchItemByName | System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> | Public |
| DefaultPlayerInventory | Player.Inventory.DefaultInventory | Public |
| InventorySlot | System.Int32 | Public |

## Methods

- **get_OnItemAddedFailed()**: System.Action (Public)
- **set_OnItemAddedFailed(System.Action value)**: System.Void (Public)
- **get_OnInventoryClosed()**: System.Action (Public)
- **set_OnInventoryClosed(System.Action value)**: System.Void (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_EquipmentModel()**: EquipmentModel (Public)
- **get_InHandInventory()**: Player.Inventory.InHandInventory (Public)
- **get_ToolBarInventory()**: ToolBarInventory (Public)
- **get_BeltPlayerInventory()**: Player.Inventory.DefaultInventory (Public)
- **set_BeltPlayerInventory(Player.Inventory.DefaultInventory value)**: System.Void (Public)
- **get_StashInventory()**: Player.Inventory.DefaultInventory (Public)
- **set_StashInventory(Player.Inventory.DefaultInventory value)**: System.Void (Public)
- **get_EquipmentInventories()**: System.Collections.Generic.Dictionary`2<EquipmentType,Player.Inventory.SingleSlotInventory> (Public)
- **get_OnSavePlayerInventory()**: System.Action`1<System.String> (Public)
- **set_OnSavePlayerInventory(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnItemInventoryUpdate()**: System.Action`1<System.String> (Public)
- **set_OnItemInventoryUpdate(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnItemAddedToAnyInventory()**: System.Action`1<System.String> (Public)
- **set_OnItemAddedToAnyInventory(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnItemRemovedFromAnyInventory()**: System.Action`1<System.String> (Public)
- **set_OnItemRemovedFromAnyInventory(System.Action`1<System.String> value)**: System.Void (Public)
- **get_EquippedItemsChanged()**: System.Action (Public)
- **set_EquippedItemsChanged(System.Action value)**: System.Void (Public)
- **get_OnItemAdded()**: System.Action`1<Player.Inventory.IInventoryItem> (Public)
- **set_OnItemAdded(System.Action`1<Player.Inventory.IInventoryItem> value)**: System.Void (Public)
- **get_FetchItemByID()**: System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> (Public)
- **set_FetchItemByID(System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> value)**: System.Void (Public)
- **get_FetchItemByName()**: System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> (Public)
- **set_FetchItemByName(System.Func`2<System.String,WildSkies.Gameplay.Items.ItemDefinition> value)**: System.Void (Public)
- **get_DefaultPlayerInventory()**: Player.Inventory.DefaultInventory (Public)
- **set_DefaultPlayerInventory(Player.Inventory.DefaultInventory value)**: System.Void (Public)
- **get_InventorySlot()**: System.Int32 (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **LoadGridData()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **LoadInventoryGridData(System.String addressableKey)**: System.Threading.Tasks.Task`1<Player.Inventory.InventoryGridData> (Private)
- **CreateDefaultPlayerInventory(Player.Inventory.InventoryGridData gridData)**: System.Void (Private)
- **CreateBeltPlayerInventory(Player.Inventory.InventoryGridData beltGridData)**: System.Void (Private)
- **CreateStashPlayerInventory(Player.Inventory.InventoryGridData stashGridData)**: System.Void (Private)
- **GetEquipmentInventoryOrCreate(EquipmentType type)**: Player.Inventory.SingleSlotInventory (Public)
- **CollectItemDefinition(WildSkies.Gameplay.Items.ItemDefinition itemDefinition, WildSkies.Gameplay.Items.Item& item, System.Int32 amount)**: System.Boolean (Public)
- **ItemAddedToInventory(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **ItemRemovedFromInventory(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **RefreshPlayerInventoryData(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **RefreshPlayerInventoryData(System.String itemId)**: System.Void (Public)
- **OnToolBarItemSlotted(Player.Inventory.IInventoryItem item, System.Action`2<Player.Inventory.IInventoryItem,System.Int32> callback)**: System.Void (Private)
- **OnToolBarItemSlottedSpecific(Player.Inventory.IInventoryItem item, System.Int32 id)**: System.Void (Private)
- **OnToolBarItemRemoved(System.Int32 id)**: System.Void (Private)
- **TryDefaultAddItemAtTransform(WildSkies.Gameplay.Items.IItem item, Player.Inventory.InventoryTransform transform)**: System.Boolean (Public)
- **TryDefaultAddItem(WildSkies.Gameplay.Items.IItem item)**: System.Boolean (Public)
- **TryDefaultAddItem(Player.Inventory.IInventoryItem inventoryItem)**: System.Boolean (Public)
- **TryDefaultAddItem(WildSkies.Gameplay.Items.ItemDefinition data)**: WildSkies.Gameplay.Items.Item (Public)
- **TryDefaultAddItem(WildSkies.Gameplay.Items.ItemDefinition data, WildSkies.Gameplay.Items.Item& resultItem)**: System.Boolean (Public)
- **TryAddToPlayerInventories(WildSkies.Gameplay.Items.IItem item, Player.Inventory.IInventoryItem& newItem)**: System.Boolean (Private)
- **TryAddToPlayerInventories(Player.Inventory.IInventoryItem item)**: System.Boolean (Private)
- **ContainsItem(WildSkies.Gameplay.Items.ItemInventoryComponent itemInventoryData)**: System.Boolean (Public)
- **ConsumeItem(Player.Inventory.IInventoryItem item)**: System.Boolean (Public)
- **ThrowItem(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **RemoveItem(Player.Inventory.IInventoryItem item)**: System.Void (Public)
- **FetchItem(WildSkies.Gameplay.Items.ItemInventoryComponent itemInventoryData)**: System.Collections.Generic.List`1<Player.Inventory.InventoryItem> (Public)
- **AddStartingCustomisation()**: System.Void (Public)
- **AddCustomisationSet(System.String name)**: System.Void (Public)
- **GetItemEquipmentType(WildSkies.Gameplay.Items.ItemDefinition itemDefinition)**: EquipmentType (Public)
- **EquipStartingItems()**: System.Void (Public)
- **GetCurrentMaxWeaponLevel()**: System.Int32 (Public)
- **RemoveInventoryItemByID(System.String itemID, System.Int32 amountNeeded, System.Boolean useCallback)**: System.Void (Public)
- **RemoveStashItemByID(System.String itemID, System.Int32 amountNeeded, System.Boolean useCallback)**: System.Void (Public)
- **ContainsItemIdOnAnyInventory(System.String itemID, System.Int32& amountHeld)**: System.Boolean (Public)
- **GetAmountHeldOfTypeInAllInventories(WildSkies.Gameplay.Items.ResourceType resourceType)**: System.Int32 (Public)
- **GetItemIdByTypeOnAllInventories(WildSkies.Gameplay.Items.ResourceType resourceType)**: System.String (Public)
- **GetAllItemsOfTypeInAllInventories(WildSkies.Gameplay.Items.ItemTypes itemType)**: System.Collections.Generic.IReadOnlyCollection`1<Player.Inventory.IInventoryItem> (Public)
- **ContainsItemIdOnStash(System.String itemID)**: System.Boolean (Public)
- **ContainsItemOnMainInventory(WildSkies.Gameplay.Items.IItem item)**: System.Boolean (Public)
- **ContainsItemOnBeltInventory(WildSkies.Gameplay.Items.IItem item)**: System.Boolean (Public)
- **EquipmentModelUpdated()**: System.Void (Private)
- **SerializeData()**: System.String (Private)
- **DeserializeData(System.String data)**: System.Void (Public)
- **DeserializeInventoryItemSaveData(Player.Inventory.IInventory inventory, System.Collections.Generic.List`1<WildSkies.Service.PlayerInventoryService/InventoryItemSaveData> playerInventoryItems)**: System.Void (Private)
- **DeserializeSlottedToolBarItems(System.Collections.Generic.Dictionary`2<System.Int32,WildSkies.Service.PlayerInventoryService/InventoryItemSaveData> slottedToolBarItems)**: System.Void (Private)
- **DeserializeEquipmentInventoryItems(System.Collections.Generic.Dictionary`2<EquipmentType,WildSkies.Service.PlayerInventoryService/InventoryItemSaveData> equipmentInventoriesItems)**: System.Void (Private)
- **DeserializeData_v0(System.String data)**: System.Void (Public)
- **ClearForTest()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<GetEquipmentInventoryOrCreate>b__87_0(Player.Inventory.IInventoryItem c)**: System.Void (Private)
- **<GetEquipmentInventoryOrCreate>b__87_1(Player.Inventory.IInventoryItem c)**: System.Void (Private)

