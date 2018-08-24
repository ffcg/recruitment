using System;
using WordReplacer.Models;
using WordReplacer.Helper;


namespace WordReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalTextText = "Det är vanligt att den största delen av IT-budgeten går åt till underhåll, och inte till efterlängtade nyinvesteringar. Men om applikationerna utvecklades på rätt sätt skulle det kunna vara annorlunda. Att bygga för framtiden handlar därför om att se såväl helheten i hur applikationerna samverkar, som detaljerna i det enskilda systemet och hur dessa stödjer verksamhetens behov.\n\r Företaget erbjuder systemutvecklingskompetens inom de plattformar som tillhandahålls av Microsoft, EPiServer, Oracle och SAP.Med vår kompetens inom Digital Transformation och UX skapar vi bra och användarvänliga system som kan anpassas efter förändrade behov.När projektet lämpar sig för offshoreutveckling kan vi, genom vårt koncept offshore, erbjuda kostnadseffektiva lösningar där delar av insatsen förläggs till China under ledning av erfarna projektledare på våra kontor i Sverige. Alldeles oavsett om utvecklingen sköts här eller där, arbetar vi med samma höga kvalitetskrav och samma närhet till kunden.";

            try
            {
                //In order to load the words from a different source, use a different implementation of ILoad interface.
                ILoad loadHelper = new SettingsHelper();
                IReplaceable textContent = new MatchCaseTextModel(loadHelper, originalTextText);
                
                string replacedText = textContent.ReplaceText();

                Console.WriteLine();
                Console.WriteLine("***** ORIGINAL TEXT *****");
                Console.WriteLine();
                Console.WriteLine(originalTextText);

                Console.WriteLine();
                Console.WriteLine("***** REPLACED TEXT *****");
                Console.WriteLine();
                Console.WriteLine(replacedText);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to replace text. Reason: " + ex.Message);
            }       
                     
            Console.ReadLine();
            
        }
      
    }
}
