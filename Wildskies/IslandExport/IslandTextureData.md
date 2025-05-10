# WildSkies.IslandExport.IslandTextureData

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <HeightMap1>k__BackingField | Unity.Collections.NativeArray`1<UnityEngine.Color> | Private |
| <HeightMap2>k__BackingField | Unity.Collections.NativeArray`1<UnityEngine.Color> | Private |
| <IslandSurface>k__BackingField | WildSkies.IslandExport.IslandSurface | Private |
| HeightmapRes | System.Int32 | Public |
| IsSrgb | System.Boolean | Public |
| _textureArray1 | UnityEngine.Texture2DArray | Private |
| _textureArray2 | UnityEngine.Texture2DArray | Private |
| _textureArray3 | UnityEngine.Texture2DArray | Private |
| _worldTexturesArray | UnityEngine.Texture2DArray | Private |
| _layerPropsLut | UnityEngine.Texture2D | Private |
| _layerIndicesLut | UnityEngine.Texture2D | Private |
| _heightMap1 | UnityEngine.Texture2D | Private |
| _heightMap2 | UnityEngine.Texture2D | Private |
| _initialized | System.Boolean | Private |
| _texturesEnabled | System.Boolean | Private |
| _triPlanarProjectionEnabled | System.Boolean | Private |
| _useTextureScaling | System.Boolean | Private |
| _useLayerBlending | System.Boolean | Private |
| _debugSampleCount | System.Boolean | Private |
| _textureFormat | System.Nullable`1<UnityEngine.TextureFormat> | Private |
| _heightJobHandle | Unity.Jobs.JobHandle | Private |
| _lastLayers | System.String[] | Private |
| PropertyCount | System.Int32 | Private |
| _lutColors | UnityEngine.Color[] | Private |
| _textureIndexColors | UnityEngine.Color32[] | Private |
| TerrainLayers | AwesomeTechnologies.MeshTerrains.TerrainLayerJob[] | Private |
| _globalUsedTextures | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Private |
| _textureIndexColor | UnityEngine.Color32 | Private |
| WorldTexturesArrayId | System.Int32 | Private |
| Maps1Id | System.Int32 | Private |
| Maps2Id | System.Int32 | Private |
| Maps3Id | System.Int32 | Private |
| LayerPropsId | System.Int32 | Private |
| LayerIndicesLutId | System.Int32 | Private |
| TextureVersionId | System.Int32 | Private |
| WorldTexturesQtyId | System.Int32 | Private |
| UseTexturesId | System.Int32 | Private |
| TriPlanarTexturesId | System.Int32 | Private |
| SeparateTextureLayerScaleId | System.Int32 | Private |
| DoLayerBlendId | System.Int32 | Private |
| HeightMap1Id | System.Int32 | Private |
| HeightMap2Id | System.Int32 | Private |
| VisualiseTexSamplesId | System.Int32 | Private |
| BlendingId | System.Int32 | Private |
| PerLayerScaleId | System.Int32 | Private |
| TriplanarId | System.Int32 | Private |
| TexturesId | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| HeightMap1 | Unity.Collections.NativeArray`1<UnityEngine.Color> | Public |
| HeightMap2 | Unity.Collections.NativeArray`1<UnityEngine.Color> | Public |
| GlobalUsedTextures | System.Collections.Generic.List`1<UnityEngine.Texture2D> | Public |
| IslandSurface | WildSkies.IslandExport.IslandSurface | Public |
| TexturesEnabled | System.Boolean | Public |
| TriPlanarProjectionEnabled | System.Boolean | Public |
| LastLayers | System.String[] | Public |
| HasHeightmapData | System.Boolean | Public |
| HasLocalTextureData | System.Boolean | Private |

## Methods

- **get_HeightMap1()**: Unity.Collections.NativeArray`1<UnityEngine.Color> (Public)
- **set_HeightMap1(Unity.Collections.NativeArray`1<UnityEngine.Color> value)**: System.Void (Private)
- **get_HeightMap2()**: Unity.Collections.NativeArray`1<UnityEngine.Color> (Public)
- **set_HeightMap2(Unity.Collections.NativeArray`1<UnityEngine.Color> value)**: System.Void (Private)
- **get_GlobalUsedTextures()**: System.Collections.Generic.List`1<UnityEngine.Texture2D> (Public)
- **get_IslandSurface()**: WildSkies.IslandExport.IslandSurface (Public)
- **set_IslandSurface(WildSkies.IslandExport.IslandSurface value)**: System.Void (Public)
- **get_TexturesEnabled()**: System.Boolean (Public)
- **get_TriPlanarProjectionEnabled()**: System.Boolean (Public)
- **get_LastLayers()**: System.String[] (Public)
- **get_HasHeightmapData()**: System.Boolean (Public)
- **GenerateWorldTextureArrays(WildSkies.IslandExport.IslandSurface[] islandSurfaces)**: System.Void (Public)
- **RemoveWorldTextureArray()**: System.Void (Public)
- **get_HasLocalTextureData()**: System.Boolean (Private)
- **ForceSetupLayers()**: System.Void (Public)
- **Debug_PrintLoadedTextures()**: System.Void (Public)
- **Debug_PrintWorldTextureArray()**: System.Void (Public)
- **SetupLayers(WildSkies.IslandExport.SerializableIslandMaterial serializableIslandMaterial, System.Boolean useGlobalTextureArrays, System.Boolean force)**: System.Void (Public)
- **SetIgnoreMipmapLimit(System.Collections.Generic.IEnumerable`1<UnityEngine.Texture2D> textures, System.Boolean ignore)**: System.Void (Private)
- **ApplyToMaterial(WildSkies.IslandExport.SerializableIslandMaterial serializableIslandMaterial, UnityEngine.Material material)**: System.Void (Public)
- **SetMaterialProperties(UnityEngine.Material material)**: System.Void (Public)
- **SetIslandMaterialLodSettings(System.Boolean useTextures, System.Boolean useTriPlanar, System.Boolean useIndividualScaling, System.Boolean doLayerBlending)**: System.Void (Public)
- **SetTextureState(System.Boolean isOn)**: System.Void (Public)
- **SetTextureProjectionState(System.Boolean useTriPlanarTextures)**: System.Void (Public)
- **SetIndividualTextureScaling(System.Boolean useTextureScaling)**: System.Void (Public)
- **SetUseLayerBlending(System.Boolean useLayerBlending)**: System.Void (Public)
- **DebugSampleCount(System.Boolean debugSampleCount)**: System.Void (Public)
- **GenerateHeightmapData(WildSkies.IslandExport.IslandMaterialLayer[] layers, System.Boolean force)**: System.Void (Public)
- **SetHeightmapData(UnityEngine.Texture2D heightmap1, UnityEngine.Texture2D heightmap2)**: System.Void (Public)
- **OnDisable()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **Initialize()**: System.Void (Private)
- **AllocateCpuHeightmapData()**: System.Void (Private)
- **DeallocateCpuHeightmapData()**: System.Void (Public)
- **InitLocalTextureArrays()**: System.Void (Private)
- **TearDown()**: System.Void (Private)
- **CleanUpLocalTextureArrays()**: System.Void (Private)
- **GetTerrainLayersForJob(WildSkies.IslandExport.IslandMaterialLayer[] layers)**: AwesomeTechnologies.MeshTerrains.TerrainLayerJob[] (Private)
- **GammaCorrectColor(UnityEngine.Color col)**: UnityEngine.Color (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

