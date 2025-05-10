# Wildskies.UI.Hud.PerceptionStateUIView

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _canvasGroup | UnityEngine.CanvasGroup | Private |
| _fadeTime | System.Single | Private |
| _aware | UnityEngine.GameObject | Private |
| _alert | UnityEngine.GameObject | Private |
| _awareFillImage | UnityEngine.UI.Image | Private |
| _id | System.Int32 | Private |
| _perception | WildSkies.AI.IAIPerceptionSystem | Private |
| _alphaTo | System.Single | Private |
| _alphaFrom | System.Single | Private |
| _fadeTimer | System.Single | Private |
| _previousState | WildSkies.AI.EPerceptionState | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Active | System.Boolean | Public |
| Id | System.Int32 | Public |
| Perception | WildSkies.AI.IAIPerceptionSystem | Public |

## Methods

- **get_Active()**: System.Boolean (Public)
- **get_Id()**: System.Int32 (Public)
- **get_Perception()**: WildSkies.AI.IAIPerceptionSystem (Public)
- **Init(WildSkies.AI.IAIPerceptionSystem perception, System.Int32 id)**: System.Void (Public)
- **OnUpdate()**: System.Void (Public)
- **SetCanvasAlpha(System.Single alpha)**: System.Void (Public)
- **.ctor()**: System.Void (Public)

