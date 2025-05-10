# Wildskies.UI.Panel.DemoNarrativeStartPanel

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _inputService | WildSkies.Service.InputService | Public |
| _fadeOutTimer | System.Single | Private |
| _viewModel | Wildskies.UI.Panel.DemoNarrativeStartPanelViewModel | Private |
| _payload | Wildskies.UI.Panel.DemoNarrativeStartPanelPayload | Private |
| _startAlphas | System.Single[] | Private |
| _currentFadeAlpha | System.Single | Private |
| _currentFadeColor | UnityEngine.Color | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIPanelType | Public |

## Methods

- **get_Type()**: UISystem.UIPanelType (Public)
- **Awake()**: System.Void (Protected)
- **InitializeText()**: System.Void (Private)
- **Show(System.Int32 panelInstanceID, IPayload payload)**: System.Void (Public)
- **RevealTextSequence()**: Cysharp.Threading.Tasks.UniTask (Private)
- **FadeInText(TMPro.TMP_Text text)**: Cysharp.Threading.Tasks.UniTask (Private)
- **WaitPause(System.Single duration)**: Cysharp.Threading.Tasks.UniTask (Private)
- **SetAlphas(System.Single alpha)**: System.Void (Private)
- **FadeOut()**: System.Void (Private)
- **.ctor()**: System.Void (Public)

