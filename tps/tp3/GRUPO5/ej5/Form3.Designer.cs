namespace tp3
{
    partial class Form3
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
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblPrimos = new System.Windows.Forms.Label();
            this.ltbPrimos = new System.Windows.Forms.ListBox();
            this.nmMax = new System.Windows.Forms.NumericUpDown();
            this.Nmmin = new System.Windows.Forms.NumericUpDown();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Cornsilk;
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMax.ForeColor = System.Drawing.Color.Black;
            this.lblMax.Location = new System.Drawing.Point(163, 62);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(128, 19);
            this.lblMax.TabIndex = 0;
            this.lblMax.Text = "Ingrese un máximo";
            this.lblMax.Click += new System.EventHandler(this.lblMax_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Linen;
            this.lblMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMin.Location = new System.Drawing.Point(163, 128);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(129, 19);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Ingrese un mínimo ";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // lblPrimos
            // 
            this.lblPrimos.AutoSize = true;
            this.lblPrimos.Location = new System.Drawing.Point(415, 197);
            this.lblPrimos.Name = "lblPrimos";
            this.lblPrimos.Size = new System.Drawing.Size(95, 13);
            this.lblPrimos.TabIndex = 2;
            this.lblPrimos.Text = "Los N° primos son:";
            this.lblPrimos.Click += new System.EventHandler(this.label3_Click);
            // 
            // ltbPrimos
            // 
            this.ltbPrimos.FormattingEnabled = true;
            this.ltbPrimos.Location = new System.Drawing.Point(418, 222);
            this.ltbPrimos.Name = "ltbPrimos";
            this.ltbPrimos.Size = new System.Drawing.Size(123, 121);
            this.ltbPrimos.TabIndex = 4;
            this.ltbPrimos.SelectedIndexChanged += new System.EventHandler(this.ltbPrimos_SelectedIndexChanged);
            // 
            // nmMax
            // 
            this.nmMax.Location = new System.Drawing.Point(296, 59);
            this.nmMax.Name = "nmMax";
            this.nmMax.Size = new System.Drawing.Size(120, 20);
            this.nmMax.TabIndex = 5;
            this.nmMax.ValueChanged += new System.EventHandler(this.nmMax_ValueChanged);
            // 
            // Nmmin
            // 
            this.Nmmin.Location = new System.Drawing.Point(296, 128);
            this.Nmmin.Name = "Nmmin";
            this.Nmmin.Size = new System.Drawing.Size(120, 20);
            this.Nmmin.TabIndex = 6;
            this.Nmmin.ValueChanged += new System.EventHandler(this.Nmmin_ValueChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(262, 222);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(101, 33);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.Nmmin);
            this.Controls.Add(this.nmMax);
            this.Controls.Add(this.ltbPrimos);
            this.Controls.Add(this.lblPrimos);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblMax);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblPrimos;
        private System.Windows.Forms.ListBox ltbPrimos;
        private System.Windows.Forms.NumericUpDown nmMax;
        private System.Windows.Forms.NumericUpDown Nmmin;
        private System.Windows.Forms.Button btnCargar;
    }
}