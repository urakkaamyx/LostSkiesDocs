# WildSkies.Mediators.PlayerGuideMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerGuideService | WildSkies.Service.IPlayerGuideService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _uiService | UISystem.IUIService | Private |
| _interactionService | InteractionService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _conversationService | WildSkies.Service.IConversationService | Private |
| _arkComputerService | WildSkies.Service.IArkComputerService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _schematicLevelService | WildSkies.Service.SchematicLevelService.ISchematicLevelService | Private |
| _waitingToShowTaskCompletePopup | System.Boolean | Private |
| _lastCompletedTask | PlayerGuideTask | Private |
| _shipService | WildSkies.Service.ShipsService | Private |
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |

## Methods

- **Initialise(WildSkies.Service.IPlayerGuideService playerGuideService, WildSkies.Service.IPlayerInventoryService inventoryService, UISystem.IUIService uiService, InteractionService interactionService, WildSkies.Service.ICraftingService craftingService, WildSkies.Service.IConversationService conversationService, WildSkies.Service.IArkComputerService arkComputerService, WildSkies.Service.ILocalPlayerService localPlayerService, WildSkies.Service.ShipsService shipService, WildSkies.Service.ITelemetryService telemetryService, WildSkies.Service.IPersistenceService persistenceService, WildSkies.Service.SchematicLevelService.ISchematicLevelService schematicLevelService)**: System.Void (Public)
- **CheckIfCompletionPopupIsWaiting(UISystem.UIPanelType paneltype)**: System.Void (Private)
- **OnDataLoaded()**: System.Void (Private)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **OnObjectiveCompleted(PlayerGuideObjective obj)**: System.Void (Private)
- **OnTaskCompleted(PlayerGuideTask completedTask)**: System.Void (Private)
- **AddShipPartPlacementListeners()**: System.Void (Private)
- **RemoveShipPartPlacementListeners(WildSkies.Gameplay.ShipBuilding.ConstructedShipController ship)**: System.Void (Private)
- **RemoveAllShipPartPlacementListeners()**: System.Void (Private)
- **OnRemovedFromShip(System.String arg1, Bossa.Dynamika.Character.DynamikaCharacter arg2)**: System.Void (Private)
- **OnNewTaskShown(PlayerGuideTask newTask)**: System.Void (Private)
- **OnFtueComplete()**: System.Void (Private)
- **ShowHud(PlayerGuideTask task)**: System.Void (Private)
- **CheckIfTaskCompleteCanBeShown(PlayerGuideTask task)**: System.Void (Private)
- **ShowTaskCompletePopup(PlayerGuideTask task)**: System.Void (Private)
- **AddGallDiscConversationForTask(PlayerGuideTask task)**: System.Void (Private)
- **OnInteractedWithObject(System.String objectiveLabel)**: System.Void (Private)
- **IsAlreadyRegisteredToShip()**: System.Boolean (Private)
- **IsPlayerRegisteredToShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController& ship)**: System.Boolean (Private)
- **OnRegisteredToShip(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter player)**: System.Void (Private)
- **IsShipPartTypeAlreadyAdded(PlayerGuideObjective objective)**: System.Boolean (Private)
- **IsPartAttachedToShip(PlayerGuideObjective objective)**: System.Boolean (Private)
- **OnShipFrameCrafted()**: System.Void (Private)
- **OnShipPartAttached(WildSkies.Ship.ShipPart shipPart)**: System.Void (Private)
- **IsTierAlreadyUnlocked(PlayerGuideObjective objective)**: System.Boolean (Private)
- **EnoughArkComputersAlreadyUsed(PlayerGuideObjective objective)**: System.Boolean (Private)
- **OnNewTierUnlocked(WildSkies.IslandExport.Culture culture, System.Int32 newTier)**: System.Void (Private)
- **OnConversationComplete(System.String conversationHistoryId)**: System.Void (Private)
- **IsConversationComplete(System.String conversationHistoryId)**: System.Boolean (Private)
- **DoesInventoryContainsObjectiveItems(PlayerGuideObjective objective)**: System.Boolean (Private)
- **OnInventoryChanged(System.String itemId)**: System.Void (Private)
- **CheckAmountInInventory(PlayerGuideObjective objective)**: System.Void (Private)
- **OnLearnSchematic(System.String schematicId, System.Boolean _)**: System.Void (Private)
- **CheckSchematicLearnedAgainstObjectives(PlayerGuideObjective objective, System.String schematicId)**: System.Void (Private)
- **CheckSchematicTypeLearnedAgainstObjectives(PlayerGuideObjective objective, System.String schematicId)**: System.Void (Private)
- **IsSchematicAlreadyKnown(PlayerGuideObjective objective)**: System.Boolean (Private)
- **IsSchematicOfTypeAlreadyKnown(PlayerGuideObjective objective)**: System.Boolean (Private)
- **IsSchematicAlreadyUpgraded(PlayerGuideObjective objective)**: System.Boolean (Private)
- **OnSchematicUpgraded(System.String schematicId)**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

