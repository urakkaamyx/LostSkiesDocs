# WildSkies.AI.AIDroneMaterialSwitcher

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _sync | Coherence.Toolkit.CoherenceSync | Private |
| _aiEntity | WildSkies.Entities.AIEntity | Private |
| _droneRenderers | UnityEngine.Renderer[] | Private |
| _idleMaterial | WildSkies.AI.AIDroneMaterialSwitcher/MatGroup | Private |
| _investigatingMaterial | WildSkies.AI.AIDroneMaterialSwitcher/MatGroup | Private |
| _attackingMaterial | WildSkies.AI.AIDroneMaterialSwitcher/MatGroup | Private |
| _repairMaterial | WildSkies.AI.AIDroneMaterialSwitcher/MatGroup | Private |
| _currentMaterialId | System.Int32 | Public |
| _materials | System.Collections.Generic.Dictionary`2<WildSkies.AI.AIDroneMaterialSwitcher/MaterialState,WildSkies.AI.AIDroneMaterialSwitcher/MatGroup> | Private |
| _seraphMaterialIndex | System.Int32 | Private |
| _cableMaterialIndex | System.Int32 | Private |
| _tempMats | UnityEngine.Material[] | Private |
| _matsSize | System.Int32 | Private |
| _hasKnownTarget | System.Boolean | Private |
| _perceptionState | WildSkies.AI.EPerceptionState | Private |

## Methods

- **Awake()**: System.Void (Private)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnPerceptionStateChanged(WildSkies.AI.EPerceptionState obj)**: System.Void (Private)
- **OnHasKnownTarget(AITargetType targetType, System.Boolean hasKnownTarget)**: System.Void (Private)
- **OnAttackStateChanged(WildSkies.AI.Attacks.AIAttackType aiAttackType, WildSkies.AI.Attacks.AIAttack/AttackState attackState)**: System.Void (Private)
- **SetMaterial(WildSkies.AI.AIDroneMaterialSwitcher/MaterialState materialState)**: System.Void (Private)
- **NetworkSyncMaterial(System.Int32 prev, System.Int32 cur)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

