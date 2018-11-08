using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwapWords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWords.Tests
{
    [TestClass()]
    public class WordDictionaryTests
    {
        [TestMethod()]
        public void FromCsvTest()
        {

            var expected = new WordDictionary();
            expected.oldWord = "a";
            expected.newWord = "b";

            var csvLine = "a,b";
            var actual = WordDictionary.FromCsv(csvLine);

            Assert.AreEqual(expected.oldWord, actual.oldWord);
            Assert.AreEqual(expected.newWord, actual.newWord);
        }
    }
}