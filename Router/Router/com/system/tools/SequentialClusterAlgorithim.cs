using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Router.com.system.tools
{
    class SequentialClusterAlgorithim
    {

        int global_min_x = 0;
        int global_min_y = 0;
        int global_closest_x = 0;
        int global_closest_y = 0;
        List<kid> kids = new List<kid>();
        List<vehicle> vehicles = new List<vehicle>();
        List<List<kid>> clusters = new List<List<kid>>(); 
        private int global_min_kid;


        SequentialClusterAlgorithim(List<kid> passed_kids, List<vehicle> passed_vehicles)
        {
            kids = passed_kids;
            vehicles = passed_vehicles;
        }

        void findAllClusters()
        {
            int curr = 0;
            
            while (!empty_map())
            {
                kid temp;
                for (int i=0;i<kids.Count();i++)
                {
                    if (temp < kids.ElementAt(i) && temp != i)
                    {
                        temp = kids.ElementAt(i);
                    }
                } 
                


                //print statement that prints the current cluster//curr_kid kinda coresponds ot current cluster
                Console.Write("cluster : "); Console.WriteLine(curr);
                //
                findNNeighbors(vehicles.ElementAt(curr).getCapacity(), curr);
                curr++;
            }

        }

        private void findNNeighbors(int n, int cluster)
        {
            for (int i = 0; i < (n - 1); i++)
            {
                findMin();
                clusters.ElementAt(cluster).Add(kids.ElementAt(global_min_kid));
                kids.RemoveAt(global_min_kid);
            }
            clusters.ElementAt(cluster).Add(kids.ElementAt(0));
            kids.RemoveAt(0);
        }

        private void findMin()
        {
            double closest = 100000;
            for (int i = 0; i < kids.Count; i++)
            {
                if(closest>dist(global_min_kid,i))
                    global_min_kid = i;
            }
        }

        private double dist(int global_min_kid, int i)
        {
            return 100000;
        }

        private bool empty_map()
        {
            if (kids.Count == 0)
                return true;
            else
                return false;
        }

        //sorts top to bottom
        private void sortKidsByAddress()
        {
            
        }
    }
}
