# Wildskies.UI.Panel.SchematicsPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| schematicsTypeData | System.Collections.Generic.List`1<Wildskies.UI.Panel.SchematicsPanel/SchematicTypeForMethod> | Private |
| _uiService | UISystem.IUIService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _viewModel | Wildskies.UI.Panel.SchematicsPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.SchematicsPanelPayload | Private |
| _itemsToLearn | System.Collections.Generic.List`1<Player.Inventory.IInventoryItem> | Private |
| _currentlySelectedMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Private |
| _currentlySelectedItem | Player.Inventory.IInventoryItem | Private |
| _schematicTypeDataDict | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.Crafting.CraftingMethod,System.Collections.Generic.List`1<Wildskies.UI.Panel.SchematicsPanel/SchematicTypeData>> | Private |
| _currentlySelectedSchematicCategory | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> | Private |
| _currentXpBooksTier | System.Int32 | Private |
| _xpBookStates | System.Collections.Generic.List`1<Wildskies.UI.Panel.SchematicsPanel/XpBookToggleState> | Private |
| _currentLevel | System.Int32 | Private |
| _addedXp | System.Int32 | Private |
| _levelsToAdd | System.Int32 | Private |
| _currentSelectedEntry | System.Int32 | Private |
| _currentSchematic | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Private |
| _currentSelectedSchematicToggle | Wildskies.UI.Panel.SchematicsListEntryToggle | Private |
| _knowledgeData | WildSkies.Service.ISchematicKnowledgeData | Private |
| _currentCategory | Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry | Private |
| _currentSelectedCategoryIndex | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **OnCraftingMethodSelected(Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry selectedCategoryEntry)**: System.Void (Private)
- **GetNumberOfSchematicsForType(WildSkies.Gameplay.Items.SchematicType schematicType, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematics)**: System.Int32 (Private)
- **OnSchematicTypeSelect(WildSkies.Gameplay.Items.SchematicType schematicType)**: System.Void (Private)
- **OnSchematicSelected(WildSkies.Gameplay.Crafting.CraftableItemBlueprint blueprint, System.Int32 index)**: System.Void (Private)
- **SetUpgradePanel()**: System.Void (Private)
- **LearnSchematic()**: System.Void (Private)
- **OpenLearnSchematicsMenu()**: System.Void (Private)
- **RefreshLearnToggles()**: System.Void (Private)
- **RefreshSelectedItemInfo()**: System.Void (Private)
- **OpenEnhanceSchematicsPanel()**: System.Void (Private)
- **AddXpBook()**: System.Void (Public)
- **RemoveXpBooks()**: System.Void (Public)
- **OnUpgrade(System.Int32 levelsAdded, System.Int32 newXp)**: System.Void (Private)
- **UpdateUpgradeUi()**: System.Void (Private)
- **GetLocalisedOrEmptyString(UnityEngine.Localization.LocalizedString locString)**: System.String (Private)
- **Update()**: System.Void (Private)
- **CategoryNavigationInput()**: System.Void (Private)
- **ClosePanelInput()**: System.Void (Private)
- **CloseMenu()**: System.Void (Private)
- **SelectLeftCategory()**: System.Void (Private)
- **SelectRightCategory()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

