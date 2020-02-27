namespace Autopista
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
            this.CmbVehiculo = new System.Windows.Forms.ComboBox();
            this.Vehiculo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbVehiculo
            // 
            this.CmbVehiculo.FormattingEnabled = true;
            this.CmbVehiculo.Items.AddRange(new object[] {
            "Motocicleta",
            "Automovil",
            "Autobus",
            "Trailer"});
            this.CmbVehiculo.Location = new System.Drawing.Point(133, 30);
            this.CmbVehiculo.Name = "CmbVehiculo";
            this.CmbVehiculo.Size = new System.Drawing.Size(124, 21);
            this.CmbVehiculo.TabIndex = 0;
            this.CmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Vehiculo
            // 
            this.Vehiculo.AutoSize = true;
            this.Vehiculo.Location = new System.Drawing.Point(59, 33);
            this.Vehiculo.Name = "Vehiculo";
            this.Vehiculo.Size = new System.Drawing.Size(51, 13);
            this.Vehiculo.TabIndex = 1;
            this.Vehiculo.Text = "Vehiculo ";
            this.Vehiculo.Click += new System.EventHandler(this.Vehiculo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usted debe pagar: $";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(118, 121);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(0, 13);
            this.lblPago.TabIndex = 3;
            this.lblPago.Click += new System.EventHandler(this.lblPago_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cobrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(172, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vehiculo);
            this.Controls.Add(this.CmbVehiculo);
            this.Name = "Form1";
            this.Text = "Caseta de cobro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbVehiculo;
        private System.Windows.Forms.Label Vehiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
    }
}

