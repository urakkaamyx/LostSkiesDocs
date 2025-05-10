# Wildskies.UI.Panel.CraftingItemList

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Protected |
| _audioService | WildSkies.Service.AudioService | Private |
| _viewModel | Wildskies.UI.Panel.CraftingItemListViewModel | Private |
| _currentItemSelection | CraftableItemListEntry | Private |
| _currentSubCategorySelection | Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry | Private |
| _craftingMenuType | WildSkies.Gameplay.Crafting.CraftingMethod | Private |
| _currentItemListEntries | System.Collections.Generic.List`1<CraftableItemListEntry> | Private |
| _allKnownSchematicsToDisplay | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> | Private |
| _newSchematics | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> | Private |
| _idToBlueprint | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint>> | Private |
| _knownSchematicsCategoryIdToSubcategoryIdList | System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.String>> | Private |
| _mainCategoriesKeys | System.Collections.Generic.List`1<System.String> | Private |
| _subCategoriesKeys | System.Collections.Generic.List`1<System.String> | Private |
| _currentSelectedMainCategoryIndex | System.Int32 | Private |
| _mainCategoryButtons | System.Collections.Generic.List`1<Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry> | Private |
| _subCategoryButtons | System.Collections.Generic.List`1<Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry> | Private |
| OnListEntryClickedEvent | System.Action`1<CraftableItemListEntry> | Public |
| OnCategoryChangedEvent | System.Action | Public |
| _navigation | UnityEngine.UI.Navigation | Private |
| _hideItemCategoryPanel | System.Boolean | Private |
| OnListRefreshedEvent | System.Action | Public |
| _cachedSelection | System.Collections.Generic.Dictionary`2<System.String,Wildskies.UI.Panel.CachedSelectionData> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentItemSelection | CraftableItemListEntry | Public |

## Methods

- **get_CurrentItemSelection()**: CraftableItemListEntry (Public)
- **Awake()**: System.Void (Private)
- **ShowCraftingList(Wildskies.UI.Panel.CraftingMenuPanelPayload payload, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematicsToShow)**: System.Void (Public)
- **ShowBuildList(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematicsToShow)**: System.Void (Public)
- **RefreshItemListPanel(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematicsToShow)**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **OnItemAddedToInventory(Player.Inventory.IInventoryItem inventoryItem)**: System.Void (Private)
- **CategoryNavigationInput()**: System.Void (Private)
- **SelectLeftCategory()**: System.Void (Private)
- **SelectRightCategory()**: System.Void (Private)
- **SetPanelNavigation(System.Boolean selectDefault)**: System.Void (Public)
- **SetItemListNavigation()**: System.Void (Private)
- **SetSubCategoriesButtonNavigation()**: System.Void (Private)
- **SetSearchInputFieldNavigation()**: System.Void (Private)
- **SetFilterDropdownNavigation()**: System.Void (Private)
- **RemoveListNavigation()**: System.Void (Public)
- **SelectDefault()**: System.Void (Private)
- **GetCachedSelection()**: System.Void (Private)
- **SetCacheForCurrentSelection()**: System.Void (Private)
- **FocusLastSelection()**: System.Void (Private)
- **ShowNoKnownRecipesMessage()**: System.Void (Public)
- **RefreshPanel()**: System.Void (Private)
- **ShowAllItems()**: System.Void (Private)
- **ShowItemsByCategory()**: System.Void (Private)
- **TrySetCategoriesList()**: System.Boolean (Private)
- **TrySetItemsList(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> listToShow)**: System.Boolean (Private)
- **ShowSelectedCategoryList()**: System.Void (Private)
- **SetListItemSelection()**: System.Void (Public)
- **SetListItemSelectionByItemId(System.String itemId)**: System.Void (Private)
- **SetMainCategoriesButtons()**: System.Void (Private)
- **SetSubCategoriesButtons()**: System.Void (Private)
- **CreateSubCategoryIdToItemBlueprint(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematicData, WildSkies.Gameplay.Items.IItemDefinition item)**: System.Void (Private)
- **SetCategorySelection()**: System.Void (Private)
- **ClearCurrentItemList()**: System.Void (Private)
- **ClearMainAndSubCategoryList()**: System.Void (Private)
- **ClearCurrentSubCategoryList()**: System.Void (Private)
- **MoveUncategorizedToEnd()**: System.Void (Private)
- **AddItemListEntry(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematicData, WildSkies.Gameplay.Items.IItemDefinition item)**: System.Void (Private)
- **SortItemListEntryToCraftableFirst()**: System.Void (Private)
- **GetIsShipyardItem(WildSkies.Gameplay.Items.IItemDefinition item)**: System.Boolean (Private)
- **HaveAllResourcesToCraftItem(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematicData)**: System.Boolean (Private)
- **SetLearnedNewSchematicsList()**: System.Void (Private)
- **OnSubCategoryButtonClicked(System.String id, Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry subCategorySelection)**: System.Void (Private)
- **GetCurrentCategorySelectionKey(System.String categoryId, System.String subcategoryId)**: System.String (Private)
- **OnCategoryButtonPressed(System.Int32 newCategoryIndex, System.String categoryKey)**: System.Void (Private)
- **OnListEntryClicked(CraftableItemListEntry listEntry)**: System.Void (Private)
- **OnListEntryButtonSelected(CraftableItemListEntry listEntry)**: System.Void (Private)
- **TryGetItemFromBlueprint(WildSkies.Gameplay.Crafting.CraftableItemBlueprint schematicData, WildSkies.Gameplay.Items.IItemDefinition& item)**: System.Boolean (Private)
- **FadeIn()**: System.Void (Public)
- **FadeOut()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

