namespace tp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private Label GetLblDado11()
        {
            return lblDado1;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Label lblDado11)
        {
            btnTirar = new Button();
            lblDado1 = new Label();
            dgvDado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvDado).BeginInit();
            SuspendLayout();
            // 
            // btnTirar
            // 
            btnTirar.Location = new Point(494, 95);
            btnTirar.Name = "btnTirar";
            btnTirar.Size = new Size(114, 47);
            btnTirar.TabIndex = 0;
            btnTirar.Text = "TIRAR";
            btnTirar.UseVisualStyleBackColor = true;
            btnTirar.Click += btnTirar_Click;
            // 
            // lblDado1
            // 
            lblDado1.AutoSize = true;
            lblDado1.Location = new Point(507, 54);
            lblDado1.Name = "lblDado1";
            lblDado1.Size = new Size(88, 21);
            lblDado1.TabIndex = 2;
            lblDado1.Text = "Tirar dados";
            // 
            // dgvDado
            // 
            dgvDado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDado.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvDado.Location = new Point(424, 252);
            dgvDado.Name = "dgvDado";
            dgvDado.RowHeadersWidth = 51;
            dgvDado.Size = new Size(420, 240);
            dgvDado.TabIndex = 4;
            dgvDado.CellContentClick += dgvDado_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Número";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Porcentaje";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 472);
            Controls.Add(dgvDado);
            Controls.Add(lblDado1);
            Controls.Add(btnTirar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnTirar;
        private Label lblDado1;
        private DataGridView dgvDado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}
