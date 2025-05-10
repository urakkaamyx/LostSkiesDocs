# WildSkies.Service.IArkComputerService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| OnArkComputerTierUnlocked | System.Action`2<WildSkies.IslandExport.Culture,System.Int32> | Public |
| OnCultureSaveDataChanged | System.Action | Public |
| OnFirstInteractionChanged | System.Action | Public |
| OnArkComputersInteractedWithUpdated | System.Action | Public |
| IsFirstInteraction | System.Boolean | Public |
| ArkComputersInteractedWith | System.Collections.Generic.List`1<System.String> | Public |
| CultureSaveData | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> | Public |
| CultureTiersData | System.Collections.Generic.List`1<Wildskies.Gameplay.ArkComputer.ArkComputerTierData> | Public |

## Methods

- **get_OnArkComputerTierUnlocked()**: System.Action`2<WildSkies.IslandExport.Culture,System.Int32> (Public)
- **set_OnArkComputerTierUnlocked(System.Action`2<WildSkies.IslandExport.Culture,System.Int32> value)**: System.Void (Public)
- **get_OnCultureSaveDataChanged()**: System.Action (Public)
- **set_OnCultureSaveDataChanged(System.Action value)**: System.Void (Public)
- **get_OnFirstInteractionChanged()**: System.Action (Public)
- **set_OnFirstInteractionChanged(System.Action value)**: System.Void (Public)
- **get_OnArkComputersInteractedWithUpdated()**: System.Action (Public)
- **set_OnArkComputersInteractedWithUpdated(System.Action value)**: System.Void (Public)
- **get_IsFirstInteraction()**: System.Boolean (Public)
- **set_IsFirstInteraction(System.Boolean value)**: System.Void (Public)
- **SetFirstInteraction()**: System.Void (Public)
- **InteractedWithArkComputer(System.String arkComputerId)**: System.Void (Public)
- **get_ArkComputersInteractedWith()**: System.Collections.Generic.List`1<System.String> (Public)
- **set_ArkComputersInteractedWith(System.Collections.Generic.List`1<System.String> value)**: System.Void (Public)
- **get_CultureSaveData()**: System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> (Public)
- **get_CultureTiersData()**: System.Collections.Generic.List`1<Wildskies.Gameplay.ArkComputer.ArkComputerTierData> (Public)
- **GetCultureTiersData(WildSkies.IslandExport.Culture culture)**: Wildskies.Gameplay.ArkComputer.ArkComputerTierData (Public)
- **GetAllUnlockedItemsIdsForCulture(WildSkies.IslandExport.Culture culture)**: System.Collections.Generic.List`1<System.String> (Public)
- **GetCultureUnlockedTier(WildSkies.IslandExport.Culture culture)**: System.Int32 (Public)
- **GetCultureSpentDataDiskAmount(WildSkies.IslandExport.Culture culture)**: System.Int32 (Public)
- **UnlockNewTierForCulture(WildSkies.IslandExport.Culture culture, System.Int32 newTier)**: System.Void (Public)
- **UnlockItemForCulture(WildSkies.IslandExport.Culture culture, System.String unlockableId, System.Int32 dataDiskSpent)**: System.Void (Public)
- **SetCultureDataDiskSpentAmount(WildSkies.IslandExport.Culture culture, System.Int32 value)**: System.Void (Public)
- **SetCulturesSavedData(System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> cultureSaveData)**: System.Void (Public)
- **GetCurrentUnlockedTierDataForCulture(WildSkies.IslandExport.Culture culture)**: Wildskies.Gameplay.ArkComputer.TierData (Public)

