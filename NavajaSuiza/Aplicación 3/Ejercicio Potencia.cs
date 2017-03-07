using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion_3
{
    public partial class FormularioPotencia : Form
    {
        public FormularioPotencia()
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

            numero = int.Parse(TextBoxNumero.Text);
            potencia = int.Parse(textBox2.Text);

            resultado = potenciapro(numero, potencia);

            MessageBox.Show("El resultado es " + resultado);
        }
    }
}
