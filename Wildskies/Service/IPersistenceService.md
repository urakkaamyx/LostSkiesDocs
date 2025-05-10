# WildSkies.Service.IPersistenceService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| CurrentCharacterSaveSlot | System.Int32 | Public |
| CurrentWorldSaveSlot | System.Int32 | Public |
| CurrentCharacterSaveData | CharacterSaveData | Public |
| CurrentPerWorldData | PerWorldData | Public |
| HasDataForCurrentWorld | System.Boolean | Public |
| CurrentWorldSaveData | WorldSaveData | Public |
| CurrentWorldId | System.String | Public |
| GetExistingSlotsForKeyRequested | System.Action`1<System.String> | Public |
| GetNextAvailableSlotForKeyRequested | System.Action`1<System.String> | Public |
| SaveRequested | System.Action`4<System.Int32,System.String,System.String,System.Guid> | Public |
| LoadRequested | System.Action`3<System.Int32,System.String,System.Guid> | Public |
| ClearRequested | System.Action`3<System.Int32,System.String,System.Guid> | Public |
| GetExistingSlotsForKeyCompleted | System.Action`3<System.Boolean,System.String,System.Collections.Generic.List`1<System.Int32>> | Public |
| GetNextAvailableSlotForKeyCompleted | System.Action`3<System.Boolean,System.String,System.Int32> | Public |
| SaveCompleted | System.Action`3<System.Boolean,System.String,System.Guid> | Public |
| LoadCompleted | System.Action`5<System.Boolean,System.Int32,System.String,System.String,System.Guid> | Public |
| ClearCompleted | System.Action`4<System.Boolean,System.Int32,System.String,System.Guid> | Public |
| FullSaveRequested | System.Action | Public |
| FullSaveCompleted | System.Action | Public |
| IslandDataCached | System.Action`1<System.String> | Public |

## Methods

- **get_CurrentCharacterSaveSlot()**: System.Int32 (Public)
- **get_CurrentWorldSaveSlot()**: System.Int32 (Public)
- **get_CurrentCharacterSaveData()**: CharacterSaveData (Public)
- **get_CurrentPerWorldData()**: PerWorldData (Public)
- **get_HasDataForCurrentWorld()**: System.Boolean (Public)
- **get_CurrentWorldSaveData()**: WorldSaveData (Public)
- **get_CurrentWorldId()**: System.String (Public)
- **get_GetExistingSlotsForKeyRequested()**: System.Action`1<System.String> (Public)
- **set_GetExistingSlotsForKeyRequested(System.Action`1<System.String> value)**: System.Void (Public)
- **get_GetNextAvailableSlotForKeyRequested()**: System.Action`1<System.String> (Public)
- **set_GetNextAvailableSlotForKeyRequested(System.Action`1<System.String> value)**: System.Void (Public)
- **get_SaveRequested()**: System.Action`4<System.Int32,System.String,System.String,System.Guid> (Public)
- **set_SaveRequested(System.Action`4<System.Int32,System.String,System.String,System.Guid> value)**: System.Void (Public)
- **get_LoadRequested()**: System.Action`3<System.Int32,System.String,System.Guid> (Public)
- **set_LoadRequested(System.Action`3<System.Int32,System.String,System.Guid> value)**: System.Void (Public)
- **get_ClearRequested()**: System.Action`3<System.Int32,System.String,System.Guid> (Public)
- **set_ClearRequested(System.Action`3<System.Int32,System.String,System.Guid> value)**: System.Void (Public)
- **get_GetExistingSlotsForKeyCompleted()**: System.Action`3<System.Boolean,System.String,System.Collections.Generic.List`1<System.Int32>> (Public)
- **set_GetExistingSlotsForKeyCompleted(System.Action`3<System.Boolean,System.String,System.Collections.Generic.List`1<System.Int32>> value)**: System.Void (Public)
- **get_GetNextAvailableSlotForKeyCompleted()**: System.Action`3<System.Boolean,System.String,System.Int32> (Public)
- **set_GetNextAvailableSlotForKeyCompleted(System.Action`3<System.Boolean,System.String,System.Int32> value)**: System.Void (Public)
- **get_SaveCompleted()**: System.Action`3<System.Boolean,System.String,System.Guid> (Public)
- **set_SaveCompleted(System.Action`3<System.Boolean,System.String,System.Guid> value)**: System.Void (Public)
- **get_LoadCompleted()**: System.Action`5<System.Boolean,System.Int32,System.String,System.String,System.Guid> (Public)
- **set_LoadCompleted(System.Action`5<System.Boolean,System.Int32,System.String,System.String,System.Guid> value)**: System.Void (Public)
- **get_ClearCompleted()**: System.Action`4<System.Boolean,System.Int32,System.String,System.Guid> (Public)
- **set_ClearCompleted(System.Action`4<System.Boolean,System.Int32,System.String,System.Guid> value)**: System.Void (Public)
- **get_FullSaveRequested()**: System.Action (Public)
- **set_FullSaveRequested(System.Action value)**: System.Void (Public)
- **get_FullSaveCompleted()**: System.Action (Public)
- **set_FullSaveCompleted(System.Action value)**: System.Void (Public)
- **get_IslandDataCached()**: System.Action`1<System.String> (Public)
- **set_IslandDataCached(System.Action`1<System.String> value)**: System.Void (Public)
- **GetExistingSlotsForKey(System.String key)**: System.Void (Public)
- **GetNextAvailableSlotForKey(System.String key)**: System.Void (Public)
- **SaveData(System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Public)
- **LoadData(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Public)
- **ClearData(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Public)
- **GetExistingSlotsForKeyComplete(System.Boolean success, System.String key, System.Collections.Generic.List`1<System.Int32> slots)**: System.Void (Public)
- **GetNextAvailableSlotForKeyComplete(System.Boolean success, System.String key, System.Int32 slot)**: System.Void (Public)
- **SaveComplete(System.Boolean success, System.String key, System.Guid requestId)**: System.Void (Public)
- **LoadComplete(System.Boolean success, System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Public)
- **ClearComplete(System.Boolean success, System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Public)
- **MigrateCharacterSaveDataToLatestVersion(CharacterSaveData originalCharacterSaveData, CharacterSaveData& migratedCharacterSaveData, System.Boolean& wasMigrated)**: System.Boolean (Public)
- **MigrateWorldSaveDataToLatestVersion(WorldSaveData originalWorldSaveData, WorldSaveData& migratedWorldSaveData, System.Boolean& wasMigrated)**: System.Boolean (Public)
- **SetSlotForTest()**: System.Void (Public)
- **SetCharacterSaveSlot(System.Int32 saveSlot)**: System.Void (Public)
- **CacheCharacterData(System.String key, System.String saveData)**: System.Void (Public)
- **SetCharacterSaveData(CharacterSaveData characterSaveData)**: System.Void (Public)
- **SetWorldSaveSlot(System.Int32 saveSlot)**: System.Void (Public)
- **SetWorldSaveData(WorldSaveData saveData)**: System.Void (Public)
- **CacheIslandData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheCraftingStationInventoryData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheStorageInventoryData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheShipPositionData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheShipHullData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheShipHealthData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheShipSnapshotData(System.String key, System.String saveData)**: System.Void (Public)
- **CacheShipwreckData(System.String key, System.String saveData)**: System.Void (Public)
- **RemoveShipData(System.String key)**: System.Void (Public)
- **RemoveShipHealthData(System.String key)**: System.Void (Public)
- **RemoveShipwreckData(System.String key)**: System.Void (Public)
- **RemoveCraftingStationInventoryData(System.String key)**: System.Void (Public)
- **RemoveStorageInventoryData(System.String key)**: System.Void (Public)
- **CacheBossData(System.String key, System.String saveData)**: System.Void (Public)
- **ShipHealthDataExists(System.String key)**: System.Boolean (Public)
- **IslandDataExists(System.String islandName)**: System.Boolean (Public)
- **StorageInventoryDataExists(System.String storageName)**: System.Boolean (Public)
- **DeathLootDataExists(System.String key)**: System.Boolean (Public)
- **CacheDeathLootData(System.String key, System.String saveData)**: System.Void (Public)
- **RemoveDeathLootData(System.String key)**: System.Void (Public)
- **RequestFullSave()**: System.Void (Public)
- **FullSaveComplete()**: System.Void (Public)
- **SetHasDataForCurrentWorld(System.Boolean hasData)**: System.Void (Public)
- **SetWorldIdForPersistence(System.String worldId)**: System.Void (Public)
- **CachePlayerPositionData(PlayerPositionData positionData)**: System.Void (Public)
- **CacheRegisteredShipwrecks(System.String shipwrecks)**: System.Void (Public)
- **CacheRegisteredShip(System.String shipGuid)**: System.Void (Public)

