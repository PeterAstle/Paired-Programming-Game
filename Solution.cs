using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgrammingGame
{
    public class Solution
    {
        private string _word = RandomWordGenerator.GiveMeRandomWord();
        public string Word 
        {
            get 
            {
                return _word;
            }
            set 
            {
                _word=value;
            }
        }

        public int Guesses { get; set; } = 10;

        public List<char> WordCharacters
        {
            get
            {
                List<char> letterholder = new List<char>();

                foreach (char character in Word)
                {
                    letterholder.Add(character);
                }

                return letterholder;


            }

        }

        public Solution() { }

    }
}
