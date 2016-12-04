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


        public vehicle(string name_and_capacity)
        {
            int idx = name_and_capacity.IndexOf('/');
            this.name = name_and_capacity.Substring(0, idx);
            this.capacity = int.Parse(name_and_capacity.Substring(idx + 1));
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

        public bool Equals(object obj)
        {
            return (((vehicle)obj).capacity == this.capacity && ((vehicle)obj).name == this.name);
        }
        
        public void load_kid(kid k)
        {
            kids_list.Add(k);
        }
        public override string ToString()
        {
            return this.name + "/" + this.capacity;
        }
    }
}
