using System;
using System.Collections.Generic;

namespace router.com.system
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
        
        public List<kid> getKids()
        {
            return kids_list;
        }

        public bool Equals()
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            return this.name + "/" + this.capacity;
        }
    }
}
