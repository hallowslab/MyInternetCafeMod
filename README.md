### Installing

- Put MyInternetCafeMod.dll in `<Internet Cafe Simulator root>\BepInEx\plugins\MyInternetCafeMod.dll` where `<Internet Cafe Simulator root>` is the path in which the game executable is located

### DEV

#### Building

- Copy/rename the GamePath.props.template into GamePath.props and make sure the game path is correct
- Run `dotnet publish -c Release -r win-x64 --self-contained false`
