using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion2
{
    /// <summary>
    /// Clase Logica Factorial
    /// </summary>
    public static class LogicaFactorial
    {
        /// <summary>
        /// Nos devolverá el factorial calculado a partir de un número añadido.
        /// </summary>
        /// <param name="Numero">El numero que introducimos por TextBox del que calcularemos su factorial.</param>
        /// <param name="Mensaje">Si el número que obtenemos es negativo nos saldrá un mensaje de error</param>
        /// <returns>Devolvemos el factorial del número.</returns>
      public static int CalcularFactorial(int Numero, out string Mensaje)
        {
            int i, Factorial;
                     
            Mensaje = " ";
            Factorial = 1;

            for (i = Numero; i > 0; i--)
            {
                Factorial = Factorial * i;
            }

            if (Numero < 0)
            {
                Mensaje = "El número escrito es negativo";
            }
            else
            {
                Mensaje = "El factorial de " + Numero + " es " + Factorial;
            }
            return Factorial;
        }
    }
}
