using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación2
{
    public partial class frmAplicacion2 : Form
    {
        public frmAplicacion2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion_2.FormularioFactorial Formulario = new NavajaSuiza.Aplicacion_2.FormularioFactorial();
            Formulario.ShowDialog();
        }
    }
}
