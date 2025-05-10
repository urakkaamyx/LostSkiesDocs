# WildSkies.Service.LandEncounterService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _activeEncounters | System.Collections.Generic.List`1<ILandEncounter> | Private |
| _currentIsland | World.IslandController | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| CurrentIsland | World.IslandController | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_CurrentIsland()**: World.IslandController (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **SetCurrentIsland(World.IslandController island)**: System.Void (Public)
- **RegisterEncounter(ILandEncounter encounter)**: System.Void (Public)
- **UnregisterEncounter(ILandEncounter encounter)**: System.Void (Public)
- **IncreaseEncounterChance(UnityEngine.Vector3 position, WildSkies.Audio.AudioType audioType, WildSkies.IslandExport.SubBiomeType subBiomeType)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **GetNearestEncounter(UnityEngine.Vector3 position, WildSkies.IslandExport.SubBiomeType subBiomeType)**: ILandEncounter (Private)
- **.ctor()**: System.Void (Public)

