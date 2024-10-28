using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przekazywanie_imienia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            string message = textBox1.Text;
            Form2 form2 = new Form2(message);
            form2.FormClosed += (s,args) => this.Show();
            form2.ShowDialog();
        }
    }
}
