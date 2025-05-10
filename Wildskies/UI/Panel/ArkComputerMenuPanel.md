# Wildskies.UI.Panel.ArkComputerMenuPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Unlock | System.Int32 | Private |
| DataDiskId | System.String | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _arkComputerService | WildSkies.Service.IArkComputerService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _conversationService | WildSkies.Service.IConversationService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _unlockAnimationEvents | TierUnlockAnimationEvents | Private |
| _currentIslandCulture | WildSkies.IslandExport.Culture | Private |
| _viewModel | Wildskies.UI.Panel.ArkComputerMenuPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.ArkComputerMenuPanelPayload | Private |
| _knowledgeData | WildSkies.Service.ISchematicKnowledgeData | Private |
| _currentSchematic | WildSkies.Gameplay.Crafting.CraftableItemBlueprint | Private |
| _tierEntries | System.Collections.Generic.List`1<ArkComputerTierEntry> | Private |
| _allUnlockedItemsIds | System.Collections.Generic.List`1<System.String> | Private |
| _currentUnlockedTierLevel | System.Int32 | Private |
| _currentDataDisksAmount | System.Int32 | Private |
| _currentSelectedItem | ArkComputerTierItemButton | Private |
| _acquireButtonCurrentHeldDuration | System.Single | Private |
| _gamepadAcquireButtonPressed | System.Boolean | Private |
| _navigation | UnityEngine.UI.Navigation | Private |
| _isPanelOpen | System.Boolean | Private |
| _isUnlockAnimationPlaying | System.Boolean | Private |
| _firstIn | System.Boolean | Private |
| _firstInTimer | System.Single | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _dynamikaCharacter | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _currentCameraTransform | UnityEngine.Transform | Private |
| _cachedPosition | UnityEngine.Vector3 | Private |
| _currentTweenSequence | DG.Tweening.Sequence | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **PlayPulseAnimation()**: System.Void (Private)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **SetAllUnlockedItemsIds()**: System.Void (Private)
- **IsAllUnlockablesUnlocked()**: System.Boolean (Private)
- **ShowTierItemPanel()**: System.Void (Private)
- **ShowTierMaxPanel()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isNewInputGamepad)**: System.Void (Private)
- **SetTierPanelEntries()**: System.Void (Private)
- **SetTierPanelItemButtonNavigation()**: System.Void (Private)
- **SetTierItemButtonSelection()**: System.Void (Private)
- **SetCurrentSelectedItemState()**: System.Void (Private)
- **SetCurrentDataDiskAmount()**: System.Void (Private)
- **RefreshDataDiskCounter()**: System.Void (Private)
- **OnTierItemButtonClicked(ArkComputerTierItemButton tierItemData)**: System.Void (Private)
- **RefreshTooltipAndAcquireButton()**: System.Void (Private)
- **RefreshTooltipUI()**: System.Void (Private)
- **RefreshAcquireUiByInput(System.Boolean isInputGamepad)**: System.Void (Private)
- **ToggleDisableAcquireInput(System.Boolean isDisable)**: System.Void (Private)
- **CheckAcquireInput()**: System.Void (Private)
- **OnAcquiredButtonClicked()**: System.Void (Private)
- **RefreshTierEntries()**: System.Void (Private)
- **TryUnlockNextTier()**: System.Void (Private)
- **GetNextTierUnlockCost()**: System.Int32 (Private)
- **AcquireTierItem()**: System.Void (Private)
- **UpgradeItem()**: System.Void (Private)
- **TriggerUnlockAnimation()**: System.Void (Private)
- **OnTierUnlockAnimationEnded()**: System.Void (Private)
- **StartConversation(System.String conversationId)**: System.Void (Private)
- **OnConversationFinished()**: System.Void (Private)
- **ChangeCameraControl()**: System.Void (Private)
- **MoveCameraToComputer()**: System.Void (Private)
- **MoveCameraToOriginalPosition()**: System.Void (Private)
- **RevertCameraView()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)
- **<MoveCameraToComputer>b__73_0()**: System.Void (Private)
- **<MoveCameraToOriginalPosition>b__74_0()**: System.Void (Private)

