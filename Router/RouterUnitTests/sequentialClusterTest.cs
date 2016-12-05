using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using router.com.system;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;


/*
 *Authors: Chris, Turki 
 */

namespace RouterUnitTests
{
    [TestClass]
    public class sequentialClusterTest
    {
        //test main constructor
        [TestMethod]
        public void SequentialClusterConstructorTest()
        {
            List<vehicle> rightResult;
            List<kid> kids = new List<kid>();
            kids.Add(new kid("Turonis/488 N Main St, Evansville, IN 47711, USA"));
            kids.Add(new kid("Waltons/956 Parrett St, Evansville, IN 47713 USA"));
            kids.Add(new kid("Taco John's/ 2509 Washington Ave, Evansville, IN 47714, USA"));
            kids.Add(new kid("ri ra/701 NW Riverside Dr, Evansville, IN 47708, USA"));
            kids.Add(new kid("O'Charles/7301 E indiana st, Evansville, IN 47715,USA"));
            List<vehicle> vehicles = new List<vehicle>();
            vehicles.Add(new vehicle("van/4"));
            vehicles.Add(new vehicle("truck/2"));
            SequentialCluster clusters = new SequentialCluster(kids,vehicles);

            Assert.AreEqual(clusters.getKidsList(), kids);
            Assert.AreEqual(clusters.getVehiclesList(),vehicles);
        }

        [TestMethod]
        public void SequentialClusterMinKidTest()
        {
            List<vehicle> rightResult;
            List<kid> kids = new List<kid>();
            kids.Add(new kid("Turonis/488 N Main St, Evansville, IN 47711, USA"));//0
            kids.Add(new kid("Waltons/956 Parrett St, Evansville, IN 47713 USA"));//1
            kids.Add(new kid("Taco John's/ 2509 Washington Ave, Evansville, IN 47714, USA"));//2
            kids.Add(new kid("ri ra/701 NW Riverside Dr, Evansville, IN 47708, USA"));//3
            kids.Add(new kid("O'Charles/7301 E indiana st, Evansville, IN 47715,USA"));//4
            kids.Add(new kid("Los Bravos/3534 N First Ave, Evansville, IN 47710"));//5
            List<vehicle> vehicles = new List<vehicle>();
            vehicles.Add(new vehicle("van/5"));
            vehicles.Add(new vehicle("truck/5"));
            SequentialCluster clusters = new SequentialCluster(kids, vehicles);
            Assert.AreEqual(clusters.getMinKid(), kids.ElementAt(5));
        }

        
        [TestMethod]
        public void SequentialClusterfindAllTest()
        {
            List<vehicle> acceptedResult =new List<vehicle>();
            List<kid> kids = new List<kid>();

            kids.Add(new kid("Turonis/488 N Main St, Evansville, IN 47711, USA"));//0
            kids.Add(new kid("Waltons/956 Parrett St, Evansville, IN 47713 USA"));//1
            kids.Add(new kid("Taco John's/ 2509 Washington Ave, Evansville, IN 47714, USA"));//2
            kids.Add(new kid("ri ra/701 NW Riverside Dr, Evansville, IN 47708, USA"));//3
            kids.Add(new kid("O'Charles/7301 E indiana st, Evansville, IN 47715,USA"));//4
            kids.Add(new kid("Los Bravos/3534 N First Ave, Evansville, IN 47710"));//5

            List<vehicle> vehicles = new List<vehicle>();
            vehicles.Add(new vehicle("van/3"));
            vehicles.Add(new vehicle("truck/5"));
            SequentialCluster clusters = new SequentialCluster(kids, vehicles);
            clusters.findAllClusters();

            kids.Add(new kid("Turonis/488 N Main St, Evansville, IN 47711, USA"));//0
            kids.Add(new kid("Waltons/956 Parrett St, Evansville, IN 47713 USA"));//1
            kids.Add(new kid("Taco John's/ 2509 Washington Ave, Evansville, IN 47714, USA"));//2
            kids.Add(new kid("ri ra/701 NW Riverside Dr, Evansville, IN 47708, USA"));//3
            kids.Add(new kid("O'Charles/7301 E indiana st, Evansville, IN 47715,USA"));//4
            kids.Add(new kid("Los Bravos/3534 N First Ave, Evansville, IN 47710"));//5
            //MessageBox.Show(kids.ElementAt(0).ToString());
            /*
            MessageBox.Show(clusters.getClusterListVehicles().ElementAt(0).getKids().ElementAt(0).ToString());
            MessageBox.Show(clusters.getClusterListVehicles().ElementAt(0).getKids().ElementAt(1).ToString());
            MessageBox.Show(clusters.getClusterListVehicles().ElementAt(0).getKids().ElementAt(2).ToString());
            MessageBox.Show(clusters.getClusterListVehicles().ElementAt(1).getKids().ElementAt(0).ToString());
            MessageBox.Show(clusters.getClusterListVehicles().ElementAt(1).getKids().ElementAt(1).ToString());
            MessageBox.Show(clusters.getClusterListVehicles().ElementAt(1).getKids().ElementAt(2).ToString());
            */

            Assert.AreEqual(clusters.getClusterListVehicles().ElementAt(0).getKids().ElementAt(0), kids.ElementAt(5));
            Assert.AreEqual(clusters.getClusterListVehicles().ElementAt(0).getKids().ElementAt(1), kids.ElementAt(0));
            Assert.AreEqual(clusters.getClusterListVehicles().ElementAt(0).getKids().ElementAt(2), kids.ElementAt(3));
            Assert.AreEqual(clusters.getClusterListVehicles().ElementAt(1).getKids().ElementAt(0), kids.ElementAt(4));
            Assert.AreEqual(clusters.getClusterListVehicles().ElementAt(1).getKids().ElementAt(1), kids.ElementAt(2));
            Assert.AreEqual(clusters.getClusterListVehicles().ElementAt(1).getKids().ElementAt(2), kids.ElementAt(1));

        }
        

    }
}
