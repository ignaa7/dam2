using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio5c;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5c.Tests
{
    [TestClass()]
    public class ServicioTests
    {
        [TestMethod()]
        public void validarTest()
        {
            bool result = Servicio.validar("(2+[3-12]*{8/3})");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void validarTestCadenaVacia()
        {
            bool result = Servicio.validar("");
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void validarTestMal()
        {
            bool result = Servicio.validar("(2+3-12]*{8/3})");
            Assert.IsFalse(result);
        }
    }
}