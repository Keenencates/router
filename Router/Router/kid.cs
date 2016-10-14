using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    public class kid
    {
        private string name;
        private string address;

        public kid(string kid_name, string kid_address)
        {
            name = kid_name;
            address = kid_address;
        }
        public string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }
    }
}
