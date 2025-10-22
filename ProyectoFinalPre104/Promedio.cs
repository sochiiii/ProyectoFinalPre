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
    public partial class Promedio : Form
    {
        public Promedio()
        {
            InitializeComponent();
        }
        private void Promedio_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaracion de variables 
                Double v1, v2, v3, prom;

                // Entrada de datos
                v1 = Convert.ToDouble(txtVenta1.Text);
                v2 = Convert.ToDouble(txtVenta2.Text);
                v3 = Convert.ToDouble(txtVenta3.Text);

                // Validar que no sean negativas
                if (v1 < 0 || v2 < 0 || v3 < 0)
                {
                    MessageBox.Show("Las ventas no pueden ser negativas", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Proceso: SUMA LAS TRES VENTAS Y CALCULA EL PROMEDIO DIVIENDO ENTRE 3
                
            
                prom = (v1 + v2 + v3) / 3;

                // Salida
                txtPromedio.Text = Math.Round(prom, 2).ToString();

                // Validacion de la promocion
                if (prom >= 500)
                {
                    lblMensaje.Text = "🎉 SE HA GANADO UN REGALITO 🎁";
                    lblMensaje.ForeColor = Color.Green;
                }
                else
                {
                    lblMensaje.Text = "....🤗 Lo esperamos pronto...vaya con cuidado";
                    lblMensaje.ForeColor = Color.Orange;
                }
            }
            //Validacion que detecta cuando el usuario ingresa un valor que no es un número
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores numéricos válidos",
                    "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Validacion para evitar cualquier otro tipo de formato extraño 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtVenta1.Clear();
            txtVenta2.Clear();
            txtVenta3.Clear();
            txtPromedio.Clear();
            lblMensaje.Text = "";
        }

        
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
            this.Dispose();
        }
    }
}
