# ICS Mod Menu

*A mod menu for **Internet Cafe Simulator**, powered by BepInEx.*

![Mod Status](https://img.shields.io/badge/status-active-brightgreen)
![BepInEx](https://img.shields.io/badge/BepInEx-5.x-blue)
![Platform](https://img.shields.io/badge/platform-Windows%20x64-lightgrey)

---

## Features

- **In‑game Mod Menu (F11)** – Toggle the mod UI at any time.
- **Add Money Tool** – Enter any amount and instantly add it to your wallet.
- **Live Value Preview** – Displays how much money is being added.
- **Modular Structure** – Clean separation of features, patches, and utilities.
- **Future‑proof Architecture** – Designed to be easily expanded

---

## Requirements

- **[BepInEx 5 (x64)](https://github.com/BepInEx/BepInEx)**
  Required for loading and running the mod.

---

## Installation

### 1. Install BepInEx

1. Download **BepInEx x64** from the [official releases](https://github.com/BepInEx/BepInEx/releases):
   > If you run into issues, try the older version used during development:
   > [**5.4.23.4**](https://github.com/BepInEx/BepInEx/releases/tag/v5.4.23.4)

2. Extract the contents of the ZIP.

3. Place all extracted files into the **game’s root folder**
   (the folder containing the game executable).
   Example:

   ```cmd
   C:\SteamLibrary\steamapps\common\Internet Cafe Simulator\windows_content
   ```

---

### 2. Install the Mod

Place `ICSModMenu.dll` into:

```txt
<Internet Cafe Simulator root>\BepInEx\plugins\ICSModMenu.dll
```

Launch the game and press **F11** to open the menu.

---

## Development

### Building

1. Copy/rename:

   ```txt
   GamePath.props.template → GamePath.props
   ```

2. Edit the file and ensure the game path is correct.

3. Build the mod:

   ```cmd
   dotnet publish -c Release
   ```

The DLL will be generated inside the `publish` folder.

---

## Project Structure

```table
ICSModMenu/
│
├── Features/        # Game logic and mod features
├── Patches/         # Harmony patches (future expansion)
├── Utils/           # Helper classes
├── GamePath.props   # Local path to the game installation
└── ModMenuPlugin.cs # Main BepInEx entrypoint
```

---

## Notes

- This mod is does not modify game files.
- For debugging, a Debug build will also generate PDBs for dnSpy inspection.

---

## Support

If you want improvements, more cheats, or UI enhancements, feel free to request them!
