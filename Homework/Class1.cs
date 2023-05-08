using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class TextManager
    {

        //we can create a private variable that we can access through our Class but not exploit it outside
        private string sentence;

        public void LoadSentence(string input)
        {
            sentence = input;
        }

        //we can not assign the arguments in our Method and then use it as a function .functionName();
        public string GetLongestWord()
        {


            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (sentence.Length < 1 || words.Length < 1)
                throw new Exception("Your sentence is too short");

            //is it working like in JS's arrow functions?
            string longestWord = words.OrderByDescending(w => w.Length).First();
            return longestWord;
        }

        public string[] GetAllLongestWords()
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new Exception("Input sentence cannot be null or empty.");
            }

            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length == 0)
            {
                throw new Exception("Input sentence does not contain any words.");
            }

            int maxLength = words.Max(w => w.Length);
            string[] longestWords = words.Where(w => w.Length == maxLength).ToArray();
            return longestWords;
        }
    }
}
