using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using router.com.system;
using System.Collections.Generic;
using Router.com.system;
using System.Linq;
using Router.com.gui;

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

        // test that nothing happens when we click exit instead of save

        // test vehicleListBox edit method
        [TestMethod]
        public void editKidTest()
        {
            // make a kid and add him to the list
            kidListBox kid_list_box = new kidListBox();
            kid child = new kid("Simon Owens", "Lincoln Ave");
            kid_list_box.add(child);

            // edit him
            kid_list_box.edit(child, "Don Roberts", "Heaven Ave");

            // only kid that should exist is the kid that we edited
            HashSet<kid> expectedList = new HashSet<kid>();
            kid expected = new kid("Don Roberts/Heaven Ave");
            expectedList.Add(expected);

            CollectionAssert.Equals(expectedList.ToList(), kid_list_box.getSet().ToList());
        }

        // test kidListBox edit method
        [TestMethod]
        public void editVehicleTest()
        {
            // make a vehicle and add him to the list
            vehicleListBox vehicle_list_box = new vehicleListBox();
            vehicle van = new vehicle("Red Van/7");
            vehicle_list_box.add(van);

            // edit it
            vehicle_list_box.edit(van, "Blue Van", 10);

            // only vehicle that should exist is the vehilce that we edited
            HashSet<vehicle> expectedList = new HashSet<vehicle>();
            vehicle expected = new vehicle("Blue Van/10");
            expectedList.Add(expected);

            CollectionAssert.Equals(expectedList.ToList(), vehicle_list_box.getSet().ToList());
        }

        // if we edit a kid to a kid that is already in the current list, it should only keep the newly edited kid
        [TestMethod]
        public void editAlreadyExisitingKidTest()
        {
            // add two kids to the list
            kidListBox kid_list_box = new kidListBox();
            kid child1 = new kid("Simon Owens", "Lincoln Ave");
            kid child2 = new kid("Don Roberts/Heaven Ave");
            kid_list_box.add(child1);
            kid_list_box.add(child2);

            // edit one to what the other kid already is
            kid_list_box.edit(child1, "Don Roberts", "Heaven Ave");

            // we already have what we edited, the edited copy should be all that is left
            HashSet<kid> expectedList = new HashSet<kid>();
            kid expected = new kid("Don Roberts/Heaven Ave");
            expectedList.Add(expected);

            CollectionAssert.Equals(expectedList.ToList(), kid_list_box.getSet().ToList());
        }

        // if we edit a vehicle to a vehicle that is already in the current list, it should onlyu keep the newly edited kid
        [TestMethod]
        public void editAlreadyExisitingVehicleTest()
        {
            // add two vehilces to the list
            vehicleListBox vehicle_list_box = new vehicleListBox();
            vehicle van1 = new vehicle("Red Van/7");
            vehicle van2 = new vehicle("Blue Van/10");
            vehicle_list_box.add(van1);
            vehicle_list_box.add(van2);

            // edit one of the vehilces to what another vehicle again.  
            vehicle_list_box.edit(van1, "Blue Van", 10);

            // only vehicle that should exist is the vehilce that we edited
            HashSet<vehicle> expectedList = new HashSet<vehicle>();
            vehicle expected = new vehicle("Blue Van/10");
            expectedList.Add(expected);

            CollectionAssert.Equals(expectedList.ToList(), vehicle_list_box.getSet().ToList());
        }
    }
}
