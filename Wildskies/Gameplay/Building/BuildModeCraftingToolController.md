# WildSkies.Gameplay.Building.BuildModeCraftingToolController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _components | System.Collections.Generic.List`1<ShipPartComponentResources> | Private |

## Methods

- **.ctor(WildSkies.Service.BuildingService buildingService, WildSkies.Service.ICraftingService craftingService, WildSkies.Service.InputService inputService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.IPlayerInventoryService inventoryService, WildSkies.Gameplay.Building.CraftingToolPlacementData placementData, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.AudioService audioService, WildSkies.Service.IItemService itemService, UISystem.IUIService uiService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService)**: System.Void (Protected)
- **SetItemComponents(System.Collections.Generic.List`1<ShipPartComponentResources> components)**: System.Void (Public)
- **CountUpBuildProgress()**: System.Void (Public)
- **TryPlaceAsset()**: WildSkies.Service.BuildResult (Public)
- **CheckBuildAttemptResult()**: WildSkies.Service.BuildResult (Protected)
- **PlaceAsset()**: System.Void (Public)
- **CreateAsset(UnityEngine.GameObject asset, UnityEngine.Quaternion stampRotation, UnityEngine.Vector3 Position)**: UnityEngine.GameObject (Private)
- **OnAssetCreated(UnityEngine.GameObject gameObject)**: System.Void (Private)
- **CancelAssetPlacement()**: System.Void (Public)
- **ResetBuildTimeElapsed()**: System.Void (Public)

