using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion2
{
   /// <summary>
   /// Clase pública del FormularioFactorial.
   /// </summary>
    public partial class FormularioFactorial : Form
    {
        /// <summary>
        /// Constructor del FormularioFactorial.
        /// </summary>
        public FormularioFactorial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// En este botón pasamos el numero por un TextBox y mediante la funcion CalcularFactorial obtenemos
        /// un MessageBox diciendo el factorial de un número.
        /// </summary>
        /// <remarks>Si el número es muy grande mostrará un MessageBox diciendo que el programa no permite números 
        /// tan grandes</remarks>
        /// <remarks>Si escribes caracteres incorrectos nos mostrará un alerta de ello con un MessageBox.</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void BotonCalcular_Click(object sender, EventArgs e)
        {
           int Numero, Factorial;
           bool NumeroCorrecto;
           string Mensaje;

            Numero = 0;
            Factorial = 0;
            NumeroCorrecto = int.TryParse(TextBoxFactorial.Text, out Numero);
            Mensaje = "";

            try
            {
                // Si hay ints escritos          
                if (NumeroCorrecto)
                {
                    Factorial = LogicaFactorial.CalcularFactorial(Numero, out Mensaje);
                    // si el valor es demasiado alto
                    if (Factorial == 0)
                    {
                        Mensaje = "El programa no permite números tan grandes";
                    }                 
                }
                // Si escribes strings o hay un espacio en blanco
                else
                {
                   Mensaje = "Introduzca un número";
                }

                MessageBox.Show(Mensaje);
            }
            catch (Exception Excepcion)
            {

                MessageBox.Show("Se ha producido un error" + Excepcion.Message);
            }
                                                                         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
