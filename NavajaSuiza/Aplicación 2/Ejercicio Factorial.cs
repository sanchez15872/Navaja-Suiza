using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion_2
{
    public partial class FormularioFactorial : Form
    {
        public FormularioFactorial()
        {
            InitializeComponent();
        }

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
        private void button1_Click(object sender, EventArgs e)
        {
           int numero, factorial;           
            numero = int.Parse(textBox1.Text);

            factorial = CalcularFactorial(numero);
                                                         
            MessageBox.Show("El factorial de " + numero + " es " + factorial);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
