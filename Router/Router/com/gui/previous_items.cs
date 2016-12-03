using router.com.system;
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

namespace Router.com.gui
{
    public partial class previous_items : Form
    {
        private objectListBox received_box;
        private string type;
        // constructor for kids
        public previous_items(kidListBox list_box, HashSet<kid> kids)
        {
            type = "kid";
            InitializeComponent();
            foreach (kid each in kids)
            {
                previous_items_box.Items.Add(each);
            }
            received_box = list_box;
        }

        // constructor for vehicles
        public previous_items(vehicleListBox list_box, HashSet<vehicle> vehicles)
        {
            InitializeComponent();
            type = "vehicle";
            foreach (vehicle each in vehicles)
            {
                previous_items_box.Items.Add(each);
            }
            received_box = list_box;
        }

        // adds all selected items to the appropriate box in the main window
        private void add_button_Click(object sender, EventArgs e)
        {
            if (type == "kid")
            {
                foreach (object each in previous_items_box.CheckedItems)
                {
                    ((kidListBox)received_box).add((kid)each);
                }
            }
            else
            {
                foreach (object each in previous_items_box.CheckedItems)
                {
                    ((vehicleListBox)received_box).add((vehicle)each);
                }
            }
            
            this.Close();
        }
    }
}
