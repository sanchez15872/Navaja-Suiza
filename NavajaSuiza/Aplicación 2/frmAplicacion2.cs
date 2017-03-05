using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int numero, i, fac;
            fac = 1;   
            numero = int.Parse(textBox1.Text);
  
            for (i = numero; i > 0; i--)
                fac = fac * i;
              
                                                          
            MessageBox.Show("El factorial de " + numero + " es " + fac);
        }
    }
}
