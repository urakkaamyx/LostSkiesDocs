# Wildskies.UI.Panel.CraftingWindow

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Protected |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Protected |
| _telemetryService | WildSkies.Service.ITelemetryService | Protected |
| _inputService | WildSkies.Service.InputService | Protected |
| _itemService | WildSkies.Service.IItemService | Protected |
| _itemStatService | WildSkies.Service.IItemStatService | Protected |
| _uiService | UISystem.IUIService | Protected |
| _craftingService | WildSkies.Service.ICraftingService | Protected |
| _buildingService | WildSkies.Service.BuildingService | Protected |
| _localisationService | WildSkies.Service.LocalisationService | Protected |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _hasAllResources | System.Boolean | Private |
| _currentSelectedItem | CraftableItemListEntry | Private |
| _lastIconItemDefinition | WildSkies.Gameplay.Items.IItemDefinition | Private |
| _currentSelectedSchematicData | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Protected |
| _viewModel | Wildskies.UI.Panel.CraftingWindowViewModel | Protected |
| _currentResourceSlots | System.Collections.Generic.List`1<ResourceInputSlot> | Private |
| _currentComponentSlots | System.Collections.Generic.List`1<ShipPartComponentResources> | Private |
| _currentSelectedResourceSlot | UnityEngine.GameObject | Private |
| _isFarLeftResourceSlot | System.Boolean | Private |
| _statsDirty | System.Boolean | Private |
| _defaultTitleColor | UnityEngine.Color32 | Private |
| _defaultEdgeBackgroundColor | UnityEngine.Color32 | Private |
| _levelString | UnityEngine.Localization.LocalizedString | Private |
| _navigation | UnityEngine.UI.Navigation | Private |
| OnBeginCraftEvent | System.Action`2<WildSkies.Gameplay.Crafting.CraftableItemBlueprint,WildSkies.Gameplay.Items.IItemDefinition> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| ResourceSelectionListIsShowing | System.Boolean | Public |
| _craftingMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Private |
| IsShowing | System.Boolean | Public |
| CurrentSelectedSchematicData | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Public |

## Methods

- **get_ResourceSelectionListIsShowing()**: System.Boolean (Public)
- **get__craftingMethod()**: WildSkies.Gameplay.Crafting.CraftingMethod (Protected)
- **get_IsShowing()**: System.Boolean (Public)
- **get_CurrentSelectedSchematicData()**: WildSkies.Gameplay.Crafting.CraftableItemBlueprint (Public)
- **set_CurrentSelectedSchematicData(WildSkies.Gameplay.Crafting.CraftableItemBlueprint value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Protected)
- **Initialise()**: System.Void (Public)
- **Show(CraftableItemListEntry selection)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **UpdateListeners()**: System.Void (Private)
- **SetCraftButtonFill(System.Single value)**: System.Void (Public)
- **SetUnloadButtonFill(System.Single value)**: System.Void (Public)
- **ResetButtonsFill()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **SetNoItemListSelection()**: System.Void (Private)
- **OnItemAddedToInventory(Player.Inventory.IInventoryItem item)**: System.Void (Private)
- **GetCurrentResourceAmount(System.String itemId, System.Boolean acceptAnyResourceOfType)**: System.Int32 (Private)
- **RefreshCraftingWindow(CraftableItemListEntry selectedItem)**: System.Void (Public)
- **UpdateDetailViewIcon(CraftableItemListEntry selectedItem, System.Boolean forceUpdate)**: System.Void (Private)
- **PopulateStats(WildSkies.Gameplay.Items.IItemDefinition item, System.String schematicId, System.Boolean isOutputItemForSchematic)**: System.Void (Private)
- **SetRarity(WildSkies.Gameplay.Items.IItemDefinition item)**: System.Void (Private)
- **ShowContextualElements(System.Boolean hasSelection)**: System.Void (Protected)
- **GetFirstResourceSlot()**: UnityEngine.GameObject (Private)
- **BeginCrafting()**: System.Void (Protected)
- **HideResourceSelectionLists()**: System.Void (Public)
- **CreateShipPartResourceInputSlots(WildSkies.Gameplay.Crafting.CraftableItemBlueprint blueprint)**: System.Void (Private)
- **CreateSubComponentsForShipPartSchematic(WildSkies.Gameplay.Items.ItemShipPartComponentSchematic schematic)**: System.Void (Private)
- **OnShipPartComponentChanged(ShipPartComponentResources slotSubData)**: System.Void (Private)
- **CreateInputSlots(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> components, ShipPartComponentResources parent, System.Int32 slotStartIndex)**: System.Void (Protected)
- **SetResourceSlotsNavigation()**: System.Void (Private)
- **GetCraftingSlotItems()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Items.ItemDefinition> (Protected)
- **GetCraftingSlotItemIds()**: System.Collections.Generic.List`1<System.String> (Protected)
- **GetCraftingUpgradeLevel(System.String schematicId)**: System.Int32 (Protected)
- **CreateAnyItemOfTypeSlot(ResourceInputSlot slot, WildSkies.Gameplay.Crafting.CraftingComponent component)**: System.Void (Private)
- **CreateItemSlot(ResourceInputSlot slot, WildSkies.Gameplay.Crafting.CraftingComponent component)**: System.Void (Private)
- **OnItemSlotUpdated(WildSkies.Gameplay.Items.ItemDefinition slotItemDefinition)**: System.Void (Private)
- **SetStatsDirty()**: System.Void (Public)
- **SetSelectedResourcesToCraftItem()**: System.Void (Private)
- **SetResourceSelection(System.Boolean updateIcon)**: System.Void (Public)
- **IsFarLeftResourceItemSelected()**: System.Boolean (Public)
- **ClearResourceSlots()**: System.Void (Protected)
- **ClearComponentSlots()**: System.Void (Private)
- **UnloadResources()**: System.Void (Public)
- **TryAutoPopulate()**: System.Void (Protected)
- **UpdateCraftInputState()**: System.Void (Private)
- **TryCraftItem()**: System.Void (Public)
- **HandleTryCraftResult(CraftingResult result)**: System.Void (Protected)
- **IsDockedShipItemOutsideBubble(WildSkies.Gameplay.Items.IItemDefinition item)**: System.Boolean (Private)
- **HasAnyResourcesInSlots()**: System.Boolean (Public)
- **HasAllResources()**: System.Boolean (Public)
- **GetItem(System.String id, WildSkies.Gameplay.Items.IItemDefinition& itemFound)**: System.Boolean (Protected)
- **GetAllShipParts()**: System.Collections.Generic.List`1<ShipPartComponentResources> (Protected)
- **OnSlotHighlighted(WildSkies.Gameplay.Items.ItemDefinition itemDefinition)**: System.Void (Private)
- **OnSlotUnhighlighted()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

