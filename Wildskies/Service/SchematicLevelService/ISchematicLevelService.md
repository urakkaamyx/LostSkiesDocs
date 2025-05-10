# WildSkies.Service.SchematicLevelService.ISchematicLevelService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| LevelUpData | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Items.Level.LevelUpItemData> | Public |
| CurrentSchematicLevels | System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.SchematicLevelService.SchematicLevel> | Public |
| OnSchemaLevelChanged | System.Action`1<System.String> | Public |

## Methods

- **get_LevelUpData()**: System.Collections.Generic.Dictionary`2<System.String,WildSkies.Gameplay.Items.Level.LevelUpItemData> (Public)
- **get_CurrentSchematicLevels()**: System.Collections.Generic.Dictionary`2<System.String,WildSkies.Service.SchematicLevelService.SchematicLevel> (Public)
- **get_OnSchemaLevelChanged()**: System.Action`1<System.String> (Public)
- **set_OnSchemaLevelChanged(System.Action`1<System.String> value)**: System.Void (Public)
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
- **TryGetOnlyLevelUpStats(System.String schematicId, System.Collections.Generic.Dictionary`2<System.String,System.Single>& currentLevelUpStats)**: System.Boolean (Public)
- **GetPreviousUnlockedGateLevel(System.String schematicId)**: System.Int32 (Public)
- **TryGetNextLevelGate(System.String schematicId)**: System.Int32 (Public)
- **TryGetNextLevelGateForLevel(System.String schematicId, System.Int32 level)**: System.Int32 (Public)
- **GetMaxLevelForCurrentTier(System.String schematicId)**: System.Int32 (Public)
- **TryGetStatsForSchematicLevel(System.String schematicId, System.Int32 level, System.Collections.Generic.Dictionary`2<System.String,System.Single>& stats)**: System.Boolean (Public)
- **CanLevelUpItem(System.String schematicId)**: System.Boolean (Public)
- **IsSchematicMaxLevel(System.String schematicId)**: System.Boolean (Public)
- **GetSchematicMaxLevel(System.String schematicId)**: System.Int32 (Public)
- **GetNextLevelGateRequirements(System.String schematicId)**: System.Collections.Generic.List`1<WildSkies.Gameplay.Items.Level.UpgradeGateRequirements> (Public)

