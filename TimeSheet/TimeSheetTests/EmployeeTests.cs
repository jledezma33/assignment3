using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetTests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void testTest()
        {
            //arrange
            Employee e = new Employee()
            {
                FirstName = "Matt",
                LastName = "Warner",
                Age = 23
            };
            int expected = 23;

            //act  
            e.Age = 23;

            //assert
            Assert.AreEqual(expected, e.Age);
         }

     }
 }
