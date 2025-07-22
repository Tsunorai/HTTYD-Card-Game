using Godot;

public partial class UICard : Control
{
    private Label m_NameLabel;
    private TextureRect m_ImageTexture;
    private Label m_ClassLabel;
    private TextEdit m_DescriptionText;
    private Label m_AttackLabel;
    private Label m_DefenseLabel;
    private Label m_Speed;

    public override void _Ready()
    {
        GD.Print("UICard: _Ready called");
        m_NameLabel = GetNode<Label>("CenterContainer/VBoxContainer/Name");
        m_ImageTexture = GetNode<TextureRect>("CenterContainer/VBoxContainer/Image");
        m_ClassLabel = GetNode<Label>("CenterContainer/VBoxContainer/Class");
        m_DescriptionText = GetNode<TextEdit>("CenterContainer/VBoxContainer/Description");
        m_AttackLabel = GetNode<Label>("CenterContainer/VBoxContainer/Stats/Attack");
        m_DefenseLabel = GetNode<Label>("CenterContainer/VBoxContainer/Stats/Defense");
        m_Speed = GetNode<Label>("CenterContainer/VBoxContainer/Stats/Speed");
    }

    public void Init(Card card)
    {
        if (card == null)
        {
            GD.PrintErr("UICard: Card is not initialized.");
            return;
        }

        if (card.Data is CardData data)
        {
            m_NameLabel.Text = "data.Name";
            m_ImageTexture.Texture = data.Image;
            m_ClassLabel.Text = data.Class;
            m_DescriptionText.Text = data.Description;
            m_AttackLabel.Text = $"Attack: {data.Attack}";
            m_DefenseLabel.Text = $"Defense: {data.Defense}";
            m_Speed.Text = $"Speed: {data.Speed}";
        }
    }
}
