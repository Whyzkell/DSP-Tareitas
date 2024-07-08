namespace Guia_2_Ejercicio_3
{
    partial class wasasin
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblMayorNegativo = new System.Windows.Forms.Label();
            this.lblPositivos = new System.Windows.Forms.Label();
            this.lblPromedioNegativos = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(118, 77);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(128, 177);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblMayorNegativo
            // 
            this.lblMayorNegativo.AutoSize = true;
            this.lblMayorNegativo.Location = new System.Drawing.Point(334, 82);
            this.lblMayorNegativo.Name = "lblMayorNegativo";
            this.lblMayorNegativo.Size = new System.Drawing.Size(79, 13);
            this.lblMayorNegativo.TabIndex = 2;
            this.lblMayorNegativo.Text = "MayorNegativo";
            // 
            // lblPositivos
            // 
            this.lblPositivos.AutoSize = true;
            this.lblPositivos.Location = new System.Drawing.Point(334, 144);
            this.lblPositivos.Name = "lblPositivos";
            this.lblPositivos.Size = new System.Drawing.Size(49, 13);
            this.lblPositivos.TabIndex = 3;
            this.lblPositivos.Text = "Positivos";
            // 
            // lblPromedioNegativos
            // 
            this.lblPromedioNegativos.AutoSize = true;
            this.lblPromedioNegativos.Location = new System.Drawing.Point(335, 203);
            this.lblPromedioNegativos.Name = "lblPromedioNegativos";
            this.lblPromedioNegativos.Size = new System.Drawing.Size(107, 13);
            this.lblPromedioNegativos.TabIndex = 4;
            this.lblPromedioNegativos.Text = "Promedios Negativos";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(333, 273);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(58, 13);
            this.lblPorcentaje.TabIndex = 5;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // wasasin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblPromedioNegativos);
            this.Controls.Add(this.lblPositivos);
            this.Controls.Add(this.lblMayorNegativo);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtNumero);
            this.Name = "wasasin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblMayorNegativo;
        private System.Windows.Forms.Label lblPositivos;
        private System.Windows.Forms.Label lblPromedioNegativos;
        private System.Windows.Forms.Label lblPorcentaje;
    }
}

