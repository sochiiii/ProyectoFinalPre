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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcaj_Click(object sender, EventArgs e)
        {
            if (din.Text == "")
            {
                MessageBox.Show("Debe ingresar algun monto a retirar", "Error");
                din.Focus();
                return;
            }

            int data;
            try
            {
                data = Convert.ToInt32(din.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un valor monetario numerico ", "Error");
                din.Text = "";
                din.Focus();
                return;
            }

            //Calculos
            int a, b, c, d, cien, vein, die, cinc, uno;

            cien = data / 100;
            a = data % 100;

            vein = a / 20;
            b = a % 20;

            die = b / 10;
            c = b % 10;

            cinc = c / 5;
            d = c % 5;

            uno = d / 1;

            //Mostrar resultados
            txt100.Text = cien.ToString();
            txt20.Text = vein.ToString();
            txt10.Text = die.ToString();
            txt5.Text = cinc.ToString();
            txt1.Text = uno.ToString();
            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void limpcaj_Click(object sender, EventArgs e)
        {
            din.Text = "";
            txt100.Text = "";
            txt20.Text = "";
            txt10.Text = "";
            txt5.Text = "";
            txt1.Text = "";
            din.Focus();
        }
    }
}
