using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            var bil = new Bil();
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void KøretøjTest()
        {
            //Arrange
            var bil = new Bil();
            //Act
            string køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Bil",køretøj);
        }
    }
}