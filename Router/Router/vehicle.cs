using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    class vehicle
    {
        private int capacity;
        private string name;
        private List<kid> kids_list = new List<kid>();

        vehicle(int vehicle_capacity, string vehicle_name)
        {
            capacity = vehicle_capacity;
            name = vehicle_name;
        }

        int getCapacity()
        {
            return capacity;
        }

        string getName()
        {
            return name;
        }
        

    }
}
