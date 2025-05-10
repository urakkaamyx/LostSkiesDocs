# WildSkies.Service.ObjectScanForPrizesService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _scannedObjectForPrize | System.Collections.Generic.List`1<System.String> | Private |
| <OnScannedObjectForPrizeAdded>k__BackingField | System.Action | Private |
| <FinishedInitialisation>k__BackingField | System.Boolean | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ScannedObjectsForPrize | System.Collections.Generic.List`1<System.String> | Public |
| OnScannedObjectForPrizeAdded | System.Action | Public |
| ServiceErrorCode | System.Int32 | Public |
| FinishedInitialisation | System.Boolean | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ScannedObjectsForPrize()**: System.Collections.Generic.List`1<System.String> (Public)
- **get_OnScannedObjectForPrizeAdded()**: System.Action (Public)
- **set_OnScannedObjectForPrizeAdded(System.Action value)**: System.Void (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_FinishedInitialisation()**: System.Boolean (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetScannedObjectsForPrize(System.Collections.Generic.List`1<System.String> scannedObjEntries)**: System.Void (Public)
- **AddScannedObject(System.String instanceGuid)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

