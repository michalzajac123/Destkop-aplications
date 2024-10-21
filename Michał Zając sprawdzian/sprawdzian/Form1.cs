using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprawdzian
{
    public partial class Form1 : Form
    {
        string fileName = "lista_zakupow.txt";

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        productsListBox.Items.Add(line);
                    }
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string nameOfProduct = nameOfProductTextBox.Text; //deklaracja zmiennych zawierajacych dane z textBoxow
            string howMany = howManyTextBox.Text;
            if (nameOfProduct == "" || howMany == "") //sprawdzenie czy textBoxy nei sa puste
            {
                MessageBox.Show("Błąd nie wpisałeś danych");
                return;
            }
            productsListBox.Items.Add(nameOfProduct+" "+howMany); //Dodanie elementu do listy
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = productsListBox.SelectedIndex; //pobranie wartości indexu zaznaczonegto elemetnu
            if(selectedIndex== -1) //jezeli jest rowny -1 to znaczy ze nic nie zaznaczono - zwroc blad
            {
                MessageBox.Show("Nalezy zaznaczyc element");
                return;
            }
            productsListBox.Items.RemoveAt(selectedIndex); //usun element z listy
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            string fileName = "lista_zakupow.txt";
            if (productsListBox.Items.Count == 0) // jezeli lista zakupow jest pusta zwroc blad
            {
                MessageBox.Show("Najpierw dodaj element");
                return;
            }

            using (StreamWriter writer = new StreamWriter(fileName,true)) { 
                for(int i=0; i<productsListBox.Items.Count; i++)
                {
                    writer.WriteLine(productsListBox.Items[i].ToString()); //zapisz do pliku kazdy element z listy
                }
            }

        }

        private void loadListButton_Click(object sender, EventArgs e)
        {
            if(!File.Exists(fileName)) { //sprawdz czy plik istneije jezeli nie to zroc blad
                MessageBox.Show("Plik nie istnieje");
                return;
            }
            productsListBox.Items.Clear(); //wyczysc liste 
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    productsListBox.Items.Add(line); //dodanie elementu wczytanego z listy
                }
            }
        }
    }
}
