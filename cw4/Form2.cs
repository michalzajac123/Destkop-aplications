using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw4
{
    public partial class Form2 : Form
    {
        public Form1 mainForm;

        public Form2()
        {
            InitializeComponent();

            comboBox1.Items.Add("Czerwony");
            comboBox1.Items.Add("Zielony");
            comboBox1.Items.Add("Niebieski");
        }

        public string kolor;
        public Color kolorOut;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Czerwony":
                    kolorOut = Color.Red;
                    break;
                case "Zielony":
                    kolorOut = Color.Green;
                    break;
                case "Niebieski":
                    kolorOut = Color.Blue;
                    break;
                default:
                    kolorOut = Color.White;
                    break;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.ChangeBackgroundColor(kolorOut);
        }
    }
}
