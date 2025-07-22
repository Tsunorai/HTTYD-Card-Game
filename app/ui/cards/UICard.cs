using Godot;
using System;

public partial class UICard : Control
{
    private Card card;

    private Label nameLabel;
    private TextureRect imageTexture;
    private Label classLabel;
    private TextEdit descriptionText;
    private Label attackLabel;
    private Label defenseLabel;
    private Label speedLabel;

    public override void _Ready()
    {
        nameLabel = GetNode<Label>("Name");
        imageTexture = GetNode<TextureRect>("Image");
        classLabel = GetNode<Label>("Class");
        descriptionText = GetNode<TextEdit>("Description");
        attackLabel = GetNode<Label>("Attack");
        defenseLabel = GetNode<Label>("Defense");
        speedLabel = GetNode<Label>("Speed");
    }

    public void Init(Card card)
    {
        if (this.card == null)
        {
            GD.PrintErr("Card data is not initialized.");
            return;
        }
        this.card = card;
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (card.card is CardData data)
        {
            nameLabel.Text = data.Name;
            imageTexture.Texture = data.Image;
            classLabel.Text = data.Class;
            descriptionText.Text = data.Description;
            attackLabel.Text = $"Attack: {data.Attack}";
            defenseLabel.Text = $"Defense: {data.Defense}";
            speedLabel.Text = $"Speed: {data.Speed}";
        }
        else
        {
            GD.PrintErr("Card data is not of type CardData.");
        }
    }
}
