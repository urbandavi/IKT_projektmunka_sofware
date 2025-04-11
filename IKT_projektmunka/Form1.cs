using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKT_projektmunka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void openTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //mentés
        private void mentésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Szöveges fájl (*.txt)|*.txt|Rich Text File (*.rtf)|*.rtf|Minden fájl (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.DefaultExt = "rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, "Mentett szöveg");
            }
        }
        private void mentésMáskéntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Minden fájl (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, "Mentett szöveg");
            }
        }


        
        //megnyitás
        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Fájl megnyitása";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Szöveges fájlok (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
        //kilépés
        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
        private void startTextWelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //betütipusválasztó
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
            }
        }
        private void betűstílusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
            }
        }
        //összes törlése
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //másolás
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //beillesztés
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //kivágás
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //visszalépés
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //újralépés
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }


        //betűszín választás
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                Color selectedColor = colorDialog1.Color;
                
            }
        }
        private void betűszínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;

            }
        }

        //összes kijelölése
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

    }
}
