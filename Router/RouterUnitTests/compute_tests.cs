using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using router.com.system;
using System.Collections.Generic;
using System.IO;

namespace RouterUnitTests
{
    [TestClass]
    public class compute_tests
    {
        [TestMethod]
        public void compute_one_kid_test()
        {
            HashSet<kid> kids = new HashSet<kid>{new kid("Keenen Cates/Main st.")};
            HashSet<vehicle> vehicles = new HashSet<vehicle>{new vehicle(5, "Honda Civic", kids)};
            route_manager manager = new route_manager(kids, vehicles);
            manager.computeRoutes();
            foreach (var each in manager.getRoutes())
            {
                Assert.AreEqual(each.Value, "Honda Civic: \r\n\tKeenen Cates: Main st. \r\n\t");
            }
        }

        [TestMethod]
        public void compute_two_kid_test()
        {
            HashSet<kid> kids = new HashSet<kid> { new kid("Keenen Cates/Main st."), new kid("Zeyu Zhang/Lincoln ave.") };
            HashSet<vehicle> vehicles = new HashSet<vehicle> { new vehicle(5, "Honda Civic", kids) };
            route_manager manager = new route_manager(kids, vehicles);
            manager.computeRoutes();
            foreach (var each in manager.getRoutes())
            {
                Assert.AreEqual(each.Value, "Honda Civic: \r\n\tKeenen Cates: Main st. \r\n\t" +
                                                           "Zeyu Zhang: Lincoln ave. \r\n\t");
            }
        }

        [TestMethod]
        public void print_route_output_test()
        {
            HashSet<kid> kids = new HashSet<kid> { new kid("Keenen Cates/Main st."), new kid("Zeyu Zhang/Lincoln ave.") };
            HashSet<vehicle> vehicles = new HashSet<vehicle> { new vehicle(5, "Honda Civic", kids) };
            route_manager manager = new route_manager(kids, vehicles);
            manager.computeRoutes();
            manager.printFiles("output_routes/");
            string test = File.ReadAllText("output_routes/Honda Civic.txt");
            Assert.AreEqual(test, "Honda Civic: \r\n\tKeenen Cates: Main st. \r\n\t" +
                                                 "Zeyu Zhang: Lincoln ave. \r\n\t");
        }
    }
}
