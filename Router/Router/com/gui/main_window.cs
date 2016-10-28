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
        HashSet<kid> kids_riding = new HashSet<kid>();
        HashSet<kid> previous_kids = new HashSet<kid>();
        HashSet<vehicle> vehicles_running = new HashSet<vehicle>();
        HashSet<vehicle> previous_vehicles = new HashSet<vehicle>();

        public main_window()
        {
            InitializeComponent();
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
                    // create a new kid based off what the user entered in
                    kid new_kid = new kid(input_box_kid.Text);
                    // Check if that kid is already in the set of kids getting driven home today
                    if(!kids_riding.Contains(new_kid))
                    {
                        // If kid is not already in set, add them to the set, and put their information in the list box
                        kids_riding.Add(new_kid);

                        // that box needs to display the name and address of the kid
                        kids_list_box.Items.Add(new_kid.getName());
                        kids_list_box.Update();
                        
                    }
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
                    vehicle new_vehicle = new vehicle(input_box_vehicle.Text);
                    // Check if that kid is already in the set of kids getting driven home today
                    if (!vehicles_running.Contains(new_vehicle))
                    {
                        // If kid is not already in set, add them to the set, and put their information in the list box
                        vehicles_running.Add(new_vehicle);

                        // that box needs to display the name and address of the kid
                        vehicle_list_box.Items.Add(new_vehicle.getName());
                        vehicle_list_box.Update();

                    }
                    input_box_vehicle.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Format: Name/Capacity\n\n" + ex.Message);
                }
            }
        }
    }
}
