using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using router.com.system;
using System.Collections.Generic;

namespace RouterUnitTests
{
    [TestClass]
    public class deleteTest
    {
        //Authors:Chris Turki
        //Delete button Test 
        //Same for Vechicle and Kid
        [TestMethod]
        public void TestMethod1()
        {
            System.Windows.Forms.CheckedListBox kids_list_box = new System.Windows.Forms.CheckedListBox() ;

            HashSet<kid> ridingKids = new HashSet<kid>();
            kid turki = new kid("turki/1720");
            kid chris = new kid("chris/1920");
            ridingKids.Add(turki);
            ridingKids.Add(chris);
            kids_list_box.Items.Add(turki);
            kids_list_box.Items.Add(chris);
            kids_list_box.SetItemChecked(0, true);
            List<kid> removedKids = new List<kid>();
            foreach (kid each in kids_list_box.CheckedItems)
            {
                foreach (kid kid in ridingKids)
                {
                    if(kid.Equals(each))
                    {
                        removedKids.Add(kid);
                    }
                }
        }
            foreach(kid rekid in removedKids)
            {
                ridingKids.Remove(rekid);
            }
            foreach (kid each in ridingKids)
            {
                Assert.AreNotEqual("turki", each.getName());
            }
        }
    }
}
