namespace guia_3_Ejemplo1
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
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lstDesorden = new System.Windows.Forms.ListBox();
            this.lstOrdenada = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Location = new System.Drawing.Point(81, 65);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(83, 13);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "Ingrese numero:";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(272, 58);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lstDesorden
            // 
            this.lstDesorden.FormattingEnabled = true;
            this.lstDesorden.Location = new System.Drawing.Point(84, 204);
            this.lstDesorden.Name = "lstDesorden";
            this.lstDesorden.Size = new System.Drawing.Size(120, 95);
            this.lstDesorden.TabIndex = 2;
            // 
            // lstOrdenada
            // 
            this.lstOrdenada.FormattingEnabled = true;
            this.lstOrdenada.Location = new System.Drawing.Point(314, 205);
            this.lstOrdenada.Name = "lstOrdenada";
            this.lstOrdenada.Size = new System.Drawing.Size(120, 95);
            this.lstOrdenada.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(629, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(638, 118);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstOrdenada);
            this.Controls.Add(this.lstDesorden);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblnumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox lstDesorden;
        private System.Windows.Forms.ListBox lstOrdenada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

