# WildSkies.Profiling.RuntimeProfiler

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _UI | UnityEngine.GameObject | Private |
| _labelFPS | TMPro.TextMeshProUGUI | Private |
| _labelQuality | TMPro.TextMeshProUGUI | Private |
| _labelGPU | TMPro.TextMeshProUGUI | Private |
| _labelCustomProfilers1 | TMPro.TextMeshProUGUI | Private |
| _labelCustomProfilers2 | TMPro.TextMeshProUGUI | Private |
| _labelBatches | TMPro.TextMeshProUGUI | Private |
| _labelDrawCalls | TMPro.TextMeshProUGUI | Private |
| _labelVertCount | TMPro.TextMeshProUGUI | Private |
| _labelTriCount | TMPro.TextMeshProUGUI | Private |
| _labelMemUsed | TMPro.TextMeshProUGUI | Private |
| _labelMemPeak | TMPro.TextMeshProUGUI | Private |
| _labelMemLimit | TMPro.TextMeshProUGUI | Private |
| _labelPlatformSpecs | TMPro.TextMeshProUGUI | Private |
| isVisible | System.Boolean | Private |
| frameSampleRate | System.Single | Private |
| <SmoothCpuFrameRate>k__BackingField | System.Single | Private |
| <SmoothGpuFrameRate>k__BackingField | System.Single | Private |
| ProfilerGroups | WildSkies.Profiling.ProfilerGroup[] | Private |
| qualityLevelStrings | System.String[] | Private |
| cpuFrameRateText | System.String | Private |
| qualityLevelText | System.String | Private |
| gpuFrameRateText | System.String | Private |
| usedMemoryText | System.String | Private |
| peakMemoryText | System.String | Private |
| limitMemoryText | System.String | Private |
| memoryUsage | System.UInt64 | Private |
| peakMemoryUsage | System.UInt64 | Private |
| limitMemoryUsage | System.UInt64 | Private |
| peakMemoryUsageDirty | System.Boolean | Private |
| frameCount | System.Int32 | Private |
| accumulatedFrameTimeCPU | System.Single | Private |
| accumulatedFrameTimeGPU | System.Single | Private |
| frameSampleRateMS | System.Single | Private |
| frameTimings | UnityEngine.FrameTiming[] | Private |
| batchesRecorder | Unity.Profiling.ProfilerRecorder | Private |
| drawCallsRecorder | Unity.Profiling.ProfilerRecorder | Private |
| vertStatsRecorder | Unity.Profiling.ProfilerRecorder | Private |
| triStatsRecorder | Unity.Profiling.ProfilerRecorder | Private |
| activeProfilerGroups | System.Collections.Generic.List`1<WildSkies.Profiling.ProfilerGroup> | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| IsVisible | System.Boolean | Public |
| FrameSampleRate | System.Single | Public |
| SmoothCpuFrameRate | System.Single | Public |
| SmoothGpuFrameRate | System.Single | Public |
| AppMemoryUsage | System.UInt64 | Private |
| AppMemoryUsageLimit | System.UInt64 | Private |

## Methods

- **get_IsVisible()**: System.Boolean (Public)
- **set_IsVisible(System.Boolean value)**: System.Void (Public)
- **get_FrameSampleRate()**: System.Single (Public)
- **set_FrameSampleRate(System.Single value)**: System.Void (Public)
- **get_SmoothCpuFrameRate()**: System.Single (Public)
- **set_SmoothCpuFrameRate(System.Single value)**: System.Void (Private)
- **get_SmoothGpuFrameRate()**: System.Single (Public)
- **set_SmoothGpuFrameRate(System.Single value)**: System.Void (Private)
- **Refresh()**: System.Void (Public)
- **OnEnable()**: System.Void (Private)
- **OnDisable()**: System.Void (Private)
- **OnValidate()**: System.Void (Private)
- **LateUpdate()**: System.Void (Private)
- **BuildWindow()**: System.Void (Private)
- **GetFrameRateString(System.Int32 curFPS)**: System.String (Private)
- **GetGPUTimeString(System.Int32 curFPS)**: System.String (Private)
- **MemoryUsageToString(System.UInt64 memoryUsage)**: System.String (Private)
- **SceneStatsToString(System.Int64 drawCalls)**: System.String (Private)
- **MeshStatsToString(System.Int64 count)**: System.String (Private)
- **MillisecondsToString(System.Single milliseconds)**: System.String (Private)
- **get_AppMemoryUsage()**: System.UInt64 (Private)
- **get_AppMemoryUsageLimit()**: System.UInt64 (Private)
- **ConvertMegabytesToBytes(System.Int32 megabytes)**: System.UInt64 (Private)
- **ConvertBytesToMegabytes(System.UInt64 bytes)**: System.Single (Private)
- **ConvertMegabytesToGigabytes(System.Single megabytes)**: System.Single (Private)
- **.ctor()**: System.Void (Public)

