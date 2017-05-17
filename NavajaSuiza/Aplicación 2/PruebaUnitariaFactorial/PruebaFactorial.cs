using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion2;

namespace PruebaUnitariaFactorial
{
    [TestClass]
    public class PruebasFactorial
    {
        /// <summary>
        /// Resultado Correcto
        /// </summary>
        [TestMethod]
        public void FactorialCorrecto()
        {
            int Numero = 5;          
            int ResultadoFactorial = 1;
            string MensajeObtenido = " ";

            string MensajeEsperado = "";
            int ResultadoEsperado = 120;
           
            ResultadoFactorial = LogicaFactorial.CalcularFactorial(Numero, out MensajeObtenido);
            MensajeEsperado = "El factorial de " + Numero + " es " + ResultadoFactorial;

            Assert.AreEqual(ResultadoEsperado, ResultadoFactorial);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
        /// <summary>
        /// Cuando el número que insertamos es negativo
        /// </summary>
        [TestMethod]
        public void FactorialNegativo()
        {
            int Numero = -3;
            int ResultadoFactorial = 1;
            string MensajeObtenido = " ";

            string MensajeEsperado = "";
            int ResultadoEsperado = 1;

            ResultadoFactorial = LogicaFactorial.CalcularFactorial(Numero, out MensajeObtenido);
            MensajeEsperado = "El número escrito es negativo";

            Assert.AreEqual(ResultadoEsperado, ResultadoFactorial);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
        /// <summary>
        /// Cuando ponemos el máximo valor
        /// </summary>
        [TestMethod]
        public void FactorialMax()
        {
            int Numero = int.MaxValue;
            int ResultadoFactorial = 1;
            string MensajeObtenido = " ";

            string MensajeEsperado = "";
            int ResultadoEsperado = 0;

            ResultadoFactorial = LogicaFactorial.CalcularFactorial(Numero, out MensajeObtenido);
            MensajeEsperado = "El factorial de " + Numero + " es " + ResultadoFactorial; ;

            Assert.AreEqual(ResultadoEsperado, ResultadoFactorial);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
    }
}
