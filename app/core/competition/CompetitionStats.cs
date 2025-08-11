using System;

[Flags]
public enum Stats
{
    // Player WIP
    Training = 1 << 0,
    Riding = 1 << 1,
    Knowledge = 1 << 2,

    // Dragon WIP
    Speed = 1 << 3,
    Stealth = 1 << 4,
    Intelligence = 1 << 5
}
