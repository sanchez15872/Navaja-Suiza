using System;
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
    public partial class FormularioHora : Form
    {
        public FormularioHora()
        {
            InitializeComponent();
        }
        void MostrarHora(int horas,int minutos, int segundos)
        {
            if (horas < 24 && minutos < 60 && segundos < 60)
            {
                if (segundos < 59)
                {
                    segundos = segundos + 1;
                    MessageBox.Show("La hora siguiente será :" + horas + " :" + minutos + " :" + segundos);
                }
                if (segundos == 59)
                {
                    if (minutos == 59)
                    {
                        if (horas == 23)
                        {
                            MessageBox.Show("La hora siguiente será :" + "00 :" + "00 :" + "00 ");

                        }
                        else
                        {
                            horas = horas + 1;
                            MessageBox.Show("La hora siguiente será :" + horas + "00 :" + "00 ");
                        }

                    }
                    else
                    {
                        minutos = minutos + 1;
                        MessageBox.Show("La hora siguiente será :" + horas + " :" + minutos + " :" + "00 ");
                    }
                }
            }
            else
            {
                MessageBox.Show("La hora no es correcta");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int horas, minutos, segundos;

            horas = int.Parse(Horas.Text);
            minutos = int.Parse(Minutos.Text);
            segundos = int.Parse(Segundos.Text);

            MostrarHora(horas, minutos, segundos);
            
        }
    }
}
