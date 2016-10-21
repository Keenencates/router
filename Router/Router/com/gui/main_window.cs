using router.com.system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace router.com.gui
{
    public partial class main_window : Form
    {
        private input_handler vehicle_handler;
        private input_handler kid_handler;
        public main_window()
        {
            InitializeComponent();
            kid_handler = new input_handler();
            vehicle_handler = new input_handler();
            kid_handler.Subscribe(list_box_kid);
            vehicle_handler.Subscribe(list_box_vehicle);
        }

        /// <summary>
        /// Sends input in kid box to list box on enter key event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_box_kid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                try {
                    kid_handler.insert_kid(input_box_kid.Text);
                    input_box_kid.Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Format: Name/Address\n\n" + ex.Message);
                }
            }
        }

        private void input_box_vehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                try
                {
                    vehicle_handler.insert_vehicle(input_box_vehicle.Text);
                    input_box_vehicle.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Not Finished." + ex.Message);
                }
            }
        }
    }
}
