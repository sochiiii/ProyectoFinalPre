namespace ProyectoFinalPre104
{
    partial class Plano_Cartesiano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plano_Cartesiano));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X_pos = new System.Windows.Forms.TextBox();
            this.Y_pos = new System.Windows.Forms.TextBox();
            this.lbl_point = new System.Windows.Forms.Label();
            this.lbl_punto_ingresado = new System.Windows.Forms.Label();
            this.lbl_ub = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.y_div_1 = new System.Windows.Forms.Label();
            this.y_div_2 = new System.Windows.Forms.Label();
            this.x_div_1 = new System.Windows.Forms.Label();
            this.x_div_2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lcd = new System.Windows.Forms.Label();
            this.mostar = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.y_menos1 = new System.Windows.Forms.Button();
            this.y_mas1 = new System.Windows.Forms.Button();
            this.x_menos1 = new System.Windows.Forms.Button();
            this.x_mas1 = new System.Windows.Forms.Button();
            this.lbl_planno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(511, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese las coordenadas del punto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(511, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(510, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // X_pos
            // 
            this.X_pos.Location = new System.Drawing.Point(559, 55);
            this.X_pos.Name = "X_pos";
            this.X_pos.Size = new System.Drawing.Size(192, 29);
            this.X_pos.TabIndex = 5;
            this.X_pos.Text = "0";
            this.X_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X_pos.TextChanged += new System.EventHandler(this.X_pos_TextChanged);
            // 
            // Y_pos
            // 
            this.Y_pos.Location = new System.Drawing.Point(559, 100);
            this.Y_pos.Name = "Y_pos";
            this.Y_pos.Size = new System.Drawing.Size(192, 29);
            this.Y_pos.TabIndex = 6;
            this.Y_pos.Text = "0";
            this.Y_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Y_pos.TextChanged += new System.EventHandler(this.Y_pos_TextChanged);
            // 
            // lbl_point
            // 
            this.lbl_point.AutoSize = true;
            this.lbl_point.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.lbl_point.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_point.Location = new System.Drawing.Point(500, 235);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(169, 23);
            this.lbl_point.TabIndex = 7;
            this.lbl_point.Text = "-> Punto ingresado:";
            this.lbl_point.Visible = false;
            this.lbl_point.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_punto_ingresado
            // 
            this.lbl_punto_ingresado.AutoSize = true;
            this.lbl_punto_ingresado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.lbl_punto_ingresado.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_punto_ingresado.Location = new System.Drawing.Point(500, 265);
            this.lbl_punto_ingresado.Name = "lbl_punto_ingresado";
            this.lbl_punto_ingresado.Size = new System.Drawing.Size(67, 23);
            this.lbl_punto_ingresado.TabIndex = 8;
            this.lbl_punto_ingresado.Text = "( 0, 0 )";
            this.lbl_punto_ingresado.Visible = false;
            // 
            // lbl_ub
            // 
            this.lbl_ub.AutoSize = true;
            this.lbl_ub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.lbl_ub.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_ub.Location = new System.Drawing.Point(500, 295);
            this.lbl_ub.Name = "lbl_ub";
            this.lbl_ub.Size = new System.Drawing.Size(303, 23);
            this.lbl_ub.TabIndex = 9;
            this.lbl_ub.Text = "-> El punto ingresado se ubica en el:";
            this.lbl_ub.Visible = false;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(145)))));
            this.lbl_resultado.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbl_resultado.Location = new System.Drawing.Point(500, 325);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(66, 23);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.Text = "Origen";
            this.lbl_resultado.Visible = false;
            // 
            // y_div_1
            // 
            this.y_div_1.AutoSize = true;
            this.y_div_1.BackColor = System.Drawing.Color.DimGray;
            this.y_div_1.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_div_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.y_div_1.Location = new System.Drawing.Point(243, 43);
            this.y_div_1.Name = "y_div_1";
            this.y_div_1.Size = new System.Drawing.Size(44, 16);
            this.y_div_1.TabIndex = 11;
            this.y_div_1.Text = "1x10^0";
            // 
            // y_div_2
            // 
            this.y_div_2.AutoSize = true;
            this.y_div_2.BackColor = System.Drawing.Color.DimGray;
            this.y_div_2.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_div_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.y_div_2.Location = new System.Drawing.Point(243, 434);
            this.y_div_2.Name = "y_div_2";
            this.y_div_2.Size = new System.Drawing.Size(49, 16);
            this.y_div_2.TabIndex = 12;
            this.y_div_2.Text = "-1x10^0";
            // 
            // x_div_1
            // 
            this.x_div_1.AutoSize = true;
            this.x_div_1.BackColor = System.Drawing.Color.DimGray;
            this.x_div_1.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_div_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x_div_1.Location = new System.Drawing.Point(408, 268);
            this.x_div_1.Name = "x_div_1";
            this.x_div_1.Size = new System.Drawing.Size(44, 16);
            this.x_div_1.TabIndex = 13;
            this.x_div_1.Text = "1x10^0";
            // 
            // x_div_2
            // 
            this.x_div_2.AutoSize = true;
            this.x_div_2.BackColor = System.Drawing.Color.DimGray;
            this.x_div_2.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_div_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.x_div_2.Location = new System.Drawing.Point(12, 268);
            this.x_div_2.Name = "x_div_2";
            this.x_div_2.Size = new System.Drawing.Size(49, 16);
            this.x_div_2.TabIndex = 14;
            this.x_div_2.Text = "-1x10^0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(208, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "0";
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.Red;
            this.point.Location = new System.Drawing.Point(226, 243);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(10, 10);
            this.point.TabIndex = 16;
            this.point.Visible = false;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(479, 385);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(360, 52);
            this.volver.TabIndex = 17;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.label6.Location = new System.Drawing.Point(479, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 190);
            this.label6.TabIndex = 18;
            // 
            // lcd
            // 
            this.lcd.BackColor = System.Drawing.Color.DarkGray;
            this.lcd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lcd.Location = new System.Drawing.Point(479, 211);
            this.lcd.Name = "lcd";
            this.lcd.Size = new System.Drawing.Size(360, 160);
            this.lcd.TabIndex = 19;
            // 
            // mostar
            // 
            this.mostar.Location = new System.Drawing.Point(510, 144);
            this.mostar.Name = "mostar";
            this.mostar.Size = new System.Drawing.Size(137, 30);
            this.mostar.TabIndex = 24;
            this.mostar.Text = "MOSTRAR";
            this.mostar.UseVisualStyleBackColor = true;
            this.mostar.Click += new System.EventHandler(this.button6_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(665, 144);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(138, 30);
            this.limpiar.TabIndex = 25;
            this.limpiar.Text = "LIMPIAR";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.button7_Click);
            // 
            // y_menos1
            // 
            this.y_menos1.BackColor = System.Drawing.Color.White;
            this.y_menos1.Image = ((System.Drawing.Image)(resources.GetObject("y_menos1.Image")));
            this.y_menos1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.y_menos1.Location = new System.Drawing.Point(773, 115);
            this.y_menos1.Name = "y_menos1";
            this.y_menos1.Size = new System.Drawing.Size(30, 15);
            this.y_menos1.TabIndex = 27;
            this.y_menos1.UseVisualStyleBackColor = false;
            this.y_menos1.Click += new System.EventHandler(this.y_menos1_Click);
            // 
            // y_mas1
            // 
            this.y_mas1.BackColor = System.Drawing.Color.White;
            this.y_mas1.Font = new System.Drawing.Font("Berlin Sans FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.y_mas1.Image = ((System.Drawing.Image)(resources.GetObject("y_mas1.Image")));
            this.y_mas1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.y_mas1.Location = new System.Drawing.Point(773, 99);
            this.y_mas1.Margin = new System.Windows.Forms.Padding(0);
            this.y_mas1.Name = "y_mas1";
            this.y_mas1.Size = new System.Drawing.Size(30, 15);
            this.y_mas1.TabIndex = 26;
            this.y_mas1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.y_mas1.UseVisualStyleBackColor = false;
            this.y_mas1.Click += new System.EventHandler(this.y_mas1_Click);
            // 
            // x_menos1
            // 
            this.x_menos1.BackColor = System.Drawing.Color.White;
            this.x_menos1.Image = ((System.Drawing.Image)(resources.GetObject("x_menos1.Image")));
            this.x_menos1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.x_menos1.Location = new System.Drawing.Point(773, 69);
            this.x_menos1.Name = "x_menos1";
            this.x_menos1.Size = new System.Drawing.Size(30, 15);
            this.x_menos1.TabIndex = 21;
            this.x_menos1.UseVisualStyleBackColor = false;
            this.x_menos1.Click += new System.EventHandler(this.x_menos1_Click);
            // 
            // x_mas1
            // 
            this.x_mas1.BackColor = System.Drawing.Color.White;
            this.x_mas1.Font = new System.Drawing.Font("Berlin Sans FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_mas1.Image = ((System.Drawing.Image)(resources.GetObject("x_mas1.Image")));
            this.x_mas1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.x_mas1.Location = new System.Drawing.Point(773, 53);
            this.x_mas1.Margin = new System.Windows.Forms.Padding(0);
            this.x_mas1.Name = "x_mas1";
            this.x_mas1.Size = new System.Drawing.Size(30, 15);
            this.x_mas1.TabIndex = 20;
            this.x_mas1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.x_mas1.UseVisualStyleBackColor = false;
            this.x_mas1.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_planno
            // 
            this.lbl_planno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_planno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_planno.Image = global::ProyectoFinalPre104.Properties.Resources.g5;
            this.lbl_planno.Location = new System.Drawing.Point(30, 10);
            this.lbl_planno.Name = "lbl_planno";
            this.lbl_planno.Size = new System.Drawing.Size(430, 440);
            this.lbl_planno.TabIndex = 0;
            this.lbl_planno.Click += new System.EventHandler(this.lbl_planno_Click);
            // 
            // Plano_Cartesiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.y_menos1);
            this.Controls.Add(this.y_mas1);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.mostar);
            this.Controls.Add(this.x_menos1);
            this.Controls.Add(this.x_mas1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.x_div_2);
            this.Controls.Add(this.x_div_1);
            this.Controls.Add(this.y_div_2);
            this.Controls.Add(this.y_div_1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_ub);
            this.Controls.Add(this.lbl_punto_ingresado);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.Y_pos);
            this.Controls.Add(this.X_pos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_planno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lcd);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Plano_Cartesiano";
            this.Text = "Plano cartesiano";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_planno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox X_pos;
        private System.Windows.Forms.TextBox Y_pos;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Label lbl_punto_ingresado;
        private System.Windows.Forms.Label lbl_ub;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label y_div_1;
        private System.Windows.Forms.Label y_div_2;
        private System.Windows.Forms.Label x_div_1;
        private System.Windows.Forms.Label x_div_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lcd;
        private System.Windows.Forms.Button x_mas1;
        private System.Windows.Forms.Button x_menos1;
        private System.Windows.Forms.Button mostar;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button y_menos1;
        private System.Windows.Forms.Button y_mas1;
    }
}