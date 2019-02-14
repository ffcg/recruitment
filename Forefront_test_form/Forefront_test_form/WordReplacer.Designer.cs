namespace Forefront_test_form
{
    partial class WordReplacer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWordReplacer = new System.Windows.Forms.Label();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonAddToWordList = new System.Windows.Forms.Button();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.labelWordList = new System.Windows.Forms.Label();
            this.labelReplace = new System.Windows.Forms.Label();
            this.labelReplaceWith = new System.Windows.Forms.Label();
            this.textBoxReplaceWith = new System.Windows.Forms.TextBox();
            this.listBoxWordDict = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelWordReplacer
            // 
            this.labelWordReplacer.AutoSize = true;
            this.labelWordReplacer.Location = new System.Drawing.Point(70, 45);
            this.labelWordReplacer.Name = "labelWordReplacer";
            this.labelWordReplacer.Size = new System.Drawing.Size(115, 20);
            this.labelWordReplacer.TabIndex = 0;
            this.labelWordReplacer.Text = "Word Replacer";
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Location = new System.Drawing.Point(74, 82);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(617, 460);
            this.richTextBoxText.TabIndex = 1;
            this.richTextBoxText.Text = "";
            this.richTextBoxText.TextChanged += new System.EventHandler(this.richTextBoxText_TextChanged);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(74, 562);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(125, 45);
            this.buttonRun.TabIndex = 2;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonAddToWordList
            // 
            this.buttonAddToWordList.Location = new System.Drawing.Point(733, 562);
            this.buttonAddToWordList.Name = "buttonAddToWordList";
            this.buttonAddToWordList.Size = new System.Drawing.Size(125, 45);
            this.buttonAddToWordList.TabIndex = 5;
            this.buttonAddToWordList.Text = "Add";
            this.buttonAddToWordList.UseVisualStyleBackColor = true;
            this.buttonAddToWordList.Click += new System.EventHandler(this.buttonAddToWordList_Click);
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Location = new System.Drawing.Point(733, 443);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(301, 26);
            this.textBoxReplace.TabIndex = 6;
            // 
            // labelWordList
            // 
            this.labelWordList.AutoSize = true;
            this.labelWordList.Location = new System.Drawing.Point(733, 45);
            this.labelWordList.Name = "labelWordList";
            this.labelWordList.Size = new System.Drawing.Size(70, 20);
            this.labelWordList.TabIndex = 7;
            this.labelWordList.Text = "Word list";
            // 
            // labelReplace
            // 
            this.labelReplace.AutoSize = true;
            this.labelReplace.Location = new System.Drawing.Point(733, 413);
            this.labelReplace.Name = "labelReplace";
            this.labelReplace.Size = new System.Drawing.Size(68, 20);
            this.labelReplace.TabIndex = 8;
            this.labelReplace.Text = "Replace";
            // 
            // labelReplaceWith
            // 
            this.labelReplaceWith.AutoSize = true;
            this.labelReplaceWith.Location = new System.Drawing.Point(733, 486);
            this.labelReplaceWith.Name = "labelReplaceWith";
            this.labelReplaceWith.Size = new System.Drawing.Size(41, 20);
            this.labelReplaceWith.TabIndex = 10;
            this.labelReplaceWith.Text = "With";
            // 
            // textBoxReplaceWith
            // 
            this.textBoxReplaceWith.Location = new System.Drawing.Point(733, 516);
            this.textBoxReplaceWith.Name = "textBoxReplaceWith";
            this.textBoxReplaceWith.Size = new System.Drawing.Size(301, 26);
            this.textBoxReplaceWith.TabIndex = 9;
            // 
            // listBoxWordDict
            // 
            this.listBoxWordDict.FormattingEnabled = true;
            this.listBoxWordDict.ItemHeight = 20;
            this.listBoxWordDict.Location = new System.Drawing.Point(733, 82);
            this.listBoxWordDict.Name = "listBoxWordDict";
            this.listBoxWordDict.Size = new System.Drawing.Size(301, 324);
            this.listBoxWordDict.TabIndex = 12;
            // 
            // WordReplacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1154, 638);
            this.Controls.Add(this.listBoxWordDict);
            this.Controls.Add(this.labelReplaceWith);
            this.Controls.Add(this.textBoxReplaceWith);
            this.Controls.Add(this.labelReplace);
            this.Controls.Add(this.labelWordList);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.buttonAddToWordList);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.labelWordReplacer);
            this.Name = "WordReplacer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWordReplacer;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonAddToWordList;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Label labelWordList;
        private System.Windows.Forms.Label labelReplace;
        private System.Windows.Forms.Label labelReplaceWith;
        private System.Windows.Forms.TextBox textBoxReplaceWith;
        private System.Windows.Forms.ListBox listBoxWordDict;
    }
}

