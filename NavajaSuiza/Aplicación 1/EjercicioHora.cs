using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion1
{
    /// <summary>
    /// Clase pública del FormularioHora.
    /// </summary>
    public partial class FormularioHora : Form
    {
        /// <summary>
        /// Constructor de la primera aplicación.
        /// </summary>
        public FormularioHora()
        {
            InitializeComponent();
        }

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
        void MostrarHora(int horas,int minutos, int segundos)
        {       
            if (horas < 24 && minutos < 60 && segundos < 60)
            {
                if (segundos < 59)
                {                    
                    segundos = segundos + 1;
                    MessageBox.Show("La hora siguiente será :" + horas + " :" + minutos + " :" + segundos);
                }
                if (segundos == 59)
                {
                    if (minutos == 59)
                    {
                        if (horas == 23)
                        {
                            MessageBox.Show("La hora siguiente será :" + "00 :" + "00 :" + "00 ");

                        }
                        else
                        {
                            horas = horas + 1;
                            MessageBox.Show("La hora siguiente será :" + horas + "00 :" + "00 ");
                        }

                    }
                    else
                    {
                        minutos = minutos + 1;
                        MessageBox.Show("La hora siguiente será :" + horas + " :" + minutos + " :" + "00 ");
                    }
                }
            }
            else
            {
                MessageBox.Show("La hora no es correcta");
            }

        }
        /// <summary>
        /// En este botón pasamos los datos de las horas, los minutos y los segundos por los TextBox, 
        /// y llamamos a la función MostrarHora.
        /// </summary>
        /// <remarks>En caso de no pasar todos los datos o no poner los caracteres correctos dará un mensaje de error.</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void BotonHora_Click(object sender, EventArgs e)
        {                 
            int horas, minutos, segundos;

            horas = 0;
            minutos = 0;
            segundos = 0;

            try
            {
                horas = int.Parse(Horas.Text);
                minutos = int.Parse(Minutos.Text);
                segundos = int.Parse(Segundos.Text);


                MostrarHora(horas, minutos, segundos);
            }
            catch 
            {
                MessageBox.Show("Faltan datos");
            }       
                           
        }
    }
}
