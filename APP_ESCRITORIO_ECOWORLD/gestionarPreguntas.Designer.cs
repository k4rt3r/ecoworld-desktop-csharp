namespace WindowsFormPrototipos
{
    partial class gestionarPreguntas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionarPreguntas));
            this.labelListaDePreguntas = new System.Windows.Forms.Label();
            this.dataGridViewListaPreguntas = new System.Windows.Forms.DataGridView();
            this.Enunciado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCrearPregunta = new System.Windows.Forms.Button();
            this.buttonModificarPregunta = new System.Windows.Forms.Button();
            this.buttonEliminarPregunta = new System.Windows.Forms.Button();
            this.buttonAbrirJSON = new System.Windows.Forms.Button();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.comboBoxDificultad = new System.Windows.Forms.ComboBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.labelDificultad = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPreguntas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListaDePreguntas
            // 
            this.labelListaDePreguntas.AutoSize = true;
            this.labelListaDePreguntas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaDePreguntas.Location = new System.Drawing.Point(17, 50);
            this.labelListaDePreguntas.Name = "labelListaDePreguntas";
            this.labelListaDePreguntas.Size = new System.Drawing.Size(171, 28);
            this.labelListaDePreguntas.TabIndex = 6;
            this.labelListaDePreguntas.Text = "Lista de preguntas";
            // 
            // dataGridViewListaPreguntas
            // 
            this.dataGridViewListaPreguntas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaPreguntas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewListaPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enunciado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewListaPreguntas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewListaPreguntas.Location = new System.Drawing.Point(21, 80);
            this.dataGridViewListaPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListaPreguntas.Name = "dataGridViewListaPreguntas";
            this.dataGridViewListaPreguntas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewListaPreguntas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewListaPreguntas.RowHeadersWidth = 51;
            this.dataGridViewListaPreguntas.RowTemplate.Height = 24;
            this.dataGridViewListaPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListaPreguntas.Size = new System.Drawing.Size(541, 326);
            this.dataGridViewListaPreguntas.TabIndex = 7;
            // 
            // Enunciado
            // 
            this.Enunciado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Enunciado.DataPropertyName = "Enunciado";
            this.Enunciado.HeaderText = "Enunciado";
            this.Enunciado.MinimumWidth = 10;
            this.Enunciado.Name = "Enunciado";
            // 
            // buttonCrearPregunta
            // 
            this.buttonCrearPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearPregunta.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearPregunta.Location = new System.Drawing.Point(613, 80);
            this.buttonCrearPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCrearPregunta.Name = "buttonCrearPregunta";
            this.buttonCrearPregunta.Size = new System.Drawing.Size(133, 71);
            this.buttonCrearPregunta.TabIndex = 8;
            this.buttonCrearPregunta.Text = "Crear Pregunta";
            this.buttonCrearPregunta.UseVisualStyleBackColor = true;
            this.buttonCrearPregunta.Click += new System.EventHandler(this.buttonCrearPregunta_Click);
            // 
            // buttonModificarPregunta
            // 
            this.buttonModificarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarPregunta.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarPregunta.Location = new System.Drawing.Point(613, 164);
            this.buttonModificarPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificarPregunta.Name = "buttonModificarPregunta";
            this.buttonModificarPregunta.Size = new System.Drawing.Size(133, 71);
            this.buttonModificarPregunta.TabIndex = 9;
            this.buttonModificarPregunta.Text = "Modificar Pregunta";
            this.buttonModificarPregunta.UseVisualStyleBackColor = true;
            this.buttonModificarPregunta.Click += new System.EventHandler(this.buttonModificarPregunta_Click);
            // 
            // buttonEliminarPregunta
            // 
            this.buttonEliminarPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarPregunta.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarPregunta.Location = new System.Drawing.Point(613, 248);
            this.buttonEliminarPregunta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarPregunta.Name = "buttonEliminarPregunta";
            this.buttonEliminarPregunta.Size = new System.Drawing.Size(133, 71);
            this.buttonEliminarPregunta.TabIndex = 0;
            this.buttonEliminarPregunta.Text = "Eliminar Pregunta";
            this.buttonEliminarPregunta.UseVisualStyleBackColor = true;
            this.buttonEliminarPregunta.Click += new System.EventHandler(this.buttonEliminarPregunta_Click);
            // 
            // buttonAbrirJSON
            // 
            this.buttonAbrirJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirJSON.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrirJSON.Location = new System.Drawing.Point(635, 12);
            this.buttonAbrirJSON.Name = "buttonAbrirJSON";
            this.buttonAbrirJSON.Size = new System.Drawing.Size(111, 34);
            this.buttonAbrirJSON.TabIndex = 5;
            this.buttonAbrirJSON.Text = "Abrir";
            this.buttonAbrirJSON.UseVisualStyleBackColor = true;
            this.buttonAbrirJSON.Click += new System.EventHandler(this.buttonAbrirJSON_Click);
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Español",
            "English"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(161, 18);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(145, 24);
            this.comboBoxIdioma.TabIndex = 2;
            // 
            // comboBoxDificultad
            // 
            this.comboBoxDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDificultad.FormattingEnabled = true;
            this.comboBoxDificultad.Items.AddRange(new object[] {
            "Fácil",
            "Normal",
            "Difícil"});
            this.comboBoxDificultad.Location = new System.Drawing.Point(471, 19);
            this.comboBoxDificultad.Name = "comboBoxDificultad";
            this.comboBoxDificultad.Size = new System.Drawing.Size(143, 24);
            this.comboBoxDificultad.TabIndex = 4;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdioma.Location = new System.Drawing.Point(18, 20);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(137, 19);
            this.labelIdioma.TabIndex = 1;
            this.labelIdioma.Text = "Seleccionar idioma";
            // 
            // labelDificultad
            // 
            this.labelDificultad.AutoSize = true;
            this.labelDificultad.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDificultad.Location = new System.Drawing.Point(312, 20);
            this.labelDificultad.Name = "labelDificultad";
            this.labelDificultad.Size = new System.Drawing.Size(153, 19);
            this.labelDificultad.TabIndex = 3;
            this.labelDificultad.Text = "Seleccionar dificultad";
            // 
            // buttonSalir
            // 
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(613, 335);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(133, 71);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // gestionarPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelDificultad);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.comboBoxDificultad);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.buttonAbrirJSON);
            this.Controls.Add(this.buttonEliminarPregunta);
            this.Controls.Add(this.buttonModificarPregunta);
            this.Controls.Add(this.buttonCrearPregunta);
            this.Controls.Add(this.dataGridViewListaPreguntas);
            this.Controls.Add(this.labelListaDePreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "gestionarPreguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestionar preguntas";
            this.Activated += new System.EventHandler(this.gestionarPreguntas_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.gestionarPreguntas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaPreguntas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListaDePreguntas;
        private System.Windows.Forms.DataGridView dataGridViewListaPreguntas;
        private System.Windows.Forms.Button buttonCrearPregunta;
        private System.Windows.Forms.Button buttonModificarPregunta;
        private System.Windows.Forms.Button buttonEliminarPregunta;
        private System.Windows.Forms.Button buttonAbrirJSON;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enunciado;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.ComboBox comboBoxDificultad;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Label labelDificultad;
        private System.Windows.Forms.Button buttonSalir;
    }
}