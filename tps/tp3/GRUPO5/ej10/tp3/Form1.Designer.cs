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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvConversiones = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnConvertir = new Button();
            cboInicial = new ComboBox();
            cboFinal = new ComboBox();
            txtTemperatura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConversiones).BeginInit();
            SuspendLayout();
            // 
            // dgvConversiones
            // 
            dgvConversiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConversiones.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvConversiones.Location = new Point(130, 355);
            dgvConversiones.Name = "dgvConversiones";
            dgvConversiones.RowHeadersWidth = 51;
            dgvConversiones.Size = new Size(554, 187);
            dgvConversiones.TabIndex = 0;
            dgvConversiones.CellContentClick += dgvConversiones_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Valor Inicial";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Escala Inicial";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Escala Final";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Resultado";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConvertir.ForeColor = Color.Coral;
            btnConvertir.Location = new Point(324, 287);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(212, 51);
            btnConvertir.TabIndex = 1;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // cboInicial
            // 
            cboInicial.FormattingEnabled = true;
            cboInicial.Items.AddRange(new object[] { "Celsius ", "Fahrenheit", "Kelvin", "Rankine" });
            cboInicial.Location = new Point(354, 120);
            cboInicial.Name = "cboInicial";
            cboInicial.Size = new Size(151, 29);
            cboInicial.TabIndex = 4;
            cboInicial.SelectedIndexChanged += cboInicial_SelectedIndexChanged;
            // 
            // cboFinal
            // 
            cboFinal.FormattingEnabled = true;
            cboFinal.Items.AddRange(new object[] { "Celsius ", "Fahrenheit", "Kelvin", "Rankine" });
            cboFinal.Location = new Point(354, 172);
            cboFinal.Name = "cboFinal";
            cboFinal.Size = new Size(151, 29);
            cboFinal.TabIndex = 5;
            cboFinal.SelectedIndexChanged += cboFinal_SelectedIndexChanged;
            // 
            // txtTemperatura
            // 
            txtTemperatura.Location = new Point(363, 223);
            txtTemperatura.Name = "txtTemperatura";
            txtTemperatura.Size = new Size(125, 29);
            txtTemperatura.TabIndex = 6;
            txtTemperatura.TextChanged += txtTemperatura_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 363);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(190, 22);
            label2.Name = "label2";
            label2.Size = new Size(613, 27);
            label2.TabIndex = 8;
            label2.Text = "¡Bienvenido al convertidor de temperaturas!";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 120);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 9;
            label3.Text = "Temp. Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 180);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 10;
            label4.Text = "Temp. Final";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 226);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 11;
            label5.Text = "Ingrese grados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 591);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTemperatura);
            Controls.Add(cboFinal);
            Controls.Add(cboInicial);
            Controls.Add(btnConvertir);
            Controls.Add(dgvConversiones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConversiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvConversiones;
        private Button btnConvertir;
        private ComboBox cboInicial;
        private ComboBox cboFinal;
        private TextBox txtTemperatura;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
