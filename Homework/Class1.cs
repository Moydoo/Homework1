using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class TextManager
    {
        private string sentence;

        public void LoadSentence(string input)
        {
            sentence = input;
        }

        public string GetLongestWord()
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentException("Input sentence cannot be null or empty.");
            }

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                throw new ArgumentException("Input sentence does not contain any words.");
            }

            string longestWord = words.OrderByDescending(w => w.Length).First();
            return longestWord;
        }

        public string[] GetAllLongestWords()
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentException("Input sentence cannot be null or empty.");
            }

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                throw new ArgumentException("Input sentence does not contain any words.");
            }

            int maxLength = words.Max(w => w.Length);
            string[] longestWords = words.Where(w => w.Length == maxLength).ToArray();
            return longestWords;
        }
    }
}
