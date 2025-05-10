# WildSkies.Gameplay.Effectors.EffectorContainer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _shouldSlowDown | System.Boolean | Private |
| _effectorContainerData | EffectorContainerData | Private |
| _initialMass | System.Single | Private |
| _currentLiftForce | System.Single | Private |
| _bumpForce | System.Single | Private |
| _slowDownTimer | System.Single | Private |
| _effectors | System.Collections.Generic.List`1<WildSkies.Gameplay.Effectors.Effector> | Private |
| _colliders | System.Collections.Generic.List`1<UnityEngine.Collider> | Private |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| _connectedBody | UnityEngine.Rigidbody | Private |
| _connectedNetworkedRigidbody | Bossa.Core.Entity.NetworkedRigidbody | Private |
| DestroyContainer | System.Action | Public |
| _inAuthoritySwitch | System.Boolean | Private |
| _localPlayerServices | WildSkies.Service.ILocalPlayerService | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Effectors | System.Collections.Generic.List`1<WildSkies.Gameplay.Effectors.Effector> | Public |

## Methods

- **get_Effectors()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Effectors.Effector> (Public)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **ClearEffectors()**: System.Void (Public)
- **Setup(UnityEngine.Rigidbody connectedBody, EffectorContainerData effectorContainerData)**: System.Void (Public)
- **GetNetworkedRigidbody()**: System.Void (Private)
- **SaveInitialMass(UnityEngine.Rigidbody connectedBody)**: System.Void (Private)
- **AuthorityChanged(System.Boolean authority)**: System.Void (Private)
- **AddEffector(WildSkies.Gameplay.Effectors.Effector effector)**: System.Void (Public)
- **ChangeAuthority(WildSkies.Gameplay.Effectors.Effector effector)**: System.Void (Public)
- **RemoveEffector(WildSkies.Gameplay.Effectors.Effector effector)**: System.Void (Public)
- **FixedUpdate()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **CheckConnection()**: System.Void (Public)
- **HandleVelocitySlowDown()**: System.Void (Private)
- **SlowDownVelocity()**: System.Void (Private)
- **CalculateLiftForce()**: System.Void (Public)
- **CalculateWeight()**: System.Void (Private)
- **LiftUp()**: System.Void (Private)
- **Bump(UnityEngine.Vector3 position)**: System.Void (Private)
- **GetAdjustedVelocity()**: UnityEngine.Vector3 (Private)
- **CalculateBumpForce()**: System.Void (Private)
- **FindCollider()**: System.Void (Private)
- **IgnoreCollider(WildSkies.Gameplay.Effectors.Effector effector, System.Boolean ignoreCollision)**: System.Void (Private)
- **FindMidpoint(System.Collections.Generic.List`1<WildSkies.Gameplay.Effectors.Effector> objects)**: UnityEngine.Vector3 (Private)
- **Grapple(UnityEngine.Vector3 grapplePoint)**: System.Void (Public)
- **OnYank(UnityEngine.Vector3 direction)**: System.Void (Public)
- **DetachGrapple()**: System.Void (Public)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<Setup>b__19_0()**: System.Void (Private)

