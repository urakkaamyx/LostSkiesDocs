# WildSkies.Player.Settings.SettingsEntry

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _bgImage | UnityEngine.UI.Image | Private |
| _entryUiElement | WildSkies.Player.Settings.SettingsEntryUiElementController | Private |
| _bgNormalColor | UnityEngine.Color | Private |
| _bgSelectedColor | UnityEngine.Color | Private |
| OnEntrySelectedEvent | System.Action`1<WildSkies.Player.Settings.SettingsEntry> | Public |
| OnEntryDeselectedEvent | System.Action`1<WildSkies.Player.Settings.SettingsEntry> | Public |
| OnPointerEnterEvent | System.Action`1<WildSkies.Player.Settings.SettingsEntry> | Private |
| OnPointerExitEvent | System.Action`1<WildSkies.Player.Settings.SettingsEntry> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| UiElement | UnityEngine.UI.Selectable | Public |

## Methods

- **get_UiElement()**: UnityEngine.UI.Selectable (Public)
- **add_OnPointerEnterEvent(System.Action`1<WildSkies.Player.Settings.SettingsEntry> value)**: System.Void (Public)
- **remove_OnPointerEnterEvent(System.Action`1<WildSkies.Player.Settings.SettingsEntry> value)**: System.Void (Public)
- **add_OnPointerExitEvent(System.Action`1<WildSkies.Player.Settings.SettingsEntry> value)**: System.Void (Public)
- **remove_OnPointerExitEvent(System.Action`1<WildSkies.Player.Settings.SettingsEntry> value)**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnUiElementSelected()**: System.Void (Private)
- **OnUiElementDeselect()**: System.Void (Private)
- **OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

