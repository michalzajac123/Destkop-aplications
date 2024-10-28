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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(number1TextBox.Text);
            int number2 = int.Parse(number2TextBox.Text);

            Form2 form2 = new Form2(number1,number2);
            form2.FormClosed += (s, args) => this.Show();
            form2.ShowDialog();
        }
    }
}
