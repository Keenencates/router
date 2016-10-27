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
        private input_handler handler;
        public main_window()
        {
            InitializeComponent();
            handler = new input_handler();
            handler.Subscribe(list_box_kid);
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
                    handler.insert_kid(input_box_kid.Text);
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
                    // create a new kid based off what the user entered in
                    vehicle new_vehicle = new vehicle(Text);
                    // Check if that kid is already in the set of kids getting driven home today
                    if (!vehicles_running.Contains(new_vehicle))
                    {
                        // If kid is not already in set, add them to the set, and put their information in the list box
                        vehicles_running.Add(new_vehicle);
                        // needs to add item to box below
                        // that box needs to display the name and address of the kid
                        //list_box_vehicles.Items.Add(new_vehicle.getName());
                    }

                    input_box_kid.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Format: Name/Capacity\n\n" + ex.Message);
                }
            }
        }

        private void input_box_vehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)13)
            {
                try
                {
                    // create a new kid based off what the user entered in
                    vehicle new_vehicle = new vehicle(Text);
                    // Check if that kid is already in the set of kids getting driven home today
                    if (!vehicles_running.Contains(new_vehicle))
                    {
                        // If kid is not already in set, add them to the set, and put their information in the list box
                        vehicles_running.Add(new_vehicle);
                        // needs to add item to box below
                        // that box needs to display the name and address of the kid
                        //list_box_vehicles.Items.Add(new_vehicle.getName());
                    }

                    input_box_kid.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Format: Name/Capacity\n\n" + ex.Message);
                }
            }
        }
    }
}
