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
/// Espacio de nombres del Formulario 3
/// </summary>
namespace NavajaSuiza.Aplicacion3
{
    /// <summary>
    /// Clase pública del formulario que te llevará a la aplicación 3.
    /// </summary>
    public partial class frmAplicacion3 : Form
    {
        /// <summary>
        /// Constructor del formulario que te llevará a la aplicación 3.
        /// </summary>
        public frmAplicacion3()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Este Botón nos devolverá la aplicación 3.
        /// </summary>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion_3.FormularioPotencia Formulario = new NavajaSuiza.Aplicacion_3.FormularioPotencia(); 
            Formulario.ShowDialog();
        }
    }
}
