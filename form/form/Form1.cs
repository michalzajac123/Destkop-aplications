using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool radio1 = radioButton1.Checked;
            bool radio2 = radioButton2.Checked;
            Form2 form2 = new Form2();
            form2.radio1 = radio1;
            form2.radio2 = radio2;

            form2.FormClosed += (s, args) => this.Show();
            form2.Show();
        }
    }
}
