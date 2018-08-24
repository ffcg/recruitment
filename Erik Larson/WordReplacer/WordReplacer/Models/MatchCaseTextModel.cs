using System.Collections.Generic;
using WordReplacer.Models.Exceptions;
using WordReplacer.Helper;

namespace WordReplacer.Models
{
    public class MatchCaseTextModel : BaseTextModel, IReplaceable
    {

        public MatchCaseTextModel(ILoad helper, string text)
        {
            this.helper = helper;
            this.originalText = text;
            this.wordsToReplace = LoadWordsToReplace();
        }


        /// <summary>
        /// Replaces text using MatchCase.
        /// </summary>
        /// <returns>Replaced text</returns>
        public string ReplaceText()
        {
            //Console.WriteLine("In ReplaceText() method in MatchCaseTextContentModel.");
           
            if (string.IsNullOrEmpty(this.originalText) || this.wordsToReplace == null)
            {
                throw new NoDataFoundException("Text content must not be empty!");
            }
            string targetText = this.originalText;

            foreach (KeyValuePair<string, string> kvp in this.wordsToReplace)
            {
                targetText = targetText.Replace(kvp.Key, kvp.Value);
            }
            return targetText;
           
        }
       
    }
}
