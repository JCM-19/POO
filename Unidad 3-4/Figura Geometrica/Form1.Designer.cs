namespace Figura_Geometrica
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
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMedidaCuadrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAreaCuadrado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPerimetroCuadrado = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaseTriangulo = new System.Windows.Forms.TextBox();
            this.txtAlturaTriangulo = new System.Windows.Forms.TextBox();
            this.lblAreaTriangulo = new System.Windows.Forms.Label();
            this.lblPerimetroTriangulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAreaCirculo = new System.Windows.Forms.Label();
            this.lblPerimetroCirculo = new System.Windows.Forms.Label();
            this.txtRadioCirculo = new System.Windows.Forms.TextBox();
            this.txtCircunferenciaCirculo = new System.Windows.Forms.TextBox();
            this.btnCirculo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.Location = new System.Drawing.Point(36, 75);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(71, 31);
            this.btnCuadrado.TabIndex = 17;
            this.btnCuadrado.Text = "Calcular";
            this.btnCuadrado.UseVisualStyleBackColor = true;
            this.btnCuadrado.Click += new System.EventHandler(this.btnCuadrado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Medida de lado";
            // 
            // txtMedidaCuadrado
            // 
            this.txtMedidaCuadrado.Location = new System.Drawing.Point(98, 18);
            this.txtMedidaCuadrado.Name = "txtMedidaCuadrado";
            this.txtMedidaCuadrado.Size = new System.Drawing.Size(64, 20);
            this.txtMedidaCuadrado.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Area:";
            // 
            // lblAreaCuadrado
            // 
            this.lblAreaCuadrado.AutoSize = true;
            this.lblAreaCuadrado.Location = new System.Drawing.Point(65, 159);
            this.lblAreaCuadrado.Name = "lblAreaCuadrado";
            this.lblAreaCuadrado.Size = new System.Drawing.Size(0, 13);
            this.lblAreaCuadrado.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Perimetro:";
            // 
            // lblPerimetroCuadrado
            // 
            this.lblPerimetroCuadrado.AutoSize = true;
            this.lblPerimetroCuadrado.Location = new System.Drawing.Point(65, 181);
            this.lblPerimetroCuadrado.Name = "lblPerimetroCuadrado";
            this.lblPerimetroCuadrado.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroCuadrado.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblPerimetroCuadrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblAreaCuadrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMedidaCuadrado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCuadrado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 209);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cuadrado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Base:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Altura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Area:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Perimetro:";
            // 
            // txtBaseTriangulo
            // 
            this.txtBaseTriangulo.Location = new System.Drawing.Point(62, 12);
            this.txtBaseTriangulo.Name = "txtBaseTriangulo";
            this.txtBaseTriangulo.Size = new System.Drawing.Size(59, 20);
            this.txtBaseTriangulo.TabIndex = 29;
            // 
            // txtAlturaTriangulo
            // 
            this.txtAlturaTriangulo.Location = new System.Drawing.Point(62, 40);
            this.txtAlturaTriangulo.Name = "txtAlturaTriangulo";
            this.txtAlturaTriangulo.Size = new System.Drawing.Size(58, 20);
            this.txtAlturaTriangulo.TabIndex = 30;
            // 
            // lblAreaTriangulo
            // 
            this.lblAreaTriangulo.AutoSize = true;
            this.lblAreaTriangulo.Location = new System.Drawing.Point(74, 90);
            this.lblAreaTriangulo.Name = "lblAreaTriangulo";
            this.lblAreaTriangulo.Size = new System.Drawing.Size(0, 13);
            this.lblAreaTriangulo.TabIndex = 31;
            // 
            // lblPerimetroTriangulo
            // 
            this.lblPerimetroTriangulo.AutoSize = true;
            this.lblPerimetroTriangulo.Location = new System.Drawing.Point(80, 181);
            this.lblPerimetroTriangulo.Name = "lblPerimetroTriangulo";
            this.lblPerimetroTriangulo.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroTriangulo.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.lblTriangulo);
            this.groupBox2.Controls.Add(this.btnTriangulo);
            this.groupBox2.Controls.Add(this.lblPerimetroTriangulo);
            this.groupBox2.Controls.Add(this.lblAreaTriangulo);
            this.groupBox2.Controls.Add(this.txtAlturaTriangulo);
            this.groupBox2.Controls.Add(this.txtBaseTriangulo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 209);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Triangulo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(23, 75);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(67, 31);
            this.btnTriangulo.TabIndex = 33;
            this.btnTriangulo.Text = "Calcular";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(73, 158);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(0, 13);
            this.lblTriangulo.TabIndex = 34;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnCirculo);
            this.groupBox3.Controls.Add(this.txtCircunferenciaCirculo);
            this.groupBox3.Controls.Add(this.txtRadioCirculo);
            this.groupBox3.Controls.Add(this.lblPerimetroCirculo);
            this.groupBox3.Controls.Add(this.lblAreaCirculo);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(395, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 210);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Circulo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Radio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Circunferencia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Area:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Perimetro:";
            // 
            // lblAreaCirculo
            // 
            this.lblAreaCirculo.AutoSize = true;
            this.lblAreaCirculo.Location = new System.Drawing.Point(77, 161);
            this.lblAreaCirculo.Name = "lblAreaCirculo";
            this.lblAreaCirculo.Size = new System.Drawing.Size(0, 13);
            this.lblAreaCirculo.TabIndex = 4;
            // 
            // lblPerimetroCirculo
            // 
            this.lblPerimetroCirculo.AutoSize = true;
            this.lblPerimetroCirculo.Location = new System.Drawing.Point(77, 184);
            this.lblPerimetroCirculo.Name = "lblPerimetroCirculo";
            this.lblPerimetroCirculo.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetroCirculo.TabIndex = 5;
            // 
            // txtRadioCirculo
            // 
            this.txtRadioCirculo.Location = new System.Drawing.Point(90, 19);
            this.txtRadioCirculo.Name = "txtRadioCirculo";
            this.txtRadioCirculo.Size = new System.Drawing.Size(56, 20);
            this.txtRadioCirculo.TabIndex = 6;
            // 
            // txtCircunferenciaCirculo
            // 
            this.txtCircunferenciaCirculo.Location = new System.Drawing.Point(89, 47);
            this.txtCircunferenciaCirculo.Name = "txtCircunferenciaCirculo";
            this.txtCircunferenciaCirculo.Size = new System.Drawing.Size(56, 20);
            this.txtCircunferenciaCirculo.TabIndex = 7;
            // 
            // btnCirculo
            // 
            this.btnCirculo.Location = new System.Drawing.Point(42, 83);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(66, 24);
            this.btnCirculo.TabIndex = 8;
            this.btnCirculo.Text = "Calcular";
            this.btnCirculo.UseVisualStyleBackColor = true;
            this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 278);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMedidaCuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAreaCuadrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPerimetroCuadrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBaseTriangulo;
        private System.Windows.Forms.TextBox txtAlturaTriangulo;
        private System.Windows.Forms.Label lblAreaTriangulo;
        private System.Windows.Forms.Label lblPerimetroTriangulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.TextBox txtCircunferenciaCirculo;
        private System.Windows.Forms.TextBox txtRadioCirculo;
        private System.Windows.Forms.Label lblPerimetroCirculo;
        private System.Windows.Forms.Label lblAreaCirculo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

