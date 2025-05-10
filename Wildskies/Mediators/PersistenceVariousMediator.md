# WildSkies.Mediators.PersistenceVariousMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _uiService | UISystem.IUIService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _playerGuideService | WildSkies.Service.IPlayerGuideService | Private |
| _deathLootService | WildSkies.Service.IDeathLootService | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _islandService | WildSkies.Service.IIslandService | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _megaService | WildSkies.Service.MegaService | Private |
| _networkCommandService | NetworkCommandService | Private |
| _objectScanForPrizesServiceService | WildSkies.Service.IObjectScanForPrizesService | Private |
| _arkComputerService | WildSkies.Service.IArkComputerService | Private |
| _conversationService | WildSkies.Service.IConversationService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _downloadableContentService | Bossa.WildSkies.Service.DownloadableContentService | Private |
| DiscoveredItemsKey | System.String | Private |
| UnlockedCompendiumEntriesKey | System.String | Private |
| DataBanksKey | System.String | Private |
| PlayerGuideKey | System.String | Private |
| PlayerShipKey | System.String | Private |
| PlayerShipwreckKey | System.String | Private |
| ScannedObjectsForPrizeKey | System.String | Private |
| ArkComputerKey | System.String | Private |
| ArkComputerInteractionKey | System.String | Private |
| ArkComputersInteractedWithKey | System.String | Private |
| ConversationsHistoryKey | System.String | Private |
| SchematicLevelUpKey | System.String | Private |
| AwardedDLCBundlesKey | System.String | Private |
| CharacterWorldSaveInterval | System.Single | Private |
| ShipWaitTime | System.Single | Private |
| SaveQuitDelay | System.Single | Private |
| _characterSaveRequested | System.Boolean | Private |
| _worldSaveRequested | System.Boolean | Private |
| _isSaving | System.Boolean | Private |
| _requestIds | System.Collections.Generic.List`1<System.Guid> | Private |
| _requestId | System.Guid | Private |
| _characterWorldSaveTimer | System.Single | Private |
| _shipSaveTimer | System.Single | Private |
| _bossSaveTimer | System.Single | Private |
| _shipsToBeRemoved | System.Collections.Generic.List`1<System.String> | Private |
| _shipwrecksToBeRemoved | System.Collections.Generic.List`1<System.String> | Private |
| _deathLootToBeRemoved | System.Collections.Generic.List`1<System.String> | Private |
| _jsonSerializerSettings | Newtonsoft.Json.JsonSerializerSettings | Private |
| _savedIslands | System.Int32 | Private |

## Methods

- **Initialise(WildSkies.Service.IPersistenceService persistenceService, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.IItemService itemService, WildSkies.Service.IPlayerInventoryService playerInventoryService, WildSkies.Service.IPlayerGuideService playerGuideService, WildSkies.Service.IDeathLootService deathLootService, WildSkies.Service.ICompendiumService compendiumService, WildSkies.Service.IIslandService islandService, UISystem.IUIService uiService, WildSkies.Service.ShipsService shipsService, WildSkies.Service.SessionService sessionService, WildSkies.Service.MegaService megaService, NetworkCommandService networkCommandService, WildSkies.Service.IObjectScanForPrizesService objectScanForPrizeService, WildSkies.Service.IArkComputerService arkComputerService, WildSkies.Service.IConversationService conversationService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService, Bossa.WildSkies.Service.DownloadableContentService downloadableContentService)**: System.Void (Public)
- **OnWorldIdSet(System.String worldId)**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **OnLocalPlayerRegistered()**: System.Void (Private)
- **SaveDiscoveredItems(System.String id, System.Boolean wasLearned)**: System.Void (Private)
- **SaveInventory(System.String dataToSave)**: System.Void (Private)
- **SavePlayerGuide(WildSkies.Service.PlayerGuideData guideData)**: System.Void (Private)
- **SaveUnlockedCompendiumEntries()**: System.Void (Private)
- **SaveScannedObjectsForPrizeEntries()**: System.Void (Private)
- **SaveUnlockedNewTier()**: System.Void (Private)
- **SaveArkComputerFirstInteraction()**: System.Void (Private)
- **SaveArkComputersInteractedWith()**: System.Void (Private)
- **SaveConversationHistory(System.String _)**: System.Void (Private)
- **SaveSchematicLevelUpData(System.String _)**: System.Void (Private)
- **SetCharacterGrantedDLCs(System.Collections.Generic.List`1<System.String> playerAwardedDLCIds)**: System.Void (Private)
- **OnSessionEnded(WildSkies.Service.SessionService/DisconnectionReason disconnectionReason, Coherence.Connection.ConnectionCloseReason connectionCloseReason)**: System.Void (Private)
- **SaveCharacterAndWorldDataOnTimer()**: System.Void (Private)
- **OnFullSaveRequested()**: System.Void (Private)
- **OnSaveCompleted(System.Boolean success, System.String key, System.Guid requestId)**: System.Void (Private)
- **SaveCharacterAndWorldSaveData()**: System.Threading.Tasks.Task (Private)
- **SaveCharacterData()**: System.Void (Private)
- **SaveWorldData()**: System.Void (Private)
- **SaveIslandData()**: System.Threading.Tasks.Task (Private)
- **OnIslandDataCached(System.String islandName)**: System.Void (Private)
- **SaveShipData()**: System.Threading.Tasks.Task (Private)
- **SaveShipwreckData()**: System.Void (Private)
- **SaveBossData()**: System.Void (Private)
- **SaveDeathLootData()**: System.Void (Private)
- **UpdatePlayerShipData(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **UpdatePlayerShipwreckData(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **RegisterPlayerWithShip()**: System.Void (Private)
- **RegisterPlayerWithShipwrecks()**: System.Void (Private)
- **ClearInventory()**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **<SaveIslandData>b__70_0()**: System.Boolean (Private)
- **<RegisterPlayerWithShip>b__78_0(WildSkies.Gameplay.ShipBuilding.ConstructedShipController s)**: System.Boolean (Private)
- **<RegisterPlayerWithShip>b__78_1(WildSkies.Gameplay.ShipBuilding.ConstructedShipController s)**: System.Boolean (Private)

