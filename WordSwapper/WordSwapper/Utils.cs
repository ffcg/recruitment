using System.Collections.Generic;

namespace WordSwapper {

    public class Utils {

        /// <summary>
        /// Handle the parsing of the lines of a dictionary file to a dictionary.
        /// </summary>
        /// <param name="lines">The lines of the dictionary file (format for each line: "word to be swapped, the word replacing")</param>
        /// <param name="invalidWords">A dictionary of unaccepted words (e.g. words containing only whitespaces) that were ignored</param>
        /// <returns>A dictionary containing the words to swap and their replacements</returns>
        public static Dictionary<string, string> GetSwapDictionary(string[] lines, out Dictionary<string, string> invalidWords) {
            invalidWords = new Dictionary<string, string>();
            var dictionary = new Dictionary<string, string>();

            foreach (string line in lines) {
                string[] words = line.Split(',');
                string wordToSwap = words[0].Trim();
                string replacementWord = words[1].Trim();

                if (!string.IsNullOrWhiteSpace(wordToSwap) && !string.IsNullOrWhiteSpace(replacementWord)) {
                    dictionary.Add(wordToSwap, replacementWord);
                } else {
                    invalidWords.Add(wordToSwap, replacementWord);
                }
            }
            return dictionary;
        }

    }

}
