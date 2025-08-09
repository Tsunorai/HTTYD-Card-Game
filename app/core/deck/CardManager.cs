using System.Collections.Generic;
using System.IO;
using Godot;

public partial class CardManager : Node
{
    public static CardManager Instance { get; private set; }
    private readonly string m_CardPath = "res://app/assets/resources/cards/data";
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
        DirAccess dir = DirAccess.Open(m_CardPath);
        if (dir == null)
        {
            GD.PushError($"Failed to open directory: {m_CardPath}");
            return;
        }

        dir.ListDirBegin();
        string fileName = dir.GetNext();
        while (!string.IsNullOrEmpty(fileName))
        {
            if (!dir.CurrentIsDir() && fileName.EndsWith(".tres"))
            {
                string fullPath = Path.Combine(m_CardPath, fileName);
                var data = ResourceLoader.Load<CardData>(fullPath);
                if (data != null)
                {
                    Card newCard = new(data);
                    Cards.Add(newCard);
                }
            }
            fileName = dir.GetNext();
        }
        GD.Print($"Loaded {Cards.Count} cards from {m_CardPath}");
    }
}
