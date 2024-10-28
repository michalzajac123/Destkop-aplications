using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_w_okienkach
{
    public partial class Form2 : Form
    {
        public Form2 (int num1, int num2)
        {
            InitializeComponent();
            int suma = num1+num2;
            label1.Text = "Suma rowna sie " + suma;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
