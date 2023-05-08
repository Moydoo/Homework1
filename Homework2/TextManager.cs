using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class TextManager
    {
        public string FindLongestWord(string sentence)
        {

            string[] words = sentence.Split(' ');
            if (sentence.Length < 1 || words.Length < 1)
                throw new Exception("Your sentence is too short");

            string currentLongest = string.Empty;

            foreach (string word in words)
            {
                if (word.Length > currentLongest.Length)
                    currentLongest = word;
            }
            return currentLongest;
        }

        public string[] FindAllLongestWords(string sentence)
        {
            string longest = FindLongestWord(sentence);
            return FindWordsOfGivenLength(longest.Length, sentence);

        }

        private string[] FindWordsOfGivenLength(int length, string sentence)
        {
            var foundWords = new List<string>();
            foreach (var word in sentence.Split(' '))
            {
                if (word.Length == length)
                    foundWords.Add(word);

            }
            return foundWords.ToArray();
        }
    }
}
