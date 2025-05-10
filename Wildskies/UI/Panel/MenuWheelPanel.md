# Wildskies.UI.Panel.MenuWheelPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Private |
| _uiService | UISystem.IUIService | Private |
| _itemService | WildSkies.Service.IItemService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _viewModel | Wildskies.UI.Panel.MenuWheelPanelViewModel | Private |
| _currentSelectionIndex | System.Int32 | Private |
| _degreesPerButton | System.Single | Private |
| _activeIcons | System.Collections.Generic.List`1<SelectionData> | Private |
| _activeIconObjects | System.Collections.Generic.List`1<MenuWheelIcon> | Private |
| _equipmentMode | System.Boolean | Private |
| _wheelTimer | System.Single | Private |
| StickReleaseDeadzone | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **RefreshSelectionIcons()**: System.Void (Private)
- **CreateRadialIcon(System.Int32 index)**: System.Void (Private)
- **CreateHeaderIcon(System.Int32 index)**: System.Void (Private)
- **Update()**: System.Void (Private)
- **EvaluateCurrentSelection(UnityEngine.Vector2 input, System.Single currentAngle)**: System.Void (Private)
- **UpdateArrowPosition(UnityEngine.Vector2 input, System.Single currentAngle)**: System.Void (Private)
- **SelectHighlightedButton()**: System.Void (Private)
- **OnMenuUnlocked(UISystem.UIPanelType menuUnlocked)**: System.Void (Public)
- **GetActiveIcons()**: System.Void (Private)
- **ClearIconObjects()**: System.Void (Private)
- **GetInputAngleInDegrees()**: System.Single (Private)
- **.ctor()**: System.Void (Public)

