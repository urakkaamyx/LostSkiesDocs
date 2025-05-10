# WildSkies.Service.CompendiumService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |
| _serviceReadyCallback | System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> | Private |
| _categories | System.Collections.Generic.List`1<CompendiumCategory> | Private |
| _entries | System.Collections.Generic.List`1<CompendiumEntry> | Private |
| _tutorialEntries | System.Collections.Generic.List`1<CompendiumEntry> | Private |
| _unlockedEntries | System.Collections.Generic.List`1<System.String> | Private |
| _newUnlockedEntries | System.Collections.Generic.List`1<System.String> | Private |
| _loadedTutorialVideo | UnityEngine.Video.VideoClip | Private |
| _tutorialVideoHandle | UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1<UnityEngine.Video.VideoClip> | Private |
| <OnEntryUnlocked>k__BackingField | System.Action | Private |
| <OnTutorialUnlocked>k__BackingField | System.Action`1<System.String> | Private |
| <OnRemoveNewUnlockedEntry>k__BackingField | System.Action | Private |
| CompendiumPrefix | System.String | Public |
| TutorialsCategoryName | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| Categories | System.Collections.Generic.List`1<CompendiumCategory> | Public |
| Entries | System.Collections.Generic.List`1<CompendiumEntry> | Public |
| UnlockedEntries | System.Collections.Generic.List`1<System.String> | Public |
| NewUnlockedEntries | System.Collections.Generic.List`1<System.String> | Public |
| LoadedTutorialVideo | UnityEngine.Video.VideoClip | Public |
| OnEntryUnlocked | System.Action | Public |
| OnTutorialUnlocked | System.Action`1<System.String> | Public |
| OnRemoveNewUnlockedEntry | System.Action | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **set_FinishedInitialisation(System.Boolean value)**: System.Void (Private)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_Categories()**: System.Collections.Generic.List`1<CompendiumCategory> (Public)
- **get_Entries()**: System.Collections.Generic.List`1<CompendiumEntry> (Public)
- **get_UnlockedEntries()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_NewUnlockedEntries()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_LoadedTutorialVideo()**: UnityEngine.Video.VideoClip (Public)
- **get_OnEntryUnlocked()**: System.Action (Public)
- **set_OnEntryUnlocked(System.Action value)**: System.Void (Public)
- **get_OnTutorialUnlocked()**: System.Action`1<System.String> (Public)
- **set_OnTutorialUnlocked(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnRemoveNewUnlockedEntry()**: System.Action (Public)
- **set_OnRemoveNewUnlockedEntry(System.Action value)**: System.Void (Public)
- **SetCallbackForServiceReady(System.Action`2<WildSkies.Service.Interface.IAsyncService,System.Int32> callback)**: System.Void (Public)
- **ClearCallback()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **LoadItems()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **OnCategoryDataLoaded(CompendiumCategory category)**: System.Void (Private)
- **OnEntryDataLoaded(CompendiumEntry entry)**: System.Void (Private)
- **LoadTutorialVideo(System.String videoName)**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **SetUnlockedEntriesList(System.Collections.Generic.List`1<System.String> unlockedEntries)**: System.Void (Public)
- **GetEntryFromItemId(System.String itemId)**: CompendiumEntry (Public)
- **GetEntryFromEntryId(System.String entryId)**: CompendiumEntry (Public)
- **UnlockEntry(System.String entryId)**: System.Void (Public)
- **IsUnlocked(System.String entryId)**: System.Boolean (Public)
- **UnlockTutorial(System.String entryId)**: System.Void (Public)
- **UnlockTutorialFromItemId(System.String itemId)**: System.Void (Public)
- **HasNewUnlockedEntries()**: System.Boolean (Public)
- **IsNewUnlockedEntry(System.String itemId)**: System.Boolean (Public)
- **RemoveNewUnlockedEntry(System.String itemId)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

