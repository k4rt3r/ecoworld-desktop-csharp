namespace WindowsFormPrototipos
{
    partial class confirmarEliminarA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(confirmarEliminarA));
            this.buttonAceptarA = new System.Windows.Forms.Button();
            this.labelEliminarActivista = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAceptarA
            // 
            this.buttonAceptarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptarA.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptarA.Location = new System.Drawing.Point(64, 101);
            this.buttonAceptarA.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptarA.Name = "buttonAceptarA";
            this.buttonAceptarA.Size = new System.Drawing.Size(124, 41);
            this.buttonAceptarA.TabIndex = 0;
            this.buttonAceptarA.Text = "Aceptar";
            this.buttonAceptarA.UseVisualStyleBackColor = true;
            this.buttonAceptarA.Click += new System.EventHandler(this.buttonAceptarA_Click);
            // 
            // labelEliminarActivista
            // 
            this.labelEliminarActivista.AutoSize = true;
            this.labelEliminarActivista.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarActivista.Location = new System.Drawing.Point(59, 41);
            this.labelEliminarActivista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEliminarActivista.Name = "labelEliminarActivista";
            this.labelEliminarActivista.Size = new System.Drawing.Size(270, 25);
            this.labelEliminarActivista.TabIndex = 3;
            this.labelEliminarActivista.Text = "¿Desea eliminar el/la activista?";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmarEliminarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAceptarA);
            this.Controls.Add(this.labelEliminarActivista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "confirmarEliminarA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar activista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAceptarA;
        private System.Windows.Forms.Label labelEliminarActivista;
        private System.Windows.Forms.Button button1;
    }
}