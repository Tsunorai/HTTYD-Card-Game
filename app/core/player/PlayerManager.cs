using Godot;
using Godot.Collections;
using FileAccess = Godot.FileAccess;

public partial class PlayerManager : Node
{
    public static PlayerManager Instance { get; private set; }
    private readonly string m_PlayerDataPath = "res://app/assets/resources/player.json";
    public Player m_Player;

    [Signal]
    public delegate void UpdatePlayerEventHandler();

    public override void _Ready()
    {
        Instance = this;
        LoadPlayer();

        Instance.UpdatePlayer += SavePlayer;
    }

    private void LoadPlayer()
    {
        using var file = FileAccess.Open(m_PlayerDataPath, FileAccess.ModeFlags.Read);
        string playerData = file.GetAsText();

        Json json = new();
        Error error = json.Parse(playerData);

        if (error == Error.Ok)
        {
            var data = (Dictionary)json.Data;
            m_Player = JsonToPlayer(data);
        }
        else
        {
            GD.PushError($"Failed to parse player data: {error}");
        }
    }

    private void SavePlayer()
    {
        using var file = FileAccess.Open(m_PlayerDataPath, FileAccess.ModeFlags.Write);
        Json json = new();
        string playerData = Json.Stringify(PlayerToJson(m_Player));
        file.StoreString(playerData);
        GD.Print($"Player data saved: {playerData}");
    }

    private Player JsonToPlayer(Dictionary json)
    {
        return new Player(
            json["name"].ToString(),
            json["level"].As<int>(),
            json["riding"].As<short>(),
            json["knowladge"].As<short>(),
            json["training"].As<short>()
        );
    }

    private Dictionary PlayerToJson(Player player)
    {
        return new Dictionary
        {
            { "name", player.Name },
            { "level", player.Level },
            { "riding", player.Riding },
            { "knowladge", player.Knowladge },
            { "training", player.Training }
        };
    }
}
