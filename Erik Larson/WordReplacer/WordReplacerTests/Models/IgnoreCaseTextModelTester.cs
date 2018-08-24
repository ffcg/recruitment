using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using WordReplacer.Models;
using WordReplacer.Models.Exceptions;
using WordReplacer.Helper;



namespace WordReplacerTests.Model
{
    [TestFixture]
    public class IgnoreCaseTextModelTester
    {        
        private Dictionary<string, string> wordsToReplace;
        private Dictionary<string, string> emptyWordsToReplace;
        private string origText = "";
        private string emptyOrigText = "";

        [SetUp]
        public void Setup()
        {
            origText = "Det är vanligt att den största delen av IT-budgeten går åt till underhåll, och inte till efterlängtade nyinvesteringar. Men om applikationerna utvecklades på rätt sätt skulle det kunna vara annorlunda. Att bygga för framtiden handlar därför om att se såväl helheten i hur applikationerna samverkar, som detaljerna i det enskilda systemet och hur dessa stödjer verksamhetens behov. Företaget erbjuder systemutvecklingskompetens inom de plattformar som tillhandahålls av Microsoft, EPiServer, Oracle och SAP. Med vår kompetens inom Digital Transformation och UX skapar vi bra och användarvänliga system som kan anpassas efter förändrade behov. När projektet lämpar sig för offshoreutveckling kan vi, genom vårt koncept offshore, erbjuda kostnadseffektiva lösningar där delar av insatsen förläggs till China under ledning av erfarna projektledare på våra kontor i Sverige. Alldeles oavsett om utvecklingen sköts här eller där, arbetar vi med samma höga kvalitetskrav och samma närhet till kunden.";
            emptyWordsToReplace = new Dictionary<string, string>();
            wordsToReplace = new Dictionary<string, string>(); 
            wordsToReplace.Add("företaget", "Forefront");
            
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void IgnoreCaseTextModelTest()
        {            
            Mock<ILoad> helper = new Mock<ILoad>();
            helper.Setup(m => m.LoadWordsToReplace()).Returns(wordsToReplace);

            IReplaceable textModel = new IgnoreCaseTextModel(helper.Object, origText);

            string replacedText = textModel.ReplaceText();

            Assert.IsFalse(replacedText.Contains("Företaget"));
        }



        [Test]
        public void ReplaceWithEmptyDataTest()
        {
            Mock<ILoad> helper = new Mock<ILoad>();
            helper.Setup(m => m.LoadWordsToReplace()).Returns(emptyWordsToReplace);

            IReplaceable textModel = new IgnoreCaseTextModel(helper.Object, emptyOrigText);

            Assert.Throws<NoDataFoundException>(() => textModel.ReplaceText());
        }

      

    }
}