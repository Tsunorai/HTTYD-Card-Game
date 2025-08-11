using Godot;

public partial class CompetitionsManager : Node
{
    public static CompetitionsManager Instance { get; private set; }
    private readonly string m_DataPath = "res://app/assets/resources/competitions";

    [Signal]
    public delegate void UpdateEventHandler(string cardId);

    public override void _Ready()
    {
        Instance = this;
    }
}
