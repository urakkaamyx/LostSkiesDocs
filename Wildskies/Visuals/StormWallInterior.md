# Wildskies.Visuals.StormWallInterior

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _apvWindSampler | ApvWindSampler | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _realTimeParameters | System.Boolean | Private |
| _drawGizmos | System.Boolean | Private |
| _debugCloudVolume | Expanse.ProceduralCloudVolume | Private |
| _debugCamera | UnityEngine.Camera | Private |
| _debugNormalizedTime | System.Single | Private |
| _debugWindDir | UnityEngine.Vector3 | Private |
| _fadeDist | System.Single | Private |
| _material | UnityEngine.Material | Private |
| _baseSpeed | System.Single | Private |
| _fogColorOverTime | UnityEngine.Gradient | Private |
| _minStorm | System.Single | Private |
| _maxStorm | System.Single | Private |
| _nearLayerColorGrad | UnityEngine.Gradient | Private |
| _nearEffectStrength | System.Single | Private |
| _nearLayerContrast | System.Single | Private |
| _shadeOffset | System.Single | Private |
| _baseScale | System.Single | Private |
| _nearPlane | System.Single | Private |
| _vortexSpeed | System.Single | Private |
| _directionRandomization | System.Single | Private |
| _geoBlendDepth | System.Single | Private |
| _nearLayerStretch | UnityEngine.Vector3 | Private |
| _farLayerHighlightsGrad | UnityEngine.Gradient | Private |
| _farLayerColorGrad | UnityEngine.Gradient | Private |
| _farLayerContrast | System.Single | Private |
| _shadeWidth | System.Single | Private |
| _farLayerStretch | UnityEngine.Vector3 | Private |
| _bottomLayerOffset | System.Single | Private |
| RefreshUniformsDelay | System.Single | Private |
| _creationTime | System.Single | Private |
| _stormValue | System.Single | Private |
| _storedWidth | System.Int32 | Private |
| _storedHeight | System.Int32 | Private |
| _startingCloudDensity | System.Single | Private |
| _windOffset | UnityEngine.Vector2 | Private |
| _boxCollider | UnityEngine.BoxCollider | Private |
| _renderCamera | UnityEngine.Camera | Private |
| WindOffsetId | System.Int32 | Private |
| StrengthId | System.Int32 | Private |
| NearStormEdgeId | System.Int32 | Private |
| WorldOffsetId | System.Int32 | Private |
| BottomLayerId | System.Int32 | Private |
| NearColId | System.Int32 | Private |
| FarDarkColId | System.Int32 | Private |
| FarLightColId | System.Int32 | Private |
| FogColId | System.Int32 | Private |
| GeoBlendId | System.Int32 | Private |
| VortexSpdId | System.Int32 | Private |
| OffsetId | System.Int32 | Private |
| SpeedId | System.Int32 | Private |
| DirRndId | System.Int32 | Private |
| BaseDistId | System.Int32 | Private |
| NearStretchId | System.Int32 | Private |
| FarStretchId | System.Int32 | Private |
| BaseScaleId | System.Int32 | Private |
| ShadeWidthId | System.Int32 | Private |
| NearContrastId | System.Int32 | Private |
| FarContrastId | System.Int32 | Private |

## Methods

- **OnEnable()**: System.Void (Private)
- **LateUpdate()**: System.Void (Private)
- **OnValidate()**: System.Void (Private)
- **OnApplicationFocus(System.Boolean hasFocus)**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **SetDynamicUniforms()**: System.Void (Private)
- **SetCamera()**: System.Void (Private)
- **RefreshUniforms()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)

