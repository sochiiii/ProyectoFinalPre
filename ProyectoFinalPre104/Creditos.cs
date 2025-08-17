using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace ProyectoFinalPre104
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.StartFigure();
            gp.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            gp.AddArc(new Rectangle(boton.Width - radio, 0, radio, radio), 270, 90);
            gp.AddArc(new Rectangle(boton.Width - radio, boton.Height - radio, radio, radio), 0, 90);
            gp.AddArc(new Rectangle(0, boton.Height - radio, radio, radio), 90, 90);
            gp.CloseFigure();

            boton.Region = new Region(gp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RedondearBoton(button1, 15); // Bordes redondeados con radio 15
        }


    }
}
