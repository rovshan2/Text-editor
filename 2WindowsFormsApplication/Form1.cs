using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            //OpenFileDialog1.ShowDialog();
            //OpenFileDialog1.Filter = "Text File (.doc)|*.doc";

            //if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader sr = new StreamReader(OpenFileDialog1.FileName);
            //    richTextBox1.Text = sr.ReadToEnd();
            //    sr.Close();
            //}
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            //OpenFileDialog1.ShowDialog();
            //OpenFileDialog1.Filter = "Text File (.doc)|*.doc";

            //if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    StreamReader sr = new StreamReader(OpenFileDialog1.FileName);
            //    richTextBox1.Text = sr.ReadToEnd();
            //    sr.Close();
            //}
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           textBox1.Clear();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            //OpenFileDialog1.Filter = "Text File (.txt)|*.txt";

            //if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string path = openFileDialog1.FileName;
            //    StreamReader sr = new StreamReader(path, Encoding.Default);
            //    textBox1.Text = sr.ReadToEnd();
            //    sr.Close();
            //}


            openFileDialog1.Filter = "Text File (.txt)|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
                
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(openFileDialog1.FileName, false, Encoding.Default);
            //sw.WriteLine(textBox1.Text);
            //sw.Close();

            string path = saveFileDialog1.FileName;
            if (path == "")
                saveAsToolStripMenuItem_Click(saveAsToolStripMenuItem, null);
            else
                SaveToFile(path);
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text File (.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                SaveToFile(path);
                //Text = "Text Editor - " + Path.GetFileName(path);
            }
        }

        private void SaveToFile(string path)
        {
            StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            //textBox1.Modified = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.Show();
        }
        
    }
}
