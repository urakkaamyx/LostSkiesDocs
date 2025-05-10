# Wildskies.UI.Hud.StaminaBarHud

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| _viewModel | Wildskies.UI.Hud.StaminaBarHudViewModel | Private |
| _minBarWidth | System.Single | Private |
| _maxBarWidth | System.Single | Private |
| _barHeight | System.Single | Private |
| _maxDisplayedStamina | System.Single | Private |
| _fadeInDuration | System.Single | Private |
| _fadeOutDuration | System.Single | Private |
| _timeToStartFadeOut | System.Single | Private |
| _fillLerpDuration | System.Single | Private |
| _lazyBarFillLerpDuration | System.Single | Private |
| _fillCurve | UnityEngine.AnimationCurve | Private |
| _baseAmountColour | UnityEngine.Color | Private |
| _buffedAmountColour | UnityEngine.Color | Private |
| _lazyFillColour | UnityEngine.Color | Private |
| _lowStaminaThreshold | System.Int32 | Private |
| _baseAmountLowStaminaColour | UnityEngine.Color | Private |
| _buffedAmountLowStaminaColour | UnityEngine.Color | Private |
| _lazyFillLowStaminaColour | UnityEngine.Color | Private |
| _flashRepeatCount | System.Single | Private |
| _lowStaminaFlashDuration | System.Single | Private |
| _flashColor | UnityEngine.Color | Private |
| _localPlayer | WildSkies.Player.LocalPlayer | Private |
| _minStamina | System.Single | Private |
| _timeSinceChangedOrFull | System.Single | Private |
| _initialSetupComplete | System.Boolean | Private |
| _active | System.Boolean | Private |
| _isFlashing | System.Boolean | Private |
| _isLowOnStamina | System.Boolean | Private |
| Tolerance | System.Single | Private |
| LazyFillTolerance | System.Single | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |
| _normalisedStamina | System.Single | Private |
| _shouldFade | System.Boolean | Private |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **get__normalisedStamina()**: System.Single (Private)
- **get__shouldFade()**: System.Boolean (Private)
- **Awake()**: System.Void (Protected)
- **Show(IPayload payload)**: System.Void (Public)
- **SetUpBaseWidthUI()**: System.Void (Private)
- **Hide()**: System.Void (Public)
- **Update()**: System.Void (Private)
- **CheckShouldBeActive()**: System.Void (Private)
- **CheckLowStaminaThresholdPassed()**: System.Void (Private)
- **UpdateText()**: System.Void (Private)
- **UpdateColour()**: System.Void (Private)
- **UpdateFill()**: System.Void (Private)
- **OnCurrentStaminaChanged()**: System.Void (Private)
- **AdjustMaxStaminaBar()**: System.Void (Private)
- **CalculateBarWidth(System.Single maxStamina)**: System.Single (Private)
- **ShowActionFailedVisual()**: System.Void (Private)
- **Fade()**: System.Void (Private)
- **LerpFillAmount(UnityEngine.RectTransform fillRect, System.Single targetWidth, System.Single duration)**: System.Void (Private)
- **LerpLazyFillAmount(UnityEngine.RectTransform fillRect, System.Single targetWidth, System.Single duration)**: System.Void (Private)
- **CalculateTargetFillValue()**: System.Single (Private)
- **FlashStaminaBar()**: Cysharp.Threading.Tasks.UniTask (Private)
- **.ctor()**: System.Void (Public)

