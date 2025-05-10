# Wildskies.UI.Hud.ObjectiveListEntry

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _description | TMPro.TextMeshProUGUI | Private |
| _quantityProgress | TMPro.TextMeshProUGUI | Private |
| _completedCheckBox | UnityEngine.UI.Toggle | Private |
| _objective | PlayerGuideObjective | Private |
| _playerGuideService | WildSkies.Service.IPlayerGuideService | Private |
| OnObjectiveComplete | System.Action | Private |

## Methods

- **Initialise(WildSkies.Service.IPlayerGuideService playerGuideService, PlayerGuideObjective objective)**: System.Void (Public)
- **SetText()**: System.Void (Public)
- **SetupQuantityTracking()**: System.Void (Private)
- **CheckObjectiveProgress(Player.Inventory.IInventoryItem _)**: System.Void (Private)
- **CheckObjectiveProgress(System.String itemId)**: System.Void (Private)
- **SetObjectiveComplete(PlayerGuideObjective objective)**: System.Void (Private)
- **SetObjectiveIncomplete(PlayerGuideObjective objective)**: System.Void (Private)
- **Clear()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

