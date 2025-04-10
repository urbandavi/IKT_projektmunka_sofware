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
            using (StreamWriter wr = new StreamWriter("file.docx"))
            {
                wr.Write(richTextBox1.Text);
            }
        }

        private void startTextWelperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
