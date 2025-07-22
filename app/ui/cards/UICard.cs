using Godot;
using System;

public partial class UICard : Control
{
    private Card m_Card;

    private Label m_MameLabel;
    private TextureRect m_ImageTexture;
    private Label m_ClassLabel;
    private TextEdit m_DescriptionText;
    private Label m_AttackLabel;
    private Label m_DefenseLabel;
    private Label m_Speed;

    public override void _Ready()
    {
        m_MameLabel = GetNode<Label>("CenterContainer/VBoxContainer/Name");
        m_ImageTexture = GetNode<TextureRect>("CenterContainer/VBoxContainer/Image");
        m_ClassLabel = GetNode<Label>("CenterContainer/VBoxContainer/Class");
        m_DescriptionText = GetNode<TextEdit>("CenterContainer/VBoxContainer/Description");
        m_AttackLabel = GetNode<Label>("CenterContainer/VBoxContainer/Stats/Attack");
        m_DefenseLabel = GetNode<Label>("CenterContainer/VBoxContainer/Stats/Defense");
        m_Speed = GetNode<Label>("CenterContainer/VBoxContainer/Stats/Speed");
    }

    public void Init(Card card)
    {
        m_Card = card;
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (m_Card == null)
        {
            GD.PrintErr("UICard: Card is not initialized.");
            return;
        }
        if (m_Card.Data is CardData data)
        {
            m_MameLabel.Text = data.Name;
            m_ImageTexture.Texture = data.Image;
            m_ClassLabel.Text = data.Class;
            m_DescriptionText.Text = data.Description;
            m_AttackLabel.Text = $"Attack: {data.Attack}";
            m_DefenseLabel.Text = $"Defense: {data.Defense}";
            m_Speed.Text = $"Speed: {data.Speed}";
        }
        else
        {
            GD.PrintErr("Card data is not of type CardData.");
        }
    }
}
