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

namespace notatnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FileName;
        private void saveAsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                try
                {
                    File.WriteAllText(filePath,textBox1.Text.ToString());
                    MessageBox.Show("Zapis przebiegł pomyslnie");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd przy zapise pliku: " + ex.Message);
                }
            }

        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                FileName = filePath;
                pathToFileLabel.Text = filePath;
                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    textBox1.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd przy otwarciu pliku: " + ex.Message);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfd.FileName;
                try
                {
                    File.Delete(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd przy zapise pliku: " + ex.Message);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string textToSave = textBox1.Text;

            using (StreamWriter writer= new StreamWriter(FileName))
            {
                writer.WriteLine(textToSave);
            }
        }

        private void createNewFileButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
