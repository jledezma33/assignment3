using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeSheet;

namespace TimeSheetTests
{
    [TestClass]
    public class DayTests
    {
        /*
         * How do I enter time for a day?
         * Pass
         * Simplest is 8 hours regular
         * 8 hours sick
         * 24 hours regular
         * 
         * Fall 
         * -1 hours regular, 0 hours should fail too
         * 21 hours regular and 5 hours sick
         *   
         */

        [TestMethod]
        public void TestDayMax()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));


            //act
            d.SetHours(Day.TimeCodes.REGULAR, 8);

            //assert
            Assert.IsTrue(d.Validate());

        }

        [TestMethod]
        public void TestDaySick()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.SetHours(Day.TimeCodes.SICK, 8);

            //assert
            Assert.IsTrue(d.Validate());
        }

        [TestMethod]
        public void TestDayEqual24()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.SetHours(Day.TimeCodes.REGULAR, 24);

            //assert
            Assert.IsTrue(d.Validate());
        }

        [TestMethod]
        public void TestDayMix()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.SetHours(Day.TimeCodes.REGULAR, 8);
            d.SetHours(Day.TimeCodes.SICK, 8);

            //assert
            Assert.IsTrue(d.Validate());
        }

        [TestMethod]
        public void TestDayOver24()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.SetHours(Day.TimeCodes.REGULAR, 21);
            d.SetHours(Day.TimeCodes.SICK, 5);

            //assert
            Assert.IsFalse(d.Validate());
        }

        [TestMethod]
        public void TestDayZero()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.SetHours(Day.TimeCodes.REGULAR, 0);

            //assert
            Assert.IsFalse(d.Validate());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDayNegative()
        {

            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            d.SetHours(Day.TimeCodes.REGULAR, -1);
        }

        [TestMethod]
        public void TestBelow0WithTryCatch()
        {
            //arrange
            Day d = new Day(new DateTime(2016, 6, 28));

            //act
            try
            {
                d.SetHours(Day.TimeCodes.REGULAR, -1);
                Assert.Fail("ArgumentOutOfRangeException was not thrown.");
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }
    }
}
