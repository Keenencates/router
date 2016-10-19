using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router
{
    public class input_handler
    {
        private List<string> data;

        public input_handler()
        {
            data = new List<String>();
        }

        /// <summary>
        /// Inserts data into the input handler.
        /// </summary>
        /// <param name="input"></param>
        public void insert(string input)
        {
            data.Add(input);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string parse_kid(string input)
        {
            return input;
        }

        /// <summary>
        /// Returns the index of the first occurences of the string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int find(string str)
        {
            return data.FindIndex(x => x.Contains(str));
        }

        /// <summary>
        /// Returns a data at given idx.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public string get(int idx)
        {
            return data.ElementAt(idx);
        }
    }
}
