namespace tp3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPlazofijo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTasa = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlazofijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlazofijo
            // 
            this.dgvPlazofijo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlazofijo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvPlazofijo.Location = new System.Drawing.Point(118, 275);
            this.dgvPlazofijo.Name = "dgvPlazofijo";
            this.dgvPlazofijo.Size = new System.Drawing.Size(544, 196);
            this.dgvPlazofijo.TabIndex = 0;
            this.dgvPlazofijo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlazofijo_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Monto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tasa";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Días";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Interés";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(311, 72);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(311, 116);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(100, 20);
            this.txtTasa.TabIndex = 2;
            this.txtTasa.TextChanged += new System.EventHandler(this.txtTasa_TextChanged);
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(311, 166);
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(100, 20);
            this.nudDias.TabIndex = 3;
            this.nudDias.ValueChanged += new System.EventHandler(this.nudDias_ValueChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(297, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 45);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(257, 72);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 5;
            this.lblMonto.Text = "Monto:";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // lblTasa
            // 
            this.lblTasa.AutoSize = true;
            this.lblTasa.Location = new System.Drawing.Point(234, 116);
            this.lblTasa.Name = "lblTasa";
            this.lblTasa.Size = new System.Drawing.Size(63, 13);
            this.lblTasa.TabIndex = 6;
            this.lblTasa.Text = "Tasa anual:";
            this.lblTasa.Click += new System.EventHandler(this.lblTasa_Click);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(266, 168);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(31, 13);
            this.lblDias.TabIndex = 7;
            this.lblDias.Text = "Dias:";
            this.lblDias.Click += new System.EventHandler(this.lblDias_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(205, 28);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(285, 20);
            this.lblBienvenido.TabIndex = 8;
            this.lblBienvenido.Text = "Calculadora de intereses plazo fijo";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(831, 483);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblTasa);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nudDias);
            this.Controls.Add(this.txtTasa);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.dgvPlazofijo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlazofijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interés;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView dgvPlazofijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.NumericUpDown nudDias;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTasa;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblBienvenido;
    }
}

