namespace ProyectoFinalPre104
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_planno = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_planno
            // 
            this.lbl_planno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_planno.Image = global::ProyectoFinalPre104.Properties.Resources.g5;
            this.lbl_planno.Location = new System.Drawing.Point(5, 10);
            this.lbl_planno.Name = "lbl_planno";
            this.lbl_planno.Size = new System.Drawing.Size(430, 440);
            this.lbl_planno.TabIndex = 0;
            this.lbl_planno.Click += new System.EventHandler(this.lbl_planno_Click);
            // 
            // point
            // 
            this.point.BackColor = System.Drawing.Color.Red;
            this.point.Location = new System.Drawing.Point(202, 243);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(10, 10);
            this.point.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "X:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese los valores de las coordenadas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(620, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(620, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 29);
            this.textBox2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.point);
            this.Controls.Add(this.lbl_planno);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Plano cartesiano";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_planno;
        private System.Windows.Forms.Label point;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}