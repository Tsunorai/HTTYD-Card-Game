using Godot;

public partial class Player : Node
{
    private string m_Name;
    private int m_Level;
    private short m_Riding;
    private short m_Knowladge;
    private short m_Training;

    public string Name => m_Name;
    public int Level => m_Level;
    public short Riding => m_Riding;
    public short Knowladge => m_Knowladge;
    public short Training => m_Training;

    public Player(string name, int level, short riding, short knowladge, short training)
    {
        m_Name = name;
        m_Level = level;
        m_Riding = riding;
        m_Knowladge = knowladge;
        m_Training = training;

        GD.Print($"Player created: {m_Name}, Level: {m_Level}, Riding: {m_Riding}, Knowledge: {m_Knowladge}, Training: {m_Training}");
    }
}
