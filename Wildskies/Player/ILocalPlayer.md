# WildSkies.Player.ILocalPlayer

**Type**: Interface

## Properties

| Name | Type | Access |
|------|------|--------|
| Health | WildSkies.Entities.Health.EntityHealth | Public |
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
| PlayerHUD | UI.PlayerHUD | Public |
| PlayerSync | PlayerSync | Public |
| PlayerNetwork | PlayerNetwork | Public |
| SchematicKnowledgeData | WildSkies.Service.ISchematicKnowledgeData | Public |
| UserControl | UserControl | Public |
| AttackTokenHandler | AttackTokenHandler | Public |
| IslandAuthority | IslandAuthority | Public |
| Buffs | WildSkies.BuffSystem.EntityBuffs | Public |
| BuffReceiver | WildSkies.BuffSystem.ExternalBuffsReceiver | Public |
| InitialLoadCompleted | System.Boolean | Public |
| IsInsideShipBubble | System.Boolean | Public |
| IsInShipVolume | System.Boolean | Public |
| CurrentShipVolume | WildSkies.Ship.ShipControl | Public |
| LocalPlayerPosition | UnityEngine.Vector3 | Public |
| CurrentControlContext | WildSkies.Player.LocalPlayer/ControlContext | Public |
| DeathLootSpawned | System.Action`1<PlayerDeathLootController> | Public |
| CurrentlyPiloting | WildSkies.Ship.IPilotable | Public |
| DamageableComponents | Entities.Weapons.IDamageable[] | Public |

## Methods

- **get_Health()**: WildSkies.Entities.Health.EntityHealth (Public)
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
- **get_PlayerHUD()**: UI.PlayerHUD (Public)
- **get_PlayerSync()**: PlayerSync (Public)
- **get_PlayerNetwork()**: PlayerNetwork (Public)
- **get_SchematicKnowledgeData()**: WildSkies.Service.ISchematicKnowledgeData (Public)
- **set_UserControl(UserControl value)**: System.Void (Public)
- **get_AttackTokenHandler()**: AttackTokenHandler (Public)
- **get_IslandAuthority()**: IslandAuthority (Public)
- **get_Buffs()**: WildSkies.BuffSystem.EntityBuffs (Public)
- **get_BuffReceiver()**: WildSkies.BuffSystem.ExternalBuffsReceiver (Public)
- **get_InitialLoadCompleted()**: System.Boolean (Public)
- **get_IsInsideShipBubble()**: System.Boolean (Public)
- **set_IsInsideShipBubble(System.Boolean value)**: System.Void (Public)
- **get_IsInShipVolume()**: System.Boolean (Public)
- **get_CurrentShipVolume()**: WildSkies.Ship.ShipControl (Public)
- **get_LocalPlayerPosition()**: UnityEngine.Vector3 (Public)
- **get_CurrentControlContext()**: WildSkies.Player.LocalPlayer/ControlContext (Public)
- **get_DeathLootSpawned()**: System.Action`1<PlayerDeathLootController> (Public)
- **set_DeathLootSpawned(System.Action`1<PlayerDeathLootController> value)**: System.Void (Public)
- **SetPlayerPosition()**: System.Void (Public)
- **TakeControlOfShip(WildSkies.ShipParts.Helm helm)**: System.Void (Public)
- **PilotTurret(WildSkies.ShipParts.ShipWeapon turret, System.Boolean isRemotePiloting)**: System.Void (Public)
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
- **RegisterDeathLoot(PlayerDeathLootController deathLoot)**: System.Void (Public)

