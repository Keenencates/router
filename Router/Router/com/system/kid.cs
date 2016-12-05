using Google.Maps.Geocoding;
using System;
using System.Linq;

namespace router.com.system
{
    public class kid
    {
        private string name;
        private string address;
        private point p;
        //Author : Simon Owens
        /// <summary>
        /// Constructs kid object from a name and address
        /// </summary>
        /// <param name="name"> String name</param>
        /// <param name="address">String address</param>
        public kid(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        //Authors : Keenen Cates, Simon Owens
        /// <summary>
        /// Constructs a kid object with string of name and addr seperated by a / (name/addr).
        /// </summary>
        /// <param name="name_and_addr"> String containing name and address seperated by a tab character (4 spaces).</param>
        public kid(string name_and_addr)
        {
            int idx = name_and_addr.IndexOf('/');
            this.name = name_and_addr.Substring(0, idx); 
            this.address = name_and_addr.Substring(idx + 1);
    }

        public point getPoint()
        {
            if (p == null)
            {
                var request = new GeocodingRequest();
                request.Address = this.address + ", IN";
                request.Sensor = false;
                var response = new GeocodingService().GetResponse(request);
                var result = response.Results.First();
                p = new point(result.Geometry.Location.Longitude, result.Geometry.Location.Latitude);
            }
            return p;
        }


        //Author : Simon Owens
        /// <summary>
        /// Getter for kid.name.
        /// </summary>
        /// <returns>string name</returns>
        public string getName()
        {
            return name;
        }

        //Author : Simon Owens
        /// <summary>
        /// Getter for kid.address
        /// </summary>
        /// <returns>string address</returns>
        public string getAddress()
        {
            return address;
        }
        
        //Author: Keenen Cates
        /// <summary>
        /// Kid object's name and address in a string in "kid.name, kid.address" format.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.getName() + "/" + this.getAddress();
        }

        //Authors : Keenen Cates, Simon Owens
        /// editted authors: Zeyu and Chris
        /// Overrides Equals() for equality comparer
        /// <param name = "obj" ></ param >
        /// < returns > bool </ returns >
        public override bool Equals(object obj)
        {
            try
            {
                return (this.name == ((kid)obj).getName() && this.address == ((kid)obj).getAddress());
            }
            catch
            { return false; }
       }

        /// <summary>
        /// Overrides GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return name.GetHashCode() + address.GetHashCode();
        }
    }
}
