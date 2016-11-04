namespace router.com.system
{
    public class kid
    {
        private string name;
        private string address;

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

        //chris johnson: commented out breaks code
        //////Authors : Keenen Cates, Simon Owens
        /////// <summary>
        /////// Overrides Equals() for equality comparer
        /////// </summary>
        /////// <param name="obj"></param>
        /////// <returns>bool</returns>
        ////public override bool Equals(object obj)
        ////{
        ////    return (this.name == ((kid)obj).getName() && this.address == ((kid)obj).getAddress());
        ////}

        /// <summary>
        /// Overrides GetHashCode()
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
