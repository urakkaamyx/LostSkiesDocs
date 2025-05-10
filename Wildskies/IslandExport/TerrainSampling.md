# WildSkies.IslandExport.TerrainSampling

**Type**: Class

## Methods

- **GetTerrainLayerAtPos(Unity.Mathematics.float3 normal, Unity.Mathematics.float3 wPos, UnityEngine.Color[] colors, Unity.Collections.NativeArray`1<UnityEngine.Color> heightMap1, Unity.Collections.NativeArray`1<UnityEngine.Color> heightMap2, System.Int32 heightMapRes, WildSkies.IslandExport.IslandMaterialLayer[] layers)**: System.Int32 (Public)
- **TriPlanarHeightMapSampleCoord(Unity.Mathematics.float3 normal, Unity.Mathematics.float3 worldPos, System.Single scale)**: Unity.Mathematics.float2[] (Private)
- **GetHeightsAtCoord(Unity.Mathematics.float2 coord, Unity.Collections.NativeArray`1<UnityEngine.Color> heightMaps1, Unity.Collections.NativeArray`1<UnityEngine.Color> heightMaps2, System.Int32 heightMapRes)**: UnityEngine.Color[] (Private)
- **FindTerrainLayerWinner(UnityEngine.Color height1, UnityEngine.Color height2, UnityEngine.Color[] inColors, WildSkies.IslandExport.IslandMaterialLayer[] layers)**: System.Int32 (Private)
- **SmoothStepWithTolerance(System.Single v1, System.Single v2, System.Single blend)**: System.Single (Private)
- **.ctor()**: System.Void (Public)

