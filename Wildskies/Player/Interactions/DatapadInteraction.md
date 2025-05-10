# WildSkies.Player.Interactions.DatapadInteraction

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| TargetPlayer | Coherence.Toolkit.CoherenceSync | Public |
| ObjectMetaDataId | System.Int32 | Public |
| WorldLoadingService | WildSkies.Service.WorldLoadingService | Public |
| IslandLoadingService | WildSkies.Service.IslandLoadingService | Public |
| IslandService | WildSkies.Service.IIslandService | Public |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _datapadAnimator | UnityEngine.Animator | Private |
| _animatorActivatedKey | System.String | Private |
| _datapadCoherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _datapad | WildSkies.IslandExport.Datapad | Private |
| TIMEOUT | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| InteractionDistance | System.Single | Public |
| Message | System.String | Public |

## Methods

- **get_InteractionDistance()**: System.Single (Public)
- **get_Message()**: System.String (Public)
- **Start()**: System.Void (Private)
- **Interact(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Public)
- **InteractAsync(Bossa.Dynamika.Character.DynamikaCharacter character)**: Cysharp.Threading.Tasks.UniTask (Public)
- **TakeAuthority()**: System.Threading.Tasks.Task (Private)
- **Close()**: Cysharp.Threading.Tasks.UniTask (Public)
- **OpenDatapadSpectator(Coherence.Toolkit.CoherenceSync targetOld, Coherence.Toolkit.CoherenceSync targetInUse)**: System.Void (Public)
- **ActivateGallDiscDatapadViewerAsync(Bossa.Dynamika.Character.DynamikaCharacter dc, System.Boolean targetPlayerIsLocal)**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)
- **<>n__0(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **<TakeAuthority>b__18_0()**: System.Boolean (Private)

