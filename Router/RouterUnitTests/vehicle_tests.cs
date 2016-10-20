using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router;
using router.com.system;

namespace RouterUnitTests
{
    [TestClass]
    public class vehicle_tests
    {
        /// <summary>
        /// Tests the explicit vehicle constructor with all three explicit variables being rec'd.
        /// </summary>
        [TestMethod]
        public void VehicleConstructor()
        {
            vehicle car = new vehicle(10, "Red Van", kids_list());
            AssertVehicleEquals(10, "Red Van", kids_list(), car);
        }

        //Authors: Keenen Cates, Simon Owens
        /// <summary>
        /// Tests to see if actual name, capacity, and kid_list match the constructed vehicle object. 
        /// </summary>
        /// <param name="actual_name"></param>
        /// <param name="actual_capacity"></param>
        /// <param name="actual_kids"></param>
        /// <param name="expected_vehicle"></param>
        private void AssertVehicleEquals(int actual_capacity, string actual_name,
                                         List<kid> actual_kids, vehicle expected_vehicle)
        {
            // Test for name
            Assert.AreEqual(actual_name, expected_vehicle.getName());

            // Test for capacity
            Assert.AreEqual(actual_capacity, expected_vehicle.getCapacity());

            // Test for list of kids
            CollectionAssert.AreEqual(actual_kids, expected_vehicle.getKids());
        }

        /// <summary>
        /// Private helper function that returns a list of kids.
        /// </summary>
        /// <returns>List of kids</returns>
        private List<kid> kids_list()
        {
            kid child1 = new kid("Simon Owens", "1312 W CR 250 N Rockport, IN. 47635");
            kid child2 = new kid("Chris Johnson", "5555 W CR 250 N Mars, IN. 47635");
            kid child3 = new kid("Jesus", "Heaven Ave, IN. 99999");

            return new List<kid>(){child1, child2, child3};
        }
    }
}
