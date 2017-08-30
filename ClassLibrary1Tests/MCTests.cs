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
    public class MCTests
    {
        [TestMethod()]
        public void McPrisTest()
        {
            //Arange
            var mc = new MC("1234567",DateTime.Now);
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void McKøretøjTest()
        {
            //Arrange
            var mc = new MC("1234567",DateTime.Now);
            //Act
            string køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("MC",køretøj);
        }
    }
}