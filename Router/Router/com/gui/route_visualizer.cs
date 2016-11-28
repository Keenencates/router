using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using router.com.system;

namespace Router.com.gui
{
    public partial class route_visualizer : Form
    {

        public route_visualizer()
        {
            InitializeComponent();
        }

        public route_visualizer(HashSet<vehicle> v)
        {
            InitializeComponent();
            foreach(var each in v)
            {
                Vehicles.Items.Add(each);
            }
            Vehicles.Update();
        }

        private void objectListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
