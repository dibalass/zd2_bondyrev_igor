using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 :Form
    {
        private static PhoneBook phonebook;
        public Form1 ()
        {
            InitializeComponent();
            phonebook = new PhoneBook();
            PhoneBookLoader.Load(new PhoneBook(), "", table);
        }

        private void Form1_Load (object sender, EventArgs e)
        {
        }

        private bool NameCheck (string name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Введи ФИО");
                return false;
            } else
            {
                foreach (char sym in name)
                {
                    if (!char.IsLetter(sym) && sym != ' ')
                    {
                        MessageBox.Show("Введи только буквы");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool PhoneCheck (string phone)
        {
            if (phone.Length == 0)
            {
                MessageBox.Show("Введи телефон");
                return false;
            } else
            {
                if (phone.Length !=14)
                {
                    MessageBox.Show("В номере телефона должно быть 10 цифр");
                    return false;
                } else
                {
                    foreach (char sym in phone)
                    {
                        if (!char.IsDigit(sym) && sym != '(' && sym != ')' && sym != '-')
                        {
                            MessageBox.Show("Введи только цифры");
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        public bool Found ()
        {
            for (int i = 0; i <= table.Rows.Count - 1; i++)
                for (int j = 0; j <= table.ColumnCount - 1; j++)
                    if (table.Rows[i].Cells[j].Value != null && table.Rows[i].Cells[j].Value.ToString() == FIO.Text)
                        return false;
            return true;
        }
        private void Add_button (object sender, EventArgs e)
        {
            bool name = NameCheck(FIO.Text);
            bool phone = PhoneCheck(numberPhone.Text);
            Contact contact = new Contact(FIO.Text, numberPhone.Text);
            bool found = Found();
            if (name && phone)
            {
                if (found)
                {
                    phonebook.Add(contact);
                    table.Rows.Add(FIO.Text, numberPhone.Text);
                    MessageBox.Show("Контак добавлен");
                } else
                    MessageBox.Show("Такой контакт уже есть");
            }
        }

        private void Exit (object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Save_Click (object sender, EventArgs e)
        {
            if (fileName.Text.Length != 0)
            {
                PhoneBookLoader.Save(phonebook, fileName.Text, table);
                MessageBox.Show("Сохранено");
            } else
                MessageBox.Show("Вы не ввели имя файла");
        }

        private void Search (object sender, EventArgs e)
        {
            if (search_text.Text!="")
            {
                table.ClearSelection();
                for (int i = 0; i <= table.Rows.Count - 1; i++)
                    for (int j = 0; j <= table.ColumnCount - 1; j++)
                    {
                        if (table.Rows[i].Cells[j].Value != null && table.Rows[i].Cells[j].Value.ToString() == search_text.Text)
                            table.Rows[i].Selected = true;
                    }
            }
        }

        private void delete (object sender, EventArgs e)
        {
            phonebook.Remove(table.SelectedRows[0].Index, table);
        }
    }
}