# WildSkies.Mediators.BuildingMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _input | WildSkies.Gameplay.Building.BuildingInput | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _fabricationHelper | FabricationHelper | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _isDeleting | System.Boolean | Private |
| _placementStampParent | UnityEngine.GameObject | Private |
| _notificationArgumentsAux | System.Object[] | Private |

## Methods

- **Initialise(UISystem.IUIService uiService, WildSkies.Service.BuildingService buildingService, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.InputService inputService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.IPlayerInventoryService inventoryService, WildSkies.Service.ICraftingService craftingService, WildSkies.Service.AudioService audioService, WildSkies.Service.IItemService itemService, WildSkies.Service.LocalisationService localisationService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **OnLocalPlayerRegistered()**: System.Void (Private)
- **CreatePlacementStamps()**: System.Void (Private)
- **PlacementStampInstantiator(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> stampTemplates, WildSkies.Gameplay.Building.PlacementStampControllerInstance placementStampControllerInstance)**: System.Void (Private)
- **PlacementStampDynamicSetup(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> stampTemplates, WildSkies.Gameplay.Building.PlacementStampControllerInstance placementStampControllerInstance)**: System.Void (Private)
- **UpdateShipPartMaterialDescriptors(WildSkies.Gameplay.Building.PlacementStampTemplate baseStampTemplate, UnityEngine.GameObject objectBase)**: System.Void (Private)
- **AssignPlacementGhostRenderPass()**: System.Void (Private)
- **ShowPlacementChargeHud(WildSkies.Gameplay.Building.CraftingToolController payload)**: System.Void (Private)
- **DeleteStarted(WildSkies.Gameplay.Building.CraftingToolController payload)**: System.Void (Private)
- **DeleteCancelled(WildSkies.Service.DeleteResult result)**: System.Void (Private)
- **ShowAssetBuiltNotification(WildSkies.Gameplay.Building.BuildableItemDefinition assetPlaced)**: System.Void (Private)
- **ProcessBuildAttemptResult(WildSkies.Gameplay.Building.CraftingToolController payload, WildSkies.Gameplay.Building.BuildableItemDefinition assetToPlace, WildSkies.Service.BuildResult result)**: System.Void (Private)
- **ShowPickupFailedMessage(System.Boolean shipyardBubbleFail, System.Boolean canBeDismantled)**: System.Void (Private)
- **Update()**: System.Void (Public)
- **ActiveToolChange()**: System.Void (Private)
- **EnterBuildMode()**: System.Void (Private)
- **ExitBuildMode()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

