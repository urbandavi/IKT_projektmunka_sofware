﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

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
            saveFileDialog1.Title = "Fájl mentése";
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.DefaultExt = "rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }
        


        
        //megnyitás
        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Fájl megnyitása";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Rich Text Format(*.rtf)| *.rtf | Text Files(*.txt) | *.txt | All Files(*.*) | *.* ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }
        //kilépés
        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           this.Close();
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
        private void másolásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //beillesztés
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void beillesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        //kivágás
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void kivágásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        //visszalépés
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        private void visszavonásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }
        //újralépés
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void ktgukjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        //összes kijelölése
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        private void összesKijelöléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        //betütipusválasztó
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
                richTextBox1.SelectionFont = selectedFont;
            }
        }
        private void betűstílusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog1.Font;
            }
        }

        //betűszín választás
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            { 
                Color selectedColor = colorDialog1.Color;
                richTextBox1.SelectionColor = selectedColor;
                
            }
        }
        private void betűszínToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog1.Color;
                richTextBox1.SelectionColor = selectedColor;
                
            }
        }

        private void háttérToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog2.Color;
                richTextBox1.SelectionBackColor = selectedColor;
            }
        }
        private void startTextWelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Text Welper jelenleg nem eléhető!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(5000);
            this.Cursor = Cursors.Default;
            MessageBox.Show("Váratlan hiba történt! A Text Welper nem tudott megfelelően elindulni.", "Hiba" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Thread.Sleep(60000 * 5);
            DialogResult result = MessageBox.Show("A fájlok másolása sikeresen megtörtént! folytatni kívánja?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) 
            this.Cursor = Cursors.WaitCursor;
            Thread.Sleep(10000);
            this.Cursor = Cursors.Default;
            Process.Start("cmd.exe");*/
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog2.Color;
                richTextBox1.SelectionBackColor = selectedColor;
            }
        }

        private void onlineSúgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Az online súgól jelenleg nem eléhető!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textWelperSúgóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A súgó használatához először indítsa el a Text Welpert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textWelperSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A beállítások használatához először indítsa el a Text Welpert!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menüIkonokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.flaticon.com/");
        
        }
    }
}
