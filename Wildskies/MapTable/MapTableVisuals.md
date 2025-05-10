# WildSkies.MapTable.MapTableVisuals

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| Area | System.Int32 | Public |
| MapTexture | System.Int32 | Private |
| IslandSize | System.Int32 | Private |
| IslandTexture | System.Int32 | Private |
| WorldToMapSpace | System.Single | Private |
| <Position>k__BackingField | UnityEngine.Vector2 | Private |
| <Zoom>k__BackingField | System.Single | Private |
| _worldMapData | UnityEngine.TextAsset | Private |
| _mapTable | WildSkies.ShipParts.MapTable | Private |
| _mapVisualEffect | UnityEngine.VFX.VisualEffect | Private |
| _linesVisualEffect | UnityEngine.VFX.VisualEffect | Private |
| _minVerticalOffset | System.Single | Private |
| _maxVerticalOffset | System.Single | Private |
| _blankHeight | UnityEngine.Texture2D | Private |
| _blankColor | UnityEngine.Texture2D | Private |
| _largeMapHeights | UnityEngine.Texture2D | Private |
| _largeMapColors | UnityEngine.Texture2D | Private |
| _islandMapsData | WildSkies.MapTable.MapTableVisuals/IslandMapData[] | Private |
| _islandMapTextureDatas | WildSkies.MapTable.MapTableVisuals/IslandMapTextures[] | Private |
| _currentViewRect | UnityEngine.Rect | Private |
| _islandTexturesLoaded | System.Boolean | Private |
| _textureLoadCounter | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Position | UnityEngine.Vector2 | Public |
| Zoom | System.Single | Public |
| IslandTexturesLoaded | System.Boolean | Public |
| IslandMapDatas | WildSkies.MapTable.MapTableVisuals/IslandMapData[] | Public |

## Methods

- **get_Position()**: UnityEngine.Vector2 (Public)
- **set_Position(UnityEngine.Vector2 value)**: System.Void (Public)
- **get_Zoom()**: System.Single (Public)
- **set_Zoom(System.Single value)**: System.Void (Public)
- **get_IslandTexturesLoaded()**: System.Boolean (Public)
- **get_IslandMapDatas()**: WildSkies.MapTable.MapTableVisuals/IslandMapData[] (Public)
- **Awake()**: System.Void (Private)
- **Start()**: System.Void (Private)
- **BuildIslandMapData()**: System.Void (Private)
- **GetMapDataForIsland(System.String islandName, WildSkies.MapTable.MapTableVisuals/IslandMapTextures textureStorage)**: System.Void (Private)
- **BuildTextureData()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **UpdateMapData()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

