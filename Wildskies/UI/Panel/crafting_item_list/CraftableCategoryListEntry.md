# Wildskies.UI.Panel.crafting_item_list.CraftableCategoryListEntry

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _icon | UnityEngine.UI.Image | Private |
| _selectionBar | UnityEngine.UI.Image | Private |
| _background | UnityEngine.UI.Image | Private |
| _categoryName | TMPro.TMP_Text | Private |
| _button | UnityEngine.UI.Button | Private |
| _buttonBaseColor | UnityEngine.Color | Private |
| _buttonSelectedColor | UnityEngine.Color | Private |
| _useSelectionBar | System.Boolean | Private |
| _generalString | UnityEngine.Localization.LocalizedString | Private |
| _craftingMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Private |
| _connectedCounterIcon | Wildskies.UI.Panel.crafting_item_list.CategoryCounterIcon | Private |
| _scrollOnSelect | ScrollToOnSelect | Private |
| _isSelected | System.Boolean | Private |
| _categoryData | WildSkies.Gameplay.Items.IItemCategory | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CategoryId | System.String | Public |
| CraftingMethod | WildSkies.Gameplay.Crafting.CraftingMethod | Public |
| Button | UnityEngine.UI.Button | Public |
| ConnectedCounterIcon | Wildskies.UI.Panel.crafting_item_list.CategoryCounterIcon | Public |

## Methods

- **get_CategoryId()**: System.String (Public)
- **get_CraftingMethod()**: WildSkies.Gameplay.Crafting.CraftingMethod (Public)
- **get_Button()**: UnityEngine.UI.Button (Public)
- **get_ConnectedCounterIcon()**: Wildskies.UI.Panel.crafting_item_list.CategoryCounterIcon (Public)
- **Initialise(WildSkies.Gameplay.Items.IItemCategory categoryData, Wildskies.UI.Panel.crafting_item_list.CategoryCounterIcon connectedCounterIcon)**: System.Void (Public)
- **SetSelected(System.Boolean isSelected)**: System.Void (Public)
- **OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)**: System.Void (Public)
- **SetButtonColor(UnityEngine.Color newColor)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

