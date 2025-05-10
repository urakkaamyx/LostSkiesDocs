# WildSkies.Mediators.ItemInventoryMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _uiService | UISystem.IUIService | Private |
| _localisationService | WildSkies.Service.LocalisationService | Private |

## Methods

- **Initialise(WildSkies.Service.IItemService itemService, WildSkies.Service.IPlayerInventoryService playerInventoryService, UISystem.IUIService uiService, WildSkies.Service.LocalisationService localisationService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **ShowInventoryFullPopup()**: System.Void (Private)
- **ItemRequestedByID(System.String ItemID)**: WildSkies.Gameplay.Items.ItemDefinition (Private)
- **ItemRequestedByName(System.String ItemName)**: WildSkies.Gameplay.Items.ItemDefinition (Private)
- **.ctor()**: System.Void (Public)

