using DemoLibreria;

namespace DemoPrueba
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables -> Arrange
            decimal numero1 = 6;
            decimal numero2 = 7;

            // Ejecutamos la prueba -> Act
            decimal resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            decimal valorEsperado = 13;
            Assert.AreEqual(resultado, valorEsperado);
        }

        [TestMethod]
        public void TestResta()
        {
            // Definimos las variables -> Arrange
            decimal numero1 = 6;
            decimal numero2 = 7;

            // Ejecutamos la prueba -> Act
            decimal resultado = Calculadora.restar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            decimal valorEsperado = -1;
            Assert.AreEqual(resultado, valorEsperado);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            // Definimos las variables -> Arrange
            decimal numero1 = 6;
            decimal numero2 = 7;

            // Ejecutamos la prueba -> Act
            decimal resultado = Calculadora.multiplicar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            decimal valorEsperado = 42;
            Assert.AreEqual(resultado, valorEsperado);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Definimos las variables -> Arrange
            decimal numero1 = 15;
            decimal numero2 = 3;

            // Ejecutamos la prueba -> Act
            decimal resultado = Calculadora.dividir(numero1, numero2);

            // Comprobamos los resultados -> Assert
            decimal valorEsperado = 5;
            Assert.AreEqual(resultado, valorEsperado);
        }
    }
}