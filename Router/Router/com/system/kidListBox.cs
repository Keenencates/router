using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router.com.system
{
    
       //Authors: Turki ,  Mohammed 
    public class kidListBox : objectListBox
    {
        public HashSet<kid> getSet()
        {
            HashSet<kid> kids = new HashSet<kid>();
            foreach (kid each in this.Items)
            {
                kids.Add(each);
            }
            return kids;
        }
        public bool contains(kid k)
        {
            foreach (kid kid in this.Items)
            {
                if (kid.ToString().Equals(k.ToString()))
                {
                    return true;
                }
            }
            return false;
        }
        public void add(kid new_kid)
        {
            if (!this.contains(new_kid)) this.Items.Add(new_kid);
        }

        public void edit(object selectedItem,string Name, string Address)
        {
            kid new_kid = new kid(Name, Address);
            Items.Remove(selectedItem);
            add(new_kid);
        }
    }
}
