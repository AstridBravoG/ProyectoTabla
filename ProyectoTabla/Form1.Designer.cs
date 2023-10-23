namespace ProyectoTabla
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
            this.grbTipoEstu = new System.Windows.Forms.GroupBox();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.radprofe = new System.Windows.Forms.RadioButton();
            this.radEstu = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSuel = new System.Windows.Forms.TextBox();
            this.txtCali = new System.Windows.Forms.ComboBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTipoEstu.SuspendLayout();
            this.grbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbTipoEstu
            // 
            this.grbTipoEstu.Controls.Add(this.radEstu);
            this.grbTipoEstu.Controls.Add(this.radprofe);
            this.grbTipoEstu.Location = new System.Drawing.Point(156, 64);
            this.grbTipoEstu.Name = "grbTipoEstu";
            this.grbTipoEstu.Size = new System.Drawing.Size(200, 100);
            this.grbTipoEstu.TabIndex = 0;
            this.grbTipoEstu.TabStop = false;
            this.grbTipoEstu.Text = "Tipo Estu";
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtCali);
            this.grbDatos.Controls.Add(this.txtSuel);
            this.grbDatos.Controls.Add(this.txtNom);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(156, 288);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(220, 133);
            this.grbDatos.TabIndex = 1;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            // 
            // radprofe
            // 
            this.radprofe.AutoSize = true;
            this.radprofe.Location = new System.Drawing.Point(20, 37);
            this.radprofe.Name = "radprofe";
            this.radprofe.Size = new System.Drawing.Size(50, 17);
            this.radprofe.TabIndex = 0;
            this.radprofe.TabStop = true;
            this.radprofe.Text = "Profe";
            this.radprofe.UseVisualStyleBackColor = true;
            // 
            // radEstu
            // 
            this.radEstu.AutoSize = true;
            this.radEstu.Location = new System.Drawing.Point(20, 61);
            this.radEstu.Name = "radEstu";
            this.radEstu.Size = new System.Drawing.Size(46, 17);
            this.radEstu.TabIndex = 1;
            this.radEstu.TabStop = true;
            this.radEstu.Text = "Estu";
            this.radEstu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "suel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "cali";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(73, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtSuel
            // 
            this.txtSuel.Location = new System.Drawing.Point(73, 61);
            this.txtSuel.Name = "txtSuel";
            this.txtSuel.Size = new System.Drawing.Size(100, 20);
            this.txtSuel.TabIndex = 4;
            // 
            // txtCali
            // 
            this.txtCali.FormattingEnabled = true;
            this.txtCali.Location = new System.Drawing.Point(73, 87);
            this.txtCali.Name = "txtCali";
            this.txtCali.Size = new System.Drawing.Size(53, 21);
            this.txtCali.TabIndex = 5;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(540, 76);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(75, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(540, 122);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Suel,
            this.Cali});
            this.dataGridView1.Location = new System.Drawing.Point(519, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "nom";
            this.Nom.Name = "Nom";
            // 
            // Suel
            // 
            this.Suel.HeaderText = "sueldo";
            this.Suel.Name = "Suel";
            // 
            // Cali
            // 
            this.Cali.HeaderText = "Calificacion";
            this.Cali.Name = "Cali";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.grbTipoEstu);
            this.Name = "Form1";
            this.Text = "Estudiantes";
            this.grbTipoEstu.ResumeLayout(false);
            this.grbTipoEstu.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoEstu;
        private System.Windows.Forms.RadioButton radEstu;
        private System.Windows.Forms.RadioButton radprofe;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.TextBox txtSuel;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtCali;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cali;
    }
}

