using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    class PhoneBook
    {
        List<Contact> contacts;
        public PhoneBook ()
        {
            contacts = new List<Contact>();
        }
        public void Add(Contact contact)
        {
            contacts.Add(contact);
        }
        public void Remove(int index, DataGridView table)
        {
            try
            {
                table.Rows.RemoveAt(index);
            } catch
            {
                MessageBox.Show("Вы не выделили строчку, которую хотите удалить");
            }
        }
    }
}
