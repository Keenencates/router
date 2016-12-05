using router.com.system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Author: Chris,Zeyu,Turki
 */

namespace router.com.system
{
    public class SequentialCluster
    {
        kid min_kid;
        List<kid> kids = new List<kid>();
        List<vehicle> vehicles = new List<vehicle>();

        public SequentialCluster(List<kid> passedKids, List<vehicle> passedVehicles)
        {
            kids = passedKids;
            vehicles = passedVehicles;
        }

        public void findAllClusters()
        {
            int indexOfVehicle = 0;

            while (kids.Count() != 0)
            {
                findMinKid();
                findNNeighbors(vehicles.ElementAt(indexOfVehicle),indexOfVehicle);
                indexOfVehicle++;
            }
        }

        void findMinKid()
        {
            double minY = kids.ElementAt(0).getPoint().getLatitude();
            min_kid = kids.ElementAt(0);
            foreach (kid element in kids)
            {
                if (minY < element.getPoint().getLatitude())
                {
                    minY = element.getPoint().getLatitude();
                    min_kid = element;
                }
            }

        }

        public void findNNeighbors(vehicle passedVehicle,int indexOfVehicle)
        {
            passedVehicle.addKid(min_kid);
            for(int i=1; i < passedVehicle.getCapacity(); i++)
            {
                kid k = findminDist();

                passedVehicle.addKid(k);
                kids.Remove(k);
            }
            kids.Remove(min_kid);
            vehicles.ElementAt(indexOfVehicle).addKids(passedVehicle.getKids());
        }

        private kid findminDist()
        {
           double mindist = 100000;
            kid min = null;
            foreach (kid each in kids)
            {
                double dist = min_kid.getPoint().disTo(each.getPoint());
                if(mindist > dist && each != min_kid)
                {
                    mindist = dist;
                    min = each;
                }
            }
            return min;
        }

        public List<kid> getKidsList()
        {
            return kids;
        }

        public List<vehicle> getVehiclesList()
        {
            return vehicles;
        }

        public kid getMinKid()
        {
            findMinKid();
            return min_kid;
        }

        public kid getMinDistKid()
        {
            findMinKid();
            return findminDist();
        }

        public List<vehicle> getClusterListVehicles()
        {
            return vehicles;
        }
    }
}
