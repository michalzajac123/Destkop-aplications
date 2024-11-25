using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gra_w_kosci
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        private int totalScore = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void throw_Dice_Click(object sender, EventArgs e)
        {
            int dice1 = random.Next(1,7);
            int dice2 = random.Next(1,7);

            diceLabel1.Text = "Kość 1: " + dice1;
            diceLabel2.Text = "Kość 2: " + dice2;

            int sum = dice1+ dice2;

            diceSum.Text = "Suma " + sum;

            totalScore += sum;

            diceTotal.Text = "Wynik całkowity: " + totalScore;

            diceBox1.Image = Image.FromFile($"Images/dice{dice1}.png");
            diceBox2.Image = Image.FromFile($"Images/dice{dice2}.png");

        }
    }
}
