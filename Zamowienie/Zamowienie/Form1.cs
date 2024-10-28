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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            productComboBox.Items.Add("Marchewki");
            productComboBox.Items.Add("Cosik");
            productComboBox.Items.Add("jazda");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            string name = nameTextBox.Text;
            string surnName = surnNameTextBox.Text;
            string address=adressTextBox.Text;
            int index = productComboBox.SelectedIndex;
            Form2 form2 = new Form2();
            form2.name= name;
            form2.address=address;
            form2.surnName=surnName;
            form2.product = productComboBox.SelectedItem.ToString();
            form2.FormClosed += (s, args) => { this.Show(); };
            form2.Show();
        }
    }
}
