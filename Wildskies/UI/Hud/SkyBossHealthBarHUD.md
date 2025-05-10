# Wildskies.UI.Hud.SkyBossHealthBarHUD

**Type**: Class

## Fields

| Name | Type | Access |
|------|------|--------|
| _showedIntro | System.Boolean | Private |
| _viewModel | Wildskies.UI.Hud.MegaHealthBarView | Private |
| _health | WildSkies.Entities.Health.EntityHealth | Private |
| _currentHealth | System.Single | Private |
| _maxHeath | System.Single | Private |
| _showHealthbar | System.Boolean | Private |
| ShowAnimationString | System.String | Private |
| DefeatedAnimationString | System.String | Private |

## Properties

| Name | Type | Access |
|------|------|--------|
| Type | UISystem.UIHudType | Public |

## Methods

- **get_Type()**: UISystem.UIHudType (Public)
- **Awake()**: System.Void (Protected)
- **ShowHealthPanel(System.Boolean show)**: System.Void (Public)
- **Setup(WildSkies.Entities.Health.EntityHealth health)**: System.Void (Public)
- **OnDestroy()**: System.Void (Private)
- **OnEntityDamaged()**: System.Void (Private)
- **ShowMegaDefeatedPanel()**: System.Void (Public)
- **UpdateUI()**: System.Void (Private)
- **AdjustCurrentHealthBar()**: System.Void (Private)
- **AdjustHealthbarColor()**: System.Void (Private)
- **.ctor()**: System.Void (Public)
- **<ShowHealthPanel>b__11_0()**: System.Single (Private)
- **<ShowHealthPanel>b__11_1(System.Single alpha)**: System.Void (Private)
- **<ShowHealthPanel>b__11_2()**: System.Single (Private)
- **<ShowHealthPanel>b__11_3(System.Single fillAmount)**: System.Void (Private)
- **<ShowHealthPanel>b__11_4()**: System.Single (Private)
- **<ShowHealthPanel>b__11_5(System.Single alpha)**: System.Void (Private)
- **<AdjustCurrentHealthBar>b__17_0()**: System.Single (Private)
- **<AdjustCurrentHealthBar>b__17_1(System.Single fillAmount)**: System.Void (Private)

