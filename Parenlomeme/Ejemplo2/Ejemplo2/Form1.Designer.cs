namespace Ejemplo2
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
            this.gbInformacon = new System.Windows.Forms.GroupBox();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.gbMantenimiento = new System.Windows.Forms.GroupBox();
            this.Lbtipo_info = new System.Windows.Forms.Label();
            this.Lbdig_info = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btPromedio = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgdatos = new System.Windows.Forms.DataGridView();
            this.cbtipoinfo = new System.Windows.Forms.ComboBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.gbInformacon.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            this.gbMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInformacon
            // 
            this.gbInformacon.Controls.Add(this.cbtipoinfo);
            this.gbInformacon.Controls.Add(this.txtEdad);
            this.gbInformacon.Controls.Add(this.txtInfo);
            this.gbInformacon.Controls.Add(this.lbedad);
            this.gbInformacon.Controls.Add(this.Lbdig_info);
            this.gbInformacon.Controls.Add(this.Lbtipo_info);
            this.gbInformacon.Location = new System.Drawing.Point(36, 39);
            this.gbInformacon.Name = "gbInformacon";
            this.gbInformacon.Size = new System.Drawing.Size(303, 151);
            this.gbInformacon.TabIndex = 0;
            this.gbInformacon.TabStop = false;
            this.gbInformacon.Text = "Informacion";
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.button5);
            this.gbMatriz.Controls.Add(this.btPromedio);
            this.gbMatriz.Controls.Add(this.btLimpiar);
            this.gbMatriz.Controls.Add(this.btMostrar);
            this.gbMatriz.Controls.Add(this.btAgregar);
            this.gbMatriz.Location = new System.Drawing.Point(372, 39);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(395, 151);
            this.gbMatriz.TabIndex = 1;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // gbMantenimiento
            // 
            this.gbMantenimiento.Controls.Add(this.dgdatos);
            this.gbMantenimiento.Location = new System.Drawing.Point(36, 228);
            this.gbMantenimiento.Name = "gbMantenimiento";
            this.gbMantenimiento.Size = new System.Drawing.Size(731, 193);
            this.gbMantenimiento.TabIndex = 2;
            this.gbMantenimiento.TabStop = false;
            this.gbMantenimiento.Text = "Mantenimientos";
            // 
            // Lbtipo_info
            // 
            this.Lbtipo_info.AutoSize = true;
            this.Lbtipo_info.Location = new System.Drawing.Point(42, 35);
            this.Lbtipo_info.Name = "Lbtipo_info";
            this.Lbtipo_info.Size = new System.Drawing.Size(100, 13);
            this.Lbtipo_info.TabIndex = 0;
            this.Lbtipo_info.Text = "Tipo de informacion";
            // 
            // Lbdig_info
            // 
            this.Lbdig_info.AutoSize = true;
            this.Lbdig_info.Location = new System.Drawing.Point(42, 73);
            this.Lbdig_info.Name = "Lbdig_info";
            this.Lbdig_info.Size = new System.Drawing.Size(102, 13);
            this.Lbdig_info.TabIndex = 1;
            this.Lbdig_info.Text = "Digite la informacion";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(47, 118);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(32, 13);
            this.lbedad.TabIndex = 2;
            this.lbedad.Text = "Edad";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(152, 111);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 4;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(48, 41);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 0;
            this.btAgregar.Text = "&Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(164, 39);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(100, 23);
            this.btMostrar.TabIndex = 1;
            this.btMostrar.Text = "Mostrar Matriz";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(48, 81);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(97, 23);
            this.btLimpiar.TabIndex = 2;
            this.btLimpiar.Text = "Limpiar Matriz";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btPromedio
            // 
            this.btPromedio.Location = new System.Drawing.Point(164, 81);
            this.btPromedio.Name = "btPromedio";
            this.btPromedio.Size = new System.Drawing.Size(75, 23);
            this.btPromedio.TabIndex = 3;
            this.btPromedio.Text = "Promedio";
            this.btPromedio.UseVisualStyleBackColor = true;
            this.btPromedio.Click += new System.EventHandler(this.btPromedio_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dgdatos
            // 
            this.dgdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdatos.Location = new System.Drawing.Point(29, 19);
            this.dgdatos.Name = "dgdatos";
            this.dgdatos.Size = new System.Drawing.Size(648, 150);
            this.dgdatos.TabIndex = 0;
            // 
            // cbtipoinfo
            // 
            this.cbtipoinfo.FormattingEnabled = true;
            this.cbtipoinfo.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbtipoinfo.Location = new System.Drawing.Point(152, 27);
            this.cbtipoinfo.Name = "cbtipoinfo";
            this.cbtipoinfo.Size = new System.Drawing.Size(121, 21);
            this.cbtipoinfo.TabIndex = 3;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(152, 66);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(100, 20);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInfo_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbMantenimiento);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbInformacon);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.gbInformacon.ResumeLayout(false);
            this.gbInformacon.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInformacon;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label Lbdig_info;
        private System.Windows.Forms.Label Lbtipo_info;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btPromedio;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.GroupBox gbMantenimiento;
        private System.Windows.Forms.DataGridView dgdatos;
        private System.Windows.Forms.ComboBox cbtipoinfo;
        private System.Windows.Forms.TextBox txtInfo;
    }
}

