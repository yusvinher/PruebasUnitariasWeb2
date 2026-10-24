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
    }
}

