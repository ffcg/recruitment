using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forefront_test_form
{
    public class StringManipulator
    {
        public StringManipulator()
        {
        }

        // Replace words from dictionary in given string
        public string ReplaceWords(string str, Dictionary<string, string> dict)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException();
            }
            else
            {
                var replacedStr = dict.Aggregate(str, (cur, val) => cur.Replace(val.Key, val.Value));
                return replacedStr;
            }
        }
        
        // Add words to dictionary
        public void AddToDict(string word, string wordReplacer, Dictionary<string, string> dict)
        {
            if(String.IsNullOrEmpty(word) || String.IsNullOrEmpty(wordReplacer))
            {
                throw new ArgumentNullException();
            }
            else
            {
                dict.Add(word, wordReplacer);
            }
        }
    }
}
