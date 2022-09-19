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
    public class LogicTests
    {
        [TestMethod()]
        public void ingenioTest()
        {
            //arrege
            int posicion = 7;

            //act
            Logic.ingenio(posicion);

        }
    }
}