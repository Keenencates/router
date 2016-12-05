using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Router.com.system.tools
{
    class SequentialClustering
    {
        kid min_kid = new kid();
        List<kid> kids = new List<kid>();
        List<vehicle> vehicles = new List<vehicle>();
        
        public SequentialClustering(List<kid> passedKids,List<vehicle> passedVehicles)
        {
            kids = passedKids;
            vehicles = passedVehicles;
        }

        void findAllClusters()
        {
            int indexOfVehicle = 0;

            while (kids.count() != 0)
            {
                findMinKid();
                findNNeighbors(vehicles.ElementAt(indexOfVehcile));
                indexOfVehicle++;
            }
        }

        void findMinKid()
        {
            double minX = 100000;
            foreach(kid element in kids)
            {

            }
        }

        void findNNeighbors(vehicle passedVehicle)
        {
            
        }
    }
}
