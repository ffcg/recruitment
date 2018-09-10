using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace WordSwapper {

    public class Program {

        public static void PrintHelpMessage() {
            Console.WriteLine("WordSwapper");
            Console.WriteLine("The program takes two arguments:");
            Console.WriteLine("1. The path to the file that will have words swapped");
            Console.WriteLine("2. The path to the file that contains the dictionary of words that should be swapped and their replacements");
            Console.WriteLine("The dictionary is a file with format: <word to be swapped>, <the word replacing> new line.");
            Console.WriteLine("The result is outputted to console, to save to file use e.g. text dict > output");
        }

        public static void Main(string[] args) {
            if (args == null || args.Length != 2) {
                PrintHelpMessage();
                return;
            }

            // Open the file that should have words swapped
            string pathTextToWordSwap = args[0];
            string textToWordSwap;
            try {
                textToWordSwap = File.ReadAllText(pathTextToWordSwap, Encoding.UTF8);
            } catch (Exception e) {
                Console.WriteLine($"Failed to read file that will have words swapped: {e}");
                PrintHelpMessage();
                return;
            }

            // Read and parse the file contaning the words to be swapped and the words that should replace them into a dictionary
            // If the dictionary contains empty words/whitespaces they are not used in the swapping and are added in another dictionary
            string pathDictionary = args[1];
            Dictionary<string, string> swappingDictionary;
            Dictionary<string, string> invalidWords;
            try {
                string[] lines = File.ReadAllLines(pathDictionary, Encoding.UTF8);
                swappingDictionary = Utils.GetSwapDictionary(lines, out invalidWords);
            } catch (Exception e) {
                Console.WriteLine($"Failed to read dictionary of words: {e}");
                PrintHelpMessage();
                return;
            }

            // Present invalid words not used in the swapping
            if (invalidWords.Count != 0) {
                Console.WriteLine("Unable to use whitspace as word in the dictionary. The following word(s) has not been swapped/swapped to:");
                invalidWords.ToList().ForEach(x => Console.WriteLine($"Word to Swap: '{x.Key}', replacement word: '{x.Value}' "));
                Console.WriteLine(Environment.NewLine);
            }

            // Swap
            Console.WriteLine(Swapper.SwapWords(textToWordSwap, swappingDictionary));
        }

    }

}
