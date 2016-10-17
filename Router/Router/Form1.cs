using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string text = input_box_kid.Text;


                kid x = parse(text);
                // need to store the kid somewhere?
                updateList(x);
            }
        }

        private void updateList(kid x)
        {
            string output = x.getName() + ' ' + x.getAddress();
            list_box_kid.Items.Add(output);
            input_box_kid.Text = "";
        }

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

    }
}
