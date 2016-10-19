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
    public partial class main_window : Form
    {
        private input_handler handler;
        public main_window()
        {
            InitializeComponent();
            handler = new input_handler();
        }

        private void input_box_kid_KeyDown(object sender, KeyEventArgs e)
        {
            string input = handler.parse_kid(input_box_kid.Text);
            handler.insert(input);
            list_box_kid.Items.Add(handler.get(handler.find(input)));
            input_box_kid.Clear();
        }
    }
}
