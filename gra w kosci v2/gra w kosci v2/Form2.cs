using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_w_kosci_v2
{
    public partial class Form2: Form
    {
        private string firstPlayerName;
        private string secondPlayerName;
        private Random random = new Random();
        private int player1Sum = 0;
        private int player2Sum = 0;
        private bool firstPlayerMove = true;
        private int roundCounter = 0;
        public Form2(string n1,string n2)
        {
            InitializeComponent();
            firstPlayerName= n1;
            secondPlayerName= n2;

        }

        private void throwDiceButton_Click(object sender, EventArgs e)
        {
            if (roundCounter == 6)
            {
                if (player1Sum > player2Sum)
                {
                    MessageBox.Show("Gracz nr 1 wygral");
                    return;
                }
                else
                {
                    MessageBox.Show("Gracz nr 2 wygral");
                    return;
                }
            }
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int dice3 = random.Next(1, 7);
            int dice4 = random.Next(1, 7);
            int dice5 = random.Next(1, 7);

            if (firstPlayerMove)
            {
                playerNameLabel.Text = $"Gracz nr {firstPlayerName}";
                player1Sum += dice1 + dice2 + dice3 + dice4 + dice5;
                playerDiceSum.Text = $"Suma gracza {firstPlayerName}: " + player1Sum.ToString();
                playerDiceSum2Label.Text = $"Suma gracza {secondPlayerName}: " + player2Sum.ToString(); ;
                firstPlayerMove = false;
            }
            else
            {
                playerNameLabel.Text = $"Gracz {secondPlayerName}";
                player2Sum += dice1 + dice2 + dice3 + dice4 + dice5;

                playerDiceSum.Text = $"Suma gracza {firstPlayerName}: " + player1Sum.ToString();
                playerDiceSum2Label.Text = $"Suma gracza {secondPlayerName}: " + player2Sum.ToString(); ;

                firstPlayerMove = true;
            }

            diceBox1.Image = Image.FromFile($"Images/dice{dice1}.png");
            diceBox2.Image = Image.FromFile($"Images/dice{dice2}.png");
            diceBox3.Image = Image.FromFile($"Images/dice{dice3}.png");
            diceBox4.Image = Image.FromFile($"Images/dice{dice4}.png");
            diceBox5.Image = Image.FromFile($"Images/dice{dice5}.png");
            roundCounter++;

        }
    }
}
