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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAngulos_Click(object sender, EventArgs e)
        {
            Angulos ventana = new Angulos();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Determinante ventanaDet = new Determinante();
            ventanaDet.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cajero ventanaCaj = new Cajero();
            ventanaCaj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Creditos ventanaCred = new Creditos();
            ventanaCred.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
        "¿Desea salir del sistema?",   
        "Confirmación",               
        MessageBoxButtons.YesNo,      
        MessageBoxIcon.Question       
    );

            if (opcion == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void Form1_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Plano_Cartesiano plano_win = new Plano_Cartesiano();
            plano_win.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Promedio ventanaProm = new Promedio();
            ventanaProm.Show();
            this.Hide();
        }
    }
}
