using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstSentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Which term would you like to find?");
            string term = Console.ReadLine();
            term = term.Trim().ToLower();
            firstSentence = firstSentence.ToLower();
            int index = firstSentence.IndexOf(term);
            Console.WriteLine("The index of " + term + " is " + index +". And it's length is " + term.Length + ".");
            string newSentence = firstSentence.Replace(term, "");
            Console.WriteLine(newSentence);
        }
    }
}
