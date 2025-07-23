# HTTYD Card Game

*A fan-made HTTYD Card-Collection Game built with Godot.*

## Vision

This is a 2D card-collection game inspired by the *How to Train Your Dragon* universe. The game focuses on **dragon competitions** rather than combat. Players collect and train dragon cards and participate in stat-influenced challenges that determine the winner.

## Core Features

- **Card-Based Dragon Collection**  
  Players collect dragon cards through events such as exploration and dragon-catching competitions. Cards represent different species with unique stat ceilings.

- **Non-Combat Competitions**  
  Competitions are decided by probability systems where higher stats improve the chances of winning, but outcomes are not deterministic. There is no fighting between dragons. Example: in a racing competition, the outcome depends primarily on the dragon’s Speed and the player’s Riding stat.

- **Stat-Based Progression**  
  Dragons have individual stats and stat limits. Training improves these stats within species-specific boundaries (e.g., a Terrible Terror cannot reach the speed of a Night Fury).

- **Training System**  
  - Dragons can be trained by the player or by a trainer.
  - Player-led training improves the bond between dragon and rider.
  - While training, dragons and players are unavailable for competitions.

- **Bonding Mechanic**  
  - Bond increases by using the dragon in training, competitions, or playing with it.
  - A better bond means the dragon trusts the rider more, which (in the background) increases effective stat performance during competitions.

## Card Acquisition

- **Dragon-Catching Competitions**  
  A recurring type of competition where players can catch basic dragons.  
  At the end of a competition, the winner can select one dragon from the pool of caught dragons, followed by the loser.  
  
- **Exploration-Based Collection**  
  Dragons are discovered through a narrative-inspired exploration mechanic. More details to be added later.

## Technical Details

- **Engine**: Godot  
- **Graphics**: 2D  
- **No animations planned for now**
  
### Core seperation
The core game logic is separated from the UI layer. If you want to reuse the same card-based game mechanics in a different format—such as a 3D or animated game—you can fork this project and simply replace the contents of the **UI** folder with your custom interface.

## Help Request

This project is in early conceptual stages and being developed solo for now.  
If you're interested in contributing to the design, development, art, writing, or testing of this game, your help would be greatly appreciated.  
Please reach out if you'd like to collaborate on this fan-made project.

## Disclaimer

This is a **fan-made, non-commercial project** based on the *How to Train Your Dragon* (HTTYD) franchise.  
All intellectual property including characters, names, and settings belongs to **DreamWorks Animation** and its respective owners.  
This game is created solely for educational and entertainment purposes. No copyright infringement is intended.

---

*Note: This document is a work in progress. Features and mechanics may change as the design evolves.*
