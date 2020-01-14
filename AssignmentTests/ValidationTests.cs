using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void ValidationTest()
        {
            //arrange
            var Validation = new Validate();
            var Input = "Circle 100";

            //act
            string[] result = Validation.getValidate(Input);

            //assert
            Assert.AreEqual("100", result[1]);
        }
    }
}