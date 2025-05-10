# Wildskies.UI.Hud.MegaHealthBarHUD

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _showedIntro | System.Boolean | Private |
| _viewModel | Wildskies.UI.Hud.MegaHealthBarView | Private |
| _updateIntervalInFrames | System.Single | Private |
| _health | MegaHealth | Private |
| _currentHealth | System.Single | Private |
| _mexHeath | System.Single | Private |
| healthTween | DG.Tweening.Tweener | Private |
| _showHealthbar | System.Boolean | Private |
| _megaDead | System.Boolean | Private |
| _megaService | WildSkies.Service.MegaService | Private |
| _localPlayerService | WildSkies.Service.ILocalPlayerService | Private |
| ShowAnimationString | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **Setup(MegaHealth health)**: System.Void (Public)
- **Update()**: System.Void (Private)
- **ShowMegaHealth(System.Boolean show)**: System.Void (Public)
- **OnMegaDamaged()**: System.Void (Public)
- **OnMegaDeath()**: System.Void (Public)
- **ShowMegaDefeatedPanel()**: System.Void (Public)
- **UpdateUI()**: System.Void (Private)
- **AdjustCurrentHealthBar()**: System.Void (Private)
- **AdjustHealthbarColor()**: System.Void (Private)
- **AdjustMaxHealthBar()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<ShowMegaHealth>b__17_0()**: System.Single (Private)
- **<ShowMegaHealth>b__17_1(System.Single alpha)**: System.Void (Private)
- **<ShowMegaHealth>b__17_2()**: System.Single (Private)
- **<ShowMegaHealth>b__17_3(System.Single fillAmount)**: System.Void (Private)
- **<ShowMegaHealth>b__17_4()**: System.Single (Private)
- **<ShowMegaHealth>b__17_5(System.Single alpha)**: System.Void (Private)
- **<AdjustCurrentHealthBar>b__22_0()**: System.Single (Private)
- **<AdjustCurrentHealthBar>b__22_1(System.Single fillAmount)**: System.Void (Private)

