# Wildskies.UI.Panel.SchematicsListEntryToggle

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| toggle | UnityEngine.UI.Toggle | Private |
| itemNameText | TMPro.TextMeshProUGUI | Private |
| itemInfoText | TMPro.TextMeshProUGUI | Private |
| itemIconImage | UnityEngine.UI.Image | Private |
| _uiColourData | UiColourData | Private |
| _rarityGradient | UnityEngine.UI.Image | Private |
| _uncommonImage | UnityEngine.GameObject | Private |
| _rareImage | UnityEngine.GameObject | Private |
| _epicImage | UnityEngine.GameObject | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Toggle | UnityEngine.UI.Toggle | Public |

## Methods

- **get_Toggle()**: UnityEngine.UI.Toggle (Public)
- **Init(System.String itemName, WildSkies.Gameplay.Items.InventoryRarityType rarity, System.String itemInfo, UnityEngine.Sprite itemIcon)**: System.Void (Public)
- **SetOn(System.Boolean isOn)**: System.Void (Public)
- **SetInfo(System.String value)**: System.Void (Public)
- **SetRarity(WildSkies.Gameplay.Items.InventoryRarityType rarity)**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

