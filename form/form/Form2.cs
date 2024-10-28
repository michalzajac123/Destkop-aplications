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
    public partial class Form2 : Form
    {
        public bool radio1 { get; set; }
        public bool radio2 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (radio1 == true)
            {
                label1.Text = "Wybrales tak";
            }
            else
            {
                label1.Text = "Wybrales Nie";
            }
        }
    }
}
