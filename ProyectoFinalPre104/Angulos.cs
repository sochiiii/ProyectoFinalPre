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
            this.Dispose();
            this.Close();
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
                else
                {
                    calc.Enabled = false;
                }
            }
            else
            {
                calc.Enabled = false;
            }
        }

        private void Angulos_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Double num_a, num_b;
            if (Double.TryParse(val_a.Text, out num_a) && Double.TryParse(val_b.Text, out num_b))
            {
                if (num_a > 0 && num_b > 0)
                {
                    calc.Enabled = true;
                }
                else
                {
                    calc.Enabled = false;
                }
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

            if (Double.TryParse(val_a.Text, out cat_a_val) && Double.TryParse(val_b.Text, out cat_b_val))
            {
                h_val = Math.Sqrt(Math.Pow(cat_a_val, 2) + Math.Pow(cat_b_val, 2));
                angulo_a_val = Math.Atan(cat_a_val / cat_b_val) * (180 / Math.PI);
                angulo_b_val = 90 - angulo_a_val;
                val_h.Text = h_val.ToString("F2");
                angulo_A.Text = angulo_a_val.ToString("F2");
                angulo_B.Text = angulo_b_val.ToString("F2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
        }
    }
}
