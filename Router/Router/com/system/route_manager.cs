﻿using System;
using System.Collections.Generic;
using System.IO;
using Router.com.gui;

namespace router.com.system
{
    public class route_manager
    {
        private HashSet<kid> kids;
        private HashSet<vehicle> vehicles;

        private route_visualizer visualizer;

        private Dictionary<string, string> routes;

        public route_manager(HashSet<kid> kids, HashSet<vehicle> vehicles)
        {
            if(vehicles.Count == 1)
            {
                routes = new Dictionary<string, string>();
                this.kids = kids;
                this.vehicles = vehicles;
            } else
            {
                throw new InvalidOperationException();
            }
                
        }

        public void computeRoutes()
        {
            string output = "";
            foreach(var each in vehicles)
            {
                output += each.getName() + ": \r\n\t";
                foreach(var each2 in kids)
                {
                    output += each2.getName() + ": " + each2.getAddress() + " \r\n\t";
                    each.load_kid(each2);
                }
                routes.Add(each.getName(), output);
            }
        }

        public Dictionary<string, string> getRoutes()
        {
            return routes;
        }

        public void printFiles(string file_dir)
        {
            foreach(var each in routes)
            {
                Directory.CreateDirectory(file_dir);
                File.WriteAllText(file_dir + each.Key + ".txt", each.Value);
            }
        }

        public void displayRoute()
        {
            visualizer = new route_visualizer(vehicles);
            visualizer.Show();
        }
    }
}