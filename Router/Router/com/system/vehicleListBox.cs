using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router.com.system



   {
    //Authors: Turki ,  Mohammed 
    public class vehicleListBox : objectListBox
    {

        public void add(vehicle new_vehicle)
        {
            if (!this.contains(new_vehicle))
            {
                this.Items.Add(new_vehicle);
            }
        }



        public HashSet<vehicle> getSet()
        {
            HashSet<vehicle> v = new HashSet<vehicle>();
            foreach (vehicle each in this.Items)
            {
                v.Add(each);
            }
            return v;
        }

        public bool contains(vehicle v)
        {
            foreach (vehicle vehicle in this.Items)
            {
                if (vehicle.Equals(v))
                {
                    return true;
                }
            }
            return false;
        }

        public void edit(object selectedItem, string name, int capacity)
        {
            vehicle new_vehicle = new vehicle(capacity, name, null);
            Items.Remove(selectedItem);
            this.add(new_vehicle);

        }
    }
}
