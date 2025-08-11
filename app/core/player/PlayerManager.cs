using Godot;

public partial class PlayerManager : Node
{
    public static PlayerManager Instance { get; private set; }
    private readonly string m_DataPath = "res://app/assets/resources/player.tres";
    private Player m_Player;
    public Player Player { get; private set; }

    [Signal]
    public delegate void SavePlayerEventHandler();
    public override void _Ready()
    {
        Instance = this;
        LoadPlayerFromDisk();

        Instance.SavePlayer += WritePlayerToDisk;
    }

    private void LoadPlayerFromDisk()
    {
        PlayerData data = ResourceLoader.Load<PlayerData>(m_DataPath);
        if (data != null)
        {
            GD.Print("Player loaded successfully");
            m_Player.PlayerData = data;
        }
        else
        {
            GD.PrintErr("Failed to load Player");
        }
    }

    private void WritePlayerToDisk()
    {
        Error error = ResourceSaver.Save(Player.PlayerData, m_DataPath);
        if (error == Error.Ok)
        {
            GD.Print("Player saved successfully");
        }
        else
        {
            GD.PrintErr("Failed to save Player");
        }
    }
}
