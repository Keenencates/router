using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Router.com.system;
using router.com.system;

namespace Router.com.gui
{
    public partial class edit : Form
    {
        private string type;
        private objectListBox list_box;

        // constructor
        public edit(objectListBox list_box,string type)
        {
            this.type = type;
            this.list_box = list_box;
            InitializeComponent();

            // labeling will be different whether we are editing a vehicle or kid
            if (type != "kid")
            {
                edit_address_box.Text = ((vehicle)list_box.SelectedItem).getCapacity().ToString();
                address_label.Text = "Capacity";
                edit_name_box.Text = ((vehicle)list_box.SelectedItem).getName().ToString();

            }
            else
            {
                edit_address_box.Text = ((kid)list_box.SelectedItem).getAddress().ToString();
                edit_name_box.Text = ((kid)list_box.SelectedItem).getName();
            }

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (type == "kid")
            {
                ((kidListBox)list_box).edit(list_box.SelectedItem, edit_name_box.Text, edit_address_box.Text);
            }
            if (type == "vehicle"){
                ((vehicleListBox)list_box).edit(list_box.SelectedItem, edit_name_box.Text,Convert.ToInt32(edit_address_box.Text));

            }
            Close();
        }

    }
}
