namespace LadoDeUnCuadradoAreaYPerimetro
{
    partial class frmCuadrado
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
            this.components = new System.ComponentModel.Container();
            this.txtLados = new System.Windows.Forms.TextBox();
            this.Lblperimetro = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnarea = new System.Windows.Forms.Button();
            this.btnPerimetro = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLados
            // 
            this.txtLados.Location = new System.Drawing.Point(137, 37);
            this.txtLados.Name = "txtLados";
            this.txtLados.Size = new System.Drawing.Size(103, 20);
            this.txtLados.TabIndex = 0;
            this.txtLados.TextChanged += new System.EventHandler(this.txtLados_TextChanged);
            // 
            // Lblperimetro
            // 
            this.Lblperimetro.AutoSize = true;
            this.Lblperimetro.Location = new System.Drawing.Point(213, 128);
            this.Lblperimetro.Name = "Lblperimetro";
            this.Lblperimetro.Size = new System.Drawing.Size(0, 13);
            this.Lblperimetro.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(214, 89);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Introduce lado";
            // 
            // btnarea
            // 
            this.btnarea.Location = new System.Drawing.Point(128, 84);
            this.btnarea.Name = "btnarea";
            this.btnarea.Size = new System.Drawing.Size(80, 22);
            this.btnarea.TabIndex = 4;
            this.btnarea.Text = "Area";
            this.btnarea.UseVisualStyleBackColor = true;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // btnPerimetro
            // 
            this.btnPerimetro.Location = new System.Drawing.Point(127, 124);
            this.btnPerimetro.Name = "btnPerimetro";
            this.btnPerimetro.Size = new System.Drawing.Size(80, 20);
            this.btnPerimetro.TabIndex = 5;
            this.btnPerimetro.Text = "Perimetro";
            this.btnPerimetro.UseVisualStyleBackColor = true;
            this.btnPerimetro.Click += new System.EventHandler(this.btnPerimetro_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPerimetro);
            this.Controls.Add(this.btnarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.Lblperimetro);
            this.Controls.Add(this.txtLados);
            this.Name = "frmCuadrado";
            this.Text = "Lados de un cuadrado :)";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLados;
        private System.Windows.Forms.Label Lblperimetro;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.Button btnPerimetro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

