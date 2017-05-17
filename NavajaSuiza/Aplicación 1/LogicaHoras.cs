using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavajaSuiza.Aplicacion1
{
    /// <summary>
    /// Clase Lógica de Horas
    /// </summary>
     public static class LogicaHoras
    {
        /// <summary>
        /// Esta función es un void que según la hora, 
        /// los minutos y los segundos que hayamos puesto en el TextBox
        /// nos devolvera un MessageBox diciendo la hora que es con un segundo de más.
        /// </summary>
        /// <remarks>Si las horas los minutos o los segundos son incorrectos, nos devolverá 
        /// un MessageBox diciendo que la hora no es correcta</remarks>       
        /// <param name="horas">Este parametro se lo pasamos del TextBoxHoras, nos indica la hora, se pasa de 00 a 23</param>
        /// <param name="minutos">Este parametro se lo pasamos del TextBoxMinutos, nos indica los minutos, de 00 a 59.</param>
        /// <param name="segundos">Este parametro se lo pasamos del TextBoxSegundos, nos indica los segundos, de 00 a 59.</param>
        /// <returns>Nos devuelve un mensaje con la hora correspondiente</returns>
        public static string MostrarHora(int horas, int minutos, int segundos)
        {
            string mensaje;

            mensaje = " ";

            if (horas < 0 || minutos < 0 || segundos < 0)
            {
                mensaje = "La hora no acepta negativos";
            }
            else
            {
                if (horas < 24 && minutos < 60 && segundos < 60)
                {
                    if (segundos < 59)
                    {
                        segundos = segundos + 1;
                        mensaje = ("La hora siguiente será :" + horas + " :" + minutos + " :" + segundos);
                    }
                    if (segundos == 59)
                    {
                        if (minutos == 59)
                        {
                            if (horas == 23)
                            {
                                mensaje = ("La hora siguiente será :" + "00 :" + "00 :" + "00 ");

                            }
                            else
                            {
                                horas = horas + 1;
                                mensaje = ("La hora siguiente será :" + horas + "00 :" + "00 ");
                            }

                        }
                        else
                        {
                            minutos = minutos + 1;
                            mensaje = ("La hora siguiente será :" + horas + " :" + minutos + " :" + "00 ");
                        }
                    }
                }
                else
                {
                    mensaje = ("La hora no es correcta");
                }
            }
            return mensaje;
        }     
    }
}
