using System;

[Flags]
public enum Competitions
{
    // WIP
    DragonRaceing = 1 << 0,
    DragonTraining = 1 << 1,
    DragonCapture = 1 << 2,
    Fyling = 1 << 3,
    Mapping = 1 << 4,
    Building = 1 << 5
}
