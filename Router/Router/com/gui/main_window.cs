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
                    foreach(kid each in kids_riding)
                    {
                        if (each.ToString().Equals(new_kid.ToString())) return;
                    }
                        // If kid is not already in set, add them to the set, and put their information in the list box
                        kids_riding.Add(new_kid);

                        // that box needs to display the name and address of the kid
                        kids_list_box.Items.Add(new_kid.ToString());
                        kids_list_box.Update();
                        
                    
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
                    foreach (vehicle each in vehicles_running)
                    {
                        if (each.ToString().Equals(new_vehicle.ToString())) return;
                    }
                   // If kid is not already in set, add them to the set, and put their information in the list box
                        vehicles_running.Add(new_vehicle);

                        // that box needs to display the name and address of the kid
                        vehicle_list_box.Items.Add(new_vehicle.ToString());
                        vehicle_list_box.Update();

                    
                    input_box_vehicle.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Format: Name/Capacity\n\n" + ex.Message);
                }
            }
        }

        //Author: Turki Chris
        //Removeing vehicle object from set and List_box_kid
        private void remove_kid_button_Click(object sender, EventArgs e)
        {
            List<kid> removeKid = new List<kid>();
            foreach (string each in kids_list_box.CheckedItems)
            {
                foreach (kid kid in kids_riding)
                {
                    if (kid.ToString().Equals(each))
                    {
                        removeKid.Add(kid);
                    }
                }
            }
            foreach (kid rekid in removeKid)
            {
                kids_riding.Remove(rekid);
                kids_list_box.Items.Remove(rekid.ToString());
            }
        }
        
        //Author: Turki Chris
        //Removeing vehicle object from set and List_box_vehicle
        private void remove_vehicle_button_Click(object sender, EventArgs e)
        {
            List<vehicle> removeVehicle = new List<vehicle>();
            foreach (string each in vehicle_list_box.CheckedItems)
            {

                foreach (vehicle vehicle in vehicles_running)
                {
                    if (vehicle.ToString().Equals(each))
                    {
                        removeVehicle.Add(vehicle);
                    }
                }
            }
            foreach (vehicle vehicle in removeVehicle)
            {
                vehicles_running.Remove(vehicle);
                vehicle_list_box.Items.Remove(vehicle.ToString());
            }
        }
    }
}
