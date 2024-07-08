namespace Guia_2_Ejercicio_2
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
            this.numNumber1 = new System.Windows.Forms.NumericUpDown();
            this.numNumber2 = new System.Windows.Forms.NumericUpDown();
            this.numNumber3 = new System.Windows.Forms.NumericUpDown();
            this.numNumber4 = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber4)).BeginInit();
            this.SuspendLayout();
            // 
            // numNumber1
            // 
            this.numNumber1.Location = new System.Drawing.Point(88, 66);
            this.numNumber1.Name = "numNumber1";
            this.numNumber1.Size = new System.Drawing.Size(120, 20);
            this.numNumber1.TabIndex = 0;
            // 
            // numNumber2
            // 
            this.numNumber2.Location = new System.Drawing.Point(88, 148);
            this.numNumber2.Name = "numNumber2";
            this.numNumber2.Size = new System.Drawing.Size(120, 20);
            this.numNumber2.TabIndex = 1;
            // 
            // numNumber3
            // 
            this.numNumber3.Location = new System.Drawing.Point(88, 246);
            this.numNumber3.Name = "numNumber3";
            this.numNumber3.Size = new System.Drawing.Size(120, 20);
            this.numNumber3.TabIndex = 2;
            // 
            // numNumber4
            // 
            this.numNumber4.Location = new System.Drawing.Point(88, 345);
            this.numNumber4.Name = "numNumber4";
            this.numNumber4.Size = new System.Drawing.Size(120, 20);
            this.numNumber4.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(401, 199);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numNumber4);
            this.Controls.Add(this.numNumber3);
            this.Controls.Add(this.numNumber2);
            this.Controls.Add(this.numNumber1);
            this.Name = "Form1";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.numNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNumber1;
        private System.Windows.Forms.NumericUpDown numNumber2;
        private System.Windows.Forms.NumericUpDown numNumber3;
        private System.Windows.Forms.NumericUpDown numNumber4;
        private System.Windows.Forms.Button btnCalculate;
    }
}

