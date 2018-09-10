using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordSwapper {

    /// <summary>
    /// Class for handling the swapping of words from a specified dictionary
    /// </summary>
    public class Swapper {

        /// <summary>
        /// Swap the specified words in the specified text.
        /// </summary>
        /// <remarks>Matching case is ignored, but words are swapped using the case in the dictionary.</remarks>
        /// <param name="textToAnalyse">The text to swap words in</param>
        /// <param name="words">The words and their replacements</param>
        /// <returns>The text with swapped words</returns>
        public static string SwapWords(string textToAnalyse, Dictionary<string, string> words) {
            string text = textToAnalyse;
            foreach (var word in words) {
                text = Regex.Replace(text, $@"\b{word.Key}\b", word.Value, RegexOptions.IgnoreCase);
            }
            return text;
        }

    }

}
