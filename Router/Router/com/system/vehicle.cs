using System;
using System.Collections.Generic;

namespace router.com.system
{
    public class vehicle
    {
        private int capacity;
        private string name;
        private HashSet<kid> kids_list = new HashSet<kid>();

        public vehicle(int vehicle_capacity, string vehicle_name, HashSet<kid> list)
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
        
        public HashSet<kid> getKids()
        {
            return kids_list;
        }

        public bool Equals()
        {
            throw new NotImplementedException();
        }
    }
}
