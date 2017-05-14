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
        /// En el botón obtenemos los datos del número y del exponente y mediante la función potenciapro calculamos la 
        /// potencia y la mostramos en un MessageBox.
        /// </summary>
        /// <remarks>En caso de no escribir números nos devolverá un mensaje de error</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>      
        private void BotonPotencia_Click(object sender, EventArgs e)
        {
            // Nueva instancia
            LogicaPotencia CalcularPotencia = new LogicaPotencia();
            int Numero, Exponente, Resultado;
            bool CorrectoNumero, CorrectoExponente;
            string Mensaje;

                Numero = 0;
                Exponente = 0;
                CorrectoNumero = int.TryParse(TextBoxNumero.Text, out Numero);
                CorrectoExponente = int.TryParse(TextBoxPotencia.Text, out Exponente);
                Mensaje = "";
               

            try
            {
                Resultado = CalcularPotencia.PotenciaCalculada(Numero, Exponente, out Mensaje);

                if (CorrectoNumero && CorrectoExponente)
                {
                    if (Resultado == 0)
                    {
                        Mensaje = ("Numero demasiado grande");
                    }                  
                }
                else
                {
                    Mensaje = ("No escribas strings o dejes espacios sin rellenar");
                }
                MessageBox.Show(Mensaje);
            }
            catch (Exception Excepcion)
            {

                MessageBox.Show("Se ha producido un error" + Excepcion.Message);
            }        
        }

        private void FormularioPotencia_Load(object sender, EventArgs e)
        {

        }
    }
}
