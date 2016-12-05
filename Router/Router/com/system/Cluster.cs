using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Router.com.system
{
    class Cluster
    {
        kid min_kid;
        List<kid> kids = new List<kid>();
        List<vehicle> vehicles = new List<vehicle>();

        public Cluster(List<kid> passedKids, List<vehicle> passedVehicles)
        {
            kids = passedKids;
            vehicles = passedVehicles;
        }

    }
}


//namespace Router.com.system.
//{
//    class Cluster
//    {
        


//        void findAllClusters()
//        {
//            int indexOfVehicle = 0;

//            while (kids.Count() != 0)
//            {
//                findMinKid();
//                findNNeighbors(vehicles.ElementAt(indexOfVehicle));
//                indexOfVehicle++;
//            }
//        }

//        void findMinKid()
//        {
//            double minX = kids.ElementAt(0).getPoint().getLongitude();
//            min_kid = kids.ElementAt(0);
//            foreach (kid element in kids)
//            {
//                if (minX < element.getPoint().getLongitude())
//                {
//                    minX = element.getPoint().getLongitude();
//                    min_kid = element;
//                }
//            }

//        }

//        void findNNeighbors(vehicle passedVehicle)
//        {
//            passedVehicle.addKid(min_kid);
//            for (int i = 1; i < passedVehicle.getCapacity(); i++)
//            {
//                kid k = findminDist();

//                passedVehicle.addKid(k);
//                kids.Remove(k);
//            }
//            kids.Remove(min_kid);
//        }

//        private kid findminDist()
//        {
//            double mindist = 0;
//            kid min = null;
//            foreach (kid each in kids)
//            {
//                double dist = min_kid.getPoint().disTo(each.getPoint());
//                if (mindist > dist)
//                {
//                    mindist = dist;
//                    min = each;
//                }
//            }
//            return min;
//        }

//        public List<vehicle> getClusterListVehicles()
//        {
//            return vehicles;
//        }
//    }
//}
