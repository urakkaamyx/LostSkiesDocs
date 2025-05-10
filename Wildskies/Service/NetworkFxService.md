# WildSkies.Service.NetworkFxService

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _vfxPoolService | WildSkies.Service.VfxPoolService | Private |
| _audioService | WildSkies.Service.AudioService | Private |
| _projectileService | WildSkies.Service.ProjectileService | Private |
| _networkVfxPlayer | WildSkies.NetworkVfxPlayer | Private |
| _networkAudioPlayer | WildSkies.Audio.NetworkAudioPlayer | Private |
| _networkProjectilePlayer | WildSkies.NetworkProjectilePlayer | Private |
| _servicesSet | System.Boolean | Private |
| MaxDistanceToPlayNetworkedEffects | System.Int32 | Public |

## Properties

| Name | Type | Access |
|------|------|--------|
| Vfx | WildSkies.Service.NetworkFxInterfaces/IVfx | Public |
| Audio | WildSkies.Service.NetworkFxInterfaces/IAudio | Public |
| Projectile | WildSkies.Service.NetworkFxInterfaces/IProjectile | Public |
| ServiceErrorCode | System.Int32 | Public |
| CanGameRunIfServiceFailed | System.Boolean | Public |

## Methods

- **get_Vfx()**: WildSkies.Service.NetworkFxInterfaces/IVfx (Public)
- **get_Audio()**: WildSkies.Service.NetworkFxInterfaces/IAudio (Public)
- **get_Projectile()**: WildSkies.Service.NetworkFxInterfaces/IProjectile (Public)
- **get_ServiceErrorCode()**: System.Int32 (Public)
- **get_CanGameRunIfServiceFailed()**: System.Boolean (Public)
- **Initialise()**: System.Int32 (Public)
- **Terminate()**: System.Void (Public)
- **SetServices(WildSkies.Service.VfxPoolService vfxPoolService, WildSkies.Service.AudioService audioService, WildSkies.Service.ProjectileService projectileService)**: System.Void (Public)
- **SetNetworkVfxPlayer(WildSkies.NetworkVfxPlayer networkVfx)**: System.Void (Public)
- **SetNetworkAudioPlayer(WildSkies.Audio.NetworkAudioPlayer networkAudio)**: System.Void (Public)
- **SetNetworkProjectilePlayer(WildSkies.NetworkProjectilePlayer networkProjectile)**: System.Void (Public)
- **DestroyPlayers()**: System.Void (Public)
- **WildSkies.Service.NetworkFxInterfaces.IVfx.GetVfx(WildSkies.VfxType vfxType, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, System.Boolean sync, UnityEngine.Vector3 initialVelocity, System.Int32 seed, WildSkies.VfxSize vfxSize)**: WildSkies.PoolableVfx (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.PlayOneShot(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position, System.Boolean sync)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.PlayOneShotWithParameters(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position, System.Boolean sync, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.PlayOneShotWithParameters(WildSkies.Audio.AudioType audioType, UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, UnityEngine.Transform entityTransform, System.Boolean sync, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.StartEvent(WildSkies.Audio.AudioType audioType, System.Int32 eventId, System.Boolean sync)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.StopEvent(WildSkies.Audio.AudioType audioType, System.Int32 eventId, FMOD.Studio.STOP_MODE stopMode, System.Boolean sync)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.IsEventPlaying(WildSkies.Audio.AudioType audioType, System.Int32 eventId)**: System.Boolean (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.UpdateEventParameters(WildSkies.Audio.AudioType audioType, System.Int32 eventId, UnityEngine.Vector3 position, UnityEngine.Vector3 velocity, UnityEngine.Transform entityTransform, System.Boolean sync, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.GetUniqueEventID(WildSkies.Audio.AudioType audioType, System.Int32& generatedId)**: System.Boolean (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.UpdateEventParameters(WildSkies.Audio.AudioType audioType, System.Int32 eventId, UnityEngine.Vector3 position, System.Boolean sync, System.ValueTuple`2<System.String,System.Single>[] parameters)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IAudio.PlayImpactAudio(WildSkies.VfxType responseVfxType, WildSkies.IslandExport.SurfaceType responseSurfaceType, UnityEngine.Vector3 responseWorldPoint)**: System.Void (Private)
- **WildSkies.Service.NetworkFxInterfaces.IProjectile.InitProjectile(WildSkies.Service.ProjectileType projectileType, WildSkies.Service.ProjectileService/ProjectileData data, System.Action`1<UnityEngine.RaycastHit> onHit, System.Boolean sync, System.Int32 syncId)**: System.Void (Private)
- **.ctor()**: System.Void (Public)

