using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace przekazywanie_argumentow_do_okienek
{
    public partial class Form2 : Form
    {
        public string MessageText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
            //label1.Text = message;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
