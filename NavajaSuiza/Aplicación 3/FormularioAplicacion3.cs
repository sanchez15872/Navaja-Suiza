﻿using System;
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
    /// <summary>
    /// Clase pública del formulario que te llevará a la aplicación 3.
    /// </summary>
    public partial class FormularioAplicacion4 : Form
    {
        /// <summary>
        /// Constructor del formulario que te llevará a la aplicación 3.
        /// </summary>
        public FormularioAplicacion4()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Este Botón nos devolverá la aplicación 3.
        /// </summary>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void Boton1_Click(object sender, EventArgs e)
        {
            NavajaSuiza.Aplicacion3.FormularioPotencia Formulario = new NavajaSuiza.Aplicacion3.FormularioPotencia(); 
            Formulario.ShowDialog();
        }
    }
}
