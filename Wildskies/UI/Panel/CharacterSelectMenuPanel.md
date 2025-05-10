# Wildskies.UI.Panel.CharacterSelectMenuPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.CharacterSelectMenuPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.CharacterSelectMenuPanelPayload | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _uiService | UISystem.IUIService | Private |
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _graphicsService | WildSkies.Service.GraphicsService | Private |
| _requestIds | System.Collections.Generic.List`1<System.Guid> | Private |
| _requestId | System.Guid | Private |
| _loadCompleted | System.Boolean | Private |
| _loadFails | System.Collections.Generic.List`1<System.Int32> | Private |
| _existingSlots | System.Collections.Generic.List`1<System.Int32> | Private |
| _characterSaveDatas | System.Collections.Generic.List`1<CharacterSaveData> | Private |
| _holdToDeleteTimer | System.Single | Private |
| _currentSelectedIndex | System.Int32 | Private |
| _lobbyPlayer | LobbyPlayer | Private |
| LastSelectedCharacterPlayerPrefKey | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |
| IsEmpty | System.Boolean | Public |
| LoadCompleted | System.Boolean | Public |
| CurrentSelectedIndex | System.Int32 | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **get_IsEmpty()**: System.Boolean (Public)
- **get_LoadCompleted()**: System.Boolean (Public)
- **get_CurrentSelectedIndex()**: System.Int32 (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **GetSelectedName()**: System.String (Public)
- **SelectIndex(System.Int32 index)**: System.Void (Public)
- **SpawnPlayer()**: System.Void (Private)
- **OnPlayerSpawned(UnityEngine.GameObject obj)**: System.Void (Private)
- **DestroyPlayer()**: System.Void (Private)
- **UpdateSelection()**: System.Void (Private)
- **OnGetExistingSlotsForKeyCompleted(System.Boolean success, System.String key, System.Collections.Generic.List`1<System.Int32> slots)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **UpdateInputSelection(System.Boolean isGamepad)**: System.Void (Private)
- **UpdateInput()**: System.Void (Private)
- **SelectPreviousSlot()**: System.Void (Private)
- **SelectNextSlot()**: System.Void (Private)
- **OnLoadCompleted(System.Boolean success, System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Private)
- **IsEmptySaveData(System.String saveData)**: System.Boolean (Private)
- **LoadRequestFinished()**: System.Void (Private)
- **GoBackToMainMenu()**: System.Void (Private)
- **ShowPlayPanel()**: System.Void (Public)
- **ShowCharacterCreatePanel()**: System.Void (Public)
- **DeleteSelectedCharacter()**: System.Void (Private)
- **DeleteSelectedCharacterData(System.String obj)**: System.Void (Private)
- **CreateDefaultCharacter(System.String characterName)**: System.Void (Public)
- **InitSaveDatas()**: System.Void (Private)
- **GetNextAvailableCharacterSlot()**: System.Int32 (Private)
- **GetCharacterEntryCount()**: System.Int32 (Private)
- **GetFirstExistingEntryIndex()**: System.Int32 (Private)
- **GetNextSlot(System.Boolean forward)**: System.Int32 (Private)
- **RestoreCharacterTextureQuality()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

