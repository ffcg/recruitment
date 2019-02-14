using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Forefront_test_form;

namespace Forefront_test.UnitTests
{
    [TestClass]
    public class StringManipulatorTests
    {
        [TestMethod]
        public void ReplaceWords_StrDictIsNotNull_ReturnsTrue()
        {
            string testStr = "This is a test";
            var testDict = new Dictionary<string, string>() { { "test", "hest" } };
            var sm = new StringManipulator();

            var result = sm.ReplaceWords(testStr, testDict);

            Assert.IsNotNull(result);
        }
    }
}
