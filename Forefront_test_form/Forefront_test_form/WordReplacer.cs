using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forefront_test_form
{
    public partial class WordReplacer : Form
    {
        StringManipulator stringManipulator;
        //Fetch string from resources.resx
        string txt = Properties.Resources.forefrontTxt;
        Dictionary<string, string> dict = new Dictionary<string, string>() {
                { "Företaget", "Forefront" },
                { "applikationerna", "systemen" },
                { "annorlunda", "tvärtom" },
                { "bra", "flexibla" },
                { "offshore", "Frontshore" },
                { "China", "Kina" }
            };

        public WordReplacer()
        {
            InitializeComponent();

            this.stringManipulator = new StringManipulator();

            FillTextBox(txt);
            FillListBox(dict);
        }

        // Add text to rich text box
        private void FillTextBox(string txt)
        {
            richTextBoxText.Text = txt;
        }

        // Add dictionary items to list box
        private void FillListBox(Dictionary<string, string> dict)
        {
            foreach (var kvp in dict)
            {
                listBoxWordDict.Items.Add(kvp.Key + " is replaced by " + kvp.Value);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBoxDict_TextChanged(object sender, EventArgs e)
        {
        }

        // Run the word replacer
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                string text = richTextBoxText.Text;
                string newStr = stringManipulator.ReplaceWords(text, dict);
                richTextBoxText.Clear();
                FillTextBox(newStr);
            }
            catch (Exception)
            {
                MessageBox.Show("There is no text in text box!");
            }
        }

        //Button that adds input words to dictionary and listbox
        private void buttonAddToWordList_Click(object sender, EventArgs e)
        {
            string replace = textBoxReplace.Text;
            string replaceWith = textBoxReplaceWith.Text;
            try
            {
                stringManipulator.AddToDict(replace, replaceWith, dict);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please enter a word...");
            }
            listBoxWordDict.Items.Clear();
            FillListBox(dict);
            textBoxReplace.Clear();
            textBoxReplaceWith.Clear();
        }
    }
}
