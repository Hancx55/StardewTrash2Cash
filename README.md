# **Trash2Cash - Stardew Valley Mod**

A small Stardew Valley mod that replaces the default behaviour of the trash can with a sell mechanic instead of delete.

The trash can becomes a selling point, when a player trashes an item they will receive its sale value in gold instantly. This mod was created as a personal quality of life improvement to the game as well as a learning project to explore SMAPI and Stardew Valley's internal logic through a basic modification.

## Tech Stack:
- C#
- SMAPI (Stardew Modding API)
- HarmonyLib (method patching)
- Stardew Valley internal game logic
- Visual Studio

## Features:
- Logs a 'GOODMORNING' message each in-game day (verifies mod has loaded correctly)
- Fully replaces the method "Utility.trashItem" using Harmony
- Trashed item gives the player gold equal to sale price multiplied by stack size
- A coin sound is played when item is trashed

## Skills Gained:
- Understanding how SMAPI loads mods and events
- Navigating Stardew Valley's internal classes
- Working with pre-existing game events e.g. 'DayStarted'
- Applied Transferrable Java knowledge to C# mod development
- Using Harmony patches to override game behaviour safely

## How To Use:
Dependencies: Stardew Valley, SMAPI
1. Install SMAPI
2. Download/clone this mod
3. Place the mod folder into Stardew Valley 'Mods' directory
4. Launch Stardew Valley through SMAPI
5. Open a game and trash any item

---
