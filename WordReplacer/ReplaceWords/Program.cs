using SwapWords;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ReplaceWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<WordDictionary> wordList = new List<WordDictionary>(); //New Dictionary List
            var textFile = string.Empty; 

            Console.WriteLine("Pleace enter the path to dictionary with words to be swapped (.csv): ");
            //Reads the path to the file that contains all words.
            string swappedWordsPath = Console.ReadLine();

            try
            {
                //Read all lines from the csv file and then passes each line into
                // Dictionary method FromCsv that will parse the line into a Dictionary item that will be added to the list.
                var wordsFile = File.ReadAllLines(swappedWordsPath, Encoding.UTF8);
                wordList = wordsFile.Select(x => WordDictionary.FromCsv(x)).ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(string.Format("Something failed when reading the file: {0}", ex.Message));
                return;
            }

            Console.WriteLine("Pleace enter the path to the text file where the new words will be added (.txt): ");
            //Reads the path to the file that contains the text.
            string textPath = Console.ReadLine();

            try
            {
                //Reads the text
                textFile = File.ReadAllText(textPath, Encoding.UTF8);
            }
            catch(Exception ex)
            {
                Console.WriteLine(string.Format("Something failed when reading the file: {0}", ex.Message));
            }

            //Passes the wordlist and text file to the method ReplaceWord that will return a string that contains the text
            // with all old words replaced by the new words.
            var replacedText = WordReplacer.ReplaceWord(wordList, textFile);

            Console.WriteLine(replacedText);

            Console.WriteLine("\n\rPress any key to quit");
            Console.ReadLine();
        }
    }
}
