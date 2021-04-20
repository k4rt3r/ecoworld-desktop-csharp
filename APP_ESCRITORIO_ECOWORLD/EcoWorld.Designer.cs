namespace WindowsFormPrototipos
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.buttonGestionarPreguntas = new System.Windows.Forms.Button();
            this.buttonGestionarPersonages = new System.Windows.Forms.Button();
            this.pictureBoxEcoWorld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcoWorld)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGestionarPreguntas
            // 
            this.buttonGestionarPreguntas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarPreguntas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarPreguntas.Location = new System.Drawing.Point(50, 253);
            this.buttonGestionarPreguntas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestionarPreguntas.Name = "buttonGestionarPreguntas";
            this.buttonGestionarPreguntas.Size = new System.Drawing.Size(313, 114);
            this.buttonGestionarPreguntas.TabIndex = 0;
            this.buttonGestionarPreguntas.Text = "Gestionar preguntas";
            this.buttonGestionarPreguntas.UseVisualStyleBackColor = true;
            this.buttonGestionarPreguntas.Click += new System.EventHandler(this.buttonGestionarPreguntas_Click);
            // 
            // buttonGestionarPersonages
            // 
            this.buttonGestionarPersonages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGestionarPersonages.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestionarPersonages.Location = new System.Drawing.Point(446, 253);
            this.buttonGestionarPersonages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGestionarPersonages.Name = "buttonGestionarPersonages";
            this.buttonGestionarPersonages.Size = new System.Drawing.Size(302, 114);
            this.buttonGestionarPersonages.TabIndex = 1;
            this.buttonGestionarPersonages.Text = "Gestionar activistas";
            this.buttonGestionarPersonages.UseVisualStyleBackColor = true;
            this.buttonGestionarPersonages.Click += new System.EventHandler(this.buttonGestionarPersonages_Click);
            // 
            // pictureBoxEcoWorld
            // 
            this.pictureBoxEcoWorld.Image = global::WindowsFormPrototipos.Properties.Resources.titulo__1_1;
            this.pictureBoxEcoWorld.Location = new System.Drawing.Point(224, 12);
            this.pictureBoxEcoWorld.Name = "pictureBoxEcoWorld";
            this.pictureBoxEcoWorld.Size = new System.Drawing.Size(356, 200);
            this.pictureBoxEcoWorld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEcoWorld.TabIndex = 2;
            this.pictureBoxEcoWorld.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(801, 426);
            this.Controls.Add(this.pictureBoxEcoWorld);
            this.Controls.Add(this.buttonGestionarPersonages);
            this.Controls.Add(this.buttonGestionarPreguntas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EcoWorld";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcoWorld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGestionarPreguntas;
        private System.Windows.Forms.Button buttonGestionarPersonages;
        private System.Windows.Forms.PictureBox pictureBoxEcoWorld;
    }
}

