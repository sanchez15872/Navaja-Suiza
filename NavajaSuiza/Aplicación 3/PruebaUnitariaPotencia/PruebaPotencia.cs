using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion3;

namespace PruebaPotenciaUnitaria
{
    [TestClass]
    public class PruebaPotencia
    {
        /// <summary>
        /// Resultado Correcto
        /// </summary>
        [TestMethod]
        public void PotenciaCorrecto()
        {
            // Cuando nos da un resultado Correcto
            LogicaPotencia CalcularPotencia = new LogicaPotencia();
            int Base = 3;
            int Exponente = 4;
            int ResultadoObtenido = 1;
            string MensajeObtenido = " ";

            int ResultadoEsperado = 81;
            string MensajeEsperado = ("El resultado es " + 81);

            ResultadoObtenido = CalcularPotencia.PotenciaCalculada(Base, Exponente, out MensajeObtenido);

            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
        /// <summary>
        /// Utilizamos Numeros negativos
        /// </summary>
        [TestMethod]
        public void PotenciaNegativo()
        {
            // Uno de los dos números es negativo
            LogicaPotencia CalcularPotencia = new LogicaPotencia();
            int Base = -3;
            int Exponente = 3;
            int ResultadoObtenido = 1;
            string MensajeObtenido = " ";

            int ResultadoEsperado = -27;
            string MensajeEsperado = ("El programa no acepta números negativos");

            ResultadoObtenido = CalcularPotencia.PotenciaCalculada(Base, Exponente, out MensajeObtenido);

            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
        /// <summary>
        /// La base y el exponente son 0
        /// </summary>
        [TestMethod]
        public void PotenciaCero()
        {
            //Cuando la base y el exponente son 0
            LogicaPotencia CalcularPotencia = new LogicaPotencia();
            int Base = 0;
            int Exponente = 0;
            int ResultadoObtenido = 1;
            string MensajeObtenido = " ";

            int ResultadoEsperado = 1;
            string MensajeEsperado = ("El resultado es " + 1);

            ResultadoObtenido = CalcularPotencia.PotenciaCalculada(Base, Exponente, out MensajeObtenido);

            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
        /// <summary>
        /// La Base y el exponente nos da el máximo valor posible
        /// </summary>
        [TestMethod]
        public void PotenciaMax()
        {
            // Colocamos el máximo valor en Base
            LogicaPotencia CalcularPotencia = new LogicaPotencia();
            int Base = int.MaxValue;
            int Exponente = 33;
            int ResultadoObtenido = 1;
            string MensajeObtenido = " ";

            int ResultadoEsperado = int.MaxValue;
            string MensajeEsperado = ("El resultado es " + int.MaxValue);

            ResultadoObtenido = CalcularPotencia.PotenciaCalculada(Base, Exponente, out MensajeObtenido);

            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);
            Assert.AreEqual(MensajeEsperado, MensajeObtenido);

        }
    }
}
