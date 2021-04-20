namespace WindowsFormPrototipos
{
    partial class gestionarActivistas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionarActivistas));
            this.buttonEliminarActivista = new System.Windows.Forms.Button();
            this.buttonModificarActivista = new System.Windows.Forms.Button();
            this.buttonCrearActivista = new System.Windows.Forms.Button();
            this.labelListaDeActivistas = new System.Windows.Forms.Label();
            this.dataGridViewActivistas = new System.Windows.Forms.DataGridView();
            this.Enunciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntuacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivistas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEliminarActivista
            // 
            this.buttonEliminarActivista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarActivista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarActivista.Location = new System.Drawing.Point(617, 254);
            this.buttonEliminarActivista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarActivista.Name = "buttonEliminarActivista";
            this.buttonEliminarActivista.Size = new System.Drawing.Size(133, 71);
            this.buttonEliminarActivista.TabIndex = 2;
            this.buttonEliminarActivista.Text = "Eliminar Activista";
            this.buttonEliminarActivista.UseVisualStyleBackColor = true;
            this.buttonEliminarActivista.Click += new System.EventHandler(this.buttonEliminarActivista_Click);
            // 
            // buttonModificarActivista
            // 
            this.buttonModificarActivista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarActivista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarActivista.Location = new System.Drawing.Point(617, 160);
            this.buttonModificarActivista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificarActivista.Name = "buttonModificarActivista";
            this.buttonModificarActivista.Size = new System.Drawing.Size(133, 71);
            this.buttonModificarActivista.TabIndex = 1;
            this.buttonModificarActivista.Text = "Modificar Activista";
            this.buttonModificarActivista.UseVisualStyleBackColor = true;
            this.buttonModificarActivista.Click += new System.EventHandler(this.buttonModificarActivista_Click);
            // 
            // buttonCrearActivista
            // 
            this.buttonCrearActivista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearActivista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearActivista.Location = new System.Drawing.Point(617, 62);
            this.buttonCrearActivista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrearActivista.Name = "buttonCrearActivista";
            this.buttonCrearActivista.Size = new System.Drawing.Size(133, 71);
            this.buttonCrearActivista.TabIndex = 0;
            this.buttonCrearActivista.Text = "Crear Activista";
            this.buttonCrearActivista.UseVisualStyleBackColor = true;
            this.buttonCrearActivista.Click += new System.EventHandler(this.buttonCrearActivista_Click);
            // 
            // labelListaDeActivistas
            // 
            this.labelListaDeActivistas.AutoSize = true;
            this.labelListaDeActivistas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaDeActivistas.Location = new System.Drawing.Point(19, 22);
            this.labelListaDeActivistas.Name = "labelListaDeActivistas";
            this.labelListaDeActivistas.Size = new System.Drawing.Size(165, 28);
            this.labelListaDeActivistas.TabIndex = 5;
            this.labelListaDeActivistas.Text = "Lista de Activistas";
            // 
            // dataGridViewActivistas
            // 
            this.dataGridViewActivistas.AllowUserToAddRows = false;
            this.dataGridViewActivistas.AllowUserToDeleteRows = false;
            this.dataGridViewActivistas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActivistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewActivistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActivistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enunciado,
            this.Puntuacion});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewActivistas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewActivistas.Location = new System.Drawing.Point(23, 62);
            this.dataGridViewActivistas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewActivistas.Name = "dataGridViewActivistas";
            this.dataGridViewActivistas.ReadOnly = true;
            this.dataGridViewActivistas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewActivistas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewActivistas.RowHeadersWidth = 51;
            this.dataGridViewActivistas.RowTemplate.Height = 24;
            this.dataGridViewActivistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActivistas.Size = new System.Drawing.Size(541, 357);
            this.dataGridViewActivistas.TabIndex = 8;
            // 
            // Enunciado
            // 
            this.Enunciado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Enunciado.DataPropertyName = "nombre";
            this.Enunciado.HeaderText = "Nombre";
            this.Enunciado.MinimumWidth = 10;
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.ReadOnly = true;
            // 
            // Puntuacion
            // 
            this.Puntuacion.DataPropertyName = "puntuacion";
            dataGridViewCellStyle2.NullValue = null;
            this.Puntuacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Puntuacion.HeaderText = "Puntuación";
            this.Puntuacion.MinimumWidth = 6;
            this.Puntuacion.Name = "Puntuacion";
            this.Puntuacion.ReadOnly = true;
            this.Puntuacion.Width = 125;
            // 
            // buttonSalir
            // 
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(617, 348);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(133, 71);
            this.buttonSalir.TabIndex = 9;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // gestionarActivistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 453);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dataGridViewActivistas);
            this.Controls.Add(this.buttonEliminarActivista);
            this.Controls.Add(this.buttonModificarActivista);
            this.Controls.Add(this.buttonCrearActivista);
            this.Controls.Add(this.labelListaDeActivistas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "gestionarActivistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar activistas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestionarActivistas_FormClosed);
            this.Load += new System.EventHandler(this.gestionarActivistas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActivistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEliminarActivista;
        private System.Windows.Forms.Button buttonModificarActivista;
        private System.Windows.Forms.Button buttonCrearActivista;
        private System.Windows.Forms.Label labelListaDeActivistas;
        private System.Windows.Forms.DataGridView dataGridViewActivistas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enunciado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntuacion;
        private System.Windows.Forms.Button buttonSalir;
    }
}