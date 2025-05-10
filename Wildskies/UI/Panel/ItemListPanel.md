# Wildskies.UI.Panel.ItemListPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _craftingItemList | Wildskies.UI.Panel.CraftingItemList | Private |
| _craftingWindow | Wildskies.UI.Panel.CraftingWindow | Private |
| _craftingQueue | CraftingQueue | Private |
| _holdButtonThreshold | System.Single | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| OnWindowFocusChangeEvent | System.Action`1<System.String> | Public |
| _craftingWindowBehaviourController | CraftingWindowBehaviourController | Private |
| _currentWindow | Wildskies.UI.Panel.CurrentWindow | Private |
| _backButtonCurrentlyHeldDuration | System.Single | Private |
| _craftButtonCurrentlyHeldDuration | System.Single | Private |
| _takeAllButtonCurrentlyHeldDuration | System.Single | Private |
| _unloadedWithThisButtonPress | System.Boolean | Private |
| _craftedWithThisButtonPress | System.Boolean | Private |
| _takeAllWithThisButtonPress | System.Boolean | Private |
| _isShowingGallDiskBuild | System.Boolean | Private |
| _noKnownRecipes | System.Boolean | Private |
| _closeString | UnityEngine.Localization.LocalizedString | Private |
| _backString | UnityEngine.Localization.LocalizedString | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentWindow | Wildskies.UI.Panel.CurrentWindow | Public |

## Methods

- **get_CurrentWindow()**: Wildskies.UI.Panel.CurrentWindow (Public)
- **Awake()**: System.Void (Private)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **TryShowCraftingItemList(Wildskies.UI.Panel.CraftingMenuPanelPayload payload, System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematicsToShow)**: System.Boolean (Public)
- **TryShowBuildItemList(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematicsToShow)**: System.Boolean (Public)
- **UpdateKnownSchematicsList(System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftableItemBlueprint> schematicsToShow)**: System.Void (Public)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **ShowNoKnownRecipesMessage()**: System.Void (Private)
- **OnCategoryChanged()**: System.Void (Private)
- **UpdateCraftingWindowInfo(CraftableItemListEntry selectedItem)**: System.Void (Private)
- **InitialiseCraftingWindow(WildSkies.Gameplay.Crafting.CraftingMethod craftingMethod)**: System.Void (Private)
- **InitialiseCraftingQueue(CraftingStationInventory craftingStationInventory)**: System.Void (Private)
- **OnBeginCraft(WildSkies.Gameplay.Crafting.CraftableItemBlueprint currentSelectedSchematicData, WildSkies.Gameplay.Items.IItemDefinition itemDefinition)**: System.Void (Private)
- **ResetHoldPrompts()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **CheckForWindowFocusChange()**: System.Void (Private)
- **SetFocusToItemList()**: System.Void (Private)
- **SetFocusToCraftingWindow()**: System.Void (Private)
- **CurrentWindowFocusUpdate()**: System.Void (Private)
- **CheckCraftingQueueInput()**: System.Void (Private)
- **CheckCraftInput()**: System.Void (Private)
- **CheckUnloadInput()**: System.Void (Private)
- **CheckTakeAllInput()**: System.Void (Private)
- **SetCurrentWindow(Wildskies.UI.Panel.CurrentWindow window)**: System.Void (Private)
- **CheckForBackButtonPressed()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

