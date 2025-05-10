# WildSkies.Gameplay.Building.EditModeCraftingToolController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _currentAssetPickedUp | WildSkies.Gameplay.Building.BuildableAsset | Private |
| OnEditItemAttemptFailed | System.Action`2<System.Boolean,System.Boolean> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentAssetPickedUp | WildSkies.Gameplay.Building.BuildableAsset | Public |

## Methods

- **get_CurrentAssetPickedUp()**: WildSkies.Gameplay.Building.BuildableAsset (Public)
- **.ctor(WildSkies.Service.BuildingService buildingService, WildSkies.Service.ICraftingService craftingService, WildSkies.Service.InputService inputService, WildSkies.Service.WildSkiesInstantiationService instantiationService, WildSkies.Service.IPlayerInventoryService inventoryService, WildSkies.Gameplay.Building.CraftingToolPlacementData placementData, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.AudioService audioService, WildSkies.Service.IItemService itemService, UISystem.IUIService uiService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService)**: System.Void (Protected)
- **PickUpOrDropExistingItem()**: System.Void (Public)
- **GetStampTemplates(WildSkies.Gameplay.Building.BuildableAsset pickupAsset)**: System.Collections.Generic.List`1<WildSkies.Gameplay.Building.PlacementStampTemplate> (Private)
- **AddObjectsToIgnore(WildSkies.Gameplay.Building.BuildableAsset pickupAsset)**: System.Void (Private)
- **TryPlaceAsset()**: WildSkies.Service.BuildResult (Public)
- **CheckBuildAttemptResult()**: WildSkies.Service.BuildResult (Protected)
- **CheckDeleteAttemptResult()**: WildSkies.Service.DeleteResult (Private)
- **PlaceAsset()**: System.Void (Public)
- **GetExcludedObjects()**: System.Collections.Generic.List`1<UnityEngine.GameObject> (Public)
- **CancelAssetPlacement()**: System.Void (Public)
- **CountUpDeleteProgress()**: System.Void (Public)
- **StartDeleteAsset()**: System.Void (Public)
- **DeleteObject()**: System.Void (Private)
- **DeleteBuildableAsset()**: System.Boolean (Private)
- **DeletePanel()**: System.Boolean (Private)
- **DeleteBeam()**: System.Boolean (Private)
- **ResetDeleteTimeElapsed()**: System.Void (Public)

