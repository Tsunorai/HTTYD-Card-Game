using Godot;
using System;

public partial class Card : Node
{
	public CardData card;

	public void Init(CardData cardData)
	{
		card = cardData;
    }

	public int Attack()
	{
		return card.Attack;
    }
}
