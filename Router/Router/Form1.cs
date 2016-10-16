using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
