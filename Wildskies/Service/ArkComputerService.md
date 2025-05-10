# WildSkies.Service.ArkComputerService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| ArkComputerAddressablesKey | System.String | Private |
| _culturesTiersData | System.Collections.Generic.List`1<Wildskies.Gameplay.ArkComputer.ArkComputerTierData> | Private |
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| <OnArkComputerTierUnlocked>k__BackingField | System.Action`2<WildSkies.IslandExport.Culture,System.Int32> | Private |
| <OnCultureSaveDataChanged>k__BackingField | System.Action | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _culturesSaveData | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> | Private |
| _arkComputersInteractedWith | System.Collections.Generic.List`1<System.String> | Private |
| <OnFirstInteractionChanged>k__BackingField | System.Action | Private |
| <OnArkComputersInteractedWithUpdated>k__BackingField | System.Action | Private |
| _isFirstInteraction | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CultureTiersData | System.Collections.Generic.List`1<Wildskies.Gameplay.ArkComputer.ArkComputerTierData> | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| FinishedInitialisation | System.Boolean | Public |
| ServiceErrorCode | System.Int32 | Public |
| OnArkComputerTierUnlocked | System.Action`2<WildSkies.IslandExport.Culture,System.Int32> | Public |
| OnCultureSaveDataChanged | System.Action | Public |
| ArkComputersInteractedWith | System.Collections.Generic.List`1<System.String> | Public |
| OnFirstInteractionChanged | System.Action | Public |
| OnArkComputersInteractedWithUpdated | System.Action | Public |
| IsFirstInteraction | System.Boolean | Public |
| CultureSaveData | System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> | Public |

## Methods

- **get_CultureTiersData()**: System.Collections.Generic.List`1<Wildskies.Gameplay.ArkComputer.ArkComputerTierData> (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_OnArkComputerTierUnlocked()**: System.Action`2<WildSkies.IslandExport.Culture,System.Int32> (Public)
- **set_OnArkComputerTierUnlocked(System.Action`2<WildSkies.IslandExport.Culture,System.Int32> value)**: System.Void (Public)
- **get_OnCultureSaveDataChanged()**: System.Action (Public)
- **set_OnCultureSaveDataChanged(System.Action value)**: System.Void (Public)
- **get_ArkComputersInteractedWith()**: System.Collections.Generic.List`1<System.String> (Public)
- **set_ArkComputersInteractedWith(System.Collections.Generic.List`1<System.String> value)**: System.Void (Public)
- **get_OnFirstInteractionChanged()**: System.Action (Public)
- **set_OnFirstInteractionChanged(System.Action value)**: System.Void (Public)
- **get_OnArkComputersInteractedWithUpdated()**: System.Action (Public)
- **set_OnArkComputersInteractedWithUpdated(System.Action value)**: System.Void (Public)
- **get_IsFirstInteraction()**: System.Boolean (Public)
- **set_IsFirstInteraction(System.Boolean value)**: System.Void (Public)
- **SetFirstInteraction()**: System.Void (Public)
- **InteractedWithArkComputer(System.String arkComputerId)**: System.Void (Public)
- **get_CultureSaveData()**: System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnArkComputerDataLoaded(Wildskies.Gameplay.ArkComputer.ArkComputerTierData arkComputerTierData)**: System.Void (Private)
- **GetCultureTiersData(WildSkies.IslandExport.Culture culture)**: Wildskies.Gameplay.ArkComputer.ArkComputerTierData (Public)
- **GetAllUnlockedItemsIdsForCulture(WildSkies.IslandExport.Culture culture)**: System.Collections.Generic.List`1<System.String> (Public)
- **SetCulturesSavedData(System.Collections.Generic.Dictionary`2<WildSkies.IslandExport.Culture,WildSkies.Service.ArkComputerSaveData> cultureSaveData)**: System.Void (Public)
- **GetCurrentUnlockedTierDataForCulture(WildSkies.IslandExport.Culture culture)**: Wildskies.Gameplay.ArkComputer.TierData (Public)
- **GetCultureUnlockedTier(WildSkies.IslandExport.Culture culture)**: System.Int32 (Public)
- **GetCultureSpentDataDiskAmount(WildSkies.IslandExport.Culture culture)**: System.Int32 (Public)
- **UnlockNewTierForCulture(WildSkies.IslandExport.Culture culture, System.Int32 newTier)**: System.Void (Public)
- **UnlockItemForCulture(WildSkies.IslandExport.Culture culture, System.String unlockableId, System.Int32 dataDiskSpent)**: System.Void (Public)
- **SetCultureDataDiskSpentAmount(WildSkies.IslandExport.Culture culture, System.Int32 amount)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

