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
        public void BilPrisTest()
        {
            //Arrange
            var bil = new Bil("1234567", DateTime.Now);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240,pris);
        }

        [TestMethod()]
        public void BilKøretøjTest()
        {
            //Arrange
            var bil = new Bil("1234567", DateTime.Now);
            //Act
            string køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Bil",køretøj);
        }
        [TestMethod()]
        public void BilNummberpladeTest()
        {
            //Arrange
            var bil = new Bil("1234567",DateTime.Now);
            //Act
            string nummerplade = bil.Nummberpladecount();
            //Assert
            Assert.AreEqual("Bil", nummerplade);
        }
    }
}