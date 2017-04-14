using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza
{
    /// <summary>
    /// Clase pública del Formulario Main.
    /// </summary>
    public partial class FormularioMain : Form
    {
        /// <summary>
        /// Constructor del formulario Main.
        /// </summary>
        public FormularioMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Llama al formulario de la primera aplicación, la que muestra la hora con un segundo de más.
        /// </summary>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void Boton1_Click(object sender, EventArgs e)
        {
            Aplicacion1.FormularioAplicacion1 Llamada = new Aplicacion1.FormularioAplicacion1();
            Llamada.ShowDialog();
                  
         }
        /// <summary>
        /// No hay código que comentar
        /// </summary>
        /// <param name="sender">Lanza el evento del frmMain_Load/param>
        /// <param name="e">sin uso</param>
        private void FormularioMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// No hay código que comentar
        /// </summary>
        /// <param name="sender">Lanza el evento del pictureBox1_Click</param>
        /// <param name="e">sin uso</param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Llama al formulario de la segunda aplicación, te calcula el factorial de un número.
        /// </summary>
        /// <param name="sender">Lanza el evento del button4</param>
        /// <param name="e">Si uso</param>
        private void Boton2_Click(object sender, EventArgs e)
        {
            Aplicacion2.FormularioAplicacion2 Llamada = new Aplicacion2.FormularioAplicacion2();
            Llamada.ShowDialog();

        }
        /// <summary>
        /// Llama al formulario de la tercera aplicación, te calcula la potencia de un número.
        /// </summary>
        /// <param name="sender">Lanza el evento del button3</param>
        /// <param name="e">Si uso</param>
        private void Boton3_Click(object sender, EventArgs e)
        {
            Aplicacion3.FormularioAplicacion4 Llamada = new Aplicacion3.FormularioAplicacion4();
            Llamada.ShowDialog();
        }
        /// <summary>
        /// Te llama al formulario la cuarta aplicación, te devuelve la sucesión de fibonacci de un número.
        /// </summary>
        /// <param name="sender">Lanza el evento del button2 </param>
        /// <param name="e">Si uso</param>
        private void Boton4_Click(object sender, EventArgs e)
        {
            Aplicacion4.FormularioAplicacion4 Llamada = new Aplicacion4.FormularioAplicacion4();
            Llamada.ShowDialog();
        }
    }
}
