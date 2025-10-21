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
            double r;
            try
            {
                r = Convert.ToDouble(txt3.Text);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor numérico en el número 3", "Error");
                txt3.Text = "";
                txt3.Focus();
                return;
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
            txt1.Focus();
        }
    }
}
