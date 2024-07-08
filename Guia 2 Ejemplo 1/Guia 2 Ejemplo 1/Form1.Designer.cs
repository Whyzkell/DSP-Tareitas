namespace Guia_2_Ejemplo_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DIV = new System.Windows.Forms.Label();
            this.cbosuma = new System.Windows.Forms.ComboBox();
            this.cboresta = new System.Windows.Forms.ComboBox();
            this.cbomult = new System.Windows.Forms.ComboBox();
            this.cbodiv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tabla Aritmetica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(228, 90);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(208, 20);
            this.txtnumero.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(581, 87);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(581, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Suma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Resta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Multiplicacion";
            // 
            // DIV
            // 
            this.DIV.AutoSize = true;
            this.DIV.Location = new System.Drawing.Point(602, 319);
            this.DIV.Name = "DIV";
            this.DIV.Size = new System.Drawing.Size(44, 13);
            this.DIV.TabIndex = 9;
            this.DIV.Text = "Division";
            // 
            // cbosuma
            // 
            this.cbosuma.FormattingEnabled = true;
            this.cbosuma.Location = new System.Drawing.Point(55, 358);
            this.cbosuma.Name = "cbosuma";
            this.cbosuma.Size = new System.Drawing.Size(121, 21);
            this.cbosuma.TabIndex = 10;
            // 
            // cboresta
            // 
            this.cboresta.FormattingEnabled = true;
            this.cboresta.Location = new System.Drawing.Point(228, 358);
            this.cboresta.Name = "cboresta";
            this.cboresta.Size = new System.Drawing.Size(121, 21);
            this.cboresta.TabIndex = 11;
            // 
            // cbomult
            // 
            this.cbomult.FormattingEnabled = true;
            this.cbomult.Location = new System.Drawing.Point(404, 358);
            this.cbomult.Name = "cbomult";
            this.cbomult.Size = new System.Drawing.Size(121, 21);
            this.cbomult.TabIndex = 12;
            // 
            // cbodiv
            // 
            this.cbodiv.FormattingEnabled = true;
            this.cbodiv.Location = new System.Drawing.Point(605, 358);
            this.cbodiv.Name = "cbodiv";
            this.cbodiv.Size = new System.Drawing.Size(121, 21);
            this.cbodiv.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbodiv);
            this.Controls.Add(this.cbomult);
            this.Controls.Add(this.cboresta);
            this.Controls.Add(this.cbosuma);
            this.Controls.Add(this.DIV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tabla aritmetica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DIV;
        private System.Windows.Forms.ComboBox cbosuma;
        private System.Windows.Forms.ComboBox cboresta;
        private System.Windows.Forms.ComboBox cbomult;
        private System.Windows.Forms.ComboBox cbodiv;
    }
}

