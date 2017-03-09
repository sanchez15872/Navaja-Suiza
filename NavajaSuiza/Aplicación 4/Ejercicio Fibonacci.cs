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
/// Espacio de nombres de la Aplicación 4
/// </summary>
namespace NavajaSuiza.Aplicacion_4
{
    /// <summary>
    /// Clase pública del FormularioFibonacci
    /// </summary>
    public partial class FormularioFibonacci : Form
    {
        /// <summary>
        /// Constructor del FormularioPotencia
        /// </summary>
        public FormularioFibonacci()
        {
            InitializeComponent();
        }

        /// <summary>
        /// En esta función introducimos un número y nos hará un bucle que nos calculará la sucesión de fibonacci
        /// esta nos devolverá una cadena de texto que se repetirá hasta el numero que hayamos
        /// introducido con las sumas realizadas.
        /// </summary>
        /// <param name="numero">el numero que nos indica hasta donde debe llegar la sucesión</param>
        /// <returns>Devuelve una cadena de texto con la sucesión de fibonacci</returns>
        string CalcularFibonacci (int numero)
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

        /// <summary>
        /// Muestra el resultado de la funcion CalcularFibonacci mediante un MessageBox
        /// pasándole el número en un TextBox.
        /// </summary>
        /// <remarks>En caso de no poner números nos dará un error que nos dirá que introduzcamos números</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            string texto;
            try
            {

                numero = int.Parse(textBox1.Text);
                texto = CalcularFibonacci(numero);

                MessageBox.Show(texto);
            }
            catch 
            {
                MessageBox.Show("Por Favor, introduzca números");
            }         
        }
    }
}
