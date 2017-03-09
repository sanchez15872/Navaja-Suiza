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
/// Espacio de nombres del Formulario 2
/// </summary>
namespace NavajaSuiza.Aplicación2
{
    /// <summary>
    /// Clase publica del formulario que te llevará a la aplicación 2.
    /// </summary>
    public partial class frmAplicacion2 : Form
    {
        /// <summary>
        /// Constructor del formulario que te llevará a la aplicación 2.
        /// </summary>
        public frmAplicacion2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Este Botón nos devolverá la aplicación 2.
        /// </summary>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion_2.FormularioFactorial Formulario = new NavajaSuiza.Aplicacion_2.FormularioFactorial();
            Formulario.ShowDialog();
        }
    }
}
