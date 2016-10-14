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


        private kid parse(string input)
        {
            string name, addr = "";
            int idx = input.IndexOf('/');
            name = input.Substring(0, idx - 1);
            addr = input.Substring(idx + 1);
            kid kid1 = new kid(name, addr);
            return kid1;
        }

    }
}
