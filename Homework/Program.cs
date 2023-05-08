using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextManager manager = new TextManager();
            Console.WriteLine("Write the sentence that you want to manage: ");
            manager.LoadSentence(Console.ReadLine());

            string longestWord = manager.GetLongestWord();
            Console.WriteLine("Longest word: " + longestWord);

            string[] allLongestWords = manager.GetAllLongestWords();
            Console.WriteLine("All longest words: " + string.Join(", ", allLongestWords));
        }
    }
}
