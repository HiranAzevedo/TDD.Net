using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaNumerosRomanosTest
{
    [TestClass]
    public class ConversorDeNumeroRomanoTest
    {
        [TestMethod]
        public void DeveEntenderOSimboloI()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("I");
            Assert.Equals(1, numero);
        }

        [TestMethod]
        public void DeveEntenderOSimboloV()
        {
            ConversorDeNumeroRomano romano = new ConversorDeNumeroRomano();
            int numero = romano.Converte("V");
            Assert.AreEqual(5, numero);
        }
    }
}
