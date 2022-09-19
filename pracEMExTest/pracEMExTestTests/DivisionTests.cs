using Microsoft.VisualStudio.TestTools.UnitTesting;
using pracEMExTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pracEMExTest.Tests
{
    [TestClass()]
    public class DivisionTests
    {
        [TestMethod()]
        public void DivTest()
        {
            //arrege
            decimal dividendo = 10;
            decimal divisor = 0;
            decimal result = dividendo * divisor;

            //act
           result = Division.Div(dividendo,divisor);

            ////assert
            //Assert.Fail();
        }
    }
}