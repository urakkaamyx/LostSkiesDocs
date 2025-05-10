# WildSkies.Service.WindwallService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _wallSections | System.Collections.Generic.List`1<WildSkies.Service.WindwallService/WindwallSection> | Private |
| _windwallRegisteredShips | System.Collections.Generic.List`1<WildSkies.Service.WindwallService/WindwallRegisteredShip> | Private |
| _time | System.Single | Private |
| _showDebugRays | System.Boolean | Private |
| _isReady | System.Boolean | Private |
| _wallCount | System.Int32 | Private |
| _localPlayer | WildSkies.Player.ILocalPlayer | Private |
| _nearestWallToPlayer | WildSkies.Service.WindwallService/WindwallSection | Private |
| _weatherWall | WildSkies.WorldItems.WeatherWall | Private |
| _tempOpenSailsList | System.Collections.Generic.List`1<WildSkies.ShipParts.Mast> | Private |
| OnWindwallsInitialised | System.Action | Public |
| OnLocalPlayerEnteredWindwall | System.Action | Public |
| OnLocalPlayerExitedWindwall | System.Action | Public |
| OnLocalPlayerDistanceToWindwallUpdate | System.Action`1<System.Single> | Public |
| _sampleCount | System.Int32 | Private |
| _numberOfWalls | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |
| DebugRaysActive | System.Boolean | Public |
| IsReady | System.Boolean | Public |
| WindwallSections | System.Collections.Generic.List`1<WildSkies.Service.WindwallService/WindwallSection> | Public |
| WindwallRegisteredShips | System.Collections.Generic.List`1<WildSkies.Service.WindwallService/WindwallRegisteredShip> | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **get_DebugRaysActive()**: System.Boolean (Public)
- **get_IsReady()**: System.Boolean (Public)
- **get_WindwallSections()**: System.Collections.Generic.List`1<WildSkies.Service.WindwallService/WindwallSection> (Public)
- **get_WindwallRegisteredShips()**: System.Collections.Generic.List`1<WildSkies.Service.WindwallService/WindwallRegisteredShip> (Public)
- **.ctor(WeatherWallsData data)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **AddWindwallSection(WildSkies.Service.WindwallService/WindwallSection windwallSection)**: System.Void (Public)
- **RegisterWindwallSection(WildSkies.WorldItems.WeatherWall weatherWall, System.Action`1<System.Int32> OnWallRegistered, System.Boolean& isMainWall)**: System.Void (Public)
- **SetWindwallsReady()**: System.Void (Private)
- **RegisterShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController constructedShipController, WildSkies.Ship.ShipControl shipControl)**: System.Void (Public)
- **UnregisterShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController constructedShipController)**: System.Void (Public)
- **UpdateShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController constructedShipController)**: System.Void (Public)
- **RegisterLocalPlayer(WildSkies.Player.ILocalPlayer localPlayer)**: System.Void (Public)
- **ShiftPoints(UnityEngine.Vector3 shift)**: System.Void (Public)
- **ShowDebugRays(System.Boolean show)**: System.Void (Public)
- **FixedUpdate()**: System.Void (Public)
- **UpdateNoiseSamplePositions(WindwallData windwallData, UnityEngine.Vector2Int[] samplePositions)**: System.Void (Private)
- **UpdateShipForces(WildSkies.Service.WindwallService/WindwallRegisteredShip windwallRegisteredShip)**: System.Void (Private)
- **UpdateShipSailDamage(WildSkies.Service.WindwallService/WindwallRegisteredShip windwallRegisteredShip, WildSkies.Service.WindwallService/WindwallSection windwallSection)**: System.Void (Private)
- **UpdateDownForce(WildSkies.Service.WindwallService/WindwallRegisteredShip windwallRegisteredShip, WildSkies.Service.WindwallService/WindwallSection windwallSection)**: System.Void (Private)
- **UpdateTurbulence(WildSkies.Service.WindwallService/WindwallRegisteredShip windwallRegisteredShip, WildSkies.Service.WindwallService/WindwallSection windwallSection)**: System.Void (Private)
- **UpdatePushAwayForce(WildSkies.Service.WindwallService/WindwallRegisteredShip windwallRegisteredShip, WildSkies.Service.WindwallService/WindwallSection windwallSection)**: System.Void (Private)
- **UpdateLocalPlayerCheck()**: System.Void (Private)
- **GetNearestWall(UnityEngine.Vector3 checkPosition, System.Int32 prevSectionId, System.Int32& sectionId, System.Boolean& didChange)**: System.Void (Public)
- **GetWindwallSectionById(System.Int32 id)**: WildSkies.Service.WindwallService/WindwallSection (Public)
- **GetDirectionToLine(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point)**: UnityEngine.Vector3 (Public)
- **GetClosestPointOnLineSegment(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point)**: UnityEngine.Vector3 (Public)
- **GetDistanceFromLine(UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd, UnityEngine.Vector3 point)**: System.Single (Private)
- **CalcNoise(WindwallData windwallData)**: System.Single[,] (Private)

