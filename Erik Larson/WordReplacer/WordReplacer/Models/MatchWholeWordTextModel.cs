using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using WordReplacer.Models.Exceptions;
using WordReplacer.Helper;

namespace WordReplacer.Models
{
    public class MatchWholeWordTextModel : BaseTextModel, IReplaceable
    {
        public MatchWholeWordTextModel(ILoad helper, string text)
        {
            this.helper = helper;
            this.originalText = text;
            this.wordsToReplace = LoadWordsToReplace();

        }
        
        /// <summary>
        /// Replaces text using Matching whole words.
        /// </summary>
        /// <returns>Replaced text</returns>
        public string ReplaceText()
        {
           
            // Console.WriteLine("In ReplaceText() method in MatchWholeWordContentModel.");
            if (string.IsNullOrEmpty(this.originalText) || this.wordsToReplace == null)
            {
                throw new NoDataFoundException("Text content must not be empty!");
            }

            string targetText = this.originalText;
            string pattern = "";

            foreach (KeyValuePair<string, string> kvp in this.wordsToReplace)
            {
                pattern = String.Format(@"\b{0}\b", kvp.Key);
                targetText = Regex.Replace(targetText, pattern, kvp.Value);               
            }
            return targetText;
           
           
        }

       
    }
}
