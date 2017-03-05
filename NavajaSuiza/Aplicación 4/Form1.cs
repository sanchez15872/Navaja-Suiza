using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucesion_fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero, n1, n2, n3;
            string texto;
            numero = int.Parse(textBox1.Text);
            n1 = 1;
            n2 = 1;
            n3 = 0;        
            for (int i = 1; i<= numero; i++)
            {
                n1 = n2;
                n2 = n3;
                n3 = n1 + n2;
             
            }
            MessageBox.Show(n3.ToString());
        }
    }
}
