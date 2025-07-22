using Godot;
using System;

public partial class CardData : Resource
{
    [Export] public string Id { get; set; } = "night_fury";
    [Export] public string Name { get; set; } = "Night Fury";
    [Export] public Texture2D Image { get; set; } = null;
    [Export] public string Class { get; set; } = "Strike";
    [Export] public int Attack { get; set; } = 95;
    [Export] public int Defense { get; set; } = 80;
    [Export] public int Speed { get; set; } = 100;
    [Export] public string Description { get; set; } = "A rare and intelligent dragon known for its incredible speed, stealth, and plasma blasts.";
}
