﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicación_1
{
    public partial class frmAplicacion1 : Form
    {            

        public frmAplicacion1()
        {
            InitializeComponent();
        }



    
        private void button1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion1.FormularioHora Formulario = new NavajaSuiza.Aplicacion1.FormularioHora();
            Formulario.ShowDialog();
        }
    }
}
