# WildSkies.Puzzles.RelayNode

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| <PuzzleSource>k__BackingField | WildSkies.Puzzles.PuzzleModule | Private |
| <IsEnabled>k__BackingField | System.Boolean | Private |
| <LayerMask>k__BackingField | UnityEngine.LayerMask | Private |
| _targetToHit | UnityEngine.Transform | Private |
| _laserSource | UnityEngine.Transform | Private |
| _lineRenderer | UnityEngine.LineRenderer | Private |
| _rayStartOffset | System.Single | Private |
| _materialOff | UnityEngine.Material | Private |
| _materialOn | UnityEngine.Material | Private |
| _materialSwitchRenderers | UnityEngine.Renderer[] | Private |
| _timeBeforeDeactivating | System.Single | Private |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Private |
| _rayHitBuffer | UnityEngine.RaycastHit[] | Private |
| _isPowered | System.Boolean | Private |
| _lastPoweredTime | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| PuzzleSource | WildSkies.Puzzles.PuzzleModule | Public |
| IsEnabled | System.Boolean | Public |
| IsPowered | System.Boolean | Public |
| InputPosition | UnityEngine.Vector3 | Public |
| LayerMask | UnityEngine.LayerMask | Public |

## Methods

- **get_PuzzleSource()**: WildSkies.Puzzles.PuzzleModule (Public)
- **set_PuzzleSource(WildSkies.Puzzles.PuzzleModule value)**: System.Void (Public)
- **get_IsEnabled()**: System.Boolean (Public)
- **set_IsEnabled(System.Boolean value)**: System.Void (Public)
- **get_IsPowered()**: System.Boolean (Public)
- **set_IsPowered(System.Boolean value)**: System.Void (Public)
- **get_InputPosition()**: UnityEngine.Vector3 (Public)
- **get_LayerMask()**: UnityEngine.LayerMask (Public)
- **set_LayerMask(UnityEngine.LayerMask value)**: System.Void (Public)
- **Start()**: System.Void (Private)
- **LaserCheck()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

