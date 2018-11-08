using System;

namespace SwapWords
{
    public class WordDictionary
    {
        public string oldWord { get; set; }
        public string newWord { get; set; }

        /// <summary>
        /// Parse the csvfile-line to a dictionary.
        /// </summary>
        /// <param name="csvLine">Comma separated line</param>
        /// <returns>Dictionary item containg the word thats going to be replace and the new word that will be shown instead</returns>
        public static WordDictionary FromCsv(string csvLine)
        {
            WordDictionary dictionary = new WordDictionary();
            try
            {
                string[] values = csvLine.Split(',');
                dictionary.oldWord = values[0].Trim();
                dictionary.newWord = values[1].Trim();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Something failed when parsing the words: {0}", ex.Message));
            }
            return dictionary;
        }
    }
}
