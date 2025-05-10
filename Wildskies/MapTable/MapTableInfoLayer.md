# WildSkies.MapTable.MapTableInfoLayer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| UiDim | System.Single | Private |
| _mapTable | WildSkies.ShipParts.MapTable | Private |
| _parentForInfoItems | UnityEngine.Transform | Private |
| _islandInfoPanelPrefab | WildSkies.MapTable.InfoElements.IslandInfoPanel | Private |
| _mapMarkerPrefab | WildSkies.MapTable.InfoElements.MapMarker | Private |
| _mapNotePrefab | WildSkies.MapTable.InfoElements.MapNote | Private |
| _objectDatas | System.Collections.Generic.List`1<WildSkies.MapTable.MapTableInfoLayer/MapInfoData> | Private |
| _minZoomHeight | System.Single | Private |
| _maxZoomHeight | System.Single | Private |

## Methods

- **InitIslandInfo(System.String metaData, UnityEngine.Vector3 position)**: WildSkies.MapTable.MapTableInfoLayer/MapInfoData (Public)
- **InitMarker(UnityEngine.Sprite sprite, System.String metaData)**: WildSkies.MapTable.MapTableInfoLayer/MapInfoData (Public)
- **RemoveObject(WildSkies.MapTable.MapTableInfoLayer/MapInfoData objectToRemove)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **ConvertToUISpace(UnityEngine.Vector2 bl, System.Single areaShown, UnityEngine.Vector2 position)**: UnityEngine.Vector2 (Private)
- **.ctor()**: System.Void (Public)

