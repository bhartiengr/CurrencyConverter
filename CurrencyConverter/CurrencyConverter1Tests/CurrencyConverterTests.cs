using Microsoft.VisualStudio.TestTools.UnitTesting;
using CurrencyConverter1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter1.Tests
{
    [TestClass()]
    public class CurrencyConverterTests
    {
        

        [TestMethod()]
        public void TestExceptionCase()
        {

            try
            {
                CurrencyConverter curcon = new CurrencyConverter();
                

            }
            catch(ArgumentOutOfRangeException e)
            {

            }
            Assert.Fail("No Exceptiom was thrown");
        }
    }
}