# WildSkies.Mediators.CompendiumUiMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _playerGuideService | WildSkies.Service.IPlayerGuideService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |

## Methods

- **Initialise(UISystem.IUIService uiService, WildSkies.Service.ICompendiumService compendiumService, WildSkies.Service.IPlayerGuideService playerGuideService, WildSkies.Service.IPlayerInventoryService playerInventoryService, WildSkies.Service.ICraftingService craftingService)**: System.Void (Public)
- **OnSchematicLearned(System.String schematicId, System.Boolean _)**: System.Void (Private)
- **Terminate()**: System.Void (Public)
- **OnItemAdded(System.String itemId)**: System.Void (Private)
- **OnObjectiveCompleted(PlayerGuideObjective objective)**: System.Void (Private)
- **OnTaskCompleted(PlayerGuideTask task)**: System.Void (Private)
- **OnTutorialUnlocked(System.String entryId)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

