using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion3
{
    /// <summary>
    /// Clase LogicaPotencia
    /// </summary>
    class LogicaPotencia
    {
        /// <summary>
        /// La función calcula una potencia, le devolvemos un número y un exponente y este nos devuelve la potencia.
        /// </summary>
        /// <remarks>Solo calcula positivos</remarks>
        /// <param name="numero">Parámetro que indica la base de la potencia</param>
        /// <param name="exponente">Parámetro que indica el exponente de la potencia</param>
        /// /// <param name="mensaje">Parámetro que nos devuelve el resultado</param>
        /// <returns>Nos devuelve la potencia calculada a partir del numero y el exponente.</returns>
        public int PotenciaCalculada(int numero, int exponente, out string mensaje)
        {
            int resultado = 1;
            mensaje = " ";

            for (int i = 1; i <= exponente; i++)
            {
                resultado = resultado * numero;
            }

            if (exponente < 0 || numero < 0)
            {
                mensaje = "El programa no acepta números negativos";
            }
            else
            {
                mensaje = ("El resultado es " + resultado);
            }
            return resultado;
        }
    }
}
