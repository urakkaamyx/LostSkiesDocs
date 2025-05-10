# WildSkies.Service.WindService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _windData | WindData | Private |
| _windController | WindController | Private |
| _globalDirection | System.Single | Private |
| _globalStrength | System.Single | Private |
| UpdateWindValues | System.Action | Public |
| <CurrentIsland>k__BackingField | World.IslandController | Private |
| <ApvWindSampler>k__BackingField | ApvWindSampler | Private |
| IslandWindDirectionId | System.Int32 | Private |
| IslandWindTurbulenceId | System.Int32 | Private |
| FullWindDegree | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| WindController | WindController | Public |
| WindData | WindData | Public |
| CurrentIsland | World.IslandController | Public |
| ApvWindSampler | ApvWindSampler | Public |
| StarterIslandWind | World.Wind | Public |
| StaterIslandWindDirection | System.Single | Public |
| StaterIslandWindStrength | System.Single | Public |
| StaterIslandWindTurbulence | System.Single | Public |
| StarterIslandWindAngleVariation | System.Single | Public |
| StarterIslandWindStrengthVariation | System.Single | Public |
| GlobalDirectionVariation | System.Single | Public |
| GlobalStrengthVariation | System.Single | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_WindController()**: WindController (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **RegisterWindController(WindController windController)**: System.Void (Public)
- **UnregisterWindController(WindController windController)**: System.Void (Public)
- **.ctor(WindData windData)**: System.Void (Public)
- **get_WindData()**: WindData (Public)
- **get_CurrentIsland()**: World.IslandController (Public)
- **set_CurrentIsland(World.IslandController value)**: System.Void (Private)
- **get_ApvWindSampler()**: ApvWindSampler (Public)
- **set_ApvWindSampler(ApvWindSampler value)**: System.Void (Public)
- **get_StarterIslandWind()**: World.Wind (Public)
- **GetGlobalWind()**: World.Wind (Public)
- **get_StaterIslandWindDirection()**: System.Single (Public)
- **get_StaterIslandWindStrength()**: System.Single (Public)
- **get_StaterIslandWindTurbulence()**: System.Single (Public)
- **get_StarterIslandWindAngleVariation()**: System.Single (Public)
- **get_StarterIslandWindStrengthVariation()**: System.Single (Public)
- **get_GlobalDirectionVariation()**: System.Single (Public)
- **get_GlobalStrengthVariation()**: System.Single (Public)
- **GetStarterIslandDirectionVector(System.Single variation)**: UnityEngine.Vector3 (Public)
- **GetStarterIslandWindVector(System.Single variation)**: UnityEngine.Vector3 (Public)
- **GetIslandWind(World.IslandController island)**: World.Wind (Public)
- **GetCurrentIslandWind()**: World.Wind (Public)
- **OnIslandChanged(World.IslandController islandController)**: System.Void (Public)
- **GetLocalWindDirectionVector(UnityEngine.Vector3 from, System.Single variation)**: UnityEngine.Vector3 (Public)
- **GetLocalWindStrength(UnityEngine.Vector3 from)**: System.Single (Public)
- **GetLocalWindDirection(UnityEngine.Vector3 from)**: System.Single (Public)
- **GetLocalWind(UnityEngine.Vector3 from)**: UnityEngine.Vector3 (Public)
- **GetLocalWindData(UnityEngine.Vector3 from, System.Boolean ignoreY)**: World.Wind (Public)
- **UpdateWind()**: System.Void (Private)
- **UpdateWindForIsland(World.IslandController islandController)**: System.Void (Public)
- **RandomizeStarterIslandWind()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

