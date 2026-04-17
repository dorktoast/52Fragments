[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
# 52 Fragments Public Repo
This repo contains resources used by *[The 52 Fragments](https://steamcommunity.com/app/2702660)*. It may operate in an unusual way. This is normal.

## OutOfMyHands.cs

This is a game about trust.

This is the main script of an upcoming Fragment.  I have made the path from beginning to end easy. However it is not for me to determine the difficulty of my own path, and the result is, ultimately out of my hands.

This script, therefore, is a symbolic representation of that. And you, the player, are now going to decide the difficulty of your own fate.

You will write the code of this main script, and I will build a game around it.

So now it's your turn. 

### Structure

Any contribution to this fragment must meet all of the following prerequisites:

- One second after this fragment begins, the function `BeginFragment()` will be called.
- To win the game, `WinFragment()` must be called.
- Optionally, if the boolean `AchievementCondition` is true when `WinFragment()` is called, the player will receive an achievement icon in the main menu and, if playing on Steam, a win condition achievement.

### Rules

- It must be possible to win: the code should allow a player should be able to successfuly win by calling `WinFragment()`.
- All contributions to this fragment is subject to approval or rejection by the maintainer.
- No contribution to the Fragment will be accepted which causes disruption or damage to *The 52 Fragments* in any way. No contribution may violate the Terms of Service of GIB Games, Unity3d, Steamworks itch.io, or any software connected to *The 52 Fragments*.
- Code must be human-readable and commented. Intentional obfuscation of contibuted code is not allowed. The Maintainer must be able to understand fully what the code does or it will not be accepted. 
- Code which uses the Unity Engine in an unintended or dangerous way (such as performing ACE) are not allowed.
- Avoid using any external libraries and unnecessary dependencies. Available libraries are listed below.
- Do not add code that is excessively long, unnecessary (e.g., functions and parameters that are never called or excessively long comment blocks)
- All functions and parameters should remain within the scope of this script.
- Scripts may not use C# Reflection.

### How to participate

- Please follow the [GIB Games Universal Style Guide](https://github.com/GIBGames/gib-universal-style-guide) in the writing of your script.
- Please make merge requests directly to the Master branch.
- Please include the name by which you wish to be credited in the comment of your commit.

#### Available external functions and Variables

bool `Facts.FragmentIsCompleted(int targetFragment)`

Returns whether the player has played the specific fragment.

int `Facts.GetCoinFlip()`

Returns the player's coin flip as an integer. Team **Heads** is 0, **Tails** is 1, and **No Team** is any other valid integer.

string `Facts.GetFiveName()`

Returns the name the player set in the 5th fragment. If this is not set, will return the string "You".

bool `Facts.HasFoundKey()`

Returns whether the player has found the key for Fragment 20.

bool `Facts.HasFoundClover()`

Returns whether tha player has found a 4-leaf clover in Fragment 23.

bool `Facts.DidNine()`

Returns whether the player has successfully competed Fragment 9.

bool `Director.IsSteamVersion()`

Returns whether the player is running the Steam or itch.io version of *The 52 Fragments*.

string `Director.GetCustomText()`

Returns the text of a file in the 52 Fragments install folder called CustomText.txt. If it does not exist or cannot load, returns an empty string instead.

void `Director.ExitFragment()`

Exits the Fragment and returns to the Main Menu.

#### Available Libraries (outside of standard Unity built-in)

- TextMeshPro
- PostProcessing
- Odin Inspector & Serializer
- [EventsPro](https://assetstore.unity.com/packages/tools/utilities/eventspro-improved-events-and-ui-for-unity-269511)

#### Specifications

- **Unity version**: 2022.3.22.
- **Render Pipeline**: Built-in Render Pipeline**
- **Scripting backend**: Mono
