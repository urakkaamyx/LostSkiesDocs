# Wildskies.UI.Panel.PlayerMenuPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _inventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _platformService | PlatformService | Private |
| _conversationService | WildSkies.Service.IConversationService | Private |
| _viewModel | Wildskies.UI.Panel.PlayerMenuPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.PlayerMenuPanelPayload | Private |
| _headerButtonDictionary | System.Collections.Generic.Dictionary`2<UISystem.UIPanelType,PlayerMenuButton> | Private |
| _currentPanelIndex | System.Int32 | Private |
| _activeButtons | System.Collections.Generic.List`1<PlayerMenuButton> | Private |
| _timeSinceLastTabPress | System.Single | Private |
| _tabPressBuffer | System.Single | Private |
| _dictionaryInitialised | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **OnEnable()**: System.Void (Private)
- **Start()**: System.Void (Private)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **AddListeners()**: System.Void (Private)
- **RemoveListeners()**: System.Void (Private)
- **UpdateButtonsActiveForCurrentInput(System.Boolean isGamepad)**: System.Void (Private)
- **CreateButtonDictionary()**: System.Void (Private)
- **SetConversationPanelAvailable(SelectionData buttonData)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **CheckTabNavigationPressed()**: System.Void (Private)
- **ChangePanel(System.Int32 panelToOpenIndex)**: System.Void (Private)
- **RefreshActiveButtons()**: System.Void (Private)
- **RefreshSelectionState()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **GetActiveButtons()**: System.Void (Private)
- **ClearButtons()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

