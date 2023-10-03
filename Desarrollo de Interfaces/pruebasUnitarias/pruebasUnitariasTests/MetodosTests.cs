using Microsoft.VisualStudio.TestTools.UnitTesting;
using pruebasUnitarias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebasUnitarias.Tests
{
    [TestClass()]
    public class MetodosTests
    {
        [TestMethod()]
        public void devolverStringTest()
        {
            string result = Metodos.devolverString(new string[] { "Esto ", "es ", "una ", "cadena" });
            Assert.AreEqual(result, "Esto es una cadena");
        }
    }
}