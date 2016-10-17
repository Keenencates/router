using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Router
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

<<<<<<< HEAD
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string text = textBox1.Text;
                string [] spliter = text.Split('/');
                
                kid x = new kid(spliter[0],spliter[1]);
                // need to store the kid somewhere?
                updateList(x);
            }
        }

        private void updateList(kid x)
        {
            string output = x.getName() + ' ' + x.getAddress();
            listBox1.Items.Add(output);
        }
=======

        private kid parse(string input)
        {
            string name, addr = "";
            int idx = input.IndexOf('/');
            name = input.Substring(0, idx - 1);
            addr = input.Substring(idx + 1);
            kid kid1 = new kid(name, addr);
            return kid1;
        }

        private void input_box_kid_TextChanged(object sender, EventArgs e)
        {

        }

        private void input_box_vehicle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*CJ 10/15/2016
             Imports a excel spreadsheet with the first box name second box address
             and saves the excel places as a list of kid objects.
            */
            var dialog = new System.Windows.Forms.OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            input_box_kid.Text = dialog.FileName;
            string fName = dialog.FileName;
            List<kid> kList = new List<kid>();

            if (fName.Substring(fName.Length - 5) == ".xlsx")
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@fName);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                for (int i = 1; i <= rowCount; i++)
                {
                    if (xlRange.Cells[i, 1] != null && xlRange.Cells[i, 1].Value2 != null)
                    {
                        kList.Add(new kid(xlRange.Cells[i, 1].Value2.ToString(), xlRange.Cells[i, 2].Value2.ToString()));
                        list_box_kid.Items.Add(xlRange.Cells[i, 1].Value2.ToString() + "\t" + xlRange.Cells[i, 2].Value2.ToString());
                    }
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }



        }
        

>>>>>>> 37b2a8bd39188d478725b0da28b7a5cd4340c33d
    }
}
