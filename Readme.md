# Peaceful Bubbles Game

Simple Unity bubble-popping game. Spawned bubbles move up; clicking good bubbles increases score, clicking bad bubbles ends the game.

## Quick start
- Open the project in Unity (open [Peaceful Bubbles Game.sln](Peaceful Bubbles Game.sln) or the project root).
- Press Play in the Editor to run.
- To build for Android/iOS use Unity Build Settings (Android build files and CMake artifacts are present under `.utmp` and `Library/Bee/...`).

## How to play
- Bubbles spawn automatically. Good bubbles give +1 score; bad bubbles trigger Game Over.
- Click good bubbles to score before the level timer reaches 0.
- When time runs out, score is compared to targetScore to decide win/lose.

## Important scripts (open these files)
- [`GameManager`](Assets/scripts/GameManager.cs) — core game state, score, timer, UI bindings, GameOver and Retry logic.  
  [Assets/scripts/GameManager.cs](Assets/scripts/GameManager.cs)
- [`Bubble`](Assets/scripts/Bubble.cs) — bubble behavior, movement, click handling, pop animation, interacts with `GameManager`.  
  [Assets/scripts/Bubble.cs](Assets/scripts/Bubble.cs)
- [`BubbleSpawner`](Assets/scripts/BubbleSpawner.cs) — spawns good/bad bubble prefabs at random X positions.  
  [Assets/scripts/BubbleSpawner.cs](Assets/scripts/BubbleSpawner.cs)

## UI elements (inspect in Inspector)
- Public fields in [`GameManager`](Assets/scripts/GameManager.cs): `timeText`, `scoreText`, `winPanel`, `gameOverPanel`, `levelTime`, `targetScore`, `bubbleSpeed`.
  [Assets/scripts/GameManager.cs](Assets/scripts/GameManager.cs)

## Other useful assets / examples
- TextMesh Pro example scripts included (used for UI/text samples):
  - [`TMP_TextSelector_B`](Assets/TextMesh Pro/Examples & Extras/Scripts/TMP_TextSelector_B.cs) — link handling & vertex color demo.  
    [Assets/TextMesh Pro/Examples & Extras/Scripts/TMP_TextSelector_B.cs](Assets/TextMesh Pro/Examples & Extras/Scripts/TMP_TextSelector_B.cs)
  - [`CameraController`](Assets/TextMesh Pro/Examples & Extras/Scripts/CameraController.cs) — example camera input & smoothing.  
    [Assets/TextMesh Pro/Examples & Extras/Scripts/CameraController.cs](Assets/TextMesh Pro/Examples & Extras/Scripts/CameraController.cs)
  - [`TeleType`](Assets/TextMesh Pro/Examples & Extras/Scripts/TeleType.cs) — typewriter text demo.  
    [Assets/TextMesh Pro/Examples & Extras/Scripts/TeleType.cs](Assets/TextMesh Pro/Examples & Extras/Scripts/TeleType.cs)
- TM Pro fonts / license:  
  [Assets/TextMesh Pro/Examples & Extras/Fonts/Roboto-Bold - AFL.txt](Assets/TextMesh Pro/Examples & Extras/Fonts/Roboto-Bold - AFL.txt)

## Project layout (open folders)
- Scenes: [Assets/Scenes](Assets/Scenes)
- Prefabs: [Assets/Prefabs](Assets/Prefabs)
- Scripts: [Assets/scripts](Assets/scripts)
- TextMesh Pro examples: [Assets/TextMesh Pro](Assets/TextMesh Pro)

## Notes & tips
- Game pause is implemented via `Time.timeScale = 0f` in [`GameManager.GameOver()`](Assets/scripts/GameManager.cs). Resume carefully when reloading scenes (see `RetryGame()`).
- `Bubble.OnMouseDown()` triggers pop anim and calls `GameManager.AddScore()` or `GameManager.GameOver()` depending on `isBadBubble`. See [Assets/scripts/Bubble.cs](Assets/scripts/Bubble.cs).
- If building for Android, project contains CMake/Ninja intermediate files under `.utmp/Debug/...` (used by Unity when IL2CPP + NDK builds are enabled).

## License / Credits
- Project includes TextMesh Pro example content and Roboto font license at:  
  [Assets/TextMesh Pro/Examples & Extras/Fonts/Roboto-Bold - AFL.txt](Assets/TextMesh Pro/Examples & Extras/Fonts/Roboto-Bold - AFL.txt)

If you want, I can:
- generate badges, developer notes, or CI build steps, or
- convert this README into a more detailed developer guide with class diagrams.
