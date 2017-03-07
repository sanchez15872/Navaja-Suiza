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
    public partial class frmAplicacion4 : Form
    {
        public frmAplicacion4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion_4.FormularioFibonacci Formulario = new NavajaSuiza.Aplicacion_4.FormularioFibonacci();
            Formulario.ShowDialog();
        }
    }
}
