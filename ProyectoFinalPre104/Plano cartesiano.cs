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
    public partial class Form2 : Form
    {
        // Punto de origen en el centro del plano cartesiano
        static Double[] origen = { 202, 243 };

        // Matriz para almacenar la escala del plano cartesiano
        static Double[] escala = { 10.0, 10.0 };

        // Matriz para almacenar las divisiones del plano cartesiano
        static Double[,] divisiones = {
            {-10.0, -7.5, - 5.0, - 2.5, 0, 2.5, 5.0, 7.5, 10.0},
            {-10.0, -7.5, -5.0, -2.5, 0, 2.5, 5.0, 7.5, 10.0}
        };

        // Conversiones de unidades
        static Double x_dimTopx = 50.6;
        static Double y_dimTopx = 44.0;

        //Función para ubicar un label en el plano cartesiano
        static void ubicarLabel(Label lbl, Double x, Double y)
        {
            // Calcular la posición en píxeles
            int px = (int)(origen[0] + (x * x_dimTopx / 2.5));
            int py = (int)(origen[1] - (y * y_dimTopx / 2.5));
            // Ajustar la posición del label
            lbl.Location = new Point(px - lbl.Width / 2, py - lbl.Height / 2);
        }

        //Coordenadas de entrada del usuario
        static Double[] p_in = { 0, 0 };

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbl_planno_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Verifica si se ingresó un número válido
            if (!Double.TryParse(textBox1.Text, out Double x))
            {
                //Clarar el valor de x como 0 si la entrada no es válida
                if (!String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Por favor, ingrese solo números válidos en el campo de la coordenada X.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    x = 0;
                    p_in[0] = x;
                    escala[0] = 10.0;
                    ubicarLabel(point, p_in[0], p_in[1]);
                }
            }
            else
            {
                p_in[0] = x;
                if (Math.Abs(x) <= 10) escala[0] = 10;
                else if (Math.Abs(x) > 10 && Math.Abs(x) <= 100) escala[0] = 100;
                else escala[0] = Math.Round(Math.Abs(x) + 1);
                ubicarLabel(point, p_in[0], p_in[1]);
            }
        }
    }
}
