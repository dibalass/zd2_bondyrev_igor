using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;

namespace zad2
{
    static class PhoneBookLoader
    {
        static public void Load (PhoneBook phoneBook, string fileName, DataGridView table)
        {
            FileStream stream = File.Open("contacts.xlsx", FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            do
            {
                while (reader.Read())
                {
                    table.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
            }
            while (reader.NextResult()); 
            stream.Close();
        }
        static public void Save (PhoneBook phoneBook, string fileName, DataGridView table) 
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook book = exApp.Workbooks.Add(Type.Missing);
            book.SaveAs($"{fileName}.xlsx");
            for (int i = 0; i < table.RowCount - 1; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    exApp.Cells[i + 1, j + 1] = table[j, i].Value.ToString();
                }
            }
            exApp.Visible = true;
        }
    }
}
