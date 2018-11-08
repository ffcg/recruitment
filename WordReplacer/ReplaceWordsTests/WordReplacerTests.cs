using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceWords;
using SwapWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWords.Tests
{
    [TestClass()]
    public class WordReplacerTests
    {
        [TestMethod()]
        public void ReplaceWordTest()
        {
            string text = "old";
            string repleaceWord = "new";

            var wordList = new List<WordDictionary>();
            wordList.Add(new WordDictionary
            {
                oldWord = text,
                newWord = repleaceWord
            });

            string repleacedText = WordReplacer.ReplaceWord(wordList, repleaceWord);

            Assert.AreEqual(repleaceWord, repleacedText);
        }

        [TestMethod()]
        public void ReplaceWordCasingTest()
        {
            string text = "OLD old";
            string repleaceWord = "new new";

            var wordList = new List<WordDictionary>();
            wordList.Add(new WordDictionary
            {
                oldWord = "old",
                newWord = "new"
            });

            var replacedText = WordReplacer.ReplaceWord(wordList, text);

            Assert.AreEqual(repleaceWord, replacedText);
        }
    }
}