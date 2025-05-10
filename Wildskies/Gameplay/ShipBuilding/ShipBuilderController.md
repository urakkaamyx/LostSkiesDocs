# WildSkies.Gameplay.ShipBuilding.ShipBuilderController

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _uiService | UISystem.IUIService | Private |
| _inputService | WildSkies.Service.InputService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _cameraManager | Bossa.Cinematika.CameraManager | Private |
| _persistenceService | WildSkies.Service.IPersistenceService | Private |
| _shipsService | WildSkies.Service.ShipsService | Private |
| _largeMessageService | WildSkies.Service.LargeMessageService | Private |
| _vfxPoolService | WildSkies.Service.VfxPoolService | Private |
| _buildingService | WildSkies.Service.BuildingService | Private |
| _sessionService | WildSkies.Service.SessionService | Private |
| _shipSpawnPositionOffset | UnityEngine.Vector3 | Private |
| _drone | WildSkies.Gameplay.ShipBuilding.Drone | Private |
| _objectsToRotateToShip | UnityEngine.GameObject[] | Private |
| _constructedShipPrefab | UnityEngine.GameObject | Private |
| _interaction | WildSkies.Gameplay.ShipBuilding.ShipyardInteraction | Private |
| _shipyardBubble | ShipyardDomeExpansion | Private |
| _shipForwardGizmo | UnityEngine.GameObject | Private |
| _emptyShipyardFocus | UnityEngine.Transform | Private |
| _shipyardDroneRepresentationPrefab | Coherence.Toolkit.CoherenceSyncConfig | Private |
| _droneSpawnPosition | UnityEngine.Transform | Private |
| _droneSpawnPositionNewShip | UnityEngine.Transform | Private |
| _droneBoundaryOffset | System.Single | Private |
| _lootSpawnPosition | UnityEngine.Transform | Private |
| _mirrorHelper | WildSkies.Gameplay.ShipBuilding.MirrorHelper | Private |
| _constructedShip | UnityEngine.GameObject | Private |
| _constructedShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _shipwreck | Shipwreck | Private |
| _currentShipSnapshotSaveData | ShipSnapshotSaveData | Private |
| _shipToBeRecovered | WildSkies.Gameplay.ShipBuilding.ShipHull | Private |
| _shipyardModeActive | System.Boolean | Private |
| _shipyardControlsActive | System.Boolean | Private |
| _droneModeActive | System.Boolean | Private |
| blueprintSelected | System.Boolean | Public |
| ShipYardActivated | System.Action`1<System.Boolean> | Public |
| ShipDockedToShipyard | System.Action`1<WildSkies.Gameplay.ShipBuilding.ConstructedShipController> | Public |
| _coherenceSync | Coherence.Toolkit.CoherenceSync | Private |
| DockedShipCoherenceId | System.String | Public |
| DockedShipwreckCoherenceId | System.String | Public |
| _shipyardDrone | ShipyardDroneControl | Private |
| _localPlayer | WildSkies.Player.LocalPlayer | Private |
| _lastShipCheckTimer | System.Single | Private |
| _lastShipwreckCheckTimer | System.Single | Private |
| _nearestShip | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Private |
| _nearestShipwreck | Shipwreck | Private |
| _recoveredShipName | System.String | Private |
| _recoveredShipId | System.String | Private |
| _shipCheckDelay | System.Single | Private |
| _autoDockingDistance | System.Single | Private |
| _dockingFinalLerpSpeed | System.Single | Private |
| _maxDistanceToPull | System.Single | Private |
| _maxDistanceToDock | System.Single | Private |
| _maxSpeedForDocking | System.Single | Private |
| _delayBeforeRedockAllowed | System.Single | Private |
| _scaffoldParent | UnityEngine.Transform | Private |
| _scaffoldPrefab | _game.code.gameplay.shipyard.ShipScaffoldDeck | Private |
| _scaffoldJumpForce | System.Single | Public |
| _scaffoldDropVfxPrefab | UnityEngine.GameObject | Public |
| _scaffoldJumpVfxPrefab | UnityEngine.GameObject | Public |
| _dropEffectDuration | System.Single | Public |
| _dropHoldToTriggerDuration | System.Single | Public |
| _shipScaffolding | _game.code.gameplay.shipyard.ShipScaffolding | Private |
| _redockTimer | System.Single | Private |
| _shipwreckRedockTimer | System.Single | Private |
| _shipyardLevelsData | WildSkies.Gameplay.Crafting.ShipyardLevels | Private |
| _shipyardLevel | System.Int32 | Public |
| _maxSections | System.Int32 | Public |
| _shipyardBubbleRadius | System.Single | Public |
| _beamLengthCraftingScale | System.Single | Private |
| _panelBuildableItemId | System.String | Private |
| ShipSnapshotRequestDelay | System.Single | Private |
| ShipRemovedCheckDelay | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| ShipDocked | System.Boolean | Public |
| ShipwreckDocked | System.Boolean | Public |
| IsDockingInProgress | System.Boolean | Public |
| ConstructedShipController | WildSkies.Gameplay.ShipBuilding.ConstructedShipController | Public |
| ShipFrameBuilder | WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder | Public |
| Shipwreck | Shipwreck | Public |
| CurrentShipSnapshotSaveData | ShipSnapshotSaveData | Public |
| ShipToBeRecovered | WildSkies.Gameplay.ShipBuilding.ShipHull | Public |
| LootSpawnPosition | UnityEngine.Transform | Public |
| ShipDockingPosition | UnityEngine.Vector3 | Public |
| Interaction | WildSkies.Gameplay.ShipBuilding.ShipyardInteraction | Public |
| ShipyardBubble | ShipyardDomeExpansion | Public |
| ShipyardModeActive | System.Boolean | Public |
| ShipyardControlsActive | System.Boolean | Public |
| DroneModeActive | System.Boolean | Public |
| BlueprintSelected | System.Boolean | Public |
| CoherenceSync | Coherence.Toolkit.CoherenceSync | Public |
| ShipScaffolding | _game.code.gameplay.shipyard.ShipScaffolding | Public |
| ShipyardLevel | System.Int32 | Public |
| MaxSections | System.Int32 | Public |
| ShipyardBubbleRadius | System.Single | Public |
| ScaffoldParent | UnityEngine.Transform | Public |

## Methods

- **get_ShipDocked()**: System.Boolean (Public)
- **get_ShipwreckDocked()**: System.Boolean (Public)
- **get_IsDockingInProgress()**: System.Boolean (Public)
- **get_ConstructedShipController()**: WildSkies.Gameplay.ShipBuilding.ConstructedShipController (Public)
- **get_ShipFrameBuilder()**: WildSkies.Gameplay.ShipBuilding.ShipFrameBuilder (Public)
- **get_Shipwreck()**: Shipwreck (Public)
- **get_CurrentShipSnapshotSaveData()**: ShipSnapshotSaveData (Public)
- **get_ShipToBeRecovered()**: WildSkies.Gameplay.ShipBuilding.ShipHull (Public)
- **get_LootSpawnPosition()**: UnityEngine.Transform (Public)
- **get_ShipDockingPosition()**: UnityEngine.Vector3 (Public)
- **get_Interaction()**: WildSkies.Gameplay.ShipBuilding.ShipyardInteraction (Public)
- **get_ShipyardBubble()**: ShipyardDomeExpansion (Public)
- **get_ShipyardModeActive()**: System.Boolean (Public)
- **get_ShipyardControlsActive()**: System.Boolean (Public)
- **get_DroneModeActive()**: System.Boolean (Public)
- **get_BlueprintSelected()**: System.Boolean (Public)
- **get_CoherenceSync()**: Coherence.Toolkit.CoherenceSync (Public)
- **get_ShipScaffolding()**: _game.code.gameplay.shipyard.ShipScaffolding (Public)
- **get_ShipyardLevel()**: System.Int32 (Public)
- **get_MaxSections()**: System.Int32 (Public)
- **get_ShipyardBubbleRadius()**: System.Single (Public)
- **SetBuildingParameters(System.Int32 level, System.Int32 maxSections, System.Single radius)**: System.Void (Public)
- **SetShipyardLevel(System.Int32 level)**: System.Void (Public)
- **get_ScaffoldParent()**: UnityEngine.Transform (Public)
- **SyncShipCoherenceId(System.String oldValue, System.String newValue)**: System.Void (Public)
- **CheckAndResetShip()**: System.Void (Private)
- **SyncShipwreckCoherenceId(System.String oldValue, System.String newValue)**: System.Void (Public)
- **CanEdit()**: System.Boolean (Public)
- **Start()**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **Update()**: System.Void (Private)
- **FixedUpdate()**: System.Void (Private)
- **CheckForShips()**: System.Void (Private)
- **UpdateDocking()**: System.Void (Private)
- **CheckForShipwrecks()**: System.Void (Private)
- **UpdateShipwreckDocking()**: System.Void (Private)
- **UpdateDroneRepresentation()**: System.Void (Private)
- **Initialise(System.Boolean shouldSpawnShip)**: System.Void (Public)
- **InitNewShip(System.Boolean createInitialBlock, System.Int32 saveSlot, System.Boolean isDesignSave, System.String hullData, System.Byte[] hullDataBytes)**: System.Void (Public)
- **SetDockedShip(WildSkies.Gameplay.ShipBuilding.ConstructedShipController constructedShip)**: System.Void (Public)
- **SetDockedShipwreck(Shipwreck shipwreck)**: System.Void (Public)
- **SendShipSnapshotData()**: System.Void (Private)
- **RequestShipSnapshotData()**: System.Void (Private)
- **HostSendShipSnapshotData()**: System.Void (Public)
- **OnLargeMessageReceived(WildSkies.Service.LargeMessageType messageType, System.Byte[] messageContents)**: System.Void (Private)
- **ReconstructShip()**: System.Void (Public)
- **HostRemoveShipHealthData(System.String shipId)**: System.Void (Public)
- **SetShipNameAfterReconstruct()**: System.Void (Private)
- **NetworkedSendShipRef()**: System.Void (Public)
- **SendShipRefAsync()**: Cysharp.Threading.Tasks.UniTask (Private)
- **ReceiveShipRef(UnityEngine.GameObject constructedShip)**: System.Void (Public)
- **TryDestroyShip(System.Boolean ignoreSolidBlocks)**: System.Void (Public)
- **DestroyShip()**: System.Void (Public)
- **TryDestroyShipwreck()**: System.Void (Public)
- **DestroyShipwreck()**: System.Void (Public)
- **ResetShipwreckReferences()**: System.Void (Private)
- **ResetShipReferences()**: System.Void (Private)
- **LaunchShip()**: System.Void (Public)
- **OwnerLaunchShip()**: System.Void (Public)
- **AuthorityResetShipwreck()**: System.Void (Public)
- **GetCurrentCraftingComponentsCost()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> (Public)
- **GetCurrentBuiltShipCost()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> (Public)
- **GetTotalComponentsCost()**: System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> (Public)
- **GetTotalSectionsUsed()**: System.Int32 (Public)
- **GetCraftingComponentsCost(WildSkies.Service.BuildingService buildingService, System.Single beamLength, System.Int32 panelCount)**: System.Collections.Generic.List`1<WildSkies.Gameplay.Crafting.CraftingComponent> (Public)
- **GetTemplatePanelCost(WildSkies.Service.BuildingService buildingService)**: System.Int32 (Public)
- **EnterDroneMode(System.Boolean newShipPosition)**: System.Void (Public)
- **SpawnDrone()**: System.Void (Private)
- **ExitDroneMode()**: System.Void (Public)
- **SwitchToShipView()**: System.Void (Public)
- **LoadShip(System.String designName, System.Int32 saveSlot)**: System.Void (Public)
- **CraftShip()**: System.Void (Public)
- **DeleteShipDesignAtIndex(System.Int32 targetIndex)**: System.Void (Public)
- **EnterShipOverviewMode()**: System.Void (Public)
- **ExitShipBuilding(System.Boolean stopInteracting)**: System.Void (Public)
- **SetShipEditingModeActive(System.Boolean isActive)**: System.Void (Private)
- **SetDefaultUIActive(System.Boolean isActive, WildSkies.Gameplay.ShipBuilding.MirrorHelper mirrorHelper, Wildskies.UI.Hud.ShipyardBuildInputHudPayload payload)**: System.Void (Private)
- **SetBlueprintSelected(System.Boolean selected)**: System.Void (Public)
- **UpdateShipHull(System.String hullData)**: System.Void (Public)
- **UpdateShipHull(System.Byte[] hullData)**: System.Void (Public)
- **.ctor()**: System.Void (Public)
- **.cctor()**: System.Void (Private)
- **<Start>b__121_0()**: System.Boolean (Private)
- **<SetShipNameAfterReconstruct>b__140_0()**: System.Boolean (Private)

