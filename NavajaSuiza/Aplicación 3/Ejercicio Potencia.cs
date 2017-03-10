using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Espacio de nombres de la Aplicación 3
/// </summary>
namespace NavajaSuiza.Aplicacion_3
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
         int potenciapro(int numero, int exponente)
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
        private void button1_Click(object sender, EventArgs e)
        {
            int numero, exponente, resultado;
          
            try
            {
                numero = int.Parse(TextBoxNumero.Text);
                exponente = int.Parse(textBox2.Text);

                resultado = potenciapro(numero, exponente);

                if (resultado == 0)
                {
                    MessageBox.Show("Número incorrecto");
                }
                else
                {
                    MessageBox.Show("El resultado es " + resultado);
                }              
            }
            catch 
            {
                MessageBox.Show("Error introduzca numeros");
            }
           
        }
    }
}
