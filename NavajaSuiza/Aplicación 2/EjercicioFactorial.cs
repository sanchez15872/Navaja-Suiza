﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion2
{
   /// <summary>
   /// Clase pública del FormularioFactorial.
   /// </summary>
    public partial class FormularioFactorial : Form
    {
        /// <summary>
        /// Constructor del FormularioFactorial.
        /// </summary>
        public FormularioFactorial()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Nos devolverá el factorial calculado a partir de un número añadido.
        /// </summary>
        /// <param name="numero">El numero que introducimos por TextBox del que calcularemos su factorial.</param>
        /// <returns>Devolvemos el factorial del número.</returns>
        int CalcularFactorial(int numero)
        {
            int  i, factorial;
            factorial = 1;

            for (i = numero; i > 0; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
             
        }
        /// <summary>
        /// En este botón pasamos el numero por un TextBox y mediante la funcion CalcularFactorial obtenemos
        /// un MessageBox diciendo el factorial de un número.
        /// </summary>
        /// <remarks>Si el número es muy grande mostrará un MessageBox diciendo que el programa no permite números 
        /// tan grandes</remarks>
        /// <remarks>Si escribes caracteres incorrectos nos mostrará un alerta de ello con un MessageBox.</remarks>
        /// <param name="sender">Lanza el evento del button1</param>
        /// <param name="e">Si uso</param>
        private void BotonCalcular_Click(object sender, EventArgs e)
        {
           int Numero, Factorial;
           bool NumeroCorrecto;

                Numero = 0;
                NumeroCorrecto = int.TryParse(TextBoxFactorial.Text, out Numero);
                Factorial = CalcularFactorial(Numero);

            if (NumeroCorrecto)
            {
                if (Factorial == 0)
                {
                    MessageBox.Show("El programa no permite números tan grandes");
                }
                else
                {
                    MessageBox.Show("El factorial de " + Numero + " es " + Factorial);
                }
            }
            else
            {
                MessageBox.Show("Introduzca un número");
            }   
                                                              
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
