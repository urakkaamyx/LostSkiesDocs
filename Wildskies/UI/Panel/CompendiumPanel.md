# Wildskies.UI.Panel.CompendiumPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _viewModel | Wildskies.UI.Panel.CompendiumPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.CompendiumPanelPayload | Private |
| _compendiumService | WildSkies.Service.ICompendiumService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _conversationService | WildSkies.Service.IConversationService | Private |
| _inputSpriteService | WildSkies.Service.InputSpriteService | Private |
| _mainCategoriesSetup | System.Boolean | Private |
| _mainCategoryButtons | System.Collections.Generic.List`1<CompendiumMainCategoryButton> | Private |
| _subCategoryButtons | System.Collections.Generic.List`1<CompendiumSubCategoryButton> | Private |
| _currentEntries | System.Collections.Generic.List`1<CompendiumEntryButton> | Private |
| _currentSelectedMainCategoryIndex | System.Int32 | Private |
| _currentSelectedSubCategoryButton | CompendiumSubCategoryButton | Private |
| _currentSelectedEntryButton | CompendiumEntryButton | Private |
| _currentEntry | CompendiumEntry | Private |
| _navigation | UnityEngine.UI.Navigation | Private |
| EntriesPerRow | System.Int32 | Private |
| _currentSpinDirection | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **SetupMainCategoryButtons()**: System.Void (Private)
- **SetMainCategoriesButtonsNotification()**: System.Void (Private)
- **SetSubCategoriesButtonsNotification()**: System.Void (Private)
- **CheckMainCategoryNavigation()**: System.Void (Private)
- **SelectLeftCategory()**: System.Void (Private)
- **SelectRightCategory()**: System.Void (Private)
- **OnMainCategorySelected(System.Int32 index)**: System.Void (Private)
- **SetupSubCategoryButtons()**: System.Void (Private)
- **SetupSubCategoryButtonsNavigation()**: System.Void (Private)
- **ClearSubCategoryButtons()**: System.Void (Private)
- **OnSubCategorySelected(CompendiumSubCategoryButton subCategoryButton)**: System.Void (Private)
- **SelectFirstElementWhenNoSelection()**: System.Void (Private)
- **SelectSubCategoryButton()**: System.Void (Private)
- **SetupEntries()**: System.Void (Private)
- **SetupEntriesNavigation()**: System.Void (Private)
- **ClearEntries()**: System.Void (Private)
- **OnEntrySelected(CompendiumEntryButton entryButton)**: System.Void (Private)
- **ShowConversationHistory(CompendiumEntry entry)**: System.Void (Private)
- **SetText(UnityEngine.Localization.Locale _)**: System.Void (Private)
- **ParseBodyText()**: System.String (Private)
- **CheckEntriesToBeUnlocked()**: System.Void (Private)
- **OpenAtSpecificEntry()**: System.Void (Private)
- **ShowVideo(CompendiumEntry entry)**: System.Void (Private)
- **UpdateLoadingImage()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<OpenAtSpecificEntry>b__45_0(CompendiumMainCategoryButton mainCategoryButton)**: System.Boolean (Private)
- **<OpenAtSpecificEntry>b__45_1(CompendiumSubCategoryButton subCategoryButton)**: System.Boolean (Private)
- **<OpenAtSpecificEntry>b__45_2(CompendiumEntryButton entryButton)**: System.Boolean (Private)

