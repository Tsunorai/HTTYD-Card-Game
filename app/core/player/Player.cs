using Godot;

public partial class Player : Node
{
    private PlayerData m_PlayerData;
    public PlayerData PlayerData { get; set; }

    public Player() { /* Defaults for Godot instantiation */ }
}
