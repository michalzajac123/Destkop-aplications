using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zamowienie
{
    public partial class Form2 : Form
    {
        public string name;
        public string surnName;
        public string address;
        public string product;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameLabel.Text= name;
            addressLabel.Text= address;
            productLabel.Text= product;
            surnNameLabel.Text = surnName;
        }
    }
}
