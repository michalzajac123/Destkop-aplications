using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class toDoList : Form
    {
        bool edited = false;
        public toDoList()
        {
            InitializeComponent();
        }

        private void toDoList_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string toDoItem = toDoTextBox.Text; // Zmienna przechowująca wartość labela
            if (toDoItem.Length == 0) // jeżeli nic nie podano wyswietl błąd
            {
                MessageBox.Show("Podaj prawrdziwa rzecz");
                return;
            }
            toDoListBox.Items.Add(toDoItem); // dodaj element do listy
            toDoTextBox.Text = "";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = toDoListBox.SelectedIndex; //deklaracja zmiennej przechowującej index
            if (selectedIndex == -1)
            {
                MessageBox.Show("Zaznacz Przedmiot");
                return;
            }
            toDoListBox.Items.RemoveAt(selectedIndex); // Usuń wybrany element
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = toDoListBox.SelectedIndex; //deklaracja zmiennej przechowującej index
            if (selectedIndex == -1)
            {
                MessageBox.Show("Zaznacz Przedmiot");
                return;
            }
            string text = toDoListBox.SelectedItem.ToString();
            if (text.StartsWith("[Done]")) MessageBox.Show("Juz zaznaczyłeś to zadanie");
            else toDoListBox.Items[selectedIndex] = "[Done]" + text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = toDoListBox.SelectedIndex; //deklaracja zmiennej przechowującej index
            if (selectedIndex == -1)
            {
                MessageBox.Show("Zaznacz Przedmiot");
                return;
            }
            confirmButton.Visible = true;
            string text = toDoListBox.SelectedItem.ToString();
            toDoTextBox.Text = text;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string text = toDoTextBox.Text;
            int selectedIndex = toDoListBox.SelectedIndex;
            toDoListBox.Items[selectedIndex] = text;
            confirmButton.Visible = false;
            toDoTextBox.Text = "";
        }
    }
}
