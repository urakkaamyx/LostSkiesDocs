# Wildskies.UI.Hud.CompassHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _compassIconsTransform | UnityEngine.RectTransform | Private |
| _compassTransform | UnityEngine.RectTransform | Private |
| _compassIconPrefab | CompassIcon | Private |
| _offset | System.Single | Private |
| _barLength | System.Single | Private |
| _iconYPos | System.Single | Private |
| _numberToPool | System.Int32 | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _remotePlayerService | WildSkies.Service.IRemotePlayerService | Private |
| _viewModel | Wildskies.UI.Hud.CompassHudViewModel | Private |
| _payload | Wildskies.UI.Hud.CompassHudPayload | Private |
| _compassIcons | System.Collections.Generic.List`1<CompassIcon> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **Show(IPayload payload)**: System.Void (Public)
- **Hide()**: System.Void (Public)
- **OnPlayerAddedToShip(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **OnPlayerRemovedFromShip(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **OnPlayerAddedToShipwreck(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **OnPlayerRemovedFromShipwreck(System.String shipId, Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Private)
- **OnRemotePlayerJoined(PlayerNetwork playerNetwork)**: System.Void (Private)
- **OnRemotePlayerLeft(PlayerNetwork playerNetwork)**: System.Void (Private)
- **SetupPlayers()**: System.Void (Private)
- **OnPingPlaced(System.String playerName, UnityEngine.Transform pingTransform)**: System.Void (Private)
- **OnPingCleared(UnityEngine.Transform pingTransform)**: System.Void (Private)
- **OnDeathLootSpawned(PlayerDeathLootController deathLootController)**: System.Void (Private)
- **OnDeathLootDestroyed(PlayerDeathLootController deathLootController)**: System.Void (Private)
- **OnLocalPlayerRegistered()**: System.Void (Private)
- **OnLocalPlayerUnRegistered()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

