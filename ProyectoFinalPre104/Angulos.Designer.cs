namespace ProyectoFinalPre104
{
    partial class Angulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angulos));
            this.titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.val_a = new System.Windows.Forms.TextBox();
            this.val_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.img_triangle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.val_h = new System.Windows.Forms.Label();
            this.angulo_A = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.angulo_B = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.h = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(134)))));
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titulo.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.titulo.Location = new System.Drawing.Point(8, 8);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(339, 59);
            this.titulo.TabIndex = 0;
            this.titulo.Text = ">>  Ingrese las longitudes de los catetos\r\n     \"a\" y \"b\"";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(666, 353);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver al menú";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.calc.Enabled = false;
            this.calc.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.calc.FlatAppearance.BorderSize = 0;
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calc.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.Location = new System.Drawing.Point(172, 74);
            this.calc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(94, 42);
            this.calc.TabIndex = 2;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a =";
            // 
            // val_a
            // 
            this.val_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.val_a.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_a.Location = new System.Drawing.Point(47, 74);
            this.val_a.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.val_a.MaxLength = 100;
            this.val_a.Name = "val_a";
            this.val_a.Size = new System.Drawing.Size(90, 20);
            this.val_a.TabIndex = 4;
            this.val_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.val_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // val_b
            // 
            this.val_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.val_b.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_b.Location = new System.Drawing.Point(47, 97);
            this.val_b.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.val_b.MaxLength = 100;
            this.val_b.Name = "val_b";
            this.val_b.Size = new System.Drawing.Size(90, 20);
            this.val_b.TabIndex = 6;
            this.val_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.val_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultados";
            // 
            // img_triangle
            // 
            this.img_triangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.img_triangle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.img_triangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_triangle.Image = ((System.Drawing.Image)(resources.GetObject("img_triangle.Image")));
            this.img_triangle.Location = new System.Drawing.Point(373, 7);
            this.img_triangle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.img_triangle.Name = "img_triangle";
            this.img_triangle.Size = new System.Drawing.Size(449, 317);
            this.img_triangle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "a =";
            // 
            // val_h
            // 
            this.val_h.AutoSize = true;
            this.val_h.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_h.Location = new System.Drawing.Point(76, 184);
            this.val_h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val_h.Name = "val_h";
            this.val_h.Size = new System.Drawing.Size(11, 13);
            this.val_h.TabIndex = 10;
            this.val_h.Text = "?";
            // 
            // angulo_A
            // 
            this.angulo_A.AutoSize = true;
            this.angulo_A.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angulo_A.Location = new System.Drawing.Point(76, 219);
            this.angulo_A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angulo_A.Name = "angulo_A";
            this.angulo_A.Size = new System.Drawing.Size(15, 13);
            this.angulo_A.TabIndex = 12;
            this.angulo_A.Text = "?°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "a =";
            // 
            // angulo_B
            // 
            this.angulo_B.AutoSize = true;
            this.angulo_B.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angulo_B.Location = new System.Drawing.Point(75, 254);
            this.angulo_B.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angulo_B.Name = "angulo_B";
            this.angulo_B.Size = new System.Drawing.Size(15, 13);
            this.angulo_B.TabIndex = 14;
            this.angulo_B.Text = "?°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 254);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "a =";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(221, 169);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 42);
            this.clear.TabIndex = 15;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.h.Font = new System.Drawing.Font("Berlin Sans FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.h.Location = new System.Drawing.Point(519, 121);
            this.h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(82, 37);
            this.h.TabIndex = 16;
            this.h.Text = "h = ?";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.b.Font = new System.Drawing.Font("Berlin Sans FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.b.Location = new System.Drawing.Point(589, 278);
            this.b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(36, 37);
            this.b.TabIndex = 17;
            this.b.Text = "b";
            this.b.Click += new System.EventHandler(this.label5_Click);
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.a.Font = new System.Drawing.Font("Berlin Sans FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.a.Location = new System.Drawing.Point(776, 148);
            this.a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(36, 37);
            this.a.TabIndex = 18;
            this.a.Text = "a";
            this.a.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.label5.Location = new System.Drawing.Point(377, 262);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 44);
            this.label5.TabIndex = 19;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.label6.Location = new System.Drawing.Point(773, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 44);
            this.label6.TabIndex = 20;
            this.label6.Text = "A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.label8.Font = new System.Drawing.Font("Berlin Sans FB", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.label8.Location = new System.Drawing.Point(773, 271);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 44);
            this.label8.TabIndex = 21;
            this.label8.Text = "C";
            // 
            // Angulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(830, 407);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.a);
            this.Controls.Add(this.b);
            this.Controls.Add(this.h);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.angulo_B);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.angulo_A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.val_h);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_triangle);
            this.Controls.Add(this.val_b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.val_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Angulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = " Ángulos Agudos";
            this.Load += new System.EventHandler(this.Angulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox val_a;
        private System.Windows.Forms.TextBox val_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label img_triangle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label val_h;
        private System.Windows.Forms.Label angulo_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label angulo_B;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}