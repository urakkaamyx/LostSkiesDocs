# WildSkies.Gameplay.Building.BuildingInput

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _currentTryBuildResult | WildSkies.Service.BuildResult | Private |
| _buildModeLastFrame | BuildMode | Private |
| _stickHeldTime | System.Single | Private |
| _lastInputSign | System.Single | Private |
| _coarseRotationPingTime | System.Single | Private |

## Methods

- **.ctor(WildSkies.Service.BuildingService buildingService, WildSkies.Service.InputService inputService)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **ProcessInput()**: System.Void (Private)
- **ProcessRotationOnController(WildSkies.Gameplay.Building.CraftingToolController currentController, System.Single inputValue)**: System.Void (Private)

