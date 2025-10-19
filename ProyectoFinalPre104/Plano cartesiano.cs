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
{   /*
    Se determina el cuadrante al que pertenece un punto en el plano cartesiano:
        * Primer cuadrante:     x > 0 < y
        * Segundo cuadrante:    x < 0 < y
        * Tercer cuadrante:     x < 0 > y
        * Cuarto cuadrante:     x > 0 > y
        
        * También puede posicionarce sobre un eje:
        * Eje X: y = 0 ^ x != 0
        * Eje Y: x = 0 ^ y != 0
        
        * También puede ser el origen:
        * O: x = 0 = y
    */
    public partial class Plano_Cartesiano : Form
    {
        /*
         * Datos necesarios para ubicar un punto:
         *      # Centro del plano (226, 243). Coordenadas reales
         *      # Dimensiones gráficas de los ejes
         *      # Escala de los ejes
         *      # Coordenadas relativas del punto a ubicar
        */
        static Double[] dim_plano_x = { 30, 422 };   //{ min, max }
        static Double[] dim_plano_y = { 45, 441 };   //{ min, max } Invertido por que en pantalla el eje Y está invertido

        static Double[] escala = { 10.0, 10.0 };    //{ escala_x, escala_y }

        // Matriz para almacenar las divisiones del plano cartesiano
        static String[,] divisiones = {
            {"10x10^0", "-10x10^0" },     //{ x_div_1, x_div_2 }
            {"10x10^0", "-10x10^0" }      //{ y_div_1, y_div_2 }
        };

        //Posiciones del punto
        static String[] resultados =
        {
            "Origen",
            "Eje X positivo",
            "Eje X negativo",
            "Eje Y positivo",
            "Eje Y negativo",
            "Primer Cuadrante",
            "Segundo Cuadrante",
            "Tercer Cuadrante",
            "Cuarto cuadrante"
        };

        static String resultado = resultados[0];

        static Double[] punto_ingresado = { 0, 0 }; //punto ingresado por el usuario

        //Funcion para mapear un valor de un rango a otro
        public static Double map(Double value, Double inMin, Double inMax, Double outMin, Double outMax)
        {
            //Mapeo de las coordenadas relativas en pantalla
            /*
             * Ecuación del mapeo
             * Sea "a" el valor de entrada y se tienen dos rangos [B,C] y [D,E]
             * Si se quiere pasar de "a" en el rango [B, C] a un "s" en el rango [D, E]
             * Entonces se tiene la formula:
             * f = [(a - B) * (E - D)]/(C - B) + D ; ó visto de otra forma
             * f = [(a - (-escala)) * (pos_max - pos_min)]/(escala - (-escala)) + pos_min
            */
            return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
        }

        //Función para actualizar el punto
        void actualizar_punto()
        {
            //Autoajuste de escala (Verifica q el numero no sea 0 para evitar error de logaritmo)
            escala[0] = (punto_ingresado[0] != 0) ? Math.Pow(10, Math.Ceiling(Math.Log10(Math.Abs(punto_ingresado[0])))) : 1;
            escala[1] = (punto_ingresado[1] != 0) ? Math.Pow(10, Math.Ceiling(Math.Log10(Math.Abs(punto_ingresado[1])))) : 1;

            //Actualización de las divisiones (Verifica q el numero no sea 0 para evitar error de logaritmo)
            divisiones[0, 0] = "10x10^" + ((punto_ingresado[0] != 0) ? Math.Log10(escala[0]).ToString() : "1");
            divisiones[0, 1] = "-10x10^" + ((punto_ingresado[0] != 0) ? Math.Log10(escala[0]).ToString() : "1");
            divisiones[1, 0] = "10x10^" + ((punto_ingresado[1] != 0) ? Math.Log10(escala[1]).ToString() : "1");
            divisiones[1, 1] = "-10x10^" + ((punto_ingresado[1] != 0) ? Math.Log10(escala[1]).ToString() : "1");

            //Muestra las nuevas divisiones
            x_div_1.Text = divisiones[0, 0];
            x_div_2.Text = divisiones[0, 1];
            y_div_1.Text = divisiones[1, 0];
            y_div_2.Text = divisiones[1, 1];

            int x_pos = (int)map(punto_ingresado[0], -1*escala[0], escala[0], dim_plano_x[0], dim_plano_x[1]);
            int y_pos = (int)map(punto_ingresado[1], -1 * escala[1], escala[1], dim_plano_y[1], dim_plano_y[0]);

            //Ubicamos el punto en pantalla
            point.Location = new Point(x_pos, y_pos);
            point.BringToFront();

            //Mostramos las coordenadas del punto
            lbl_punto_ingresado.Text = "( " + punto_ingresado[0].ToString() + ", " + punto_ingresado[1].ToString() + ")";
            
            //Determinamos la posición del punto
            if (punto_ingresado[0] == 0 && punto_ingresado[1] == 0)
            {
                resultado = resultados[0];
            }
            else if (punto_ingresado[0] == 0 && punto_ingresado[1] != 0)
            {
                if (punto_ingresado[1] > 0)
                {
                    resultado = resultados[3];
                }
                else
                {
                    resultado = resultados[4];
                }
            }
            else if (punto_ingresado[0] != 0 && punto_ingresado[1] == 0)
            {
                if (punto_ingresado[0] > 0)
                {
                    resultado = resultados[1];
                }
                else
                {
                    resultado = resultados[2];
                }
            }
            else if (punto_ingresado[0] > 0 && punto_ingresado[1] > 0)
            {
                resultado = resultados[5];
            }
            else if (punto_ingresado[0] < 0 && punto_ingresado[1] > 0)
            {
                resultado = resultados[6];
            }
            else if (punto_ingresado[0] < 0 && punto_ingresado[1] < 0)
            {
                resultado = resultados[7];
            }
            else if (punto_ingresado[0] > 0 && punto_ingresado[1] < 0)
            {
                resultado = resultados[8];
            }

            //Mostramos el resultado
            lbl_resultado.Text = resultado;
        }

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void X_pos_TextChanged(object sender, EventArgs e)
        {
            //Validación de la entrada
            if (!Double.TryParse(X_pos.Text, out punto_ingresado[0]))
            {
                if (X_pos.Text != "-" && !String.IsNullOrEmpty(X_pos.Text))
                {
                    MessageBox.Show("Por favor ingrese un valor numérico válido para la coordenada X.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    X_pos.Text = "0";
                    punto_ingresado[0] = 0;
                    actualizar_punto();
                }
                else if (String.IsNullOrEmpty(X_pos.Text))
                {
                    X_pos.Text = "0";
                    punto_ingresado[0] = 0;
                    actualizar_punto();
                }
                else
                {
                    //Permitir el signo negativo temporalmente
                    return;
                }
            }
            else
            {
                if (X_pos.Text.StartsWith("0") && X_pos.Text.Length > 1 && !X_pos.Text.StartsWith("0."))
                {
                    // Evitar números con ceros a la izquierda
                    X_pos.Text = punto_ingresado[0].ToString();
                    X_pos.SelectionStart = X_pos.Text.Length; // Mover el cursor al final
                }
                actualizar_punto();
            }
        }

        private void Y_pos_TextChanged(object sender, EventArgs e)
        {
            //Validación de la entrada
            if (!Double.TryParse(Y_pos.Text, out punto_ingresado[1]))
            {
                if (Y_pos.Text != "-" && !String.IsNullOrEmpty(Y_pos.Text))
                {
                    MessageBox.Show("Por favor ingrese un valor numérico válido para la coordenada Y.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Y_pos.Text = "0";
                    punto_ingresado[1] = 0;
                    actualizar_punto();
                }
                else if (String.IsNullOrEmpty(Y_pos.Text))
                {
                    Y_pos.Text = "0";
                    punto_ingresado[1] = 0;
                    actualizar_punto();
                }
                else
                {
                    //Permitir el signo negativo temporalmente
                    return;
                }
            }
            else
            {
                if (Y_pos.Text.StartsWith("0") && Y_pos.Text.Length > 1 && !Y_pos.Text.StartsWith("0."))
                {
                    // Evitar números con ceros a la izquierda
                    Y_pos.Text = punto_ingresado[1].ToString();
                    Y_pos.SelectionStart = Y_pos.Text.Length; // Mover el cursor al final
                }
                
                    actualizar_punto();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
            this.Dispose();
        }
    }
}
