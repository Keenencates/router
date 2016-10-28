using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router;
using System.Collections.Generic;
using router.com.system;
using router.com.gui;

namespace RouterUnitTests
{
    [TestClass]
    public class InputHandlerTests
    {
        [TestMethod]
        public void InputKidTest()
        {
            input_handler handler = new input_handler();
            observable_list_box mybox = new observable_list_box();
            handler.insert_kid("Test/Test ADDR");
            handler.Subscribe(mybox);
            Assert.AreEqual(true, mybox.Items.Contains("Test"));
        }
        [TestMethod]
        public void InputVehicleTest()
        {
            input_handler handler = new input_handler();
            observable_list_box mybox = new observable_list_box();
            handler.insert_vehicle("Test");
            handler.Subscribe(mybox);
            Assert.AreEqual(true, mybox.Items.Contains("Test"));
        }
    }
}
