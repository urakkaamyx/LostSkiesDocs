# WildSkies.Service.AILevelsService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| DisplayLevelMax | System.Int32 | Public |
| _attackDamages | System.Int32[] | Private |
| _regionInfoLookUp | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Region,WildSkies.Service.AILevelsService/RegionInfo> | Private |
| _islandInfoLookUp | System.Collections.Generic.Dictionary`2<WildSkies.WorldItems.Island/IslandDifficulty,WildSkies.Service.AILevelsService/IslandInfo> | Private |
| OnAttackDamageScaled | System.Func`2<System.Single,System.Int32> | Public |
| OnEffectiveDamageScaled | System.Func`5<System.Single,System.Int32,System.Int32,WildSkies.Service.AILevelsService/DamageDirection,System.Int32> | Public |
| _data | WildSkies.AI.AILevelServiceData | Private |
| _dataPath | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| Data | WildSkies.AI.AILevelServiceData | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_Data()**: WildSkies.AI.AILevelServiceData (Public)
- **.ctor(WildSkies.AI.AILevelServiceData data)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **GetLevelData(System.Int32 level, WildSkies.Gameplay.AI.AILevelDefinition levelDefinition, System.Int32& health, System.Int32[]& attackDamage)**: System.Void (Public)
- **GetLevel(WildSkies.Gameplay.AI.AIDefinition aiDefinition, System.Int32 islandLevel, WildSkies.IslandExport.Region region, WildSkies.WorldItems.Island/IslandDifficulty islandDifficulty)**: System.Int32 (Public)
- **GetLevel(WildSkies.Gameplay.AI.AIDefinition aiDefinition, System.Int32 islandLevel, WildSkies.IslandExport.Region region)**: System.Int32 (Public)

