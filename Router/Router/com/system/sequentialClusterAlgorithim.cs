using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router.com.system
{
    class SequentialClusterAlgorithim
    {
        int global_min_x = 0;
        int global_min_y = 0;
        int global_closest_x = 0;
        int global_closest_y = 0;
        List<kid> kids = new List<kid>();
        List<vehicle> vehicles = new List<vehicle>();
        List<List >

        SequentialClusterAlgorithim(List<kid> passed_kids, List<vehicle> passed_vehicles)
        {
            kids = passed_kids;
            vehicles = passed_vehicles;
        }

        void findAllClusters()
        {
            int curr=0;
            while (!empty_map())
            {

                // global_min_x = kids.ElementAt(curr_kid);
                //  global_min_y = kids.ElementAt(curr_kid);
            }

            //print statement that prints the current cluster//curr_kid kinda coresponds ot current cluster
            Console.Write("cluster : "); Console.WriteLine(curr);
            //
            findNNeighbors(vehicles.ElementAt(curr),curr);
            curr++;


        }

        private void findNNeighbors(vehicle vehicle, int curr)
        {
            for(int i=0;i<(i-1);i++)
            {
                findMin();

            }
        }

        private void findMin()
        {
            throw new NotImplementedException();
        }

        private bool empty_map()
        {
            return false;
        }

        //sorts top to bottom
        private void sortKidsByAddress()
        {
            throw new NotImplementedException();
        }
    }
}
