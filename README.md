# Open-World Dinosaur VR Experience

![Unity](https://img.shields.io/badge/Unity-2022.x-black?logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-Language-blue?logo=csharp&logoColor=white)
![Oculus](https://img.shields.io/badge/Oculus%20SDK-VR-blue?logo=oculus&logoColor=white)

> An immersive virtual reality (VR) game developed for the Oculus platform. This project focuses on creating a believable, interactive open-world environment where players can explore and interact with AI-driven dinosaurs.

---

## 1. Core Features

* **Dinosaur AI Behavior:** Programmed complex C# scripts to govern all dinosaur AI, including state machines for idling, wandering (using Unity's NavMesh), and reacting to the player.
* **Physics-Based VR Interaction:** Implemented hand controllers with custom scripts to allow players to realistically grab, hold, and interact with objects in the environment.
* **VR Performance Optimization:** Ensured a smooth, high-framerate experience (critical for avoiding motion sickness) by optimizing C# scripts, managing physics calculations, and fine-tuning render settings.
* **Open-World Environment:** Designed and built a large-scale terrain populated with foliage, water, and multiple types of AI-controlled dinosaurs.

## 2. Visual Demo

| Live Gameplay Demo (GIF) |
| :---: |
| ![Live Gameplay Demo](demo_assets/dino-demo.gif) |
| *A short clip demonstrating dinosaur AI pathfinding and player interaction.* |

*(**Aksi untuk Anda:** Buatlah folder `demo_assets` di repository Anda, rekam layar Anda memainkan game ini, simpan sebagai file GIF bernama `dino-demo.gif`, dan unggah ke folder tersebut agar dapat muncul di sini.)*

---

## 3. Key C# Scripts & Logic

The core of this project lies in the custom C# scripts created to bring the world to life.

* **`AnimalRandomMove.cs`**:
    * Controls the random wandering, idling, and grazing behaviors for all non-hostile dinosaurs.
    * Utilizes Unity's NavMeshAgent for intelligent pathfinding across the complex terrain, ensuring dinosaurs navigate around obstacles (like trees and water) realistically.

* **`AnimatorControl.cs`**:
    * Manages the dinosaur's Animation Controller.
    * Transitions between animation states (e.g., `isWalking`, `isRunning`, `isIdle`, `isAttacking`) based on the AI's current state, speed, and proximity to the player.

* **`HandAnimationController.cs`**:
    * Manages the player's virtual hand animations.
    * Links the Oculus controller's grip and trigger inputs to blend between "fist" and "pinch" animations, allowing for intuitive object grabbing.

## 4. Technology Stack

* **Game Engine:** `Unity Engine` (URP)
* **Core Language:** `C#`
* **Platform:** `Oculus SDK` (untuk VR)
* **Tools:** `Visual Studio`, `Git`
