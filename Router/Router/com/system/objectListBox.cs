using router.com.system;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Router.com.system
{


    //Authors: Turki ,  Mohammed 
    public class objectListBox : CheckedListBox
    {
        //deletes checked objects
        public void deleteChecked()
        {
            // cannot delete checked items while iterating through them
            HashSet<object> objects = new HashSet<object>();
            foreach(object b in this.CheckedItems)
            {
                objects.Add(b);
            }
            foreach(object b in objects)
            {
                this.Items.Remove(b);
            }

        }
    }
}
