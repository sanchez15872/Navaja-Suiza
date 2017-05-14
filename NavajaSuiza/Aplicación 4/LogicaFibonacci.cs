using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace NavajaSuiza.Aplicacion4
{
    /// <summary>
    /// Clase LogicaFibonacci
    /// </summary>
    class LogicaFibonacci
    {
        /// <summary>
        /// En esta función introducimos un número y nos hará un bucle que nos calculará la sucesión de fibonacci
        /// esta nos devolverá una cadena de texto que se repetirá hasta el numero que hayamos
        /// introducido con las sumas realizadas.
        /// </summary>
        /// <param name="numero">el numero que nos indica hasta donde debe llegar la sucesión</param>
        /// <returns>Devuelve una cadena de texto con la sucesión de fibonacci</returns>
        public string CalcularFibonacci(int numero)
        {
            int numero1, numero2, NumeroFibonacci;
            string texto;

            texto = "la sucesion es";
            numero1 = 1;
            numero2 = 1;
            NumeroFibonacci = 0;

            for (int i = 1; i <= numero; i++)
            {
                numero1 = numero2;
                numero2 = NumeroFibonacci;
                NumeroFibonacci = numero1 + numero2;
                texto = texto + " + " + NumeroFibonacci;

            }

            return texto;
        }
    }
}
