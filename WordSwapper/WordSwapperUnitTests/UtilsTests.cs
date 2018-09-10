using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordSwapper;

namespace WordSwapperUnitTests {

    [TestClass]
    public class UtilsTests {

        [TestMethod]
        public void GetSwapDictionary_SeparateWordOnComma_ProperDictionary() {
            // Arrange
            string[] listOFWords = { "aaa, bbb" };
            var expected = new Dictionary<string, string> {
                { "aaa", "bbb" }
            };
            var invalidWords = new Dictionary<string, string>();

            // Act
            var actual = Utils.GetSwapDictionary(listOFWords, out invalidWords);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSwapDictionary_SeparateWordsOnCommaAndNewLine_ProperDictionary() {
            // Arrange
            string[] listOFWords = { "aaa, bbb", "ccc, ddd", "eee, fff" };
            var expected = new Dictionary<string, string> {
                { "aaa", "bbb" },
                { "ccc", "ddd" },
                { "eee", "fff" }
            };
            var invalidWords = new Dictionary<string, string>();

            // Act
            var actual = Utils.GetSwapDictionary(listOFWords, out invalidWords);

            // Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetSwapDictionary_InvalidWordsAsInput_NotAddedToDictionaryButAddedToInvalidWords() {
            // Arrange
            string[] listOFWords = { "aaa, bbb", ", ddd", "eee, ", " ggg, hhh " };
            var expected = new Dictionary<string, string> {
                { "aaa", "bbb" },
                { "ggg", "hhh" }
            };
            var expectedInvalidWords = new Dictionary<string, string>() {
                { "", "ddd" },
                { "eee", "" }
            };

            // Act
            var actualInvalidWords = new Dictionary<string, string>();
            var actual = Utils.GetSwapDictionary(listOFWords, out actualInvalidWords);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
            CollectionAssert.AreEqual(expectedInvalidWords, actualInvalidWords);
        }

    }

}
