/// <summary>
/// app Made by Noodle Dev
/// PINK NOTES MAIN
/// </summary>
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinkNotes
{
    #region Class
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Shortcut Strip
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //New Data
            Form1 n = new Form1();
            n.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
           {
                //Load Data
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
           }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Save data 
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
            }
        }
        #endregion
        #region ShortCut Buttons
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                GC.Collect();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form1 n = new Form1();
            n.Show();
        }
        #endregion
        #region Tools Strip
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        #endregion
        #region Tools Buttons 
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            //Paste with the button
            richTextBox1.Paste();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //Change Font
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Change color
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }
        #endregion
        #region Credits
        private void sourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the Source Code Page
            Process.Start("http://www.google.com/");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open the creator youtube page
            Process.Start("https://www.youtube.com/channel/UCmpha1AJt9zzY2fuAgSWwUQ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
#endregion
