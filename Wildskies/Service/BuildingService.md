# WildSkies.Service.BuildingService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _isServiceReady | System.Boolean | Private |
| UseTestAssets | System.Boolean | Public |
| AssetAddressableGameKey | System.String | Private |
| AssetAddressableTestKey | System.String | Private |
| StampAddressableGameKey | System.String | Private |
| StampAddressableTestKey | System.String | Private |
| MatrixAddressableGameKey | System.String | Private |
| <IsDeleting>k__BackingField | System.Boolean | Private |
| _referenceCamTransform | UnityEngine.Transform | Private |
| _placementStampRenderPass | Visual.CustomPasses.GhostObjectPass | Private |
| _placementMatrix | WildSkies.Gameplay.ShipBuilding.ShipPartPlacementMatrix | Private |
| FabricationHelper | FabricationHelper | Public |
| _currentController | WildSkies.Gameplay.Building.CraftingToolController | Private |
| _buildModeController | WildSkies.Gameplay.Building.BuildModeCraftingToolController | Private |
| _editModeController | WildSkies.Gameplay.Building.EditModeCraftingToolController | Private |
| _currentBuildMode | BuildMode | Private |
| OnPlacementAttempted | System.Action`3<WildSkies.Gameplay.Building.CraftingToolController,WildSkies.Gameplay.Building.BuildableItemDefinition,WildSkies.Service.BuildResult> | Public |
| OnBuildCompletedSuccessfully | System.Action`1<WildSkies.Gameplay.Building.BuildableItemDefinition> | Public |
| OnBuildCompletedSuccessfullyWithObject | System.Action`2<WildSkies.Gameplay.Building.BuildableItemDefinition,UnityEngine.GameObject> | Public |
| OnBuildModeChanged | System.Action`1<BuildMode> | Public |
| OnPlacementCancelled | System.Action | Public |
| OnBuildMovedSuccessfully | System.Action`1<WildSkies.Gameplay.Building.BuildableAsset> | Public |
| OnDeleteStarted | System.Action`1<WildSkies.Gameplay.Building.CraftingToolController> | Public |
| OnDeleted | System.Action | Public |
| OnDeleteCancelled | System.Action`1<WildSkies.Service.DeleteResult> | Public |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _buildableItems | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.BuildableItemDefinition> | Private |
| _placementStampAddressables | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampController> | Private |
| _placementStamps | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Building.PlacementStampControllerInstance> | Private |
| _placementStampInstantiator | System.Action`2<System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate>,WildSkies.Gameplay.Building.PlacementStampControllerInstance> | Private |
| _placementStampDynamicSetup | System.Action`2<System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate>,WildSkies.Gameplay.Building.PlacementStampControllerInstance> | Private |
| FreeBuilding | System.Boolean | Public |
| _playerShipBubbles | System.Collections.Generic.HashSet`1<ShipyardPlayerDetection> | Private |
| _lastLadderBuildPosition | UnityEngine.Vector3 | Private |
| _lastLadderBuildScale | UnityEngine.Vector3 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |
| IsServiceReady | System.Boolean | Public |
| BuildableAssetAddressablesKey | System.String | Private |
| PlacementStampAddressablesKey | System.String | Private |
| BuildableMatrixAddressablesKey | System.String | Private |
| IsDeleting | System.Boolean | Public |
| CurrentController | WildSkies.Gameplay.Building.CraftingToolController | Public |
| CurrentBuildMode | BuildMode | Public |
| ReferenceCamTransform | UnityEngine.Transform | Public |
| PlacementStampRenderPass | Visual.CustomPasses.GhostObjectPass | Public |
| BuildableItems | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.BuildableItemDefinition> | Public |
| PlacementStampAddressables | System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampController> | Public |
| PlayerShipBubbles | System.Collections.Generic.HashSet`1<ShipyardPlayerDetection> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_IsServiceReady()**: System.Boolean (Public)
- **get_BuildableAssetAddressablesKey()**: System.String (Private)
- **get_PlacementStampAddressablesKey()**: System.String (Private)
- **get_BuildableMatrixAddressablesKey()**: System.String (Private)
- **get_IsDeleting()**: System.Boolean (Public)
- **set_IsDeleting(System.Boolean value)**: System.Void (Public)
- **get_CurrentController()**: WildSkies.Gameplay.Building.CraftingToolController (Public)
- **get_CurrentBuildMode()**: BuildMode (Public)
- **get_ReferenceCamTransform()**: UnityEngine.Transform (Public)
- **get_PlacementStampRenderPass()**: Visual.CustomPasses.GhostObjectPass (Public)
- **get_BuildableItems()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Building.BuildableItemDefinition> (Public)
- **get_PlacementStampAddressables()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampController> (Public)
- **get_PlayerShipBubbles()**: System.Collections.Generic.HashSet`1<ShipyardPlayerDetection> (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **LoadBuildableAssets()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnBuildableItemLoaded(WildSkies.Gameplay.Building.BuildableItemDefinition buildable)**: System.Void (Private)
- **OnPlacementStampLoaded(UnityEngine.GameObject placementStamp)**: System.Void (Private)
- **OnPlacementMatrixLoaded(WildSkies.Gameplay.ShipBuilding.ShipPartPlacementMatrix placementMatrix)**: System.Void (Private)
- **CreatePlacementStampDictionary(System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Building.PlacementStampControllerInstance> dictionary, System.Action`2<System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate>,WildSkies.Gameplay.Building.PlacementStampControllerInstance> stampInstantiator, System.Action`2<System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate>,WildSkies.Gameplay.Building.PlacementStampControllerInstance> stampDynamicSetup)**: System.Void (Public)
- **CreateControllers(WildSkies.Service.InputService inputService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.IPlayerInventoryService inventoryService, WildSkies.Service.ICraftingService craftingService, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.AudioService audioService, WildSkies.Service.IItemService itemService, UISystem.IUIService uiService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **EnterBuildMode(BuildMode mode, WildSkies.Gameplay.Building.BuildableItemDefinition defaultSelection)**: System.Void (Public)
- **ExitBuildMode()**: System.Void (Public)
- **SetSelectedAsset(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> stampTemplates)**: System.Void (Public)
- **SetReferenceCamera(UnityEngine.Transform camera)**: System.Void (Public)
- **GetStampInstanceController(System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> stampTemplates)**: WildSkies.Gameplay.Building.PlacementStampController (Public)
- **GetSchematicForItem(WildSkies.Gameplay.Building.PlacementStampController asset)**: WildSkies.Gameplay.Building.BuildableItemDefinition (Private)
- **GetBuildableItemByName(System.String name, WildSkies.Gameplay.Building.BuildableItemDefinition& buildable)**: System.Boolean (Public)
- **GetBuildableItemDefinitionById(System.String id, WildSkies.Gameplay.Building.BuildableItemDefinition& buildable)**: System.Boolean (Public)
- **GetBuildableItemNames()**: System.String[] (Public)
- **SetPlacementStampRenderPass(Visual.CustomPasses.GhostObjectPass renderPass)**: System.Void (Public)
- **AddToBubbles(ShipyardPlayerDetection bubble)**: System.Void (Public)
- **RemoveFromBubbles(ShipyardPlayerDetection bubble)**: System.Void (Public)
- **SetBuildingFree(System.Boolean isFree)**: System.Void (Public)
- **GetStampDictionary()**: System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Building.PlacementStampControllerInstance> (Public)
- **.ctor()**: System.Void (Public)

