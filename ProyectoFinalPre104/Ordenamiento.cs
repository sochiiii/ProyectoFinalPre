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
    public partial class Ordenamiento : Form
    {
        public Ordenamiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txt1.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el número 1", "Error");
                txt1.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(txt1.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en el número 1", "Error");
                txt1.Text = "";
                txt1.Focus();
                return;
            }
            if (txt2.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el número 2", "Error");
                txt2.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(txt2.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en el número 2", "Error");
                txt2.Text = "";
                txt2.Focus();
                return;
            }
            if (txt3.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en el número 3", "Error");
                txt3.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(txt3.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en el número 3", "Error");
                txt3.Text = "";
                txt3.Focus();
                return;
            }

            //Cálculos
            double menor, mayor, centro;
            Orden(a, b, c, out menor, out mayor, out centro);

            //Mostrando los resultados
            txtMenor.Text=menor.ToString();
            txtCentro.Text = centro.ToString();
            txtMayor.Text = mayor.ToString();
        }

        private void Orden(double a, double b, double c, out double menor, out double mayor, out double centro)
        {
            //Encontrando el número menor
            if(a<=b && a <= c)
            {
                menor = a;
            } 
            else if (b <= a && b <= c)
            {
                menor = b;
            }
            else
            {
                menor = c;
            }

            //Encontrando el número mayor
            if (a >= b && a >= c)
            {
                mayor = a;
            }
            else if (b >= a && b >= c)
            {
                mayor = b;
            }
            else
            {
                mayor = c;
            }

            //Encontrando el número del centro
            if (a != menor && a != mayor)
            {
                centro = a;
            }
            else if (b != menor && b != mayor)
            {
                centro = b;
            }
            else
            {
                centro = c;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txtMenor.Text = "";
            txtCentro.Text = "";
            txtMayor.Text = "";
            txt1.Focus();
        }
    }
}
