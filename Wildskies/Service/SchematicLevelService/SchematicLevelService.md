# WildSkies.Service.SchematicLevelService.SchematicLevelService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| XpScalingFactor | System.Int32 | Private |
| ItemLevelUpAddressablesKey | System.String | Private |
| _currentSchematicLevels | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.SchematicLevelService.SchematicLevel> | Private |
| _levelUpData | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Items.Level.LevelUpItemData> | Private |
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| <OnSchemaLevelChanged>k__BackingField | System.Action`1<System.String> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentSchematicLevels | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.SchematicLevelService.SchematicLevel> | Public |
| LevelUpData | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Items.Level.LevelUpItemData> | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |
| ServiceErrorCode | System.Int32 | Public |
| OnSchemaLevelChanged | System.Action`1<System.String> | Public |

## Methods

- **get_CurrentSchematicLevels()**: System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.SchematicLevelService.SchematicLevel> (Public)
- **get_LevelUpData()**: System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Items.Level.LevelUpItemData> (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_OnSchemaLevelChanged()**: System.Action`1<System.String> (Public)
- **set_OnSchemaLevelChanged(System.Action`1<System.String> value)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **LoadAssetsAsync()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnItemLevelUpAssetLoaded(WildSkies.Gameplay.Items.Level.LevelUpItemData levelUpItemData)**: System.Void (Private)
- **SetSchematicLevelSavedData(System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.SchematicLevelService.SchematicLevel> schematicLevels)**: System.Void (Public)
- **SetSchematicLevelAndXp(System.String schematicId, System.Int32 level, System.Int32 xp)**: System.Void (Public)
- **AddSchematicLevels(System.String schematicId, System.Int32 levelsToAdd, System.Int32 newXp)**: System.Void (Public)
- **ResetSchematicLevel(System.String schematicId)**: System.Void (Public)
- **GetSchematicLevel(System.String schematicId)**: System.Int32 (Public)
- **GetSchematicXp(System.String schematicId)**: System.Int32 (Public)
- **GetSchematicUnlockedGates(System.String schematicId)**: System.Int32 (Public)
- **GetRequiredXpForLevel(System.Int32 level)**: System.Int32 (Public)
- **GetRequiredLevelForXp(System.Int32 xp)**: System.Int32 (Public)
- **TryGetCurrentLevelStats(System.String schematicId, System.Collections.Generic.Dictionary`2<System.String,System.Single>& currentLevelUpStats)**: System.Boolean (Public)
- **TryGetNextLevelStats(System.String schematicId, System.Collections.Generic.Dictionary`2<System.String,System.Single>& nextLevelUpStats)**: System.Boolean (Public)
- **TryGetOnlyLevelUpStats(System.String schematicId, System.Int32 level, System.Collections.Generic.Dictionary`2<System.String,System.Single>& currentLevelUpStats)**: System.Boolean (Public)
- **GetFilteredStats(System.Collections.Generic.Dictionary`2<System.String,System.Single> currentStats, System.Collections.Generic.List`1<WildSkies.Gameplay.Items.Level.LevelUpItemStatsData> statsData)**: System.Collections.Generic.Dictionary`2<System.String,System.Single> (Private)
- **TryGetOnlyLevelUpStats(System.String schematicId, System.Collections.Generic.Dictionary`2<System.String,System.Single>& currentLevelUpStats)**: System.Boolean (Public)
- **GetPreviousUnlockedGateLevel(System.String schematicId)**: System.Int32 (Public)
- **GetMaxLevelForCurrentTier(System.String schematicId)**: System.Int32 (Public)
- **TryGetNextLevelGate(System.String schematicId)**: System.Int32 (Public)
- **TryGetNextLevelGateForLevel(System.String schematicId, System.Int32 level)**: System.Int32 (Public)
- **TryGetStatsForSchematicLevel(System.String schematicId, System.Int32 level, System.Collections.Generic.Dictionary`2<System.String,System.Single>& stats)**: System.Boolean (Public)
- **TryGetSchematicLevelUpData(System.String schematicId, WildSkies.Gameplay.Items.Level.LevelUpItemData& levelUpItemData)**: System.Boolean (Private)
- **CanLevelUpItem(System.String schematicId)**: System.Boolean (Public)
- **IsSchematicMaxLevel(System.String schematicId)**: System.Boolean (Public)
- **GetSchematicMaxLevel(System.String schematicId)**: System.Int32 (Public)
- **GetNextLevelGateRequirements(System.String schematicId)**: System.Collections.Generic.List`1<WildSkies.Gameplay.Items.Level.UpgradeGateRequirements> (Public)
- **GetStatsForSchematicLevel(System.Int32 level, WildSkies.Gameplay.Items.Level.LevelUpItemData levelUpItemData)**: System.Collections.Generic.Dictionary`2<System.String,System.Single> (Private)
- **.ctor()**: System.Void (Public)

