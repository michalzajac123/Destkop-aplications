using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poczta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkPriceBtn_Click(object sender, EventArgs e)
        {
            // Tworzymy zmienne bool
            bool poster = posterRadioBtn.Checked;
            bool letter = letterRadioBtn.Checked;
            bool box = boxRadioBtn.Checked;
            //Sprawdzamy co jest zaznaczone
            if(poster)
            {
                cena.Text = "CENA 1,0 ZŁ";
            }
            if(letter)
            {
                cena.Text = "CENA 1,5 ZŁ";
            }
            if(box)
            {
                cena.Text = "CENA 10 ZŁ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cyfry = "0123456789";
            string kodPocztowy = postCode.Text;
            for(int i=0; i<kodPocztowy.Length; i++)
            {
                if (!cyfry.Contains(kodPocztowy[i])) {
                    MessageBox.Show("Kod pocztowy musi składać się z samych syfr");
                    return;
                }
            }
            if (kodPocztowy.Length != 5)
            {
                MessageBox.Show("Kod poczotwy musi sie skladac z dokladnie 5 cyfr");
                return;
            }
            MessageBox.Show("Git");
        }
    }
}
