using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion3
{
    /// <summary>
    /// Clase pública del FormularioPotencia
    /// </summary>
    public partial class FormularioPotencia : Form
    {
        /// <summary>
        /// Constructor pública del FormularioPotencia
        /// </summary>
        public FormularioPotencia()
        {
            InitializeComponent();
        }
        /// <summary>
        /// La función calcula una potencia, le devolvemos un número y un exponente y este nos devuelve la potencia.
        /// </summary>
        /// <remarks>Solo calcula positivos</remarks>
        /// <param name="numero">Parámetro que indica la base de la potencia</param>
        /// <param name="exponente">Parámetro que indica el exponente de la potencia</param>
        /// <returns>Nos devuelve la potencia calculada a partir del numero y el exponente.</returns>
         int PotenciaCalculada(int numero, int exponente)
         {
            int resultado = 1;

            for (int i = 1; i<= exponente; i++ )
            {
                resultado = resultado * numero;
            }

            return resultado;
         }
        /// <summary>
        /// En el botón obtenemos los datos del número y del exponente y mediante la función potenciapro calculamos la 
        /// potencia y la mostramos en un MessageBox.
        /// </summary>
        /// <remarks>En caso de no escribir números nos devolverá un mensaje de error</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void BotonPotencia_Click(object sender, EventArgs e)
        {
            int Numero, Exponente, Resultado;
            bool CorrectoNumero, CorrectoExponente;

                Numero = 0;
                Exponente = 0;
                CorrectoNumero = int.TryParse(TextBoxNumero.Text, out Numero);
                CorrectoExponente = int.TryParse(TextBoxPotencia.Text, out Exponente);

                Resultado = PotenciaCalculada(Numero, Exponente);
              

            if (CorrectoNumero && CorrectoExponente)
            {
                if (Resultado == 0)
                {
                    MessageBox.Show("Número incorrecto");
                }
                else
                {
                    MessageBox.Show("El resultado es " + Resultado);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
