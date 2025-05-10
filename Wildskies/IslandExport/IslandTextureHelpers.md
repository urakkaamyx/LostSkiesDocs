# WildSkies.IslandExport.IslandTextureHelpers

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| TextureIndexPath | System.String | Private |
| TextureNameMapPath | System.String | Private |
| TextureFormatPaths | System.String[] | Private |
| <UpgradeNameMap>k__BackingField | System.Collections.Generic.Dictionary`2<System.String,System.String> | Private |
| BaseColorMapId | System.Int32 | Private |
| NormalMapId | System.Int32 | Private |
| TextureVersionId | System.Int32 | Private |
| TextureVersion | WildSkies.IslandExport.IslandTextureVersion | Public |
| _islandTextures | System.Collections.Generic.Dictionary`2<System.Int32,System.Collections.Generic.List`1<WildSkies.IslandExport.IslandTexture>> | Public |
| <TerrainTextureVersion>k__BackingField | System.Int32 | Private |
| <TextureIndex>k__BackingField | UnityEngine.TextAsset | Private |
| <TextureNameMap>k__BackingField | UnityEngine.TextAsset | Private |
| <IslandTextureFormats>k__BackingField | TexturePacker.PackFormat[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| UpgradeNameMap | System.Collections.Generic.Dictionary`2<System.String,System.String> | Private |
| IslandTextures | System.Collections.Generic.List`1<WildSkies.IslandExport.IslandTexture> | Public |
| TerrainTextureVersion | System.Int32 | Public |
| TextureIndex | UnityEngine.TextAsset | Public |
| TextureNameMap | UnityEngine.TextAsset | Public |
| IslandTextureFormats | TexturePacker.PackFormat[] | Public |
| IslandTextureFormat | TexturePacker.PackFormat | Public |

## Methods

- **get_UpgradeNameMap()**: System.Collections.Generic.Dictionary`2<System.String,System.String> (Private)
- **set_UpgradeNameMap(System.Collections.Generic.Dictionary`2<System.String,System.String> value)**: System.Void (Private)
- **get_IslandTextures()**: System.Collections.Generic.List`1<WildSkies.IslandExport.IslandTexture> (Public)
- **get_TerrainTextureVersion()**: System.Int32 (Public)
- **set_TerrainTextureVersion(System.Int32 value)**: System.Void (Public)
- **get_TextureIndex()**: UnityEngine.TextAsset (Public)
- **set_TextureIndex(UnityEngine.TextAsset value)**: System.Void (Private)
- **get_TextureNameMap()**: UnityEngine.TextAsset (Public)
- **set_TextureNameMap(UnityEngine.TextAsset value)**: System.Void (Private)
- **get_IslandTextureFormats()**: TexturePacker.PackFormat[] (Public)
- **set_IslandTextureFormats(TexturePacker.PackFormat[] value)**: System.Void (Private)
- **get_IslandTextureFormat()**: TexturePacker.PackFormat (Public)
- **GetIslandTextureFromString(System.String tex)**: WildSkies.IslandExport.IslandTexture (Public)
- **ClearTextures(System.Int32 version)**: System.Void (Public)
- **ParseTextures(UnityEngine.RenderTexture renderTexture, UnityEngine.Material previewMat, UnityEngine.Camera previewCamera, UnityEngine.Shader singleTintShader)**: System.Void (Public)
- **LoadTextures(WildSkies.IslandExport.IslandPropItem islandPropItem, System.String folderNameForPrefabs, System.String[] suffixes, UnityEngine.RenderTexture renderTexture, UnityEngine.Material previewMat, UnityEngine.Camera previewCamera, UnityEngine.Shader singleTintShader)**: System.Void (Private)
- **GetFullPath(System.String textureRelPath)**: System.String (Public)
- **GetTextureVersionFromString(System.String tex)**: System.Int32 (Private)
- **.cctor()**: System.Void (Private)

