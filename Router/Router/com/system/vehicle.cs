﻿using Router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace router.com.system
{
    public class vehicle : input_object
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

        public vehicle(string name_and_addr)
        {
            int idx = name_and_addr.IndexOf('/');
            this.name = name_and_addr.Substring(0, idx);
           // this.capacity= name_and_addr.Substring(idx + 1);
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
    }
}
