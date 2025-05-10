# WildSkies.ShipParts.Mast

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| BrakeTimerToCloseSails | System.Single | Private |
| furl | System.Boolean | Public |
| _furlDuration | System.Single | Private |
| _isSideSail | System.Boolean | Private |
| _isPerfectZoneForwardBiassed | System.Boolean | Private |
| _sailWindControl | SailWindControl | Private |
| _showGizmos | System.Boolean | Private |
| _drawDebugLabel | System.Boolean | Private |
| _debugLabelOffset | UnityEngine.Vector3 | Private |
| _constantlyUpdateStats | System.Boolean | Private |
| _shipPartSetup | ShipPartSetup | Private |
| _cameraTarget | UnityEngine.Transform | Private |
| _cameraSettings | Bossa.Cinematika.Controllers.PilotCinematikaController/Settings | Private |
| _windContribution | System.Single | Private |
| _dotProduct | System.Single | Private |
| _sideDotProduct | System.Single | Private |
| _windDirection | UnityEngine.Vector3 | Private |
| _furlProgress | System.Single | Private |
| _windService | WildSkies.Service.WindService | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _flappingEventId | System.Int32 | Private |
| _furl | WildSkies.Audio.AudioType | Private |
| _unfurl | WildSkies.Audio.AudioType | Private |
| _flapping | WildSkies.Audio.AudioType | Private |
| _liftAmount | System.Single | Private |
| _powerAmount | System.Single | Private |
| _windPerformance | System.Single | Private |
| _perfectAngleRange | System.Single | Private |
| _sailPower | System.Single | Private |
| _sailLift | System.Single | Private |
| _absoluteMinPower | System.Single | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _shipControlState | WildSkies.Ship.ShipControl/ShipControlState | Private |
| _logDebugStuff | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsOpen | System.Boolean | Public |

## Methods

- **get_IsOpen()**: System.Boolean (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **UpdateStats()**: System.Void (Protected)
- **OnDestroy()**: System.Void (Protected)
- **OnSetupComplete()**: System.Void (Private)
- **Init(WildSkies.Service.WindService windService, WildSkies.Service.NetworkFxService networkFxService, WildSkies.Service.ItemStatsService statsService)**: System.Void (Public)
- **OnDisable()**: System.Void (Private)
- **OnShipControlUpdate(WildSkies.Ship.ShipControl/ShipControlState state)**: System.Void (Public)
- **GetWindDirection()**: System.Void (Private)
- **CalculateWindContribution()**: System.Void (Private)
- **CalculateWindContributionSideSail()**: System.Void (Private)
- **CalculateWindContributionMainSail()**: System.Void (Private)
- **OnShipControlFixedUpdate()**: System.Void (Public)
- **SetFurl()**: System.Void (Public)
- **AuthoritySetFurl()**: System.Void (Public)
- **OnFurlSynced(System.Boolean oldFurl, System.Boolean newFurl)**: System.Void (Public)
- **FurlSail()**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<FurlSail>b__52_0()**: System.Single (Private)
- **<FurlSail>b__52_1(System.Single x)**: System.Void (Private)

