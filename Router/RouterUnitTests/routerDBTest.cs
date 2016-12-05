using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router.com;
using router.com.system;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RouterUnitTests
{
    [TestClass]
    public class routerDBTest
    {
        private router_db db = new router_db("routerTest.sqlite");


        [TestMethod]
        public void InsertData()
        {
            // construct data
            HashSet<vehicle> additional_vehicles = new HashSet<vehicle>();
            HashSet<kid> additional_kids = new HashSet<kid>();
            additional_kids.Add(new kid("simon/owens"));
            additional_vehicles.Add(new vehicle("red/7"));

            // upload data
            db.upload(additional_kids, additional_vehicles);
            db.reload();

            CollectionAssert.Equals(db.getVehicle(), additional_vehicles);
            CollectionAssert.Equals(db.getKids(), additional_kids);

        }
        [TestMethod]
        public void LoadKids()
        {
            InsertData();
            HashSet<kid> firstKid = new HashSet<kid>();
            firstKid.Add(new kid("simon", "owens"));
            HashSet<kid> kids = db.getKids();
            Assert.IsTrue(kids.IsSupersetOf(firstKid));
        }

        [TestMethod]
        public void LoadVehicles()
        {
            InsertData();
            HashSet<vehicle> firstVehicle = new HashSet<vehicle>();
            firstVehicle.Add(new vehicle("red/7"));
            HashSet<vehicle> vehicles = db.getVehicle();
            CollectionAssert.Equals(vehicles, firstVehicle);
        }
    }
}
