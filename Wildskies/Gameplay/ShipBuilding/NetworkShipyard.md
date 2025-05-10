# WildSkies.Gameplay.ShipBuilding.NetworkShipyard

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _largeMessageService | WildSkies.Service.LargeMessageService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _shipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _shipHullData | System.Byte[] | Private |
| _shipHullDataCompressed | System.Byte[] | Private |
| _receivedFullSync | System.Boolean | Private |
| _saveSlot | System.Int32 | Private |
| _requestId | System.Guid | Private |
| isDirty | System.Boolean | Public |
| _isDesignSave | System.Boolean | Private |
| _shipHullDataHash | System.Byte[] | Public |
| _shipHullBackupCompressed | System.Byte[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ShipHullDataCompressed | System.Byte[] | Public |
| ReceivedFullSync | System.Boolean | Public |

## Methods

- **get_ShipHullDataCompressed()**: System.Byte[] (Public)
- **get_ReceivedFullSync()**: System.Boolean (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **Start()**: System.Void (Private)
- **TestRequestShipHullData()**: System.Void (Private)
- **RequestShipHullData()**: System.Void (Public)
- **BinarySerialize()**: System.Void (Public)
- **UpdateShipHullHash()**: System.Void (Public)
- **SetDirty(System.Boolean dirty)**: System.Void (Public)
- **OnIsDirtySynced(System.Boolean oldDirty, System.Boolean newDirty)**: System.Void (Public)
- **SetDirtyCommand(System.Boolean dirty)**: System.Void (Public)
- **SendWholeShipHullData()**: System.Void (Public)
- **ReceiveHullDataViaLMS(WildSkies.Service.LargeMessageType largeMessageType, System.Byte[] compressedHullData)**: System.Void (Private)
- **SetShipHullDataFromSave(WildSkies.Gameplay.ShipBuilding.ShipHull shipHull)**: System.Void (Public)
- **BackupShipForUndo()**: System.Void (Public)
- **UndoShipHullChanges()**: System.Void (Public)
- **LoadShipData(System.Int32 saveSlot, System.Boolean isDesignSave)**: System.Void (Public)
- **OnLoadCompleted(System.Boolean success, System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Private)
- **SaveShip(System.Int32 saveSlot)**: System.Void (Public)
- **SaveShipDesign(System.Int32 saveSlot)**: System.Void (Public)
- **GetShipHullString()**: System.String (Public)
- **LoadShipPreset(System.Int32 presetSlot, System.Boolean loadAsDesign)**: System.Boolean (Public)
- **SaveShipPreset(System.Int32 presetSlot)**: System.Boolean (Public)
- **SaveEditedHull()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

