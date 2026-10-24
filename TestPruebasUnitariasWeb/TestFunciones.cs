using PruebasUnitariasWeb;

namespace TestPruebasUnitariasWeb

{
    [TestClass]
    public sealed class TestFunciones
    {
        [TestMethod]
        public void Factorial_Negativo()
        {
            Assert.AreEqual(
                -1,
                Funciones.CalcularFactorial(-5)
            );
        }

        [TestMethod]
        public void Factorial_Cero()
        {
            Assert.AreEqual(
                1,
                Funciones.CalcularFactorial(0)
            );
        }

        [TestMethod]
        public void Factorial_5()
        {
            Assert.AreEqual(
                120,
                Funciones.CalcularFactorial(5)
            );
        }
        [TestMethod]
        public void EsContrasenyaValida_EsNull()
        {
            Assert.IsFalse(
                Funciones.EsContrasenyaValida(null)
            );
        }

        [TestMethod]
        public void EsContrasenyaValida_EstaVacia()
        {
            Assert.IsFalse(
                Funciones.EsContrasenyaValida("")
            );
        }

        [TestMethod]
        public void EsContrasenyaValida_LongitudMenor8()
        {
            Assert.IsFalse(
                Funciones.EsContrasenyaValida("abc#")
            );
        }

        [TestMethod]
        public void EsContrasenyaValida_SinAlmohadilla()
        {
            Assert.IsFalse(
                Funciones.EsContrasenyaValida("abcdefgh")
            );
        }

        [TestMethod]
        public void EsContrasenyaValida_Valida()
        {
            Assert.IsTrue(
                Funciones.EsContrasenyaValida("abcd#123")
            );
        }
    }
}

