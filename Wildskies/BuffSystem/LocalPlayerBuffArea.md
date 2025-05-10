# WildSkies.BuffSystem.LocalPlayerBuffArea

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _buffToApply | BuffDefinitionBase | Private |
| _delayBeforeApply | System.Single | Private |
| _blockedBy | BuffDefinitionBase[] | Private |
| _removeOnExit | System.Boolean | Private |
| _playerLayer | System.String | Private |
| _localPlayerInArea | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _buffReceiver | WildSkies.BuffSystem.ExternalBuffsReceiver | Private |
| _timeSinceEnteredArea | System.Single | Private |
| _blockerCount | System.Int32 | Private |
| _buffApplied | System.Boolean | Private |
| _playerLayerId | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| CanApplyBuff | System.Boolean | Private |

## Methods

- **get_CanApplyBuff()**: System.Boolean (Private)
- **Awake()**: System.Void (Protected)
- **OnDestroy()**: System.Void (Private)
- **OnTriggerEnter(UnityEngine.Collider other)**: System.Void (Protected)
- **OnTriggerExit(UnityEngine.Collider other)**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **OnBuffAdded(WildSkies.BuffSystem.ActiveBuff buff)**: System.Void (Private)
- **OnBuffRemoved(WildSkies.BuffSystem.ActiveBuff buff)**: System.Void (Private)
- **TriggeredByLocalPlayer(UnityEngine.Transform other, Bossa.Dynamika.Character.DynamikaCharacter& character)**: System.Boolean (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

