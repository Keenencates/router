using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router;

namespace RouterUnitTests
{
    [TestClass]
    public class TestKidAndVehicleConstructors
    {
        [TestMethod]
        public void KidConstructor()
        {
            kid child1 = new kid("Simon Owens", "1312 W CR 250 N Rockport, IN. 47635");

            // Test for name
            string expected = child1.getName();
            string actual = "Simon Owens";
            Assert.Equals(actual, expected);

            // Test for address
            expected = child1.getAddress();
            actual = "1312 W CR 250 N Rockport, IN. 47635";
            Assert.Equals(actual, expected);
        }

        [TestMethod]
        public void VehicleConstructor()
        {
            #region Making kids List
            //create a list of kids for vehicle to contain
            kid child1 = new kid("Simon Owens", "1312 W CR 250 N Rockport, IN. 47635");
            kid child2 = new kid("Chris Johnson", "5555 W CR 250 N Mars, IN. 47635");
            kid child3 = new kid("Jesus", "Heaven Ave, IN. 99999");
            List<kid> kids_list = new List<kid>();
            
            kids_list.Add(child1);
            kids_list.Add(child2);
            kids_list.Add(child3);
            #endregion Making kids List

            vehicle v1 = new vehicle(10, "Red Van", kids_list);

            // Test for Capacity
            int expected = v1.getCapacity();
            int actual = 10;
            Assert.Equals(actual, expected);

            // Test for name
            string expected_name = v1.getName();
            string actual_name = "Red Van";
            Assert.Equals(actual_name, expected_name);

            // Test for list of kids
            List<kid> expected_kids = v1.getKids();
            Assert.Equals(kids_list, expected_kids);


        }
    }
}
