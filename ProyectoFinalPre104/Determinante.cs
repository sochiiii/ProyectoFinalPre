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
    public partial class Determinante : Form
    {
        public Determinante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
            this.Dispose();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtA.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en a", "Error");
                txtA.Focus();
                return;
            }
            double a;
            try
            {
                a = Convert.ToDouble(txtA.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en a", "Error");
                txtA.Text = "";
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en b", "Error");
                txtB.Focus();
                return;
            }
            double b;
            try
            {
                b = Convert.ToDouble(txtB.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en b", "Error");
                txtB.Text = "";
                txtB.Focus();
                return;
            }
            if (txtR.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en r", "Error");
                txtR.Focus();
                return;
            }
            double r;
            try
            {
                r = Convert.ToDouble(txtR.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en r", "Error");
                txtR.Text = "";
                txtR.Focus();
                return;
            }
            if (txtC.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en c", "Error");
                txtC.Focus();
                return;
            }
            double c;
            try
            {
                c = Convert.ToDouble(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en c", "Error");
                txtC.Text = "";
                txtC.Focus();
                return;
            }
            if (txtD.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en d", "Error");
                txtD.Focus();
                return;
            }
            double d;
            try
            {
                d = Convert.ToDouble(txtD.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en d", "Error");
                txtD.Text = "";
                txtD.Focus();
                return;
            }
            if (txtS.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor en s", "Error");
                txtS.Focus();
                return;
            }
            double s;
            try
            {
                s = Convert.ToDouble(txtS.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en s", "Error");
                txtS.Text = "";
                txtS.Focus();
                return;
            }

            //Cálculos
            double x, y;
            Determinantes(a,b,r,c,d,s,out x, out y);

            //Mostrar los resultados
            txtX.Text = x.ToString();
            txtY.Text = y.ToString();
        }

        private void Determinantes(double a, double b, double r, double c, double d, double s, out double x, out double y)
        {
            double determinante = (a * d) - (b * c);
            if (determinante == 0) 
            {
                MessageBox.Show("El determinante principal es 0, por lo que no tiene solución única.", "Error");
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtR.Text = "";
                txtD.Text = "";
                txtS.Text = "";
                txtX.Text = "";
                txtY.Text = "";
                txtA.Focus();

                x = 0;
                y = 0;
                return;
                

            }
            else
            {
                double determinanteX = (r * d) - (b * s);
                double determinanteY = (a * s) - (r * c);

                x = Math.Round(determinanteX / determinante, 2);
                y = Math.Round(determinanteY / determinante, 2);
            }

            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtR.Text = "";
            txtD.Text = "";
            txtS.Text = "";
            txtX.Text = "";
            txtY.Text = "";
            txtA.Focus();
        }
    }
}
