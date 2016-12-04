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
                vehicles.Items.Add(each);
            }
            vehicles.Update();
        }
        private void PrintAll_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void vehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            kids.Items.Clear();
            foreach (var each in ((vehicle)vehicles.SelectedItem).getKids())
            {
                kids.Items.Add(each);
            }
            kids.Update();
        }
    }
}
