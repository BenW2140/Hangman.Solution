# _Hangman_

#### _Play some hangman, July 27, 2020_

#### By _**Ben White & Micheal Hansen**_

## Description

_This program allows a user to play a game of hangman using randomly generated words_

## Setup/Installation Requirements

Software Requirements:

1. This program utilizes .NET version 2.2, and requires this framework to be pre-installed:
    * Please go to https://dotnet.microsoft.com/download/dotnet-core/2.2 and install the SDK version 2.2 or
      greater patch version, but do not upgrade to a higher minor version number.

2. Clone this repository onto your computer: https://github.com/...

3. In your preferred terminal window, navigate into Hangman.Solutions/Hangman using cd (i.e. cd
   desktop/Hangman.Solutions/Hangman) and open the project with your preferred code editor.
4. Run the following terminal command: $ dotnet restore

5. To initiate this terminal program, run the command: $ dotnet run

6. To run the test suite included with this project, within the terminal navigate into Hangman.Tests and run the following commands:
  * $ dotnet restore
  * $ dotnet test

## Specs

Behavior|Input|Output
------|------|------
The program will initiate a game of hangman|User clicks new game|Begin game
The program will retrieve a random word from the database|on game start|'some word'
The program will display the blanked out word to the user|'airplane'|_ _ _ _ _ _ _
The program will allow the user to guess a letter|a|a
The program will determine whether input is correct|a|correct
The program will display correct answer|a|a _ _ _ _ _ _
The program will display incorrect answer|b|guesses:3 -> guesses:2
The program will determine whether game has been won or lost|guesses:0|Game over

## Known Bugs

_None currently known_

## Support and contact details

_Reach out through GitHub_

## Technologies Used

_C#, .NET, SQL, ASP.NET_

### License

*MIT License*

Copyright (c) 2020 **_Ben White & Micheal Hansen_**