# WildSkies.Service.IItemService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| AddressableLocationKey | System.String | Public |
| ItemsDiscovered | System.Collections.Generic.List`1<System.String> | Public |
| OnItemDiscoveredListChanged | System.Action`2<System.String,System.Boolean> | Public |
| OnNewItemDiscoveredListChanged | System.Action | Public |
| DebugOnItemDiscoveredListChanged | System.Action`2<System.String,System.Boolean> | Public |

## Methods

- **get_AddressableLocationKey()**: System.String (Public)
- **get_ItemsDiscovered()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_OnItemDiscoveredListChanged()**: System.Action`2<System.String,System.Boolean> (Public)
- **set_OnItemDiscoveredListChanged(System.Action`2<System.String,System.Boolean> value)**: System.Void (Public)
- **get_OnNewItemDiscoveredListChanged()**: System.Action (Public)
- **set_OnNewItemDiscoveredListChanged(System.Action value)**: System.Void (Public)
- **get_DebugOnItemDiscoveredListChanged()**: System.Action`2<System.String,System.Boolean> (Public)
- **set_DebugOnItemDiscoveredListChanged(System.Action`2<System.String,System.Boolean> value)**: System.Void (Public)
- **FetchAllItems()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition> (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **TryFetchItemById(System.String id, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchFirstInstantiableItem(System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition>& itemDefinition, System.Int32 quantity)**: System.Boolean (Public)
- **TryFetchItemByName(System.String name, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemsByName(System.String name, System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition>& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemsByType(WildSkies.Gameplay.Items.ItemTypes type, System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition>& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemByAirtableId(System.String airtableId, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemByAirtableReferenceID(System.String airtableReferenceID, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **TryFetchItemByInventoryData(WildSkies.Gameplay.Items.ItemInventoryComponent data, WildSkies.Gameplay.Items.ItemDefinition& itemDefinition)**: System.Boolean (Public)
- **GetResourceTypeByItemId(System.String itemId)**: WildSkies.Gameplay.Items.ResourceType (Public)
- **GetGenericIconForItemId(System.String itemId)**: UnityEngine.Sprite (Public)
- **GetSchematicItemDefinition(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematic)**: WildSkies.Gameplay.Items.ItemDefinition (Public)
- **AddItemToDiscoveredList(System.String id)**: System.Void (Public)
- **RemoveItemFromDiscoveredList(System.String id)**: System.Void (Public)
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

