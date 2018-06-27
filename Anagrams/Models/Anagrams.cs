using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a first word to compare");
            string Word1 = Console.ReadLine();
            Console.WriteLine("Now enter a second word to check if its an anagram of the first ");
            string Word2 = Console.ReadLine();
        }
    }
    public class Words
    {
        public char[] SplitWord(string Word)
        {
            char[] Letters = Word.Split(' ');
            Console.WriteLine(Letters[0]);
            return Letters;
        }
    }


}
