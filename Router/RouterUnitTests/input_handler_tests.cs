using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router;
using System.Collections.Generic;

namespace RouterUnitTests
{
    [TestClass]
    public class InputHandlerTests
    {

        [TestMethod]
        public void InputTest()
        {
            input_handler handler = new input_handler();
            handler.insert("Test");
            Assert.AreEqual(0, handler.find("Test"));
        }

        [TestMethod]
        public void OutputTest()
        {
            input_handler handler = new input_handler();
            handler.insert("Test");
            Assert.AreEqual("Test", handler.get(handler.find("Test")));
        }
    }
}
