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
    public class ExceptionEnCeroTests
    {
        [TestMethod()]
        //[ExpectedException(typeof(DivideByZeroException))]
        public void DivisionEnCeroTest()
        {
            //arrege
            int numero = 1;
            DivideByZeroException e = new DivideByZeroException();
            string message = e.Message;
            
            //act
            string men = ExceptionEnCero.DivisionEnCero(numero);

            //assert 
            Assert.AreEqual(message, men);
        }
    }
}