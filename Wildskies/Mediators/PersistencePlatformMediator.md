# WildSkies.Mediators.PersistencePlatformMediator

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _platformService | PlatformService | Private |

## Methods

- **Initialise(WildSkies.Service.IPersistenceService persistenceService, PlatformService platformService)**: System.Void (Public)
- **Terminate()**: System.Void (Public)
- **RequestSlots(System.String key)**: System.Void (Private)
- **RequestNextAvailableSlot(System.String key)**: System.Void (Private)
- **RequestSave(System.Int32 saveSlot, System.String key, System.String saveData, System.Guid requestId)**: System.Void (Private)
- **RequestLoad(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Private)
- **RequestClear(System.Int32 saveSlot, System.String key, System.Guid requestId)**: System.Void (Private)
- **PlatformRetrievedExistingSlotsForKey(System.Boolean success, System.String key, System.Collections.Generic.List`1<System.Int32> existingSlots)**: System.Void (Private)
- **PlatformRetrievedNextAvailableSlotForKey(System.Boolean success, System.String key, System.Int32 nextAvailableSlot)**: System.Void (Private)
- **PlatformSaved(System.Boolean success, System.String key, System.Guid requestId)**: System.Void (Private)
- **PlatformLoaded(System.Boolean success, System.String key, System.String saveData, System.Int32 saveSlot, System.Guid requestId)**: System.Void (Private)
- **PlatformCleared(System.Boolean success, System.String key, System.Int32 saveSlot, System.Guid requestId)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

