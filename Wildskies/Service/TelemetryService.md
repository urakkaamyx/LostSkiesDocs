# WildSkies.Service.TelemetryService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| FPS_UPDATE | System.Single | Private |
| _telemetry | Telemetry.Service | Private |
| _lastFpsUpdate | System.Single | Private |
| _frameCount | System.Int32 | Private |
| _fireEventsInEditor | System.Boolean | Private |
| _runID | System.String | Private |
| _partyID | System.String | Private |
| _subPartyID | System.String | Private |
| _islandID | System.String | Private |
| _localPlayerTransform | UnityEngine.Transform | Private |
| _update | System.Single | Private |
| _fpsAccumulator | System.Single | Private |
| _fpsMin | System.Single | Private |
| _fpsMax | System.Single | Private |
| _fpsCount | System.Int32 | Private |
| _memAccumulator | System.Single | Private |
| _memMin | System.Single | Private |
| _memMax | System.Single | Private |
| _memCount | System.Int32 | Private |
| _netAccumulator | System.Single | Private |
| _netMin | System.Single | Private |
| _netMax | System.Single | Private |
| _netCount | System.Int32 | Private |
| _worldLoadingService | WildSkies.Service.WorldLoadingService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **UpdateLocalPlayerTransform(UnityEngine.Transform playerTransform)**: System.Void (Public)
- **UpdateRunId(System.String runId)**: System.Void (Public)
- **SetSessionParameters(System.String runId, System.String partyId, System.String subPartyID)**: System.Void (Public)
- **UpdateIslandID(System.String islandID)**: System.Void (Public)
- **UpdatePartyID(System.String partyID)**: System.Void (Public)
- **UpdateUserRole(System.String role)**: System.Void (Public)
- **AddEvent(TPayload payload)**: System.Void (Private)
- **GameStarted(System.String storePlatform)**: Cysharp.Threading.Tasks.UniTask (Public)
- **GameEnded()**: System.Void (Public)
- **RunStarted()**: System.Void (Public)
- **RunEnded()**: System.Void (Public)
- **PartyStart(System.String partyId, System.String subPartyId)**: System.Void (Public)
- **PartyJoin(System.String subpartyId)**: System.Void (Public)
- **PartyLeave(System.String subpartyId)**: System.Void (Public)
- **FramerateUpdate(System.Single avgFPS, System.Single maxFPS, System.Single minFPS, System.Single avgMemUse, System.Single maxMemUse, System.Single minMemUse, System.Single avgNetRefresh, System.Single maxNetRefresh, System.Single minNetRefresh)**: System.Void (Public)
- **GraphicOptionChanged(System.String option, System.String value)**: System.Void (Public)
- **LanguageSet(System.String language, System.Boolean setFromSettingsMenu)**: System.Void (Public)
- **ShellFinishedLoading()**: System.Void (Public)
- **StartSceneLoad(System.String sceneToLoad)**: System.Void (Public)
- **GamePhaseStart(System.String phaseID, System.String phase, System.String phaseInteractionID)**: System.Void (Public)
- **GamePhaseEnd(System.String phaseID, System.String phase, System.String phaseInteractionID)**: System.Void (Public)
- **OutOfStamina()**: System.Void (Public)
- **BarrierEntry(System.String shipID, System.String barrierID, System.String barrierUID, System.String barrierInteractionID)**: System.Void (Public)
- **BarrierExit(System.String shipID, System.String barrierID, System.String barrierUID, System.String barrierInteractionID, System.String barrierCompletion)**: System.Void (Public)
- **GetPlayerPosition()**: UnityEngine.Vector3 (Private)
- **Update()**: System.Void (Public)
- **BossSpawn(System.String bossID, System.String bossType, System.String bossName, System.Single enemyHealth, UnityEngine.Vector3 position)**: System.Void (Public)
- **BossPieceSpawn(System.String bossID, System.String bossType, System.String bossName, System.String bossPieceType, System.Single bossPieceHealth, UnityEngine.Vector3 position)**: System.Void (Public)
- **BossPieceDamage(System.String bossID, System.String bossType, System.String bossName, System.String bossPieceType, System.Single bossPieceHealth)**: System.Void (Public)
- **BossPieceDeath(System.String bossID, System.String bossType, System.String bossName, System.String bossPieceType)**: System.Void (Public)
- **BossDeath(System.String bossID, System.String bossType, System.String bossName)**: System.Void (Public)
- **BuildingBuilt(System.String phaseID, System.String buildingID, System.String buildingName, System.String resourceType, System.String resourceName, System.String resourceAmount, UnityEngine.Vector3 buildPosition)**: System.Void (Public)
- **BuildingRemoved(System.String phaseID, System.String buildingID, System.String buildingName, System.String resourceType, System.String resourceName, System.String resourceAmount, UnityEngine.Vector3 buildPosition)**: System.Void (Public)
- **BuildingUsed(System.String phaseID, System.String buildingID, System.String buildingName, UnityEngine.Vector3 buildPosition)**: System.Void (Public)
- **SchematicUnlocked(System.String schematicID, System.String schematicUID)**: System.Void (Public)
- **EntitySpawn(System.String entityID, System.String entityUID, System.Single entityHealth, UnityEngine.Vector3 position)**: System.Void (Public)
- **EntityDamage(System.String entityID, System.String entityUID, System.Single entityHealth, UnityEngine.Vector3 entityPosition)**: System.Void (Public)
- **EntityDeath(System.String entityID, System.String entityUID, System.Single entityHealth, UnityEngine.Vector3 entityPosition)**: System.Void (Public)
- **EntityTrigger(System.String entityID, System.String entityUID, System.Single entityHealth, UnityEngine.Vector3 entityPosition)**: System.Void (Public)
- **EntityDetrigger(System.String entityID, System.String entityUID, System.Single entityHealth, UnityEngine.Vector3 entityPosition)**: System.Void (Public)
- **ItemEquipped(System.String itemID, System.String itemUID)**: System.Void (Public)
- **ItemCrafted(System.String itemID, System.String itemUID, System.Int32 itemAmount, System.String itemInteractionID)**: System.Void (Public)
- **ItemSpend(System.String itemID, System.String itemUID, System.Int32 itemAmount, System.String itemInteractionID)**: System.Void (Public)
- **ItemCollect(System.String itemID, System.String itemUID, System.Int32 itemAmount)**: System.Void (Public)
- **ItemDrop(System.String itemID, System.String itemUID, System.Int32 itemAmount)**: System.Void (Public)
- **PlayerSpawn(System.Int32 playerLife, System.Single playerHealth)**: System.Void (Public)
- **PlayerDamage(System.String entityID, System.Int32 entityInteractionID, System.Single playerHealth, UnityEngine.Vector3 entityPosition)**: System.Void (Public)
- **PlayerDeath(System.String entityID, System.String entityInteractionID, UnityEngine.Vector3 entityPosition)**: System.Void (Public)
- **PlayerPing(UnityEngine.Vector3 pingPosition)**: System.Void (Public)
- **ObjectiveStart(System.String objectiveID, System.String parentObjectiveID)**: System.Void (Public)
- **ObjectiveEnd(System.String objectiveID, System.String parentObjectiveID)**: System.Void (Public)
- **PuzzleStart(System.String puzzleID, System.String puzzlePiece, System.String puzzleInteractionID, System.String puzzleUID)**: System.Void (Public)
- **PuzzleProgress(System.String puzzleID, System.String puzzlePiece, System.String puzzleInteractionID, System.String puzzleUID)**: System.Void (Public)
- **PuzzleComplete(System.String puzzleID, System.String puzzlePiece, System.String puzzleInteractionID, System.String puzzleUID)**: System.Void (Public)
- **PuzzleStopped(System.String puzzleID, System.String puzzleUID, System.String puzzlePiece, System.String puzzleInteractionID, System.Boolean menuEnd)**: System.Void (Public)
- **ShipPiecePlace(System.String shipID, System.String shipPieceID, System.String shipPieceType, System.Single resourceAmount, System.String shipInteractionID, System.String shipPieceName)**: System.Void (Public)
- **ShipPieceRemove(System.String shipID, System.String shipPieceID, System.String shipPieceType, System.Single resourceAmount, System.String shipInteractionID, System.String shipPieceName)**: System.Void (Public)
- **ShipPublish(System.String shipID, System.String shipInteractionID, System.String shipTemplate)**: System.Void (Public)
- **MenuButton(System.String menu, System.String buttonPressed)**: System.Void (Public)
- **EnteredMenu(System.String subMenu)**: System.Void (Public)
- **ExitedMenu(System.String subMenu)**: System.Void (Public)
- **MainMenuLoaded()**: System.Void (Public)
- **.ctor()**: System.Void (Public)

