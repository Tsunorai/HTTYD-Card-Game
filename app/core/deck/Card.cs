using Godot;
using System;

public partial class Card : Node
{
    private CardData m_Card;
    public CardData Data => m_Card;

    public Card(CardData cardData)
    {
        if (cardData == null)
        {
            GD.PrintErr("CardData cannot be null");
            return;
        }
        m_Card = cardData;
    }
}
