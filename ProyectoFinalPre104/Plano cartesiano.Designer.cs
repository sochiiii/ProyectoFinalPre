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
            this.lbl_planno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X_pos = new System.Windows.Forms.TextBox();
            this.Y_pos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_punto_ingresado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.y_div_1 = new System.Windows.Forms.Label();
            this.y_div_2 = new System.Windows.Forms.Label();
            this.x_div_1 = new System.Windows.Forms.Label();
            this.x_div_2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_planno
            // 
            this.lbl_planno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_planno.Image = global::ProyectoFinalPre104.Properties.Resources.g5;
            this.lbl_planno.Location = new System.Drawing.Point(30, 10);
            this.lbl_planno.Name = "lbl_planno";
            this.lbl_planno.Size = new System.Drawing.Size(430, 440);
            this.lbl_planno.TabIndex = 0;
            this.lbl_planno.Click += new System.EventHandler(this.lbl_planno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese las coordenadas del punto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Y:";
            // 
            // X_pos
            // 
            this.X_pos.Location = new System.Drawing.Point(574, 61);
            this.X_pos.Name = "X_pos";
            this.X_pos.Size = new System.Drawing.Size(199, 29);
            this.X_pos.TabIndex = 5;
            this.X_pos.Text = "0";
            this.X_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.X_pos.TextChanged += new System.EventHandler(this.X_pos_TextChanged);
            // 
            // Y_pos
            // 
            this.Y_pos.Location = new System.Drawing.Point(574, 100);
            this.Y_pos.Name = "Y_pos";
            this.Y_pos.Size = new System.Drawing.Size(199, 29);
            this.Y_pos.TabIndex = 6;
            this.Y_pos.Text = "0";
            this.Y_pos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Y_pos.TextChanged += new System.EventHandler(this.Y_pos_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(570, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Punto ingresado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_punto_ingresado
            // 
            this.lbl_punto_ingresado.AutoSize = true;
            this.lbl_punto_ingresado.Location = new System.Drawing.Point(604, 199);
            this.lbl_punto_ingresado.Name = "lbl_punto_ingresado";
            this.lbl_punto_ingresado.Size = new System.Drawing.Size(67, 23);
            this.lbl_punto_ingresado.TabIndex = 8;
            this.lbl_punto_ingresado.Text = "( 0, 0 )";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "El punto ingresado se ubica en el:";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(604, 278);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(66, 23);
            this.lbl_resultado.TabIndex = 10;
            this.lbl_resultado.Text = "Origen";
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plano_Cartesiano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.point);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.x_div_2);
            this.Controls.Add(this.x_div_1);
            this.Controls.Add(this.y_div_2);
            this.Controls.Add(this.y_div_1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_punto_ingresado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Y_pos);
            this.Controls.Add(this.X_pos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_planno);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_punto_ingresado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label y_div_1;
        private System.Windows.Forms.Label y_div_2;
        private System.Windows.Forms.Label x_div_1;
        private System.Windows.Forms.Label x_div_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Button button1;
    }
}