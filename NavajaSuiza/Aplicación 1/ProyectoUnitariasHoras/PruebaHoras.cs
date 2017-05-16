﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NavajaSuiza.Aplicacion1;

namespace PruebaUnitariaHora
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HoraNoCorrecta()
        {
            // Inicializamos las variables
            int Horas = 25;
            int Minutos = 23;
            int Segundos = 22;
            string ResultadoEsperado = "La hora no es correcta";

            string ResultadoObtenido = " ";
            // Acción
            ResultadoObtenido = LogicaHoras.MostrarHora(Horas, Minutos, Segundos);

            //Afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }
        [TestMethod]
        public void HoraCorrecta()
        {
            // Inicializamos las variables
            int Horas = 23;
            int Minutos = 23;
            int Segundos = 24;           
            string ResultadoEsperado = ("La hora siguiente será :" + 23 + " :" + 23 + " :" + 25);

            string ResultadoObtenido = " ";
            // Acción
            ResultadoObtenido = LogicaHoras.MostrarHora(Horas, Minutos, Segundos);

            //Afirmación
            Assert.AreEqual(ResultadoEsperado, ResultadoObtenido);

        }
    }
}
