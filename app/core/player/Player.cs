using Godot;

public partial class Player : Node
{
    private string m_Name;
    private int m_Level;
    private short m_Riding;
    private short m_Knowledge;
    private short m_Training;

    public string Name => m_Name;
    public int Level => m_Level;
    public short Riding => m_Riding;
    public short Knowledge => m_Knowledge;
    public short Training => m_Training;

    public Player() { /* Defaults for Godot instantiation */ }

    public Player(string name, int level, short riding, short knowledge, short training)
    {
        m_Name = name;
        m_Level = level;
        m_Riding = riding;
        m_Knowledge = knowledge;
        m_Training = training;

        GD.Print($"Player created: {m_Name}, Level: {m_Level}, Riding: {m_Riding}, Knowledge: {m_Knowledge}, Training: {m_Training}");
    }
}
