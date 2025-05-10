# WildSkies.Service.VfxPoolService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _vfxPoolDictionary | System.Collections.Generic.Dictionary`2<WildSkies.VfxType,WildSkies.VfxPool> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **.ctor(UnityEngine.Transform parent, PoolableVfxData[] data)**: System.Void (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **GetVfx(WildSkies.VfxType vfxType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, System.Int32 seed, UnityEngine.Vector3 velocity, WildSkies.VfxSize vfxSize)**: WildSkies.PoolableVfx (Public)

