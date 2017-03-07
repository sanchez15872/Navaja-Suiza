using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavajaSuiza.Aplicacion_4
{
    public partial class FormularioFibonacci : Form
    {
        public FormularioFibonacci()
        {
            InitializeComponent();
        }
        string CalcularFibonacci (int numero)
        {
            int numero1, numero2, NumeroFibonacci;
            string texto;

            texto = "la sucesion es";            
            numero1 = 1;
            numero2 = 1;
            NumeroFibonacci = 0;

            for (int i = 1; i <= numero; i++)
            {
                numero1 = numero2;
                numero2 = NumeroFibonacci;
                NumeroFibonacci = numero1 + numero2;
                texto = texto + " + " + NumeroFibonacci;

            }

            return texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            string texto;

            numero = int.Parse(textBox1.Text);
            texto = CalcularFibonacci(numero);
                     
            MessageBox.Show(texto);
        }
    }
}
