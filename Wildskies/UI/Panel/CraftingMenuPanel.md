# Wildskies.UI.Panel.CraftingMenuPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _telemetryService | WildSkies.Service.ITelemetryService | Private |
| _craftingService | WildSkies.Service.ICraftingService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _uiService | UISystem.IUIService | Private |
| _settingsOverride | Bossa.Cinematika.Controllers.DynamikaCamera/CameraSetting | Private |
| _viewModel | Wildskies.UI.Panel.CraftingMenuPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.CraftingMenuPanelPayload | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **OnSchematicsChanged()**: System.Void (Private)
- **SetContext()**: System.Void (Private)
- **SetText(UnityEngine.Localization.Locale _)**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

