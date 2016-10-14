using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    public class vehicle
    {
        private int capacity;
        private string name;
        private List<kid> kids_list = new List<kid>();

        public vehicle(int vehicle_capacity, string vehicle_name, List<kid> list)
        {
            capacity = vehicle_capacity;
            name = vehicle_name;
            kids_list = list;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public string getName()
        {
            return name;
        }
        
        public List<kid> getKids()
        {
            return kids_list;
        }
    }
}
