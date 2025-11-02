# Open-World Dinosaur VR Experience

> An immersive virtual reality (VR) game developed for the Oculus platform. This project focuses on creating a believable, interactive open-world environment where players can explore and interact with Algorithm-driven dinosaurs.

## 1. Project Overview

This game was developed as a deep dive into the technical challenges of VR development and game. where entities (dinosaurs) react believably to the player and their environment. All development was done in C# using the Unity Engine.

## 2. Key Technical Features & Challenges

* **Complex Algorithm Behavior:**
    * Developed advanced C# scripts to govern all dinosaur.
    * Implemented a state machine for behaviors, including `Idle` (roaming, grazing), `Aware` (investigating sounds or sights), and `Interact` (reacting to the player).
    * Utilized Unity's pathfinding system for realistic movement within a complex, uneven terrain.

* **VR Interaction Mechanics:**
    * Built an intuitive, physics-based interaction system for the player.
    * Enabled players to pick up, throw, and interact with objects in the environment using VR controllers.

* **Performance Optimization:**
    * The primary challenge in VR is maintaining a high and stable framerate (e.g., 60+ FPS) to prevent motion sickness.
    * Ensured a smooth, bug-free experience by rigorously optimizing all C# scripts, managing physics calculations efficiently, and implementing object pooling for spawned entities.

## 3. Technology Stack

* **Game Engine:** `Unity Engine`
* **Core Language:** `C#`
* **Platform:** `Oculus SDK` (VR)
* **Tools:** `Visual Studio`, `Git`
