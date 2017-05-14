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
        /// En este botón pasamos los datos de las horas, los minutos y los segundos por los TextBox, 
        /// y llamamos a la función MostrarHora.
        /// </summary>
        /// <remarks>En caso de no pasar todos los datos o no poner los caracteres correctos dará un mensaje de error.</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void BotonHora_Click(object sender, EventArgs e)
        {                 
            int Horas, Minutos, Segundos;
            bool CorrectoHora, CorrectoMinutos, CorrectoSegundos;
            string HoraCorrecta;

            Horas = 0;
            Minutos = 0;
            Segundos = 0;
            HoraCorrecta = " ";             
      
            CorrectoHora = int.TryParse(TextBoxHoras.Text, out Horas);
            CorrectoMinutos = int.TryParse(TextBoxMinutos.Text, out Minutos);
            CorrectoSegundos = int.TryParse(TextBoxSegundos.Text, out Segundos);

            try
            {
               
                // Si hay ints escritos
                if (CorrectoHora && CorrectoMinutos && CorrectoSegundos)
                 {
                   HoraCorrecta = LogicaHoras.MostrarHora(Horas, Minutos, Segundos);
                 }
                // Cuando los campos están vacíos o usando strings
               else
                {
                    HoraCorrecta = "Por favor, usa solo números o rellene los campos vacíos";
                }

                MessageBox.Show(HoraCorrecta);
            }

            catch(Exception Excepcion) 
            {
                MessageBox.Show("Se ha producido un error" + Excepcion.Message);
            }        
                               
        }
    }
}
