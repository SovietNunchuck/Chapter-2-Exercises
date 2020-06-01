using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            //string[] fragments = sentence.ToLower().Split(' ');

            Console.WriteLine("Please enter a term for which to search:");
            string query = Console.ReadLine().ToLower();
            //int index = Array.IndexOf(fragments, query);
            int index = sentence.ToLower().IndexOf(query);

            if (index > -1)
            {
                //THE NEXT TWO LINES WERE MY FIRST ATTEMPT THAT DID NOT WORK.  THE ASSOCIATED VARIABLES ARE COMMENTED OUT ABOVE. I'M KEEPING THEM HERE FOR LEARNING PURPOSES.
                //string[] newSentenceFragments = sentence.ToLower().Split(query);
                //string newSentence = string.Join("", newSentenceFragments);
                string newSentence = (sentence.Substring(0, index) + sentence.Substring((index + query.Length)));
                Console.WriteLine("Success.\nIndex of query: " + index + "\nLength of query: " + query.Length);
                Console.WriteLine("New sentence without queried word:\n" + newSentence);
            }
            else
            {
                Console.WriteLine("Query returned 0 search results.");
            }

        }
    }
}
