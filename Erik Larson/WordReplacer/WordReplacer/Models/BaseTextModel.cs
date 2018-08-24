using System.Collections.Generic;
using WordReplacer.Helper;



namespace WordReplacer.Models
{
    public abstract class BaseTextModel
    {
        protected ILoad helper { get; set; }

        /// <summary>
        /// Holds the text in which words should be replaced
        /// </summary>
        public string originalText { get; set; }

        public Dictionary<string, string> wordsToReplace { get; set; }

        public virtual Dictionary<string, string> LoadWordsToReplace()
        {
            return helper.LoadWordsToReplace();          
        }         
    }
}
