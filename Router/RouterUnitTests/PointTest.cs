using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using router.com.system;

namespace RouterUnitTests
{
    [TestClass]
    public class PointTest
    {
        [TestMethod]
        public void dist()
        {
            point p = new point(3,4 );
            point p2 = new point(0, 0);
            Assert.AreEqual(5, p.disTo(p2));
        }
    }
}
