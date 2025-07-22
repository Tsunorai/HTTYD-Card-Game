using System.Collections.Generic;
using Godot;

public partial class UIDeck : Node2D
{
    private List<UICard> m_UICards = [];
    private Container m_CardContainer;

    public override void _Ready()
    {
        m_CardContainer = GetNode<Container>("Container");
        UpdateUI();
    }
    private void UpdateUI()
    {
        var scene = GD.Load<PackedScene>("res://app/ui/deck/UICard.tscn");
        m_CardContainer.GetChildren().Clear();

        foreach (var card in CardManager.Instance.Cards)
        {
            var uiCard = scene.Instantiate<UICard>();
            m_CardContainer.AddChild(uiCard);
            uiCard.Init(card);
            m_UICards.Add(uiCard);
        }
    }
}
