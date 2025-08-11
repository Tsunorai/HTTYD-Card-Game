using Godot;

[GlobalClass]
public partial class CompetitionData : Resource
{
    [Export] public Competitions Name { get; set; }
    [Export] public Stats CompetitionStats { get; set; } = 0;

    public CompetitionData()
    {
        // Default constructor for Godot serialization
    }
}
