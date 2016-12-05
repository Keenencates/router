using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Router.com.gui;

namespace router.com.system
{
    public class route_manager
    {
        private HashSet<kid> kids;
        private HashSet<vehicle> vehicles;
        private List<vehicle> routed_vehicles;

        private route_visualizer visualizer;

        public route_manager(HashSet<kid> kids, HashSet<vehicle> vehicles)
        {
            this.kids = kids;
            this.vehicles = vehicles;
        }

        public void computeRoutes()
        {
            //string output = "";
            //foreach(var each in vehicles)
            //{
            //    output += each.getName() + ": \r\n\t";
            //    foreach(var each2 in kids)
            //    {
            //        output += each2.getName() + ": " + each2.getAddress() + " \r\n\t";
            //        each.load_kid(each2);
            //    }
            //    routes.Add(each.getName(), output);
            //}
            SequentialCluster clusters = new SequentialCluster(kids.ToList(), vehicles.ToList());
            clusters.findAllClusters();
            routed_vehicles = clusters.getClusterListVehicles();
        }

        public List<vehicle> getRoutes()
        {
            return routed_vehicles;
        }

        public void printFiles(string file_dir)
        {
            foreach(var each in routed_vehicles)
            {
                Directory.CreateDirectory(file_dir);
                String output = each.getName() + " : \n";
                foreach(kid each2 in each.getKids())
                {
                    output += (each2.getName() + "; " + each2.getAddress() + "\n");
                }
                File.WriteAllText(file_dir + each.getName() + ".txt", output);
            }
        }

        public void displayRoute()
        {
            visualizer = new route_visualizer(new HashSet<vehicle> (routed_vehicles));
            visualizer.Show();
        }
    }
}