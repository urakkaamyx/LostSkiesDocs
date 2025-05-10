# WildSkies.VfxPool

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _parent | UnityEngine.Transform | Private |
| _vfxPoolDataPerSize | System.Collections.Generic.Dictionary`2<WildSkies.VfxSize,WildSkies.VfxPoolSizeData> | Private |
| _startingScale | UnityEngine.Vector3 | Private |
| _vfxData | PoolableVfxData | Private |
| _type | WildSkies.VfxType | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Parent | UnityEngine.Transform | Public |
| Type | WildSkies.VfxType | Public |

## Methods

- **get_Parent()**: UnityEngine.Transform (Public)
- **get_Type()**: WildSkies.VfxType (Public)
- **Populate(UnityEngine.Transform parent, PoolableVfxData vfxData)**: System.Void (Public)
- **InstantiatePoolSlot(PoolableVfxData vfxData, WildSkies.VfxSize size, WildSkies.PoolableVfx[] pool, System.Int32 index)**: System.Void (Private)
- **Get(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, System.Int32 seed, UnityEngine.Vector3 velocity, WildSkies.VfxSize size)**: WildSkies.PoolableVfx (Public)
- **ReturnToPool(WildSkies.PoolableVfx poolableVfx)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

