using System.Collections.Generic;
using System.IO;
using Godot;

public partial class CardManager : Node
{
    public static CardManager Instance { get; private set; }
    private readonly string m_DataPath = "res://app/assets/resources/cards/data";
    public readonly List<Card> Cards = [];

    [Signal]
    public delegate void UpdateEventHandler(string cardId);

    public override void _Ready()
    {
        Instance = this;
        LoadCards();
    }

    private void LoadCards()
    {
        DirAccess dir = DirAccess.Open(m_DataPath);
        if (dir == null)
        {
            GD.PushError($"Failed to open directory: {m_DataPath}");
            return;
        }

        dir.ListDirBegin();
        string fileName = dir.GetNext();
        while (!string.IsNullOrEmpty(fileName))
        {
            if (!dir.CurrentIsDir() && fileName.EndsWith(".tres"))
            {
                string fullPath = Path.Combine(m_DataPath, fileName);
                var data = ResourceLoader.Load<CardData>(fullPath);
                if (data != null)
                {
                    Card newCard = new(data);
                    Cards.Add(newCard);
                }
            }
            fileName = dir.GetNext();
        }
        GD.Print($"Loaded {Cards.Count} cards from {m_DataPath}");
    }
}
