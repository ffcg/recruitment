using SwapWords;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReplaceWords
{
    public class WordReplacer
    {
        /// <summary>
        /// Replace each specific word from the given list using regular expression.
        /// </summary>
        /// <param name="WordList">List that contains all word that will be repleaced</param>
        /// <param name="TextToRepleace">The text that will modified</param>
        /// <returns>The text that has been modified</returns>
        static public string ReplaceWord(List<WordDictionary> WordList, string TextToRepleace)
        {
            var text = TextToRepleace;

            foreach (var dict in WordList)
            {
                text = Regex.Replace(text, @"\b" + dict.oldWord + @"\b", dict.newWord, RegexOptions.IgnoreCase);
            }

            return text;
        }
    }
}
