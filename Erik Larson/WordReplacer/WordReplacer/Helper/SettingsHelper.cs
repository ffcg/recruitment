using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using WordReplacer.Models.Exceptions;


namespace WordReplacer.Helper
{

    public interface ILoad
    {
        Dictionary<string, string> LoadWordsToReplace();
    }

    /// <summary>
    /// Helper class to load the words to replace from a 
    /// </summary>
    public class SettingsHelper : ILoad
    {
        public SettingsHelper()
        {            
        }

        public Dictionary<string,string> LoadWordsToReplace()
        {
            Dictionary<string, string> map = null;
            try
            {               
                string path = Directory.GetCurrentDirectory() + @"\WordsToReplace.xml";
                if (File.Exists(path))
                {
                    var xdoc = XDocument.Load(path);
                    map = xdoc.Root.Elements()
                                       .ToDictionary(a => (string)a.Attribute("keyword"),
                                                     a => (string)a.Attribute("replaceWith"));

                }
                else
                {
                    //Log 
                    //"Could not load file WordsToReplace.xml"
                    throw new FileNotFoundException("Unable to load file WordsToReplace.xml");
                }
                return map;

            }
            catch (FileNotFoundException ex)
            {                           
                throw ex;
            }
            catch (Exception ex)
            {
                throw new XMLContentException("Unable to read file WordsToReplace.xml. Exception: " +ex.Message);
                //Log 
                //"Exception in LoadWordsToReplace. Excpetion ex.Message"                
                throw ex;               
            }

            
        }
    }
}
