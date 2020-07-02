using CityDestination.Classes;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitCityDestination
{
    public class UnitTest1
    {
        [Fact]
        public void TestOne()
        {
            List<string> dest1 = new List<string>() { "London", "New York" };
            List<string> dest2 = new List<string>() { "New York", "Lima" };
            List<string> dest3 = new List<string>() { "Lima", "Sao Paulo" };

            string expected = "Sao Paulo";

            List<List<string>> cities = new List<List<string>>();
            cities.Add(dest1);
            cities.Add(dest2);
            cities.Add(dest3);

 
            string actual = MyCityDestination.DestCity(cities);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestTwo()
        {
            List<string> dest1 = new List<string>() { "B", "C" };
            List<string> dest2 = new List<string>() { "D", "B" };
            List<string> dest3 = new List<string>() { "C", "A" };

            string expected = "A";

            List<List<string>> cities = new List<List<string>>();
            cities.Add(dest1);
            cities.Add(dest2);
            cities.Add(dest3);


            string actual = MyCityDestination.DestCity(cities);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestThree()
        {
            List<string> dest1 = new List<string>() { "A", "Z" };

            string expected = "Z";

            List<List<string>> cities = new List<List<string>>();
            cities.Add(dest1);

            string actual = MyCityDestination.DestCity(cities);
            Assert.Equal(expected, actual);
        }
    }
}
