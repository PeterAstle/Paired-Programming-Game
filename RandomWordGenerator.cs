using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgrammingGame
{
    public class RandomWordGenerator
    {
        private static int MaxWordCount = 50;
        private static List<string> AccumulateWords()
        {
            //User will need to be updated by user with correct file path to their disired dictionary of words. Words will need to have a " " in between them for success

            string filepath = @"D:\Peter\ElevenFiftyProjects\Game.txt"; 
            List<string> output = File.ReadAllLines(filepath).ToList();

            List<string> wordDictionary = new List<string>();
            string[] entries = new string[100];

            foreach (string item in output)
            {
                //Console.WriteLine(item);
                entries = item.Split(' ');

                wordDictionary.Add(item);
            }
            return wordDictionary;
        }


        public static string GiveMeRandomWord()
        {
            List<string> words = AccumulateWords();
            System.Threading.Thread.Sleep(175);
            Random rnd = new Random();
            int numberselection = rnd.Next(0, MaxWordCount);
            for (int i = 0; i < words.Count; i++)
            {
                return words[numberselection];
            }
            return null;


        }

    }
}
