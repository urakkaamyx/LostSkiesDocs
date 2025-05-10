# WildSkies.Mediators.UIInputMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _ui | UISystem.IUIService | Private |
| _input | WildSkies.Service.InputService | Private |
| _inputSpriteService | WildSkies.Service.InputSpriteService | Private |
| _sceneService | WildSkies.Service.SceneService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _spriteService | WildSkies.Service.InputSpriteService | Private |
| _platformService | PlatformService | Private |
| _steamPlatform | WildSkies.Service.SteamPlatform | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _currentActiveMenuPanel | System.Nullable`1<UISystem.UIPanelType> | Private |
| _notificationHud | Wildskies.UI.Hud.NotificationHud | Private |
| _inputHelpHudShowing | System.Boolean | Private |
| _activeTaskHudShowing | System.Boolean | Private |
| _buildModeHudShowing | System.Boolean | Private |
| _isCraftingMenuShowing | System.Boolean | Private |
| _isBuildingMenuShowing | System.Boolean | Private |
| _showingSteamOverlay | System.Boolean | Private |
| _compendiumHoldTimer | System.Single | Private |
| _menuWheelHoldTimer | System.Single | Private |
| _canOpenCompendium | System.Boolean | Private |
| _canOpenInventory | System.Boolean | Private |

## Methods

- **Initialise(UISystem.IUIService uiService, WildSkies.Service.InputService inputService, WildSkies.Service.SceneService sceneService, WildSkies.Service.AudioService audioService, WildSkies.Service.SessionService sessionService, WildSkies.Service.InputSpriteService inputSpriteService, PlatformService platformService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **Update()**: System.Void (Public)
- **CheckEquipmentWheelInput()**: System.Void (Private)
- **CheckBuildingMenuInput()**: System.Void (Private)
- **CheckInventoryMenuInput()**: System.Void (Private)
- **CheckCompendiumMenuInput()**: System.Void (Private)
- **OnInputTypeChanged(System.Boolean newInputIsGamepad)**: System.Void (Private)
- **CheckPanelInput(System.Boolean keyValue, UISystem.UIPanelType panel)**: System.Void (Private)
- **CheckHudInput(System.Boolean keyValue, UISystem.UIHudType hudElement)**: System.Void (Private)
- **CheckMenuKeyInput(System.Boolean keyValue, UISystem.UIPanelType panelToToggle)**: System.Void (Private)
- **HideCurrentPanel()**: System.Void (Private)
- **OnPanelShown(UISystem.UIPanelType panelType)**: System.Void (Private)
- **OnPanelHidden(UISystem.UIPanelType panelType)**: System.Void (Private)
- **TryHideOpenPanels()**: System.Boolean (Private)
- **IsMenuPanel(UISystem.UIPanelType panelType)**: System.Boolean (Private)
- **TryToOpenCompendiumAtSpecificEntry()**: System.Boolean (Private)
- **OnSceneChanged(WildSkies.Service.SceneService/SceneLoadState sceneLoadState)**: System.Void (Private)
- **OnSessionEnded(WildSkies.Service.SessionService/DisconnectionReason disconnectionReason, Coherence.Connection.ConnectionCloseReason connectionCloseReason)**: System.Void (Private)
- **IsTutorialPopupShowing()**: System.Boolean (Private)
- **IsPriorityPopupShowing()**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)

