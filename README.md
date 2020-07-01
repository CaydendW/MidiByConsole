# MidiByConsole
A console app that plays music

The app uses Console.Beep to play notes. It was original just meant ot be inside my WhiteDOS project but I thought it was worthy of it's own project.

The app accept arguements in the following way: 
* Each letter plays it's own note. E.G: a, plays a; b, plays b; etc.
* Capitalizing the letter makes it go 1 octave up. E.G: a is low a. A is high a.
* After every letter it must get a - with a number on the end to denote time in miliseconds. E.G: A-200 plays a for 200 miliseconds.
* _ is a rest command. It too has to be followed by a - to denote time in miliseconds.
* Wraping the letter in brackets () makes it have a special note. Cases and length still apply. Special notes are:
  1. C# (c)
  2. Bb (b)
  3. G# (g)
  4. F# (f)
  5. Eb (e)
Those are all the commands.

Here is an example: (F)-1000 play F sharp high for 1000 miliseconds (1 second)

# A simple song
Here is mary had a little lamb in MidiByConsole:

b-500 a-500 g-500 a-500 b-500 b-500 b-1000 a-500 a-500 a-1000 b-500 b-500 b-1000 b-500 a-500 g-500 a-500 b-500 b-500 b-500 b-500 a-500 a-500 b-500 a-500 g-2000

