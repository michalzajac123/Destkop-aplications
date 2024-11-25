using System;

using System.Windows.Forms;

namespace gra_w_kosci_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name1 = firstPlayerTextBox.Text; 
            string name2= secondPlayerTexBox.Text;
            if(name1 == "" || name2 == "")
            {
                MessageBox.Show("Prosze podaj dane! ");
                return;
            }
            this.Hide();
            Form2 form2 = new Form2(name1,name2);
            form2.FormClosed += (s, args) => this.Show();
            form2.ShowDialog();


        }
    }
}
