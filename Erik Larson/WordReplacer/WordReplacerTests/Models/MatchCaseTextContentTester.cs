using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using WordReplacer.Models;
using WordReplacer.Helper;



namespace WordReplacerTests.Model
{
    [TestFixture]
    public class MatchCaseTextContentTester
    {
        private Dictionary<string, string> wordsToReplace;
        private Dictionary<string, string> wordsToReplaceWrongCase;
        private string origText = "";
     

        [SetUp]
        public void Setup()
        {
            origText = "Det är vanligt att den största delen av IT-budgeten går åt till underhåll, och inte till efterlängtade nyinvesteringar. Men om applikationerna utvecklades på rätt sätt skulle det kunna vara annorlunda. Att bygga för framtiden handlar därför om att se såväl helheten i hur applikationerna samverkar, som detaljerna i det enskilda systemet och hur dessa stödjer verksamhetens behov. Företaget erbjuder systemutvecklingskompetens inom de plattformar som tillhandahålls av Microsoft, EPiServer, Oracle och SAP. Med vår kompetens inom Digital Transformation och UX skapar vi bra och användarvänliga system som kan anpassas efter förändrade behov. När projektet lämpar sig för offshoreutveckling kan vi, genom vårt koncept offshore, erbjuda kostnadseffektiva lösningar där delar av insatsen förläggs till China under ledning av erfarna projektledare på våra kontor i Sverige. Alldeles oavsett om utvecklingen sköts här eller där, arbetar vi med samma höga kvalitetskrav och samma närhet till kunden.";

            wordsToReplace = new Dictionary<string, string>();
            wordsToReplace.Add("Företaget", "Forefront");
            wordsToReplace.Add("applikationerna", "systemen");
            wordsToReplace.Add("annorlunda", "tvärtom");
            wordsToReplace.Add("bra", "flexibla");
            wordsToReplace.Add("offshore", "Frontshore");
            wordsToReplace.Add("China", "Kina");

            wordsToReplaceWrongCase = new Dictionary<string, string>();
            wordsToReplaceWrongCase.Add("företaget", "Forefront");

        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void MatchCaseReplaceTextContentTest()
        {
            string targetText = "Det är vanligt att den största delen av IT-budgeten går åt till underhåll, och inte till efterlängtade nyinvesteringar. Men om systemen utvecklades på rätt sätt skulle det kunna vara tvärtom. Att bygga för framtiden handlar därför om att se såväl helheten i hur systemen samverkar, som detaljerna i det enskilda systemet och hur dessa stödjer verksamhetens behov. Forefront erbjuder systemutvecklingskompetens inom de plattformar som tillhandahålls av Microsoft, EPiServer, Oracle och SAP. Med vår kompetens inom Digital Transformation och UX skapar vi flexibla och användarvänliga system som kan anpassas efter förändrade behov. När projektet lämpar sig för Frontshoreutveckling kan vi, genom vårt koncept Frontshore, erbjuda kostnadseffektiva lösningar där delar av insatsen förläggs till Kina under ledning av erfarna projektledare på våra kontor i Sverige. Alldeles oavsett om utvecklingen sköts här eller där, arbetar vi med samma höga kvalitetskrav och samma närhet till kunden.";

            Mock<ILoad> helper = new Mock<ILoad>();
            helper.Setup(m => m.LoadWordsToReplace()).Returns(wordsToReplace);

            IReplaceable textModel = new MatchCaseTextModel(helper.Object, origText);

            string replacedText = textModel.ReplaceText();

            Assert.AreEqual(targetText, replacedText);
        }

        [Test]
        public void MatchCaseReplaceTextContentWithWrongCaseTest()
        {
            Mock<ILoad> helper = new Mock<ILoad>();
            helper.Setup(m => m.LoadWordsToReplace()).Returns(wordsToReplaceWrongCase);

            IReplaceable textModel = new MatchCaseTextModel(helper.Object, origText);

            string replacedText = textModel.ReplaceText();
            
            Assert.IsTrue(replacedText.Contains("Företaget"));
        }
    }
}