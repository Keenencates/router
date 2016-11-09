using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;
using router.com.system;

//Author: Zeyu Zhang
//Pair with: Moahmmed Alharthi 
namespace Router.com.system
{   //This class gets addresses info from kid class and makes a 
    //locations collection. Then it can connect to google maps
    //api to get distance between each address.
    public class LocationsCollection
    {
        //This class is a location which contains its address info and
        //distance to other locations
        public class location
        {
            private kid location_info;
            private Dictionary<location, double> distance;

            public location(kid kid_info)
            {
                location_info = new kid(kid_info.getName(), kid_info.getAddress());
                distance = new Dictionary<location, double>();
            }

            public kid get_location_info()
            {
                return location_info;
            }

            public void assign_distance_to(location dest, double miles)
            {
                if (!distance.ContainsKey(dest))
                    distance.Add(dest, miles);
                else
                    distance[dest] = miles;
            }

            public void remove_distance_to(location dest)
            {
                if (distance.ContainsKey(dest))
                    distance.Remove(dest);
            }

            public double distance_to(location address)
            {
                if (distance.ContainsKey(address))
                    return distance[address];
                else
                    return -1;
            }

            public void distance_sort()
            {
                distance = distance.OrderBy(o => o.Value).ToDictionary(p => p.Key, o => o.Value);
            }

            public location closest_place()
            {
                this.distance_sort();
                return distance.First().Key;
            }

            public override string ToString()
            {
                return this.location_info.ToString();
            }

            public override bool Equals(object obj)
            {
                location target = obj as location;
                if (target == null)
                    return false;
                return (this.location_info.Equals(target.location_info));
            }

            public override int GetHashCode()
            {
                return this.location_info.GetHashCode();
            }
        }


        private ArrayList location_list;
        private bool has_got_api;
        public LocationsCollection(kid[] kids_list, int number_of_address)
        {
            location_list = new ArrayList();
            has_got_api = false;
            for (int i = 0; i < number_of_address; i++)
            {
                location_list.Add(new location(kids_list[i]));
            }
        }

        public location find_location(kid location)
        {
            foreach (location each in location_list)
            {
                if (each.get_location_info().Equals(location))
                    return each;
            }
            return null;
        }

        public double parse_distance_json(string json)
        {
            if (json.IndexOf("status") == -1 || json.Substring(json.IndexOf("status") + 11, 2) != "OK")
                return -1;
            string a = json.Substring(json.IndexOf("text") + 9);
            string b = a.Substring(0, a.IndexOf("\""));
            string[] c = b.Split();
            double distance = double.Parse(c[0]);
            if (c[1] == "ft")
                distance *= 0.000189394;
            return distance;
        }

        public bool get_distance_data_from_api()
        {
            foreach (location A in location_list)
            {
                foreach (location B in location_list)
                {
                    string url = "https://maps.googleapis.com/maps/api/distancematrix/json?units=imperial&origins=" + A.get_location_info().getAddress() +
                        "&destinations=" + B.get_location_info().getAddress() + "&key=AIzaSyAJnzEiAdKJvYNQ6Wt6TpavDNLbUMShx5g";
                    HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                    request.Method = "GET";
                    request.ProtocolVersion = new Version(1, 1);
                    HttpWebResponse response;
                    try
                    {
                        response = request.GetResponse() as HttpWebResponse;
                    }
                    catch
                    {
                        return false;
                    }

                    StreamReader sr = new StreamReader(response.GetResponseStream());
                    string result = sr.ReadToEnd();

                    double distance = parse_distance_json(result);
                    if (distance < 0)
                        return false;
                    A.assign_distance_to(B, distance);
                }
                A.distance_sort();
                A.remove_distance_to(A);
            }
            has_got_api = true;
            return true;
        }

        public double distance_between(kid address_A, kid address_B)
        {
            if (has_got_api == false)
                return -1;
            location location_B = new location(address_B);
            return find_location(address_A).distance_to(location_B);
        }
    }
}
