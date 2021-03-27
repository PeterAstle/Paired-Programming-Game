# Paired-Programming-Game

Simple Hangman inspired game created by Peter Astle and Jerome Dawn 

User Instructions: In order to get the library of words to be usable, each user must change the file path within the code to direct to the correct file location. This is quite simple and also allows for you, the user, to adapt the library to be any 50 words which you select! To accomplish this please follow these simple steps:

1. Open the PairedProgrammingGame.sln file within the PairedProgrammingGame folder you have downloaded. 
2. Locate and open the RandomWordGenerator.cs file, which contains our random word generator function. 
3. Go to line 17 of this class which should read look like the line below:

string filepath = @"D:\Peter\ElevenFiftyProjects\Game.txt"; 

4. Replace the text contained within the quotes with the location of your Game.txt file. 
5. Save the RandomWordGenerator.cs file to ensure we are going to look in the correct place for our words. 
6. Play the game and enjoy!!! 

***If you wish to change the library of words to choose from just replace the words within your Game.txt file with 50 words of your choosing. Ensure each word has a space " " between them, as we will use this space when we split up the contents of the file into distinct words.***
