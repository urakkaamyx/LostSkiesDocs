# Wildskies.UI.Hud.ShipSectionsHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _viewModel | Wildskies.UI.Hud.ShipSectionsHudViewModel | Private |
| _payload | Wildskies.UI.Hud.ShipSectionsHudPayload | Private |
| _knowledgeData | WildSkies.Service.ISchematicKnowledgeData | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **OnBlocksUpdateEvent()**: System.Void (Private)
- **UpdateLevelTitle()**: System.Void (Private)
- **UpdateSectionsCounter()**: System.Void (Private)
- **ShowNoSectionsAvailableMessage()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

