using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion4
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
        /// Muestra el resultado de la funcion CalcularFibonacci mediante un MessageBox
        /// pasándole el número en un TextBox.
        /// </summary>
        /// <remarks>En caso de no poner números nos dará un error que nos dirá que introduzcamos números</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            // Nueva instancia
            LogicaFibonacci Fibonacci = new LogicaFibonacci();
            int Numero;
            string Texto;
            bool CorrectoNumero;

            Numero = 0;
            CorrectoNumero = int.TryParse(TextBoxFibonacci.Text, out Numero);
            Texto = " ";

            try
            {
                Texto = Fibonacci.CalcularFibonacci(Numero);

                if (CorrectoNumero)
                {
                    if (Numero <= 0)
                    {
                        MessageBox.Show("Por favor introduzca numeros mayores que 0");
                    }
                    else
                    {
                        MessageBox.Show(Texto);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor introduzca números");
                }
            }
            catch (Exception Excepcion)
            {
                MessageBox.Show("Se ha producido un error" + Excepcion.Message);
            }  
           
        }

        private void FormularioFibonacci_Load(object sender, EventArgs e)
        {

        }
    }
}
