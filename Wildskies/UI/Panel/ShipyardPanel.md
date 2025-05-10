# Wildskies.UI.Panel.ShipyardPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.ShipyardPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.ShipyardPanelPayload | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _uiService | UISystem.IUIService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _lootDropService | WildSkies.Service.LootDropService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _itemStatService | WildSkies.Service.IItemStatService | Protected |
| _localisationService | WildSkies.Service.LocalisationService | Protected |
| _greenColor | UnityEngine.Color | Private |
| _redColor | UnityEngine.Color | Private |
| _frameString | UnityEngine.Localization.LocalizedString | Private |
| _decksPanelsString | UnityEngine.Localization.LocalizedString | Private |
| BlueprintPlayerPrefKey | System.String | Private |
| BlueprintPresets | System.String | Private |
| ShipFrameMaterialKey | System.String | Private |
| DecksMaterialKey | System.String | Private |
| ButtonHoldTime | System.Single | Private |
| ButtonPressTime | System.Single | Private |
| DeconstructionTimeout | System.Single | Private |
| _jsonSerializerSettings | Newtonsoft.Json.JsonSerializerSettings | Private |
| _blueprintSelectEntries | System.Collections.Generic.List`1<BlueprintSelectEntry> | Private |
| _blueprintSaveDatas | System.Collections.Generic.List`1<ShipBlueprintSaveData> | Private |
| _existingSlots | System.Collections.Generic.List`1<System.Int32> | Private |
| _loadFails | System.Collections.Generic.List`1<System.Int32> | Private |
| _requestIds | System.Collections.Generic.List`1<System.Guid> | Private |
| _requestId | System.Guid | Private |
| _isSaving | System.Boolean | Private |
| _selectedEntry | BlueprintSelectEntry | Private |
| _initialHologramCraftingComponents | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> | Private |
| _initialBuiltCraftingComponents | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> | Private |
| _currentCraftingComponents | System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> | Private |
| _currentSelectedResourceSlot | UnityEngine.GameObject | Private |
| _shipPartEntries | System.Collections.Generic.List`1<ShipPartEntry> | Private |
| _shipPartCountsPerType | System.Collections.Generic.Dictionary`2<WildSkies.Gameplay.ShipBuilding.HullObjectType,System.Collections.Generic.List`1<System.Single>> | Private |
| _currentConfirmHoldTimer | System.Single | Private |
| _currentDeleteHoldTimer | System.Single | Private |
| _currentSaveHoldTimer | System.Single | Private |
| _currentCraftHoldTimer | System.Single | Private |
| _updateShipInfoTask | System.Threading.Tasks.Task | Private |
| _processInput | System.Boolean | Private |
| _reconstructClicked | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |
| BlueprintSaveDatas | System.Collections.Generic.List`1<ShipBlueprintSaveData> | Public |
| ViewModel | Wildskies.UI.Panel.ShipyardPanelViewModel | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **get_BlueprintSaveDatas()**: System.Collections.Generic.List`1<ShipBlueprintSaveData> (Public)
- **get_ViewModel()**: Wildskies.UI.Panel.ShipyardPanelViewModel (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **HideResourceSelectionLists()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **EnableInput()**: System.Void (Private)
- **UpdateInput()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isGamePad)**: System.Void (Private)
- **UpdateSubPanels()**: System.Void (Private)
- **SavePresets()**: System.Void (Private)
- **InitBlueprintSelectLists()**: System.Void (Private)
- **OnGetSlotsForSavingPresets(System.Boolean success, System.String key, System.Collections.Generic.List`1<System.Int32> slots)**: System.Void (Private)
- **OnGetExistingSlotsForKeyCompleted(System.Boolean success, System.String key, System.Collections.Generic.List`1<System.Int32> slots)**: System.Void (Private)
- **OnLoadCompleted(System.Boolean success, System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Private)
- **OnClearCompleted(System.Boolean success, System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Private)
- **CreateNewEntry(System.Int32 saveSlot, ShipBlueprintSaveData shipBlueprintSaveData, System.Boolean empty)**: System.Void (Private)
- **ParseBlueprintName(System.String blueprintName)**: System.String (Private)
- **LoadRequestFinished()**: System.Void (Private)
- **SetAllTogglesOff()**: System.Void (Private)
- **OnBlueprintEntrySelected(UnityEngine.UI.Toggle toggle)**: System.Void (Private)
- **OnConfirmBlueprintButtonClicked()**: System.Void (Private)
- **OnDeleteBlueprintButtonClicked()**: System.Void (Private)
- **OnDeleteConfirmed(System.String _)**: System.Void (Private)
- **OnSaveConfirmBlueprintButtonClicked()**: System.Void (Private)
- **OnOverwriteConfirmed(System.String _)**: System.Void (Private)
- **OnSaveConfirmed(System.String blueprintName)**: System.Void (Private)
- **GetMaterialsCost()**: System.Collections.Generic.Dictionary`2<System.String,System.Int32> (Private)
- **ExitSaving()**: System.Void (Private)
- **GetBlueprintEntryCount()**: System.Int32 (Private)
- **GetFirstExistingBlueprintEntryIndex()**: System.Int32 (Private)
- **GetFirstEmptyBlueprintEntryIndex()**: System.Int32 (Private)
- **GetSelectedEntry()**: BlueprintSelectEntry (Private)
- **OnEditShipButtonClicked()**: System.Void (Private)
- **OnSaveBlueprintButtonClicked()**: System.Void (Private)
- **OnUnloadBlueprintButtonClicked()**: System.Void (Private)
- **OnUnloadConfirmed(System.String _)**: System.Void (Private)
- **UpdateBlueprintNameText()**: System.Void (Private)
- **SetupResourceSlots()**: System.Void (Private)
- **SetResourceSelection(System.Boolean updateIcon)**: System.Void (Private)
- **CraftingComponentsValid()**: System.Boolean (Private)
- **UpdateCraftButtonInteractability()**: System.Void (Private)
- **UpdateAdditionalCraftingWeight()**: System.Void (Private)
- **ResetCraftingComponentSelection()**: System.Void (Private)
- **OnCraftClicked()**: System.Void (Private)
- **OnCraftCancelled()**: System.Void (Private)
- **OnCraftConfirmed(System.String shipName)**: System.Void (Private)
- **RefundResources()**: System.Void (Private)
- **SpendResources()**: System.Void (Private)
- **SetShipHullResources()**: System.Void (Private)
- **ShowUIAfterCrafting()**: System.Void (Private)
- **OnDiscardChangesClicked()**: System.Void (Private)
- **OnDiscardChangesConfirmed(System.String _)**: System.Void (Private)
- **OnDeconstructShipClicked()**: System.Void (Private)
- **OnDeconstructShipConfirmed(System.String _)**: System.Void (Private)
- **AreShipPartsSpawningResources(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.ReturnResourcesOnDestroy> shipPartResourceSpawners)**: System.Boolean (Private)
- **OnReconstructClicked()**: System.Void (Private)
- **OnScrapClicked()**: System.Void (Private)
- **OnScrapShipConfirmed(System.String _)**: System.Void (Private)
- **OnRenameShipClicked()**: System.Void (Private)
- **OnRenameShipConfirmed(System.String shipName)**: System.Void (Private)
- **UpdateShipName(System.String shipName)**: System.Void (Private)
- **UpdateShipInfo()**: System.Void (Private)
- **UpdateShipInfoThread()**: System.Threading.Tasks.Task (Private)
- **OnShipPartAdded(WildSkies.Ship.ShipPart shipPart)**: System.Void (Private)
- **OnShipPartRemoved(WildSkies.Ship.ShipPart shipPart)**: System.Void (Private)
- **UpdateShipParts()**: System.Void (Private)
- **UpdateShipPartsForRecovery()**: System.Void (Private)
- **InitShipPartDictionary()**: System.Void (Private)
- **ClearShipPartDictionary()**: System.Void (Private)
- **CreateShipPartEntry(System.String shipPartName, System.Int32 quantity, System.Single energy, System.Single weight)**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<SetupResourceSlots>b__88_0()**: System.Void (Private)
- **<SetupResourceSlots>b__88_1()**: System.Void (Private)
- **<OnReconstructClicked>b__106_0()**: System.Boolean (Private)
- **<OnReconstructClicked>b__106_1()**: System.Boolean (Private)
- **<UpdateShipInfoThread>b__113_0()**: System.Boolean (Private)

