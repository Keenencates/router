using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Router.com.system;
using System.IO;
using static Router.com.system.LocationsCollection;
using router.com.system;

//Author: Zeyu Zhang
//Pair with: Moahmmed Alharthi 
namespace RouterUnitTests
{   //This is the tests for LocationsCollection
    [TestClass]
    public class LocationsCollection_test
    {
        [TestMethod]
        public void LocationsCollection_constructor_test()
        {
            kid[] address = { new kid("kid1", "address1") };
            LocationsCollection a = new LocationsCollection(address, 1);
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void find_location_test()
        {
            kid kid1 = new kid("kid1", "address1");
            kid kid2 = new kid("kid2", "address2");
            kid kid3 = new kid("kid3", "address3");
            kid kid4 = new kid("kid4", "address4");
            kid[] addresses = { kid1, kid2, kid3, kid4 };
            LocationsCollection a = new LocationsCollection(addresses, 4);
            Assert.AreEqual(a.find_location(kid3).get_location_info(), kid3);
        }

        [TestMethod]
        public void parse_json_test()
        {
            kid[] addresses = { new kid("kid1", "addressa1"), new kid("kid2", "address2") };
            LocationsCollection a = new LocationsCollection(addresses, 2);
            string json = "{\n" +
                "\"destination_addresses\" : [ \"stree address, city, state zip, country\" ],\n" +
                "\"origin_addresses\" : [ \"stree address, city, state zip, country\" ],\n" +
                "\"rows\" : [\n" +
                "{\n" +
                "\"elements\" : [\n" +
                "{\n" +
                "\"distance\" : {\n" +
                "\"text\" : \"2.8 mi\",\n" +
                "\"value\" : 4465\n" +
                "},\n" +
                "\"duration\" : {\n" +
                "\"text\" : \"7 mins\",\n" +
                "\"value\" : 431\n" +
                "},\n" +
                "\"status\" : \"OK\"\n" +
                "}\n" +
                "]\n" +
                "}\n" +
                "],\n" +
                "\"status\" : \"OK\"\n" +
                "}\n";
            Assert.AreEqual(a.parse_distance_json(json), 2.8);
            json = "{\n" +
                "\"destination_addresses\" : [ \"stree address, city, state zip, country\" ],\n" +
                "\"origin_addresses\" : [ \"stree address, city, state zip, country\" ],\n" +
                "\"rows\" : [\n" +
                "{\n" +
                "\"elements\" : [\n" +
                "{\n" +
                "\"distance\" : {\n" +
                "\"text\" : \"168 ft\",\n" +
                "\"value\" : 4465\n" +
                "},\n" +
                "\"duration\" : {\n" +
                "\"text\" : \"2 mins\",\n" +
                "\"value\" : 431\n" +
                "},\n" +
                "\"status\" : \"OK\"\n" +
                "}\n" +
                "]\n" +
                "}\n" +
                "],\n" +
                "\"status\" : \"OK\"\n" +
                "}\n";
            Assert.AreEqual(a.parse_distance_json(json), 168 * 0.000189394);
            json = "{\n" +
                   "\"destination_addresses\" : [ \"\" ],\n" +
                   "\"origin_addresses\" : [ \"Chaling, Zhuzhou, Hunan, China, 412412\" ],\n" +
                   "\"rows\" : [\n" +
                   "{\n" +
                   "\"elements\" : [\n" +
                   "{\n" +
                   "\"status\" : \"NOT_FOUND\"\n" +
                   "}\n" +
                   "]\n" +
                   "}\n" +
                   "],\n" +
                   "\"status\" : \"OK\"\n" +
                   "}\n";
            Assert.AreEqual(a.parse_distance_json(json), -1);
            json = "{\n" +
                    "\"destination_addresses\" : [],\n" +
                    "\"origin_addresses\" : [],\n" +
                    "\"rows\" : [],\n" +
                    "\"status\" : \"INVALID_REQUEST\"\n" +
                    "}\n";
            Assert.AreEqual(a.parse_distance_json(json), -1);
        }

        [TestMethod]
        public void get_data_from_api_and_distance_between_test()
        {
            kid[] addresses = {new kid("kid1", "1272 Burdette Ave, Evansville, IN"),
                               new kid("kid2", "1800 Lincoln Ave, Evansville, IN"),
                               new kid("kid3", "401 N Burkhardt Rd, Evansville, IN"),
                               new kid("kid4", "6501 E Lloyd Expy, Evansville, IN"),
                               new kid("kid5", "800 N Green River Rd, Evansville, IN")};
            LocationsCollection a = new LocationsCollection(addresses, 5);
            Assert.AreEqual(a.get_distance_data_from_api(), true);

            Assert.AreEqual(a.distance_between(addresses[0], addresses[1]), 2.8);
            Assert.AreEqual(a.distance_between(addresses[0], addresses[2]), 2.9);
            Assert.AreEqual(a.distance_between(addresses[0], addresses[3]), 2.7);
            Assert.AreEqual(a.distance_between(addresses[0], addresses[4]), 2.4);

            Assert.AreEqual(a.distance_between(addresses[1], addresses[0]), 2.8);
            Assert.AreEqual(a.distance_between(addresses[1], addresses[2]), 4.0);
            Assert.AreEqual(a.distance_between(addresses[1], addresses[3]), 3.8);
            Assert.AreEqual(a.distance_between(addresses[1], addresses[4]), 3.7);

            Assert.AreEqual(a.distance_between(addresses[2], addresses[0]), 3.0);
            Assert.AreEqual(a.distance_between(addresses[2], addresses[1]), 4.2);
            Assert.AreEqual(a.distance_between(addresses[2], addresses[3]), 0.5);
            Assert.AreEqual(a.distance_between(addresses[2], addresses[4]), 1.7);

            Assert.AreEqual(a.distance_between(addresses[3], addresses[0]), 5.6);
            Assert.AreEqual(a.distance_between(addresses[3], addresses[1]), 4.9);
            Assert.AreEqual(a.distance_between(addresses[3], addresses[2]), 1.4);
            Assert.AreEqual(a.distance_between(addresses[3], addresses[4]), 3.1);

            Assert.AreEqual(a.distance_between(addresses[4], addresses[0]), 2.2);
            Assert.AreEqual(a.distance_between(addresses[4], addresses[1]), 3.3);
            Assert.AreEqual(a.distance_between(addresses[4], addresses[2]), 1.8);
            Assert.AreEqual(a.distance_between(addresses[4], addresses[3]), 1.7);
        }
    }

    [TestClass]
    public class locationTest
    {
        [TestMethod]
        public void location_constructor_test()
        {
            location a = new location(new kid("This is a test kid name", "This is test address"));
            Assert.IsNotNull(a);
        }

        [TestMethod]
        public void get_location_info_test()
        {
            location a = new location(new kid("This is a test kid name", "This is test address"));
            Assert.AreEqual(a.get_location_info().getName(), "This is a test kid name");
            Assert.AreEqual(a.get_location_info().getAddress(), "This is test address");
        }

        [TestMethod]
        public void assign_remove_and_distance_to_test()
        {
            location a = new location(new kid("This is a test kid name", "This is test address"));
            location dest1 = new location(new kid("kid1", "Dest1"));
            a.assign_distance_to(dest1, 99.99);
            Assert.AreEqual(a.distance_to(dest1), 99.99);

            a.assign_distance_to(dest1, 88.88);
            Assert.AreEqual(a.distance_to(dest1), 88.88);

            location dest2 = new location(new kid("kid2", "Dest2"));
            a.assign_distance_to(dest2, 1.0);
            Assert.AreEqual(a.distance_to(dest1), 88.88);
            Assert.AreEqual(a.distance_to(dest2), 1.0);

            location destx = new location(new kid("kidx", "Destx"));
            a.remove_distance_to(destx);
            Assert.AreEqual(a.distance_to(dest1), 88.88);
            Assert.AreEqual(a.distance_to(dest2), 1.0);

            a.remove_distance_to(dest1);
            Assert.AreEqual(a.distance_to(dest1), -1);
            Assert.AreEqual(a.distance_to(dest2), 1.0);
        }

        [TestMethod]
        public void closest_place_and_potentially_distance_sort_test()
        {
            location a = new location(new kid("This is a test kid name", "This is test address"));
            location dest1 = new location(new kid("kid1", "Dest1"));
            location dest2 = new location(new kid("kid2", "Dest2"));
            location dest3 = new location(new kid("kid3", "Dest3"));
            location dest4 = new location(new kid("kid4", "Dest4"));
            location dest5 = new location(new kid("kid5", "Dest5"));
            a.assign_distance_to(dest1, 99.99);
            a.assign_distance_to(dest2, 88.88);
            a.assign_distance_to(dest3, 77.77);
            a.assign_distance_to(dest4, 1.0);
            a.assign_distance_to(dest5, 66.66);

            Assert.AreEqual(a.closest_place(), dest4);
        }

        [TestMethod]
        public void ToString_test()
        {
            location a = new location(new kid("This is a test kid name", "This is test address"));
            Assert.AreEqual(a.ToString(), "This is a test kid name/This is test address");
        }

        [TestMethod]
        public void location_Equals_test()
        {
            location a = new location(new kid("This is a test kid name", "This is test address"));
            Assert.AreEqual(a.Equals(new location(new kid("This is a test kid name", "This is test address"))), true);
            Assert.AreEqual(a.Equals(new location(new kid("This is a different test kid name", "This is different test address"))), false);
            location b = new location(new kid("This is a test kid name", "This is test address"));
            Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        }
    }
}
