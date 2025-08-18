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
            this.lcd = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.paso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lcd
            // 
            this.lcd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(134)))));
            this.lcd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lcd.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lcd.Location = new System.Drawing.Point(8, 8);
            this.lcd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lcd.Name = "lcd";
            this.lcd.Size = new System.Drawing.Size(339, 59);
            this.lcd.TabIndex = 0;
            this.lcd.Text = ">>  Ingrese las longitudes de los catetos\r\n     \"a\" y \"b\"";
            this.lcd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lcd.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(627, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Volver al menú";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calc
            // 
            this.calc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(216)))), ((int)(((byte)(184)))));
            this.calc.Enabled = false;
            this.calc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.calc.FlatAppearance.BorderSize = 3;
            this.calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calc.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(134)))));
            this.calc.Location = new System.Drawing.Point(236, 120);
            this.calc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(111, 42);
            this.calc.TabIndex = 2;
            this.calc.Text = "Calcular";
            this.calc.UseVisualStyleBackColor = false;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "a =";
            // 
            // val_a
            // 
            this.val_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(160)))));
            this.val_a.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_a.Location = new System.Drawing.Point(62, 75);
            this.val_a.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.val_a.MaximumSize = new System.Drawing.Size(150, 4);
            this.val_a.MaxLength = 20;
            this.val_a.MinimumSize = new System.Drawing.Size(75, 4);
            this.val_a.Name = "val_a";
            this.val_a.Size = new System.Drawing.Size(150, 29);
            this.val_a.TabIndex = 4;
            this.val_a.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.val_a.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // val_b
            // 
            this.val_b.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(197)))), ((int)(((byte)(160)))));
            this.val_b.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_b.Location = new System.Drawing.Point(62, 138);
            this.val_b.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.val_b.MaximumSize = new System.Drawing.Size(150, 4);
            this.val_b.MaxLength = 20;
            this.val_b.MinimumSize = new System.Drawing.Size(75, 4);
            this.val_b.Name = "val_b";
            this.val_b.Size = new System.Drawing.Size(150, 29);
            this.val_b.TabIndex = 6;
            this.val_b.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.val_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "b =";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(116, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
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
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label4.Location = new System.Drawing.Point(21, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "h =";
            // 
            // val_h
            // 
            this.val_h.AutoSize = true;
            this.val_h.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val_h.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.val_h.Location = new System.Drawing.Point(89, 238);
            this.val_h.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.val_h.Name = "val_h";
            this.val_h.Size = new System.Drawing.Size(31, 37);
            this.val_h.TabIndex = 10;
            this.val_h.Text = "?";
            // 
            // angulo_A
            // 
            this.angulo_A.AutoSize = true;
            this.angulo_A.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angulo_A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.angulo_A.Location = new System.Drawing.Point(90, 273);
            this.angulo_A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angulo_A.Name = "angulo_A";
            this.angulo_A.Size = new System.Drawing.Size(44, 37);
            this.angulo_A.TabIndex = 12;
            this.angulo_A.Text = "?°";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label7.Location = new System.Drawing.Point(28, 276);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "  =";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // angulo_B
            // 
            this.angulo_B.AutoSize = true;
            this.angulo_B.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angulo_B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.angulo_B.Location = new System.Drawing.Point(90, 308);
            this.angulo_B.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.angulo_B.Name = "angulo_B";
            this.angulo_B.Size = new System.Drawing.Size(44, 37);
            this.angulo_B.TabIndex = 14;
            this.angulo_B.Text = "?°";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label9.Location = new System.Drawing.Point(35, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 37);
            this.label9.TabIndex = 13;
            this.label9.Text = " =";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(216)))), ((int)(((byte)(184)))));
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.clear.FlatAppearance.BorderSize = 3;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(139)))), ((int)(((byte)(134)))));
            this.clear.Location = new System.Drawing.Point(236, 70);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(111, 42);
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
            this.h.Size = new System.Drawing.Size(99, 46);
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
            this.b.Size = new System.Drawing.Size(43, 46);
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
            this.a.Size = new System.Drawing.Size(43, 46);
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
            this.label5.Size = new System.Drawing.Size(55, 55);
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
            this.label6.Size = new System.Drawing.Size(57, 55);
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
            this.label8.Size = new System.Drawing.Size(54, 55);
            this.label8.TabIndex = 21;
            this.label8.Text = "C";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(161)))), ((int)(((byte)(123)))));
            this.label10.Location = new System.Drawing.Point(378, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(392, 46);
            this.label10.TabIndex = 22;
            this.label10.Text = "Triángulo Rectángulo";
            // 
            // alpha
            // 
            this.alpha.Image = ((System.Drawing.Image)(resources.GetObject("alpha.Image")));
            this.alpha.Location = new System.Drawing.Point(5, 287);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(41, 13);
            this.alpha.TabIndex = 23;
            this.alpha.Click += new System.EventHandler(this.alpha_Click);
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(14, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 36);
            this.label11.TabIndex = 24;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // paso
            // 
            this.paso.BackColor = System.Drawing.Color.White;
            this.paso.Enabled = false;
            this.paso.FlatAppearance.BorderSize = 3;
            this.paso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paso.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paso.Location = new System.Drawing.Point(373, 348);
            this.paso.Margin = new System.Windows.Forms.Padding(2);
            this.paso.Name = "paso";
            this.paso.Size = new System.Drawing.Size(156, 48);
            this.paso.TabIndex = 25;
            this.paso.Text = "Paso a Paso";
            this.paso.UseVisualStyleBackColor = false;
            this.paso.Click += new System.EventHandler(this.button2_Click);
            // 
            // Angulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(212)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(830, 407);
            this.Controls.Add(this.paso);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.lcd);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Angulos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Ángulos Agudos";
            this.Load += new System.EventHandler(this.Angulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lcd;
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label alpha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button paso;
    }
}