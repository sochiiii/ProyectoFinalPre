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
    public partial class Angulos : Form
    {
        public Angulos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Double num_a, num_b;
            if (Double.TryParse(val_a.Text, out num_a) && Double.TryParse(val_b.Text, out num_b))
            {
                if (num_a > 0 && num_b > 0)
                {
                    calc.Enabled = true;
                }
                else calc.Enabled = false;
            }
            else
            {
                calc.Enabled = false;
            }
        }

        private void Angulos_Load(object sender, EventArgs e)
        {
            Form1 win = new Form1();
            win.Close();
            win.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Double num_a = 0, num_b = 0;
            if (Double.TryParse(val_a.Text, out num_a) && Double.TryParse(val_b.Text, out num_b))
            {
                if (num_a > 0 && num_b > 0)
                {
                    calc.Enabled = true;
                }
                else calc.Enabled = false;
            }
            else
            {
                calc.Enabled = false;
            }
        }

        private void calc_Click(object sender, EventArgs e)
        {
            //Método de cálculo de ángulos agudos por arcotangente
            Double cat_a_val, cat_b_val, h_val, angulo_a_val, angulo_b_val;

            Double.TryParse(val_a.Text, out cat_a_val);
            Double.TryParse(val_b.Text, out cat_b_val);

            //Calculo de hipotenusa y ángulos
            //Calulo de hipotenusa por el teorema de Pitágoras
            h_val = Math.Round(Math.Sqrt(Math.Pow(cat_a_val, 2) + Math.Pow(cat_b_val, 2)), 2);
            //Calculo de ángulo alpha por arcotangente
            angulo_a_val = Math.Round(Math.Atan(cat_a_val / cat_b_val) * (180 / Math.PI), 2);
            //Calculo de ángulo beta por complemento de 90 grados
            angulo_b_val = Math.Round(Math.Atan(cat_b_val / cat_a_val) * (180 / Math.PI), 2);

            //Muestra los resultados en los controles de texto
            val_h.Text = h_val.ToString("F2");
            angulo_A.Text = angulo_a_val.ToString("F2") + "°";
            angulo_B.Text = angulo_b_val.ToString("F2") + "°";

            //Deshabilita el botón de cálculo para evitar cálculos repetidos
            calc.Enabled = false;

            //Desactiva los campos de entrada para evitar cambios posteriores
            val_a.Enabled = false;
            val_b.Enabled = false;

            //Enfoca el botón de limpiar para facilitar la interacción del usuario
            clear.Focus();

            //Habilita el paso a paso 
            paso.Enabled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            val_a.Text = "";
            val_b.Text = "";
            val_h.Text = "?";
            angulo_A.Text = "?°";
            angulo_B.Text = "?°";

            val_a.Enabled = true;
            val_b.Enabled = true;

            paso.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void alpha_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double a, b, h;
            Double.TryParse(val_a.Text, out a);
            Double.TryParse(val_b.Text, out b);
            Double.TryParse(val_h.Text, out h);

            MessageBox.Show("Cálculo de la hipotenusa:\n\n" +
                " h = √(a^2 + b^2) \n" +
                $" h =  √[({Math.Round(a,2)})^2 + ({Math.Round(b,2)})^2]\n" +
                $" h = √({Math.Round(Math.Pow(a, 2), 2)} + {Math.Round(Math.Pow(b, 2), 2)})\n" +
                $" h = √({Math.Round(Math.Pow(a, 2), 2) + Math.Round(Math.Pow(b, 2), 2)})\n" +
                $" h = {h}\n");

            MessageBox.Show("Cálculo del ángulo Alpha (ángulo <CBA):\n\n" +
                " Tan(α) = a/b \n" +
                " arcTan(Tan(α)) = arcTan(a/b) \n" +
                " α = arcTan(a/b) \n" +
                $" α = arcTan({Math.Round(a, 2)}/{Math.Round(b, 2)})\n" +
                $" α = {angulo_A.Text}\n");

            MessageBox.Show("Cálculo del ángulo Beta (ángulo <BAC):\n\n" +
                " Tan(β) = b/a \n" +
                " arcTan(Tan(β)) = arcTan(b/a) \n" +
                " β = arcTan(b/a) \n" +
                $" β = arcTan({Math.Round(b, 2)}/{Math.Round(a, 2)})\n" +
                $" β = {angulo_B.Text}\n");
        }
    }
}
