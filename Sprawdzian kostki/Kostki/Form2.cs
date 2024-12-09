using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostki
{
    public partial class Form2 : Form
    {
        public Form2(int sum)
        {
            InitializeComponent();
            resultLabel.Text = "Aktuwalny Wynik: " + sum;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
