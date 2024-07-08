namespace ejemplo3_Vladi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.txtCalif = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite la nota de de evaluacion (letra A hasta F)";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Location = new System.Drawing.Point(84, 184);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(141, 13);
            this.lblResul.TabIndex = 1;
            this.lblResul.Text = "(Evaluacion del desempeño)";
            // 
            // txtCalif
            // 
            this.txtCalif.Location = new System.Drawing.Point(515, 80);
            this.txtCalif.Name = "txtCalif";
            this.txtCalif.Size = new System.Drawing.Size(134, 20);
            this.txtCalif.TabIndex = 2;
            this.txtCalif.Text = "A hasta F";
            this.txtCalif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCalif_KeyPress_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(253, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(246, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Finalizar Aplicacion";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtCalif);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox txtCalif;
        private System.Windows.Forms.Button btnSalir;
    }
}

