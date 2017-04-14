﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion1
{
    /// <summary>
    /// Clase Pública del formulario que te llevará a la aplicación 1.
    /// </summary>
    public partial class FormularioAplicacion1 : Form
    {            
        /// <summary>
        /// Constructor del formulario que te llevará a la aplicación 1.
        /// </summary>
        public FormularioAplicacion1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Este Botón nos devolverá la aplicación 1.
        /// </summary>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void Boton1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion1.FormularioHora Formulario = new NavajaSuiza.Aplicacion1.FormularioHora();
            Formulario.ShowDialog();
        }
    }
}
