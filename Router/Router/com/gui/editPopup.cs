using router.com.gui;
using router.com.system;
using System;
using System.Windows.Forms;
using router;

namespace Router.com.gui
{
    public partial class editPopup : Form
    {
        private kid edited_kid;

        //Authors: Chris and Simon
        public editPopup(kid kid1)
        {
            InitializeComponent();
            kid_textbox.Text = kid1.getName();
            address_textbox.Text = kid1.getAddress();
        }
        

        //Authors: Chris and Simon
        private void update_clicked(object sender, EventArgs e)
        {
            edited_kid = new kid(kid_textbox.Text, address_textbox.Text);
            Close();
        }

        public kid get_edited_kid()
        {
            return edited_kid;
        }


    }
}
