using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router;
using router.com.system;
using System.Windows.Forms;

namespace RouterUnitTests
{
    [TestClass]
    public class kid_tests
    {
        //Authors: Simon Owens, Keenen Cates
        ///<summary>Tests explicit constructor that takes a string name and string address</summary>
        [TestMethod]
        public void ExplicitNameAddrKidConstructor()
        {
            kid child = new kid("Simon Owens", "1312 W CR 250 N Rockport, IN. 47635");
            AssertKidEquals(    "Simon Owens", "1312 W CR 250 N Rockport, IN. 47635", child);
        }

        //Authors: Keenen Cates, Simon Owens
        ///<summary>Tests explicit constructor that takes a string and constructs a kid.</summary>
        [TestMethod]
        public void StringToKidConstructor()
        {
            kid child = new kid("Keenen Cates/123 street st, IN. 11111");
            AssertKidEquals(    "Keenen Cates", "123 street st, IN. 11111", child);
        }

        /// <summary>
        /// Tests kid.ToString() method.
        /// </summary>
        [TestMethod]
        public void KidToString()
        {
            kid child = new kid("Keenen Cates/123 street st, IN. 11111");
            Assert.AreEqual("Keenen Cates/123 street st, IN. 11111", child.ToString());
        }

        /// <summary>
        /// Test Equals() method.
        /// </summary>
        [TestMethod]
        public void Equality()
        {
            kid child1 = new kid("sam/123 street");
            kid child2 = new kid("sam/123 street");
            Assert.AreEqual(true, child1.Equals(child2));
        }

        [TestMethod]
        public void getPoint()
        {
            point p = new point(-87.533201, 37.967409);
            kid child1 = new kid("sam/1720  gum st");
            Assert.AreEqual(p.getLongitude(), child1.getPoint().getLongitude());
            Assert.AreEqual(p.getLatitude(), child1.getPoint().getLatitude());
        }
        //Authors: Keenen Cates, Simon Owens
        /// <summary>
        /// Tests to see if actual name and actual address match expected values. Otherwise, fail assertions.
        /// </summary>
        /// <param name="expected_name"> Expected name of kid. </param>
        /// <param name="expected_addr"> Expected Address of kid. </param>
        /// <param name="actual_kid"> Actual kid object. </param>
        private void AssertKidEquals(string expected_name, string expected_addr, kid actual_kid)
        {
            // Test for name
            Assert.AreEqual(expected_name, actual_kid.getName());

            // Test for address
            Assert.AreEqual(expected_addr, actual_kid.getAddress());
        }
    }
}
