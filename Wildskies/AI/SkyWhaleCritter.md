# WildSkies.AI.SkyWhaleCritter

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _flyingKinematicMovement | WildSkies.AI.AIFlyingKinematicMovement | Private |
| _depositSpawnPoints | UnityEngine.Transform[] | Private |
| _showDepositSpawnPoints | System.Boolean | Private |
| _readyToDespawn | System.Boolean | Private |
| _isReady | System.Boolean | Private |
| _despawnAltitude | System.Single | Private |
| _state | WildSkies.AI.SkyWhaleCritter/SkyWhaleState | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _lootDropService | WildSkies.Service.LootDropService | Private |
| _wildSkiesInstantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _islandService | WildSkies.Service.IIslandService | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ReadyToDespawn | System.Boolean | Public |
| State | WildSkies.AI.SkyWhaleCritter/SkyWhaleState | Public |

## Methods

- **get_ReadyToDespawn()**: System.Boolean (Public)
- **get_State()**: WildSkies.AI.SkyWhaleCritter/SkyWhaleState (Public)
- **OnEnable()**: System.Void (Protected)
- **OnDisable()**: System.Void (Protected)
- **Update()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **Init(UnityEngine.Vector3 origin, System.Single despawnAltitude)**: System.Void (Public)
- **SetState(WildSkies.AI.SkyWhaleCritter/SkyWhaleState state)**: System.Void (Public)
- **ScatterAtlasDeposits()**: System.Void (Private)
- **OnDepositSpawned(UnityEngine.GameObject deposit)**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

