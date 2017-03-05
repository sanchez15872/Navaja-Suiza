using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int potenciapro(int numero, int elevado)
        {
            int resultado = 1;

            for (int i = 1; i<= elevado; i++ )
            {
                resultado = resultado * numero;
            }
            return resultado;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numero, potencia, resultado;

            numero = int.Parse(textBox1.Text);
            potencia = int.Parse(textBox2.Text);

            resultado = potenciapro(numero, potencia);

            MessageBox.Show("El resultado es " + resultado);
        }
    }
}
