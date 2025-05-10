# WildSkies.Service.ICompendiumService

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| Categories | System.Collections.Generic.List`1<CompendiumCategory> | Public |
| Entries | System.Collections.Generic.List`1<CompendiumEntry> | Public |
| UnlockedEntries | System.Collections.Generic.List`1<System.String> | Public |
| NewUnlockedEntries | System.Collections.Generic.List`1<System.String> | Public |
| LoadedTutorialVideo | UnityEngine.Video.VideoClip | Public |
| OnEntryUnlocked | System.Action | Public |
| OnTutorialUnlocked | System.Action`1<System.String> | Public |
| OnRemoveNewUnlockedEntry | System.Action | Public |

## Methods

- **get_Categories()**: System.Collections.Generic.List`1<CompendiumCategory> (Public)
- **get_Entries()**: System.Collections.Generic.List`1<CompendiumEntry> (Public)
- **get_UnlockedEntries()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_NewUnlockedEntries()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_LoadedTutorialVideo()**: UnityEngine.Video.VideoClip (Public)
- **LoadTutorialVideo(System.String videoName)**: System.Threading.Tasks.Task`1<System.Boolean> (Public)
- **SetUnlockedEntriesList(System.Collections.Generic.List`1<System.String> unlockedEntries)**: System.Void (Public)
- **GetEntryFromItemId(System.String itemId)**: CompendiumEntry (Public)
- **GetEntryFromEntryId(System.String entryId)**: CompendiumEntry (Public)
- **UnlockEntry(System.String entryId)**: System.Void (Public)
- **UnlockTutorial(System.String entryId)**: System.Void (Public)
- **UnlockTutorialFromItemId(System.String itemId)**: System.Void (Public)
- **get_OnEntryUnlocked()**: System.Action (Public)
- **set_OnEntryUnlocked(System.Action value)**: System.Void (Public)
- **get_OnTutorialUnlocked()**: System.Action`1<System.String> (Public)
- **set_OnTutorialUnlocked(System.Action`1<System.String> value)**: System.Void (Public)
- **get_OnRemoveNewUnlockedEntry()**: System.Action (Public)
- **set_OnRemoveNewUnlockedEntry(System.Action value)**: System.Void (Public)
- **HasNewUnlockedEntries()**: System.Boolean (Public)
- **IsNewUnlockedEntry(System.String itemId)**: System.Boolean (Public)
- **RemoveNewUnlockedEntry(System.String itemId)**: System.Void (Public)
- **IsUnlocked(System.String entryId)**: System.Boolean (Public)

