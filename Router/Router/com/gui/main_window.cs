using router.com.system;
using Router.com;
using Router.com.gui;
using Router.com.system;
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

        route_manager route_computer;
        router_db db;
        public main_window()
        {
            InitializeComponent();
            db = new router_db();
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
                    kids_list_box.add(new kid(input_box_kid.Text));
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
                    vehicle_list_box.add(new vehicle(input_box_vehicle.Text));
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
            kids_list_box.deleteChecked();
            
        }
        
        //Author: Turki Chris
        //Removeing vehicle object from set and List_box_vehicle
        private void remove_vehicle_button_Click(object sender, EventArgs e)
        {
            vehicle_list_box.deleteChecked();
        }

        private void compute_button_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                route_computer = new route_manager(kids_list_box.getSet(), vehicle_list_box.getSet());
                route_computer.computeRoutes();
                route_computer.printFiles("output/");
                try
                {
                    db.upload(kids_list_box.getSet(), vehicle_list_box.getSet());
                    db.reload();
                }
                catch(System.Data.SQLite.SQLiteException ex)
                {// do nothing, already in database
                }
                route_computer.displayRoute();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Multiple kids and vehicles not implemented yet.\n" + ex.Source);
            }
        }

        private void kids_list_box_DoubleClick(object sender, EventArgs e)
        {
            edit window = new edit(kids_list_box,"kid");
            window.Show();
        }

        private void vehicle_list_box_DoubleClick(object sender, EventArgs e)
        {
            edit vehicle_window = new edit(vehicle_list_box,"vehicle");
            vehicle_window.Show();
        }

        private void add_prev_kid_Click(object sender, EventArgs e)
        {
            previous_items previous = new previous_items(kids_list_box, db.getKids());
            previous.Show();
        }

        private void add_prev_vehicles_Click(object sender, EventArgs e)
        {
            previous_items previous = new previous_items(vehicle_list_box, db.getVehicle());
            previous.Show();
        }
    }
}
