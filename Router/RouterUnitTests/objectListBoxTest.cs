using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using router.com.system;
using System.Collections.Generic;
using Router.com.system;
using System.Linq;

namespace RouterUnitTests
{
    [TestClass]
    public class objectListBoxTest
    {
        //Authors:Chris Turki
        //Delete button Test 
        //Same for Vechicle and Kid
        //--------------------------
        //--------------------------
        // Modifted By 
        //  Turki and Mohammed 

        [TestMethod]
        public void kidRemoveTest()
        {
            kidListBox kids_list_box = new kidListBox() ;
            kid turki = new kid("turki/1720");
            kid chris = new kid("chris/1920");
            kids_list_box.add(turki);
            kids_list_box.add(chris);
            //checks item at index 0
            kids_list_box.SetItemChecked(0, true);
            kids_list_box.deleteChecked();

            foreach (kid each in kids_list_box.getSet())
            {
                Assert.AreNotEqual("turki", each.getName());
            }
        }


        [TestMethod]
        public void VehicleRemoveTest()
        {
            vehicleListBox vehicles_list_box = new vehicleListBox();
            vehicle turki = new vehicle("turki/1720");
            vehicle chris = new vehicle("chris/1920");
            vehicles_list_box.add(turki);
            vehicles_list_box.add(chris);
            //checks item at index 0
            vehicles_list_box.SetItemChecked(0, true);
            vehicles_list_box.deleteChecked();

            foreach (vehicle each in vehicles_list_box.getSet())
            {
                Assert.AreNotEqual("turki/1720", each.ToString());
            }
        }
        [TestMethod]
        public void containsTest()
        {
            vehicleListBox vehicles_list_box = new vehicleListBox();
            vehicle chris = new vehicle("chris/1920");
            vehicles_list_box.add(chris);
            Assert.IsTrue(vehicles_list_box.contains(chris));


            kidListBox kids_list_box = new kidListBox();
            kid turki = new kid("turki/1720");
            kids_list_box.add(turki);
            Assert.IsTrue(kids_list_box.contains(turki));
        }

        [TestMethod]
        public void getSetTest()
        {
            vehicleListBox vehicles_list_box = new vehicleListBox();
            HashSet<vehicle> vSet = new HashSet<vehicle>();
            vehicle mohammad = new vehicle("mohammed/12");
            vehicle chris = new vehicle("chris/1920");
            vehicles_list_box.add(chris);
            vehicles_list_box.add(mohammad);
            vSet.Add(chris);
            vSet.Add(mohammad);
            CollectionAssert.AreEqual(vSet.ToList(), vehicles_list_box.getSet().ToList());

            HashSet<kid> k = new HashSet<kid>();
            kidListBox kids_list_box = new kidListBox();
            kid turki = new kid("turki/1720");
            kid simon = new kid("simon/1222");
            kids_list_box.add(simon);
            kids_list_box.add(turki);
            k.Add(simon);
            k.Add(turki);
            CollectionAssert.AreEqual(k.ToList(), kids_list_box.getSet().ToList());
        }
    }
}
