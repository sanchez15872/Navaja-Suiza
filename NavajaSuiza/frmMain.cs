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
    public partial class frmMain : Form
    {
        /// <summary>
        /// Constructor del formulario Main.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Llama al formulario de la primera aplicación, la que muestra la hora con un segundo de más.
        /// </summary>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void button1_Click(object sender, EventArgs e)
        {
            Aplicación_1.frmAplicacion1 Llamada = new Aplicación_1.frmAplicacion1();
            Llamada.ShowDialog();
                  
         }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Llama al formulario de la segunda aplicación, te calcula el factorial de un número.
        /// </summary>
        /// <param name="sender">Lanza el evento del button4</param>
        /// <param name="e">Si uso</param>
        private void button4_Click(object sender, EventArgs e)
        {
            Aplicación2.frmAplicacion2 Llamada = new Aplicación2.frmAplicacion2();
            Llamada.ShowDialog();

        }
        /// <summary>
        /// Llama al formulario de la tercera aplicación, te calcula la potencia de un número.
        /// </summary>
        /// <param name="sender">Lanza el evento del button3</param>
        /// <param name="e">Si uso</param>
        private void button3_Click(object sender, EventArgs e)
        {
            Aplicacion3.frmAplicacion3 Llamada = new Aplicacion3.frmAplicacion3();
            Llamada.ShowDialog();
        }
        /// <summary>
        /// Te llama al formulario la cuarta aplicación, te devuelve la sucesión de fibonacci de un número.
        /// </summary>
        /// <param name="sender">Lanza el evento del button2 </param>
        /// <param name="e">Si uso</param>
        private void button2_Click(object sender, EventArgs e)
        {
            Aplicacion4.frmAplicacion4 Llamada = new Aplicacion4.frmAplicacion4();
            Llamada.ShowDialog();
        }
    }
}
