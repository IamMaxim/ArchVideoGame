//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public UIButtonComponent uIButton { get { return (UIButtonComponent)GetComponent(GameComponentsLookup.UIButton); } }
    public bool hasUIButton { get { return HasComponent(GameComponentsLookup.UIButton); } }

    public void AddUIButton(UIButtonComponent.ButtonType newButtonType) {
        var index = GameComponentsLookup.UIButton;
        var component = (UIButtonComponent)CreateComponent(index, typeof(UIButtonComponent));
        component.buttonType = newButtonType;
        AddComponent(index, component);
    }

    public void ReplaceUIButton(UIButtonComponent.ButtonType newButtonType) {
        var index = GameComponentsLookup.UIButton;
        var component = (UIButtonComponent)CreateComponent(index, typeof(UIButtonComponent));
        component.buttonType = newButtonType;
        ReplaceComponent(index, component);
    }

    public void RemoveUIButton() {
        RemoveComponent(GameComponentsLookup.UIButton);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherUIButton;

    public static Entitas.IMatcher<GameEntity> UIButton {
        get {
            if (_matcherUIButton == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.UIButton);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherUIButton = matcher;
            }

            return _matcherUIButton;
        }
    }
}
