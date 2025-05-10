# WildSkies.Gameplay.Effectors.Effector

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _rigidbody | UnityEngine.Rigidbody | Private |
| _visuals | UnityEngine.GameObject | Private |
| _collider | UnityEngine.Collider | Private |
| _entityHealth | WildSkies.Entities.Health.EntityHealth | Private |
| _effectorInteraction | EffectorInteraction | Private |
| _effectorData | EffectorData | Private |
| _effectorContainerData | EffectorContainerData | Private |
| _effectorContainer | WildSkies.Gameplay.Effectors.EffectorContainer | Private |
| _connectedBody | UnityEngine.Rigidbody | Private |
| _connectedCollider | UnityEngine.Collider | Private |
| _connectedTree | ChoppableTree | Private |
| _throwCollisionIgnoreTimer | System.Single | Private |
| _pickupIgnoreTimer | System.Single | Private |
| _results | UnityEngine.Collider[] | Private |
| _remotePlayerResults | UnityEngine.Collider[] | Private |
| Power | System.Single | Public |
| Attached | System.Boolean | Public |
| Thrown | System.Boolean | Public |
| Destroyed | System.Boolean | Public |
| PowerThreshold | System.Single | Private |
| DestroyDelay | System.Single | Private |
| ScaleDuration | System.Single | Private |
| _destructionTimer | System.Single | Private |
| _networkFxService | WildSkies.Service.NetworkFxService | Private |
| _localPlayerServices | WildSkies.Service.ILocalPlayerService | Private |
| _attachedVfx | WildSkies.PoolableVfx | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Collider | UnityEngine.Collider | Public |
| ConnectedRigidbody | UnityEngine.Rigidbody | Public |
| Visuals | UnityEngine.GameObject | Public |
| Lifting | System.Int32 | Public |
| Charged | System.Boolean | Public |
| WeightDecreasePercentage | System.Single | Public |
| AssociatedEffectorContainer | WildSkies.Gameplay.Effectors.EffectorContainer | Public |
| Damaged | System.Boolean | Public |
| InIgnorePickup | System.Boolean | Public |

## Methods

- **get_Collider()**: UnityEngine.Collider (Public)
- **get_ConnectedRigidbody()**: UnityEngine.Rigidbody (Public)
- **get_Visuals()**: UnityEngine.GameObject (Public)
- **get_Lifting()**: System.Int32 (Public)
- **get_Charged()**: System.Boolean (Public)
- **get_WeightDecreasePercentage()**: System.Single (Public)
- **get_AssociatedEffectorContainer()**: WildSkies.Gameplay.Effectors.EffectorContainer (Public)
- **get_Damaged()**: System.Boolean (Public)
- **get_InIgnorePickup()**: System.Boolean (Public)
- **Start()**: System.Void (Public)
- **AuthorityChanged(System.Boolean authority)**: System.Void (Private)
- **RequestAuthority()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **SetPhysics()**: System.Void (Private)
- **OnHealthChanged()**: System.Void (Private)
- **SetPower(System.Int32 value)**: System.Void (Private)
- **Throw(WildSkies.Gameplay.Items.ItemDefinition itemDefinition, UnityEngine.Vector3 scale, UnityEngine.Vector3 force, System.Single torque)**: System.Void (Public)
- **Update()**: System.Void (Public)
- **FixedUpdate()**: System.Void (Public)
- **UpdateDestruction()**: System.Void (Private)
- **CheckForDisconnection()**: System.Void (Private)
- **UpdatePower()**: System.Void (Private)
- **UpdateCollisionTimer()**: System.Void (Private)
- **Setup(UnityEngine.Rigidbody connectedBody, WildSkies.Gameplay.Effectors.EffectorContainer effectorContainer)**: System.Void (Public)
- **FindTree(UnityEngine.GameObject tree)**: System.Void (Private)
- **TreeSplit(ChoppableTree tree)**: System.Void (Private)
- **Initialize()**: System.Void (Public)
- **DamageEffector()**: System.Void (Public)
- **Disconnect()**: System.Void (Public)
- **RemoveEffector(System.Boolean destroy)**: System.Void (Public)
- **RemoveEffectorOwnerCommand(System.Boolean destroy)**: System.Void (Public)
- **RemoveEffectorCommand(System.Boolean destroy)**: System.Void (Public)
- **DeleteEffector(System.Boolean destroy, System.Boolean playVFX)**: System.Void (Private)
- **DestroyEffector()**: System.Void (Private)
- **OnContainerDestroyed()**: System.Void (Public)
- **SearchForNewConnection()**: System.Void (Public)
- **FindNewConnection()**: System.Boolean (Private)
- **SearchForRemotePlayer()**: System.Void (Private)
- **ConnectToRemotePlayer()**: System.Void (Public)
- **OnCollisionEnter(UnityEngine.Collision collision)**: System.Void (Private)
- **TryConnectEffectorToObject(UnityEngine.Rigidbody rigidbody)**: System.Boolean (Private)
- **ConnectEffector(UnityEngine.Rigidbody rigidbody)**: System.Void (Private)
- **ConnectCommand(UnityEngine.GameObject rigidbodyGameObject)**: System.Void (Public)
- **SetupEffector(UnityEngine.Rigidbody rigidbody)**: System.Void (Private)
- **FindNewPosition()**: System.Void (Public)
- **AlignToTarget()**: System.Void (Private)
- **SetPositionAndRotation(UnityEngine.Vector3 hitpoint, UnityEngine.Vector3 hitnormal)**: System.Void (Private)
- **OnDrawGizmos()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<Start>b__44_0()**: System.Void (Private)

