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
    public partial class frmAplicacion3 : Form
    {
        public frmAplicacion3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion_3.FormularioPotencia Formulario = new NavajaSuiza.Aplicacion_3.FormularioPotencia(); 
            Formulario.ShowDialog();
        }
    }
}
