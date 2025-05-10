# WildSkies.Player.LocalPlayer

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _playerPositionDatas | StringStringDictionary | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _uiService | UISystem.IUIService | Private |
| _sceneService | WildSkies.Service.SceneService | Private |
| _floatingWorldOriginService | WildSkies.Service.FloatingWorldOriginService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _instantiationService | WildSkies.Service.WildSkiesInstantiationService | Private |
| _playerInventoryService | WildSkies.Service.IPlayerInventoryService | Private |
| _deathLootService | WildSkies.Service.IDeathLootService | Private |
| _windwallService | WildSkies.Service.WindwallService | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _buffService | WildSkies.Service.BuffService | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| _downloadableContentService | Bossa.WildSkies.Service.DownloadableContentService | Private |
| _distanceFromArkToForceCameraToDoor | System.Single | Private |
| _timeBetweenAuthCheckOnPilotables | System.Single | Private |
| _boneSync | BoneAnimationSyncCharacter | Private |
| _baseStats | BaseStats | Protected |
| _playerRoot | UnityEngine.Transform | Private |
| _stamina | WildSkies.Entities.Stamina.EntityStamina | Protected |
| _playerSkillHandler | PlayerSkillHandler | Protected |
| _cameraSwitch | CameraSwitch | Private |
| _equipmentController | EquipmentController | Private |
| _aimAssistController | PlayerAimAssistController | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _staminaController | PlayerStaminaController | Private |
| _pingController | PlayerPingController | Private |
| _dynamikaCharacter | Bossa.Dynamika.Character.DynamikaCharacter | Private |
| _playerCameraRaycast | PlayerCameraRaycast | Protected |
| _tempCustomisationSpawner | TempCustomisationSpawner | Private |
| _playerDeathHandling | PlayerDeathHandling | Protected |
| _playerSync | PlayerSync | Private |
| _playerNetwork | PlayerNetwork | Private |
| _playerHUD | UI.PlayerHUD | Private |
| _playerColliders | WildSkies.Player.PlayerColliders | Private |
| _schematicKnowledgeData | SchematicKnowledgeData | Private |
| _islandAuthority | IslandAuthority | Private |
| _initialLoadCompleted | System.Boolean | Private |
| <IsInsideShipBubble>k__BackingField | System.Boolean | Private |
| _respawnPosition | UnityEngine.Vector3 | Private |
| _respawnRotation | UnityEngine.Quaternion | Private |
| _positionData | PlayerPositionData | Private |
| <DeathLootSpawned>k__BackingField | System.Action`1<PlayerDeathLootController> | Private |
| _saveTimer | System.Single | Private |
| _saveInterval | System.Single | Private |
| _lastSavedPosition | UnityEngine.Vector3 | Private |
| _attackTokenHandler | AttackTokenHandler | Private |
| MinMoveDistanceToSave | System.Single | Private |
| _deathCameraEffect | DeathCameraEffect | Private |
| _sphereCastRadius | System.Single | Private |
| _sphereCastDistance | System.Single | Private |
| _sphereCastOffset | UnityEngine.Vector3 | Private |
| _previousContext | WildSkies.Player.LocalPlayer/ControlContext | Private |
| _currentContext | WildSkies.Player.LocalPlayer/ControlContext | Private |
| _arkSpawnLayout | WildSkies.IslandExport.ArkSpawnLayout | Private |
| _userControl | UserControl | Private |
| _userControlShip | WildSkies.Input.UserControlShip | Private |
| _userControlTurret | WildSkies.Input.UserControlTurret | Private |
| _userControlGenericMount | WildSkies.Input.UserControlGenericMount | Private |
| _entityHealthDamageComponent | WildSkies.Entities.Health.EntityHealthDamageComponent | Private |
| _isPiloting | System.Boolean | Private |
| _loadInHardAttachTarget | UnityEngine.Transform | Private |
| _islandLoadingService | WildSkies.Service.IslandLoadingService | Private |
| _isInShipVolume | System.Boolean | Private |
| _currentShipVolume | WildSkies.Ship.ShipControl | Private |
| AllowIdleSwitching | System.Int32 | Private |
| _pilotingAuthCheckTimer | System.Single | Private |
| <CurrentlyPiloting>k__BackingField | WildSkies.Ship.IPilotable | Private |
| <DamageableComponents>k__BackingField | Entities.Weapons.IDamageable[] | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| BoneSync | BoneAnimationSyncCharacter | Public |
| BaseStats | BaseStats | Public |
| PlayerRoot | UnityEngine.Transform | Public |
| Stamina | WildSkies.Entities.Stamina.EntityStamina | Public |
| PlayerSkillHandler | PlayerSkillHandler | Public |
| CameraSwitch | CameraSwitch | Public |
| EquipmentController | EquipmentController | Public |
| AimAssistController | PlayerAimAssistController | Public |
| CameraManager | Bossa.Cinematika.CameraManager | Public |
| StaminaController | PlayerStaminaController | Public |
| PingController | PlayerPingController | Public |
| DynamikaCharacter | Bossa.Dynamika.Character.DynamikaCharacter | Public |
| PlayerCameraRaycast | PlayerCameraRaycast | Public |
| TempCustomisationSpawner | TempCustomisationSpawner | Public |
| PlayerDeathHandling | PlayerDeathHandling | Public |
| PlayerSync | PlayerSync | Public |
| PlayerNetwork | PlayerNetwork | Public |
| PlayerHUD | UI.PlayerHUD | Public |
| PlayerColliders | WildSkies.Player.PlayerColliders | Public |
| CurrentShipVolume | WildSkies.Ship.ShipControl | Public |
| AttackTokenHandler | AttackTokenHandler | Public |
| SchematicKnowledgeData | WildSkies.Service.ISchematicKnowledgeData | Public |
| IslandAuthority | IslandAuthority | Public |
| InitialLoadCompleted | System.Boolean | Public |
| IsInsideShipBubble | System.Boolean | Public |
| IsInShipVolume | System.Boolean | Public |
| LocalPlayerPosition | UnityEngine.Vector3 | Public |
| UserControlShip | WildSkies.Input.UserControlShip | Public |
| UserControlGenericMount | WildSkies.Input.UserControlGenericMount | Public |
| DeathLootSpawned | System.Action`1<PlayerDeathLootController> | Public |
| CurrentControlContext | WildSkies.Player.LocalPlayer/ControlContext | Public |
| UserControl | UserControl | Public |
| ArkSpawnLayout | WildSkies.IslandExport.ArkSpawnLayout | Public |
| IsPiloting | System.Boolean | Public |
| SpawnLayerCheck | UnityEngine.LayerMask | Private |
| CurrentlyPiloting | WildSkies.Ship.IPilotable | Public |
| DamageableComponents | Entities.Weapons.IDamageable[] | Public |

## Methods

- **get_BoneSync()**: BoneAnimationSyncCharacter (Public)
- **get_BaseStats()**: BaseStats (Public)
- **get_PlayerRoot()**: UnityEngine.Transform (Public)
- **get_Stamina()**: WildSkies.Entities.Stamina.EntityStamina (Public)
- **get_PlayerSkillHandler()**: PlayerSkillHandler (Public)
- **get_CameraSwitch()**: CameraSwitch (Public)
- **get_EquipmentController()**: EquipmentController (Public)
- **get_AimAssistController()**: PlayerAimAssistController (Public)
- **get_CameraManager()**: Bossa.Cinematika.CameraManager (Public)
- **get_StaminaController()**: PlayerStaminaController (Public)
- **get_PingController()**: PlayerPingController (Public)
- **get_DynamikaCharacter()**: Bossa.Dynamika.Character.DynamikaCharacter (Public)
- **get_PlayerCameraRaycast()**: PlayerCameraRaycast (Public)
- **get_TempCustomisationSpawner()**: TempCustomisationSpawner (Public)
- **get_PlayerDeathHandling()**: PlayerDeathHandling (Public)
- **get_PlayerSync()**: PlayerSync (Public)
- **get_PlayerNetwork()**: PlayerNetwork (Public)
- **get_PlayerHUD()**: UI.PlayerHUD (Public)
- **get_PlayerColliders()**: WildSkies.Player.PlayerColliders (Public)
- **get_CurrentShipVolume()**: WildSkies.Ship.ShipControl (Public)
- **get_AttackTokenHandler()**: AttackTokenHandler (Public)
- **get_SchematicKnowledgeData()**: WildSkies.Service.ISchematicKnowledgeData (Public)
- **get_IslandAuthority()**: IslandAuthority (Public)
- **get_InitialLoadCompleted()**: System.Boolean (Public)
- **get_IsInsideShipBubble()**: System.Boolean (Public)
- **set_IsInsideShipBubble(System.Boolean value)**: System.Void (Public)
- **get_IsInShipVolume()**: System.Boolean (Public)
- **get_LocalPlayerPosition()**: UnityEngine.Vector3 (Public)
- **get_UserControlShip()**: WildSkies.Input.UserControlShip (Public)
- **get_UserControlGenericMount()**: WildSkies.Input.UserControlGenericMount (Public)
- **get_DeathLootSpawned()**: System.Action`1<PlayerDeathLootController> (Public)
- **set_DeathLootSpawned(System.Action`1<PlayerDeathLootController> value)**: System.Void (Public)
- **Awake()**: System.Void (Protected)
- **Start()**: System.Void (Private)
- **OnDestroy()**: System.Void (Private)
- **get_CurrentControlContext()**: WildSkies.Player.LocalPlayer/ControlContext (Public)
- **set_UserControl(UserControl value)**: System.Void (Public)
- **get_ArkSpawnLayout()**: WildSkies.IslandExport.ArkSpawnLayout (Public)
- **get_IsPiloting()**: System.Boolean (Public)
- **SetPlayerPosition()**: System.Void (Public)
- **ForceCameraToFaceArkDoor()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **SavePlayerPosition()**: System.Void (Private)
- **LoadPlayerPosition()**: System.Threading.Tasks.Task`1<System.Boolean> (Private)
- **get_SpawnLayerCheck()**: UnityEngine.LayerMask (Private)
- **TakeControlOfShip(WildSkies.ShipParts.Helm helm)**: System.Void (Public)
- **PilotTurret(WildSkies.ShipParts.ShipWeapon turret, System.Boolean isRemotePiloting)**: System.Void (Public)
- **PilotMount(WildSkies.ShipParts.GenericMount mount)**: System.Void (Public)
- **SyncIk(WildSkies.Ship.IPilotable pilotable)**: System.Void (Private)
- **DropInteraction()**: System.Void (Public)
- **SwitchControlContext(WildSkies.Player.LocalPlayer/ControlContext context)**: System.Void (Public)
- **get_CurrentlyPiloting()**: WildSkies.Ship.IPilotable (Public)
- **set_CurrentlyPiloting(WildSkies.Ship.IPilotable value)**: System.Void (Public)
- **get_DamageableComponents()**: Entities.Weapons.IDamageable[] (Public)
- **set_DamageableComponents(Entities.Weapons.IDamageable[] value)**: System.Void (Public)
- **SetRespawnPosition(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)**: System.Void (Public)
- **Respawn()**: System.Void (Public)
- **SetCharacter(Bossa.Dynamika.Character.DynamikaCharacter character)**: System.Void (Public)
- **Debug_TogglePlayerHud()**: System.Void (Public)
- **Debug_ShowPlayerHud()**: System.Void (Public)
- **Debug_HidePlayerHud()**: System.Void (Public)
- **MovePlayer(UnityEngine.Vector3 position)**: System.Void (Public)
- **OnEnterShipVolume(WildSkies.Ship.ShipControl ship)**: System.Void (Public)
- **OnExitShipVolume()**: System.Void (Public)
- **OnLocalPlayerEnteredWindwall()**: System.Void (Private)
- **OnLocalPlayerExitedWindwall()**: System.Void (Private)
- **OnEntityDeath()**: System.Void (Private)
- **OnEntityRevive()**: System.Void (Private)
- **OnDeathLootSpawned(UnityEngine.GameObject go)**: System.Void (Private)
- **RegisterDeathLoot(PlayerDeathLootController deathLoot)**: System.Void (Public)
- **CheckDeathLoots()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)
- **<SetPlayerPosition>b__143_0()**: System.Boolean (Private)
- **<SetPlayerPosition>b__143_1()**: System.Boolean (Private)
- **<CheckDeathLoots>b__179_0()**: System.Boolean (Private)

