using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kostki
{
    public partial class Form1 : Form
    {
        public Random random = new Random();
        public int sum=0;
        List<int> resultList = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void throwDiceButton_Click(object sender, EventArgs e)
        {
            if (playerNameLabel.Text == "")
            {
                MessageBox.Show("Podaj imie gracza");
                return;
            }
            
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            dice1Label.Text = "Kość 1: "+dice1;
            dice2Label.Text = "Kość 2: " + dice2;

            sum = dice1 + dice2;
            resultList.Add(sum);
            resultsListBox.Items.Add(playerNameLabel.Text + " - "+resultList.Last());
            DicePictureBox1.Image = Image.FromFile($"Images/dice{dice1}.png");
            DicePictureBox2.Image = Image.FromFile($"Images/dice{dice2}.png");
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            if (sum == 0)
            {
                MessageBox.Show("Najpierw rzuc koscia");
                return;
            }
            this.Hide();
            Form2 form2 = new Form2(sum);
          
            form2.FormClosed += (s, args) => this.Show();
            form2.ShowDialog();
        }

        private void confirmNameButton_Click(object sender, EventArgs e)
        {
            playerNameLabel.Text = "Gracz: " + nameTextBox.Text;
            confirmNameButton.Enabled = false;
            editButton.Visible = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            confirmNameButton.Enabled = true;
            editButton.Visible = false;

        }
    }
}
