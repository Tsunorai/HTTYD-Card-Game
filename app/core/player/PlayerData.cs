using Godot;

public partial class PlayerData : Resource
{
    [Export] public string Name { get; set; }
    [Export] public int Level { get; set; }
    [Export] public short Riding { get; set; }
    [Export] public short Knowledge { get; set; }
    [Export] public short Training { get; set; }

    public PlayerData()
    {
        // Default constructor for Godot serialization
    }
}
