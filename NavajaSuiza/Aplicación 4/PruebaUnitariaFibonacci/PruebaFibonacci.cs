using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion4;

namespace PruebaUnitariaFibonacci
{
    [TestClass]
    public class FibonacciPruebas
    {
        /// <summary>
        /// Si el resultado es correcto
        /// </summary>
        [TestMethod]
        public void FibonacciCorrecto()
        {
            LogicaFibonacci ResultadoFibonacci = new LogicaFibonacci();
            int Numero = 3;
            string ResultadoObtenido = " ";

            string ResultadoEsperado = "la sucesion es + 1 + 1 + 2";

            ResultadoObtenido = ResultadoFibonacci.CalcularFibonacci(Numero);
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
        /// <summary>
        /// Si el resultado es negativo o Cero
        /// </summary>
        [TestMethod]
        public void FibonacciNegativoOCero()
        {
            LogicaFibonacci ResultadoFibonacci = new LogicaFibonacci();
            int Numero = -3;
            string ResultadoObtenido = " ";

            string ResultadoEsperado = "la sucesion es";

            ResultadoObtenido = ResultadoFibonacci.CalcularFibonacci(Numero);
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
        }
    }
}
