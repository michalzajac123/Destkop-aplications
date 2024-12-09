using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trojkaty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wys = int.Parse(textBox1.Text);
            label1.Text = "";

            label2.Text = "";

            for (int i = 1; i <= wys; i++)
            {
                for (int j = 1; j <= wys - i; j++)
                {
                    label1.Text+=(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    label1.Text += ("*");
                }

                label1.Text += "\n";
            }

            for (int i = 1; i <= wys; i++)
            {
                // Pętla do dodawania gwiazdek
                for (int j = 1; j <= i; j++)
                {

                    label2.Text += ("*");
                }

                // Przejście do nowego wiersza po każdej iteracji

                label2.Text += ("\n");
            }
        }
    }
}
