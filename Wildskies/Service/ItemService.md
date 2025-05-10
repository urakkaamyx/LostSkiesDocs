# WildSkies.Service.ItemService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| UseTestAssets | System.Boolean | Public |
| _allItemDefinition | System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition> | Private |
| _fetchItemListByNameAux | System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition> | Private |
| _itemsDiscovered | System.Collections.Generic.List`1<System.String> | Private |
| _newItemsDiscovered | System.Collections.Generic.List`1<System.String> | Private |
| <OnItemDiscoveredListChanged>k__BackingField | System.Action`2<System.String,System.Boolean> | Private |
| <OnNewItemDiscoveredListChanged>k__BackingField | System.Action | Private |
| <DebugOnItemDiscoveredListChanged>k__BackingField | System.Action`2<System.String,System.Boolean> | Private |
| _ammoTypeDictionary | System.Collections.Generic.Dictionary`2<WildSkies.Weapon.AmmoType,System.String> | Private |
| AddressableLocationGameKey | System.String | Public |
| AddressableLocationTestKey | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| AddressableLocationKey | System.String | Public |
| ItemsDiscovered | System.Collections.Generic.List`1<System.String> | Public |
| OnItemDiscoveredListChanged | System.Action`2<System.String,System.Boolean> | Public |
| OnNewItemDiscoveredListChanged | System.Action | Public |
| DebugOnItemDiscoveredListChanged | System.Action`2<System.String,System.Boolean> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_AddressableLocationKey()**: System.String (Public)
- **get_ItemsDiscovered()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_OnItemDiscoveredListChanged()**: System.Action`2<System.String,System.Boolean> (Public)
- **set_OnItemDiscoveredListChanged(System.Action`2<System.String,System.Boolean> value)**: System.Void (Public)
- **get_OnNewItemDiscoveredListChanged()**: System.Action (Public)
- **set_OnNewItemDiscoveredListChanged(System.Action value)**: System.Void (Public)
- **get_DebugOnItemDiscoveredListChanged()**: System.Action`2<System.String,System.Boolean> (Public)
- **set_DebugOnItemDiscoveredListChanged(System.Action`2<System.String,System.Boolean> value)**: System.Void (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **FetchAllItems()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition> (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **OnLoadAddressable(WildSkies.Gameplay.Items.ItemDefinition itemDefinition)**: System.Void (Private)
- **TryFetchItemById(System.String id, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchFirstInstantiableItem(System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition>& itemDefinition, System.Int32 quantity)**: System.Boolean (Public)
- **TryFetchItemByName(System.String name, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemsByName(System.String name, System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition>& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemsByType(WildSkies.Gameplay.Items.ItemTypes type, System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition>& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemByAirtableReferenceID(System.String airtableReferenceID, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemByAirtableId(System.String airtableId, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemByInventoryData(WildSkies.Gameplay.Items.ItemInventoryComponent data, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **GetResourceTypeByItemId(System.String itemId)**: WildSkies.Gameplay.Items.ResourceType (Public)
- **GetGenericIconForItemId(System.String itemId)**: UnityEngine.Sprite (Public)
- **GetSchematicItemDefinition(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: WildSkies.Gameplay.Items.ItemDefinition (Public)
- **GetCategoryFromFlags(WildSkies.Gameplay.Items.ItemTypes types)**: System.String (Private)
- **AddItemToDiscoveredList(System.String id)**: System.Void (Public)
- **RemoveItemFromDiscoveredList(System.String id)**: System.Void (Public)
- **DebugAddItemToDiscoveredList(System.String id)**: System.Void (Public)
- **ClearItemsDiscoveredList()**: System.Void (Public)
- **SetItemsDiscoveredList(System.Collections.Generic.List`1<System.String> items)**: System.Void (Public)
- **GetAllDiscoveredItemIds(System.Collections.Generic.List`1<System.String>& discoveredItems)**: System.Boolean (Public)
- **HasDiscoveredItemById(System.String id)**: System.Boolean (Public)
- **HasDiscoveredItem(System.String name)**: System.Boolean (Public)
- **DiscoverAllItems()**: System.Void (Public)
- **ForgetAllItems()**: System.Void (Public)
- **GetDiscoveredItemCount()**: System.Int32 (Public)
- **HasNewlyDiscoveredItems()**: System.Boolean (Public)
- **IsItemNewlyDiscovered(System.String id)**: System.Boolean (Public)
- **RemoveItemFromNewlyDiscoveredList(System.String id)**: System.Void (Public)
- **GetItemIdFromAmmoType(WildSkies.Weapon.AmmoType ammoType)**: System.String (Public)
- **GetAirtableItemNames()**: System.String[] (Public)
- **GetAirtableItemIDs()**: System.String[] (Public)
- **.ctor()**: System.Void (Public)

