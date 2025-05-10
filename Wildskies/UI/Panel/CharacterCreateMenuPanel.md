# Wildskies.UI.Panel.CharacterCreateMenuPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.CharacterCreateMenuPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.CharacterCreateMenuPanelPayload | Private |
| _categories | System.Collections.Generic.List`1<CharacterCreatorCategory> | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _characterCustomisationService | WildSkies.Service.ICharacterCustomisationService | Private |
| _saveSlot | System.Int32 | Private |
| _categoryButtons | System.Collections.Generic.List`1<CharacterCreateCategoryButton> | Private |
| _currentSelectedCategoryIndex | System.Int32 | Private |
| _lobbyPlayer | LobbyPlayer | Private |
| _subPanels | ICharacterCreateSubPanel[] | Private |
| CategorySelected | System.Action`1<CharacterCreateCategoryType> | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **OnCustomisationTypeChanged()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean isGamePad)**: System.Void (Private)
- **SetupCategoryButtons()**: System.Void (Private)
- **ClearCategoryButtons()**: System.Void (Private)
- **OnCategorySelected(System.Int32 index)**: System.Void (Private)
- **SelectLeftCategory()**: System.Void (Private)
- **SelectRightCategory()**: System.Void (Private)
- **ResetSubPanels()**: System.Void (Private)
- **HideSubPanels()**: System.Void (Private)
- **BackToCharacterSelect()**: System.Void (Private)
- **NameAndConfirm()**: System.Void (Public)
- **CreateCharacter(System.String characterName)**: System.Void (Public)
- **DebugCreateCharacter(System.String characterName)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

