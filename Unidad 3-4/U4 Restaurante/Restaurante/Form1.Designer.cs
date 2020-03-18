namespace Restaurante
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
            this.txtNombreMesero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpMesero = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDiasTrabMesero = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldoMesero = new System.Windows.Forms.TextBox();
            this.Mesero = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPropinasMesero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNombreRepartidor = new System.Windows.Forms.TextBox();
            this.dtpFechaNacRepartidor = new System.Windows.Forms.DateTimePicker();
            this.cmbDiasTrabRepartidor = new System.Windows.Forms.ComboBox();
            this.txtSueldoRepartidor = new System.Windows.Forms.TextBox();
            this.txtPropinasRepartidor = new System.Windows.Forms.TextBox();
            this.txtAbonos = new System.Windows.Forms.TextBox();
            this.cmbZonaReparto = new System.Windows.Forms.ComboBox();
            this.Repartidor = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNombreCajero = new System.Windows.Forms.TextBox();
            this.dtpFechaNacCajero = new System.Windows.Forms.DateTimePicker();
            this.cmbDiasTrabCajero = new System.Windows.Forms.ComboBox();
            this.txtSueldoCajero = new System.Windows.Forms.TextBox();
            this.cmbNumeroCaja = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMesero = new System.Windows.Forms.Button();
            this.btnRepartidor = new System.Windows.Forms.Button();
            this.btnCajero = new System.Windows.Forms.Button();
            this.Mesero.SuspendLayout();
            this.Repartidor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombreMesero
            // 
            this.txtNombreMesero.Location = new System.Drawing.Point(139, 13);
            this.txtNombreMesero.Name = "txtNombreMesero";
            this.txtNombreMesero.Size = new System.Drawing.Size(81, 20);
            this.txtNombreMesero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Nacimiento";
            // 
            // dtpMesero
            // 
            this.dtpMesero.Location = new System.Drawing.Point(139, 48);
            this.dtpMesero.Name = "dtpMesero";
            this.dtpMesero.Size = new System.Drawing.Size(81, 20);
            this.dtpMesero.TabIndex = 3;
            this.dtpMesero.ValueChanged += new System.EventHandler(this.dtpMesero_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dias Trabajados";
            // 
            // cmbDiasTrabMesero
            // 
            this.cmbDiasTrabMesero.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabMesero.FormattingEnabled = true;
            this.cmbDiasTrabMesero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabMesero.Location = new System.Drawing.Point(139, 81);
            this.cmbDiasTrabMesero.Name = "cmbDiasTrabMesero";
            this.cmbDiasTrabMesero.Size = new System.Drawing.Size(81, 21);
            this.cmbDiasTrabMesero.TabIndex = 5;
            this.cmbDiasTrabMesero.SelectedIndexChanged += new System.EventHandler(this.cmbDiasTrabMesero_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sueldo";
            // 
            // txtSueldoMesero
            // 
            this.txtSueldoMesero.Location = new System.Drawing.Point(139, 115);
            this.txtSueldoMesero.Name = "txtSueldoMesero";
            this.txtSueldoMesero.Size = new System.Drawing.Size(81, 20);
            this.txtSueldoMesero.TabIndex = 7;
            // 
            // Mesero
            // 
            this.Mesero.Controls.Add(this.btnMesero);
            this.Mesero.Controls.Add(this.txtPropinasMesero);
            this.Mesero.Controls.Add(this.label5);
            this.Mesero.Controls.Add(this.txtSueldoMesero);
            this.Mesero.Controls.Add(this.label2);
            this.Mesero.Controls.Add(this.label4);
            this.Mesero.Controls.Add(this.cmbDiasTrabMesero);
            this.Mesero.Controls.Add(this.label3);
            this.Mesero.Controls.Add(this.dtpMesero);
            this.Mesero.Controls.Add(this.txtNombreMesero);
            this.Mesero.Controls.Add(this.label1);
            this.Mesero.Location = new System.Drawing.Point(12, 12);
            this.Mesero.Name = "Mesero";
            this.Mesero.Size = new System.Drawing.Size(316, 184);
            this.Mesero.TabIndex = 8;
            this.Mesero.TabStop = false;
            this.Mesero.Text = "Mesero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Propinas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombre";
            // 
            // txtPropinasMesero
            // 
            this.txtPropinasMesero.Location = new System.Drawing.Point(139, 144);
            this.txtPropinasMesero.Name = "txtPropinasMesero";
            this.txtPropinasMesero.Size = new System.Drawing.Size(81, 20);
            this.txtPropinasMesero.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de Nacimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Dias trabajados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Sueldo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Propinias";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Abonos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Zona de reparto";
            // 
            // txtNombreRepartidor
            // 
            this.txtNombreRepartidor.Location = new System.Drawing.Point(135, 6);
            this.txtNombreRepartidor.Name = "txtNombreRepartidor";
            this.txtNombreRepartidor.Size = new System.Drawing.Size(76, 20);
            this.txtNombreRepartidor.TabIndex = 16;
            // 
            // dtpFechaNacRepartidor
            // 
            this.dtpFechaNacRepartidor.Location = new System.Drawing.Point(138, 38);
            this.dtpFechaNacRepartidor.Name = "dtpFechaNacRepartidor";
            this.dtpFechaNacRepartidor.Size = new System.Drawing.Size(73, 20);
            this.dtpFechaNacRepartidor.TabIndex = 17;
            // 
            // cmbDiasTrabRepartidor
            // 
            this.cmbDiasTrabRepartidor.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabRepartidor.FormattingEnabled = true;
            this.cmbDiasTrabRepartidor.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabRepartidor.Location = new System.Drawing.Point(141, 68);
            this.cmbDiasTrabRepartidor.Name = "cmbDiasTrabRepartidor";
            this.cmbDiasTrabRepartidor.Size = new System.Drawing.Size(70, 21);
            this.cmbDiasTrabRepartidor.TabIndex = 18;
            this.cmbDiasTrabRepartidor.SelectedIndexChanged += new System.EventHandler(this.cmbDiasTrabRepartidor_SelectedIndexChanged);
            // 
            // txtSueldoRepartidor
            // 
            this.txtSueldoRepartidor.Location = new System.Drawing.Point(142, 104);
            this.txtSueldoRepartidor.Name = "txtSueldoRepartidor";
            this.txtSueldoRepartidor.Size = new System.Drawing.Size(68, 20);
            this.txtSueldoRepartidor.TabIndex = 19;
            // 
            // txtPropinasRepartidor
            // 
            this.txtPropinasRepartidor.Location = new System.Drawing.Point(145, 136);
            this.txtPropinasRepartidor.Name = "txtPropinasRepartidor";
            this.txtPropinasRepartidor.Size = new System.Drawing.Size(65, 20);
            this.txtPropinasRepartidor.TabIndex = 20;
            // 
            // txtAbonos
            // 
            this.txtAbonos.Location = new System.Drawing.Point(144, 163);
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.Size = new System.Drawing.Size(66, 20);
            this.txtAbonos.TabIndex = 21;
            // 
            // cmbZonaReparto
            // 
            this.cmbZonaReparto.FormattingEnabled = true;
            this.cmbZonaReparto.Items.AddRange(new object[] {
            "Zona 1",
            "Zona 2"});
            this.cmbZonaReparto.Location = new System.Drawing.Point(142, 189);
            this.cmbZonaReparto.Name = "cmbZonaReparto";
            this.cmbZonaReparto.Size = new System.Drawing.Size(69, 21);
            this.cmbZonaReparto.TabIndex = 22;
            // 
            // Repartidor
            // 
            this.Repartidor.Controls.Add(this.btnRepartidor);
            this.Repartidor.Controls.Add(this.cmbZonaReparto);
            this.Repartidor.Controls.Add(this.txtAbonos);
            this.Repartidor.Controls.Add(this.txtPropinasRepartidor);
            this.Repartidor.Controls.Add(this.txtSueldoRepartidor);
            this.Repartidor.Controls.Add(this.cmbDiasTrabRepartidor);
            this.Repartidor.Controls.Add(this.dtpFechaNacRepartidor);
            this.Repartidor.Controls.Add(this.txtNombreRepartidor);
            this.Repartidor.Controls.Add(this.label12);
            this.Repartidor.Controls.Add(this.label11);
            this.Repartidor.Controls.Add(this.label10);
            this.Repartidor.Controls.Add(this.label9);
            this.Repartidor.Controls.Add(this.label8);
            this.Repartidor.Controls.Add(this.label7);
            this.Repartidor.Controls.Add(this.label6);
            this.Repartidor.Location = new System.Drawing.Point(12, 202);
            this.Repartidor.Name = "Repartidor";
            this.Repartidor.Size = new System.Drawing.Size(316, 229);
            this.Repartidor.TabIndex = 23;
            this.Repartidor.TabStop = false;
            this.Repartidor.Text = "Repartidor";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(70, 27);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 24;
            this.Nombre.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Fecha de Nacimiento";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Dias trabajados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Sueldo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Numero de caja";
            // 
            // txtNombreCajero
            // 
            this.txtNombreCajero.Location = new System.Drawing.Point(142, 27);
            this.txtNombreCajero.Name = "txtNombreCajero";
            this.txtNombreCajero.Size = new System.Drawing.Size(85, 20);
            this.txtNombreCajero.TabIndex = 29;
            // 
            // dtpFechaNacCajero
            // 
            this.dtpFechaNacCajero.Location = new System.Drawing.Point(143, 56);
            this.dtpFechaNacCajero.Name = "dtpFechaNacCajero";
            this.dtpFechaNacCajero.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaNacCajero.TabIndex = 30;
            // 
            // cmbDiasTrabCajero
            // 
            this.cmbDiasTrabCajero.FormattingEnabled = true;
            this.cmbDiasTrabCajero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbDiasTrabCajero.Location = new System.Drawing.Point(143, 82);
            this.cmbDiasTrabCajero.Name = "cmbDiasTrabCajero";
            this.cmbDiasTrabCajero.Size = new System.Drawing.Size(84, 21);
            this.cmbDiasTrabCajero.TabIndex = 31;
            // 
            // txtSueldoCajero
            // 
            this.txtSueldoCajero.Location = new System.Drawing.Point(145, 116);
            this.txtSueldoCajero.Name = "txtSueldoCajero";
            this.txtSueldoCajero.Size = new System.Drawing.Size(82, 20);
            this.txtSueldoCajero.TabIndex = 32;
            // 
            // cmbNumeroCaja
            // 
            this.cmbNumeroCaja.FormattingEnabled = true;
            this.cmbNumeroCaja.Items.AddRange(new object[] {
            "Caja 1",
            "Caja 2"});
            this.cmbNumeroCaja.Location = new System.Drawing.Point(145, 147);
            this.cmbNumeroCaja.Name = "cmbNumeroCaja";
            this.cmbNumeroCaja.Size = new System.Drawing.Size(83, 21);
            this.cmbNumeroCaja.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCajero);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbNumeroCaja);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtSueldoCajero);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbDiasTrabCajero);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpFechaNacCajero);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.txtNombreCajero);
            this.groupBox1.Location = new System.Drawing.Point(396, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 204);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cajero";
            // 
            // btnMesero
            // 
            this.btnMesero.Location = new System.Drawing.Point(245, 76);
            this.btnMesero.Name = "btnMesero";
            this.btnMesero.Size = new System.Drawing.Size(59, 25);
            this.btnMesero.TabIndex = 10;
            this.btnMesero.Text = "Calcular";
            this.btnMesero.UseVisualStyleBackColor = true;
            this.btnMesero.Click += new System.EventHandler(this.btnMesero_Click);
            // 
            // btnRepartidor
            // 
            this.btnRepartidor.Location = new System.Drawing.Point(245, 95);
            this.btnRepartidor.Name = "btnRepartidor";
            this.btnRepartidor.Size = new System.Drawing.Size(59, 22);
            this.btnRepartidor.TabIndex = 23;
            this.btnRepartidor.Text = "Calcular";
            this.btnRepartidor.UseVisualStyleBackColor = true;
            this.btnRepartidor.Click += new System.EventHandler(this.btnRepartidor_Click);
            // 
            // btnCajero
            // 
            this.btnCajero.Location = new System.Drawing.Point(247, 88);
            this.btnCajero.Name = "btnCajero";
            this.btnCajero.Size = new System.Drawing.Size(63, 23);
            this.btnCajero.TabIndex = 34;
            this.btnCajero.Text = "Calcular";
            this.btnCajero.UseVisualStyleBackColor = true;
            this.btnCajero.Click += new System.EventHandler(this.btnCajero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Repartidor);
            this.Controls.Add(this.Mesero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Mesero.ResumeLayout(false);
            this.Mesero.PerformLayout();
            this.Repartidor.ResumeLayout(false);
            this.Repartidor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreMesero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpMesero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDiasTrabMesero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSueldoMesero;
        private System.Windows.Forms.GroupBox Mesero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPropinasMesero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNombreRepartidor;
        private System.Windows.Forms.DateTimePicker dtpFechaNacRepartidor;
        private System.Windows.Forms.ComboBox cmbDiasTrabRepartidor;
        private System.Windows.Forms.TextBox txtSueldoRepartidor;
        private System.Windows.Forms.TextBox txtPropinasRepartidor;
        private System.Windows.Forms.TextBox txtAbonos;
        private System.Windows.Forms.ComboBox cmbZonaReparto;
        private System.Windows.Forms.GroupBox Repartidor;
        private System.Windows.Forms.Button btnMesero;
        private System.Windows.Forms.Button btnRepartidor;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNombreCajero;
        private System.Windows.Forms.DateTimePicker dtpFechaNacCajero;
        private System.Windows.Forms.ComboBox cmbDiasTrabCajero;
        private System.Windows.Forms.TextBox txtSueldoCajero;
        private System.Windows.Forms.ComboBox cmbNumeroCaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCajero;
    }
}

