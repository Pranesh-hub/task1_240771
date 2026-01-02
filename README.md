# 🧟 MiniPac

### A Unity 2D Pac-Man–Inspired Arcade Game

## Overview

**MiniPac** is a Unity-based 2D arcade game inspired by the classic *Pac-Man*, enhanced with **health-based combat mechanics** and **enemy AI**. The project focuses on clean gameplay logic, clear player feedback, and progressive difficulty.

This project was submitted as part of the **Secretary Recruitment Task** for the **Game Development Club, IIT Kanpur**.

---

## My Contribution

### 🧠 Gameplay Programming (C#)

I independently implemented the complete gameplay logic, including:

* Player movement using keyboard input (`W/A/S/D` and Arrow Keys)
* Player **health system** with real-time updates
* Zombie enemy logic featuring:

  * Player tracking
  * Collision-based damage
  * Mutual avoidance to prevent enemy stacking
* Collectible system with score tracking
* Scene-based level progression
* Audio handling for:

  * Damage feedback
  * Pickup sounds
* Health bar UI using Unity’s `Slider`
* Escape key handling to exit the game

---

## 🎮 Controls

| Action    | Key                           |
| --------- | ----------------------------- |
| Move      | `W / A / S / D` or Arrow Keys |
| Quit Game | `Escape`                      |

---

## 🌟 Features

* Health-based gameplay with UI feedback
* Zombies deal **variable damage** (10–40)
* Optional red flash visual effect on player damage
* Audio feedback for damage and pickups
* Progressive difficulty across scenes:

  * **Level 1:** 2 zombies
  * **Level 2:** 3 zombies
  * **Level 3:** 4 zombies
* Zombie-to-zombie avoidance to prevent overlapping
* Wall collisions handled using composite colliders

---

## 🎨 Visuals & Level Setup

* Basic sprite setup using Unity 2D tools
* Manual level construction using GameObjects
* Collider-based environment interaction

---

## 🔗 Build Link

👉 **Playable Build:**
[Build Link](https://drive.google.com/drive/folders/16l1ypmyK1fr3i14GdQyZj1YQvKVbGzgZ?usp=sharing)

> Download, extract, and run the executable. No additional setup required.

---

## Notes

This project demonstrates:

* End-to-end gameplay implementation in Unity
* Clear and maintainable C# scripting practices
* Ability to design and complete a functional game within a limited timeline
* Understanding of player feedback, difficulty scaling, and game feel

---
