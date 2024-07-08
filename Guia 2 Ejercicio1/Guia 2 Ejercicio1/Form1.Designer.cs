namespace Guia_2_Ejercicio1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numLimit = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 290);
            this.listBox1.TabIndex = 0;
            // 
            // numLimit
            // 
            this.numLimit.Location = new System.Drawing.Point(62, 28);
            this.numLimit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLimit.Name = "numLimit";
            this.numLimit.Size = new System.Drawing.Size(235, 20);
            this.numLimit.TabIndex = 1;
            this.numLimit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(62, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(235, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.numLimit);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.numLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.NumericUpDown numLimit;
        private System.Windows.Forms.Button btnGenerar;
    }
}

