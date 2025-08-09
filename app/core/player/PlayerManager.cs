using Godot;
using Godot.Collections;
using FileAccess = Godot.FileAccess;

public partial class PlayerManager : Node
{
    public static PlayerManager Instance { get; private set; }
    private readonly string m_PlayerDataPath = "res://app/assets/resources/player.json";
    private Player m_Player;
    public Player Player { get; private set; }

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
            if (json.Data.VariantType != Variant.Type.Dictionary)
            {
                GD.PushError("Player data JSON is not an object.");
                m_Player = new Player("Player", 1, 0, 0, 0);
                SavePlayer();
                return;
            }
            var data = (Dictionary)json.Data;
            m_Player = JsonToPlayer(data);
        }
    }

    private void SavePlayer()
    {
        using var file = FileAccess.Open(m_PlayerDataPath, FileAccess.ModeFlags.Write);
        Json json = new();
        string playerData = Json.Stringify(PlayerToJson(Player));
        file.StoreString(playerData);
        GD.Print($"Player data saved: {playerData}");
    }

    private Player JsonToPlayer(Dictionary json)
    {
        return new Player(
            json["name"].ToString(),
            json["level"].As<int>(),
            json["riding"].As<short>(),
            json["knowledge"].As<short>(),
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
            { "knowledge", player.Knowledge },
            { "training", player.Training }
        };
    }
}
