using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordSwapper;

namespace WordSwapperUnitTests {

    [TestClass]
    public class SwapperTests {

        [TestMethod]
        public void SwapWords_OneWord_Swap() {
            // Arrange
            string word = "word";
            string expected = "swapped";
            var swappingDictionary = new Dictionary<string, string> {
                { word, expected }
            };

            // Act
            string actual = Swapper.SwapWords(word, swappingDictionary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SwapWords_MultipleWords_Swap() {
            // Arrange
            string textToAnalyse = "aaa bbb ccc";
            string expected = "ddd eee ccc";
            var swappingDictionary = new Dictionary<string, string> {
                { "aaa", "ddd" },
                { "bbb", "eee" }
            };

            // Act
            string actual = Swapper.SwapWords(textToAnalyse, swappingDictionary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SwapWords_CompundWord_DoNotSwap() {
            // Arrange
            string textToAnalyse = "aaabbb";
            string expected = "aaabbb";
            var swappingDictionary = new Dictionary<string, string> {
                { "aaa", "ccc" }
            };

            // Act
            string actual = Swapper.SwapWords(textToAnalyse, swappingDictionary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SwapWords_CompoundAndNonCompundWords_SwapNonCompoundsWord() {
            // Arrange
            string textToAnalyse = "aaabbb aaa";
            string expected = "aaabbb ccc";
            var swappingDictionary = new Dictionary<string, string> {
                { "aaa", "ccc" }
            };

            // Act
            string actual = Swapper.SwapWords(textToAnalyse, swappingDictionary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SwapWords_UpperCaseWord_Swap() {
            // Arrange
            string textToAnalyse = "Aaa AAA";
            string expected = "bbb bbb";
            var swappingDictionary = new Dictionary<string, string> {
                { "aaa", "bbb" }
            };

            // Act
            string actual = Swapper.SwapWords(textToAnalyse, swappingDictionary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SwapWords_UpperCaseDictionary_Swap() {
            // Arrange
            string textToAnalyse = "aaa aaa";
            string expected = "BBB BBB";
            var swappingDictionary = new Dictionary<string, string> {
                { "AAA", "BBB" }
            };

            // Act
            string actual = Swapper.SwapWords(textToAnalyse, swappingDictionary);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }

}
