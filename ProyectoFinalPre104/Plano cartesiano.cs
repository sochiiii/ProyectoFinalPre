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
    public partial class Plano_Cartesiano : Form
    {
        static Point origen = new Point(202, 243); // Punto de origen en la esquina superior izquierda

        // Matriz para almacenar las divisiones del plano cartesiano
        static Double[,] divisiones = {
            {-10.0, -7.5, - 5.0, - 2.5, 0, 2.5, 5.0, 7.5, 10.0},
            {-10.0, -7.5, -5.0, -2.5, 0, 2.5, 5.0, 7.5, 10.0}
        };
        static Double x_dimTopx = 50.6;
        static Double y_dimTopx = 44.0;
        public Plano_Cartesiano()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lbl_planno_Click(object sender, EventArgs e)
        {

        }
    }

    //Clase para representar un punto en el plano cartesiano
    public class Punto
    {
        // Coordenadas del punto
        public Double x;
        public Double y;

        // Constructor
        public Punto(Double x, Double y)
        {
            this.x = x;
            this.y = y;
        }

        // Método para representar el punto como una cadena
        public override string ToString()
        {
            return $"({x}, {y})";
        }

        // Método para obtener el punto
        public Punto GetPoint()
        {
            return this;
        }
    }
}
