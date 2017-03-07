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
        public frmMain()
        {
            InitializeComponent();
        }


        /// <summary>
        /// llama a una aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void button4_Click(object sender, EventArgs e)
        {
            Aplicación2.frmAplicacion2 Llamada = new Aplicación2.frmAplicacion2();
            Llamada.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aplicacion3.frmAplicacion3 Llamada = new Aplicacion3.frmAplicacion3();
            Llamada.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aplicacion4.frmAplicacion4 Llamada = new Aplicacion4.frmAplicacion4();
            Llamada.ShowDialog();
        }
    }
}
