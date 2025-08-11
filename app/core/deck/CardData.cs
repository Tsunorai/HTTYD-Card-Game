using Godot;

[GlobalClass]
public partial class CardData : Resource
{
    [Export] public string Id { get; set; }
    [Export] public string Name { get; set; }
    [Export] public Texture2D Image { get; set; }
    [Export] public string Class { get; set; }
    [Export] public int Attack { get; set; }
    [Export] public int Defense { get; set; }
    [Export] public int Speed { get; set; }
    [Export] public string Description { get; set; }

    public CardData()
    {
        // Default constructor for Godot serialization
    }
}
