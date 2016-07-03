using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeSheet;

namespace TimeSheetTests
{
    [TestClass]
    public class TimeCardTests
    {
        [TestMethod]
        public void TestOvetime()
        {
            //arrange
            TimeCard t = new TimeCard();
            float expected = 44; //hours

            //act
            foreach(Day d in Enum.GetValues(typeof(DayOfWeek))){
                d.SetHours(Day.TimeCodes.REGULAR, 8);
            }

            //assert
            Assert.AreEqual(expected, t.CalculateOvertime(1));
        }

        public void TestSunday()
        {
            //arrange
            TimeCard t = new TimeCard();
            float expected = 44; //hours

            //act
            foreach (Day d in Enum.GetValues(typeof(DayOfWeek)))
            {
                d.SetHours(Day.TimeCodes.REGULAR, 8);
            }

            //assert
            Assert.AreEqual(expected, t.CalculateOvertime(1));
        }
    }
}
