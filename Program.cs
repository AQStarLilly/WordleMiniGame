using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle_Mini_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words =
            {
                "APPLE", "HOUSE", "MOUSE", "TRAIN", "PLANE", "BEACH", "CLOUD", "DREAM",
                "EARTH", "FLAME", "GRAPE", "HEART", "IVORY", "JELLY", "KNIFE", "LEMON",
                "MUSIC", "NIGHT", "OCEAN", "PIANO", "QUEEN", "RIVER", "STORM", "TABLE",
                "VOICE", "WATER", "YOUTH", "ZEBRA", "BREAD", "CHAIR", "DANCE", "EAGLE",
                "FROGS", "GHOST", "HONEY", "JUICE", "KITES", "LIGHT", "MAGIC", "NURSE",
                "OLIVE", "PAPER", "QUIET", "RADIO", "SNAKE", "TIGER", "UNCLE", "WITCH",
                "YACHT", "ZESTY", "BLOOM", "CRISP", "DWARF", "ELBOW", "FLUTE", "GLOVE",
                "HATCH", "IGLOO", "JOKER", "KOALA", "LUNAR", "MANGO", "NOBLE", "OASIS",
                "PLUSH", "QUILT", "ROBOT", "SWIRL", "TULIP", "URBAN", "VENOM", "WALTZ",
                "YUMMY", "BLISS", "CRAVE", "DROOP", "EERIE", "FLAKY", "GIDDY", "HOARD",
                "JAZZY", "KAYAK", "LUCKY", "MOODY", "NERDY", "ONION", "PLUMP", "QUIRK",
                "ROAST", "SPICY", "TROUT", "UNZIP", "VAGUE", "WHISK", "YIELD", "ACORN",
                "BROOM", "CLOWN", "DAISY", "FROST", "GREEN", "HAPPY", "JUMBO", "MELON",
                "NORTH", "PEACH", "QUICK", "SUNNY", "THUMB", "WAGON", "ARCHS", "SCARS",
                "ARROW", "MARIO", "LUIGI", "UNITY", "YOSHI", "SHELL", "GREEN", "LANDS",
                "CLASS", "SMITE", "SHIFT", "ENTER", "DANCE", "NOTES", "QUEEN", "GAMES"
            };
            //initializes the random word array and selects a secret word                        
            Random rnd = new Random();
            int randomWordIndex = rnd.Next(0, words.Length);
            string secretWord = words[randomWordIndex];
            int attempts = 1;

            while (true)
            {
                //starts the game asking user to choose a word then responds depending on what word was chosen
                Console.WriteLine("Guess a 5 Letter Word " + secretWord);
                //converts your word to upper case if you typed it in lower case
                string input = Console.ReadLine().ToUpper();
                //if the word user chooses is not 5 digits it will stop you and let you know
                if (input.Length != 5)
                {
                    Console.WriteLine("This word doesn't have 5 letters");
                }
                else
                {
                    //if secret word is guessed, outputs that you've got it
                    if (input == secretWord)
                    {
                        Console.WriteLine($"You Got it in {attempts}!");
                        break;
                    }
                    else
                    {
                        //starts the correction process and will tell you if a letter is correct    
                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            if (secretWord[i] == input[i])
                            {
                                Console.WriteLine(input[i]);
                            }
                            else if (secretWord.Contains(input[i]))
                            {
                                Console.WriteLine("~");
                            }
                            else
                            {
                                Console.WriteLine("#");
                            }
                        }
                        Console.WriteLine("Guess Again");
                    }
                }
                attempts++;
            }
            Console.ReadLine();

        }

    }
}