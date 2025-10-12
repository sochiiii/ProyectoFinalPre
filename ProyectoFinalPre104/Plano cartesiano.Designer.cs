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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.point);
            this.Controls.Add(this.lbl_planno);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form2";
            this.Text = "Plano cartesiano";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_planno;
        private System.Windows.Forms.Label point;
    }
}