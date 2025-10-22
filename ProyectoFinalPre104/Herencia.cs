using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalPre104
{
    public partial class Herencia : Form
    {
        public Herencia()
        {
            InitializeComponent();
        }

        private void calc_Click(object sender, EventArgs e)
        {
            //Esto se ejecutara si no pone nada en el dato de la harencia
            if (her1.Text == "")
            {
                MessageBox.Show("Debe ingresar algun monto a retirar", "Error");
                her1.Focus();
                return;
            }
            //Esto se ejecutara si el dato de la Herencia no son numeros
            Double data;
            try
            {
                data = Convert.ToDouble(her1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor monetario numerico ", "Error");
                her1.Text = "";
                her1.Focus();
                return;
            }

            Double a, b, c;
            Double tres, sum1, sum2, sum3, total;
            //Calculos
            a = data / 3; //Formula para la herencia de Juan
            b = (4 * data) / 9; //Formula para la herencia de Luis
            c = (2 * data) / 9; //Formula para la herencia de Rosa
                                //Calculo para el abogado
            tres = data / 3;
            if (a < tres)
            {
                sum1 = a * 0.05;
            }
            else
            {
                sum1 = a * 0.03;
            }


            if (b < tres)
            {
                sum2 = b * 0.05;
            }
            else
            {
                sum2 = b * 0.03;
            }

            if (c < tres)
            {
                sum3 = b * 0.05;
            }
            else
            {
                sum3 = c * 0.03;
            }
            total = sum1 + sum2 + sum3;


            //Aqui declaro que las respuesta a, b y c se impriman en los espacios indicados
            juanx.Text = Math.Round(a, 2).ToString();
            luisx.Text = Math.Round(b, 2).ToString();
            rosax.Text = Math.Round(c, 2).ToString();
            abogado.Text = Math.Round(total, 2).ToString();
        }

        private void limp_Click(object sender, EventArgs e)
        {
            juanx.Text = "";
            luisx.Text = "";
            rosax.Text = "";
            abogado.Text = "";
            her1.Text = "";
            her1.Focus();
        }

        private void menuclk_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
            this.Dispose();
        }
    }
}
