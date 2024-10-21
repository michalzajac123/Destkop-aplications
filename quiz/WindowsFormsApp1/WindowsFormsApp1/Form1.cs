using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int currentQuestion = 0; //index bierzącego elementu
        private int correctAnswers = 0; //liczba poprawnych odpowiedzi
        private readonly string[] questions =
        {
            "Który język jest używany do tworzenia stron WWW?",
            "Co to jest obiekt w programowaniu?",
            "Który algorytn służy do sortowania? "
        };
        private readonly string[][] answers =
        {
            new string [] {"C#","HTML","PYTHON","JAVA"},
            new string [] {"Zmienna","Funckja","Obiekt","Klasa"},
            new string [] {"Bubble Sort","Binary Search","DFS","BFS"}
        };
        private readonly int[] correctAnswerIndexes = { 1, 2, 0 };
        public Form1()
        {
            InitializeComponent();
            LoadQuestion();
        }
        private void LoadQuestion()
        {
            questionLabel.Text = questions[currentQuestion].ToString();
            radioButtonA.Text = answers[currentQuestion][0].ToString();
            radioButtonB.Text = answers[currentQuestion][1].ToString();
            radioButtonC.Text = answers[currentQuestion][2].ToString();
            radioButtonD.Text = answers[currentQuestion][3].ToString();
            correctAnswerLabel.Text = "";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int correctAnswersIndex = correctAnswerIndexes[currentQuestion];
            int answerChecked = getIndexOfAnswer();
            if (correctAnswersIndex == -1)
            {
                MessageBox.Show("Nie zaznaczono pytania");
                return;
            }
            if(correctAnswersIndex==answerChecked)
            {
                correctAnswers++;
                pointCounterLabel.Text = "Liczba punktów " + correctAnswers;
                correctAnswerLabel.Text = "Dobra odpowiedz";
            }
            else
            {
                correctAnswerLabel.Text = "Zle poprawna odpowiedz to: "+(correctAnswerIndexes[currentQuestion]).ToString();
            }
            nextQuestionButton.Enabled = true;
        }
        private int getIndexOfAnswer()
        {
            if(radioButtonA.Checked) return 0;
            if(radioButtonB.Checked) return 1;
            if(radioButtonC.Checked) return 2;
            if(radioButtonD.Checked) return 3;
            return -1;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            nextQuestionButton.Enabled = false;
            currentQuestion++;
            if (currentQuestion >= questions.Length)
            {
                pointCounterLabel.Text = "Koniec testu Zdobyłeś " + correctAnswers.ToString();
            }
            else
            {
                LoadQuestion();
            }

        }
    }
}
