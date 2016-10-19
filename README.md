# README #

This project is an implementation of the classic Battleship game.

Requirements:

* Windows machine or Mono installed
* Unix command line (use something like MSYS2 on Windows)

To get started:

1. Clone project
1. Open `MyGame.sln` using Xamarin Studio (Windows/macOS) or MonoDevelop (Other UNIXes)
1. Rebuild the project
1. Run the project from the IDE -- you can also find the executable in the bin folder, but using the IDE will allow you to debug the project.

## If you get a black screen when running the game
### Linux/Windows users
* Build the project in Xamarin Studio so the project creates a "Debug" folder.
* Copy the "Resources" folder (from the root directory of the Git project) to "battleships_cs/bin/Debug/".

### macOS users
* Build the project in Xamarin Studio so the project creates a "Debug/ProjectTemplate.app/Contents/" folder.
* Copy the "Resources" folder (from the root directory of the Git project) to "battleships_cs/bin/Debug/ProjectTemplate.app/Contents/"
