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

        private void startTextWelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

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
    }
}
