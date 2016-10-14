using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    class kid
    {
        private string name;
        private string address;

        kid(string kid_name, string kid_address)
        {
            name = kid_name;
            address = kid_address;
        }
        string getName()
        {
            return name;
        }

        string getAddress()
        {
            return address;
        }
    }
}
