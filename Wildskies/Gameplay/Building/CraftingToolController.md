# WildSkies.Gameplay.Building.CraftingToolController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| DEGREE_TOLERANCE | System.Single | Private |
| BEAM_ITEM_ID_PREFIX | System.String | Public |
| PANEL_ITEM_ID_PREFIX | System.String | Public |
| PANEL_ITEM_ID_FULL | System.String | Public |
| PANEL_ITEM_ID_HALF | System.String | Public |
| MULTISELECT_EDIT_ITEM_ID | System.String | Public |
| _placementData | WildSkies.Gameplay.Building.CraftingToolPlacementData | Protected |
| _buildingService | WildSkies.Service.BuildingService | Protected |
| _craftingService | WildSkies.Service.ICraftingService | Protected |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Protected |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Protected |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Protected |
| _itemService | WildSkies.Service.IItemService | Private |
| _uiService | UISystem.IUIService | Protected |
| _placementPerformedThisClick | System.Boolean | Protected |
| _deletePerformedThisClick | System.Boolean | Protected |
| _lastPlacementState | System.Boolean | Private |
| _lastVisibleState | System.Boolean | Private |
| _buildTimeElapsed | System.Single | Protected |
| _deleteTimeElapsed | System.Single | Protected |
| _currentRotationStepIndex | System.Int32 | Private |
| _lastShipHullFaceWithStamp | WildSkies.Gameplay.ShipBuilding.ShipHullFace | Private |
| _lastShipHullEdgeWithStamp | WildSkies.Gameplay.ShipBuilding.ShipHullEdge | Private |
| HoldTimeToDelete | System.Single | Protected |
| _localRotation | UnityEngine.Quaternion | Private |
| _placementTargetYRotation | UnityEngine.Quaternion | Private |
| _finePlacement | System.Boolean | Private |
| _shipCoreInfoHUDVisible | System.Boolean | Private |
| _audioService | WildSkies.Service.AudioService | Protected |

## Properties

| Name | Type | Access |
|------|------|--------|
| PlacementData | WildSkies.Gameplay.Building.CraftingToolPlacementData | Public |

## Methods

- **get_PlacementData()**: WildSkies.Gameplay.Building.CraftingToolPlacementData (Public)
- **.ctor(WildSkies.Service.BuildingService buildingService, WildSkies.Service.ICraftingService craftingService, WildSkies.Service.InputService inputService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.IPlayerInventoryService inventoryService, WildSkies.Gameplay.Building.CraftingToolPlacementData placementData, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.AudioService audioService, WildSkies.Service.IItemService itemService, UISystem.IUIService uiService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService)**: System.Void (Protected)
- **OnModeExit()**: System.Void (Public)
- **SetBuildableItemToPlace(WildSkies.Gameplay.ShipBuilding.ShipPartPlacementMatrix placementMatrix, WildSkies.Gameplay.Building.BuildableItemDefinition assetData, System.Collections.Generic.List`1<System.String> craftingItemIds, System.Int32 upgradeLevel, WildSkies.Gameplay.Building.PlacementStampController placementStamp)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **ClearSelectionData()**: System.Void (Protected)
- **HideShipCoreInfoHUD()**: System.Void (Private)
- **UpdatePlacementStamp()**: System.Void (Private)
- **IsShipCoreInfoValid(WildSkies.Gameplay.ShipBuilding.ConstructedShipController& shipController)**: System.Boolean (Private)
- **UpdatePanelPlacementStamp()**: System.Void (Private)
- **UpdateBeamPlacementStamp()**: System.Void (Private)
- **UpdateVisibility(System.Boolean canPlace)**: System.Boolean (Private)
- **SetPlacementStampColour(System.Boolean canPlace)**: System.Void (Private)
- **TryPlaceAsset()**: WildSkies.Service.BuildResult (Public)
- **CheckBuildAttemptResult()**: WildSkies.Service.BuildResult (Protected)
- **PlaceAsset()**: System.Void (Public)
- **CancelAssetPlacement()**: System.Void (Public)
- **RotateAsset(System.Single inputValue, System.Boolean useFineRotation)**: System.Void (Public)
- **GetBuildProgress()**: System.Single (Public)
- **GetDeleteProgress()**: System.Single (Public)
- **HasBuildingResources(WildSkies.Gameplay.Building.BuildableItemDefinition buildable)**: System.Boolean (Protected)
- **HasResourceInInventory(WildSkies.Gameplay.Crafting.CraftingComponent component)**: System.Boolean (Private)
- **SpendResources()**: System.Void (Protected)
- **SetPlacementPerformedThisAction(System.Boolean itemPlaced)**: System.Void (Public)
- **SetDeletePerformedThisAction(System.Boolean itemDeleted)**: System.Void (Public)
- **SetFinePlacement(System.Boolean finePlacement)**: System.Void (Public)
- **RemoveYRotation(UnityEngine.Quaternion inputRotation)**: UnityEngine.Quaternion (Public)

