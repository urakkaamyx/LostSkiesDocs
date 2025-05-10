# WildSkies.AI.Attacks.AttackHandlerBase

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Protected |
| _disposalService | WildSkies.Service.DisposalService | Protected |
| cameraImpulseService | WildSkies.Service.CameraImpulseService | Protected |
| _colliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Protected |
| _aiLevelsService | WildSkies.Service.AILevelsService | Protected |
| _target | UnityEngine.Transform | Protected |
| _targetType | WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType | Protected |
| UnsetAttack | System.Int32 | Protected |
| _currentElementLODLevel | System.Int32 | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| InstantiationService | WildSkies.Service.WildSkiesInstantiationService | Public |
| DisposalService | WildSkies.Service.DisposalService | Public |
| CameraImpulseService | WildSkies.Service.CameraImpulseService | Public |
| ColliderLookupService | WildSkies.Service.Interface.ColliderLookupService | Public |
| AiLevelsService | WildSkies.Service.AILevelsService | Public |
| Target | UnityEngine.Transform | Public |
| TargetType | WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType | Public |
| CurrentElementLODLevel | System.Int32 | Public |

## Methods

- **get_InstantiationService()**: WildSkies.Service.WildSkiesInstantiationService (Public)
- **get_DisposalService()**: WildSkies.Service.DisposalService (Public)
- **get_CameraImpulseService()**: WildSkies.Service.CameraImpulseService (Public)
- **get_ColliderLookupService()**: WildSkies.Service.Interface.ColliderLookupService (Public)
- **get_AiLevelsService()**: WildSkies.Service.AILevelsService (Public)
- **get_Target()**: UnityEngine.Transform (Public)
- **get_TargetType()**: WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType (Public)
- **get_CurrentElementLODLevel()**: System.Int32 (Public)
- **SetActiveAttack(System.Int32 attackIndex)**: System.Void (Public)
- **SetActiveAttack(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Void (Public)
- **SetAttackTarget(UnityEngine.Transform target, WildSkies.AI.Attacks.AttackHandlerBase/AttackTargetType targetType)**: System.Void (Public)
- **GetActiveAttack()**: WildSkies.AI.Attacks.AIAttack (Public)
- **GetAttackMaxDistance(WildSkies.AI.Attacks.AIAttackType attackType)**: System.Single (Public)
- **GetAttackState(WildSkies.AI.Attacks.AIAttackType aIAttackType, WildSkies.AI.Attacks.AIAttack/AttackState state)**: System.Boolean (Public)
- **UpdateLODLevel(System.Int32 lodLevel)**: System.Void (Public)
- **.ctor()**: System.Void (Protected)

