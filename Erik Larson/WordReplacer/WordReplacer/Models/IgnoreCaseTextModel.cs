using System.Collections.Generic;
using System.Text.RegularExpressions;
using WordReplacer.Models.Exceptions;
using WordReplacer.Helper;

namespace WordReplacer.Models
{
    public class IgnoreCaseTextModel : BaseTextModel, IReplaceable 
    {
        public IgnoreCaseTextModel(ILoad helper, string text)
        {
            this.helper = helper;
            this.originalText = text;
            this.wordsToReplace = LoadWordsToReplace();            
        }

        /// <summary>
        /// Replaces text using IgnoreCase.
        /// </summary>
        /// <returns>Replaced text</returns>
        public string ReplaceText()
        {
            //Console.WriteLine("In ReplaceText() method in BaseTextContentModel.");

           
            if (string.IsNullOrEmpty(this.originalText) || this.wordsToReplace == null)
            {
                throw new NoDataFoundException("Text content must not be empty!");
            }

            string targetText = this.originalText;

            foreach (KeyValuePair<string, string> kvp in this.wordsToReplace)
            {
                targetText = Regex.Replace(targetText, kvp.Key, kvp.Value, RegexOptions.IgnoreCase);
            }

            return targetText;
         
        }
    }
}
