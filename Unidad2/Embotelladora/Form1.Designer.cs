namespace Embotelladora
{
    partial class FrmEmbotelladora
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
            this.LblNivelLlenado = new System.Windows.Forms.Label();
            this.TxtNivelLlenado = new System.Windows.Forms.TextBox();
            this.BtnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNivelLlenado
            // 
            this.LblNivelLlenado.AutoSize = true;
            this.LblNivelLlenado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblNivelLlenado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblNivelLlenado.Location = new System.Drawing.Point(3, 44);
            this.LblNivelLlenado.Name = "LblNivelLlenado";
            this.LblNivelLlenado.Size = new System.Drawing.Size(153, 13);
            this.LblNivelLlenado.TabIndex = 0;
            this.LblNivelLlenado.Text = "Introduce el numero de llenado";
            this.LblNivelLlenado.Click += new System.EventHandler(this.LblNivelLlenado_Click);
            // 
            // TxtNivelLlenado
            // 
            this.TxtNivelLlenado.Location = new System.Drawing.Point(183, 41);
            this.TxtNivelLlenado.Name = "TxtNivelLlenado";
            this.TxtNivelLlenado.Size = new System.Drawing.Size(100, 20);
            this.TxtNivelLlenado.TabIndex = 1;
            // 
            // BtnVerificar
            // 
            this.BtnVerificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVerificar.Location = new System.Drawing.Point(183, 184);
            this.BtnVerificar.Name = "BtnVerificar";
            this.BtnVerificar.Size = new System.Drawing.Size(75, 23);
            this.BtnVerificar.TabIndex = 2;
            this.BtnVerificar.Text = "Verificar";
            this.BtnVerificar.UseVisualStyleBackColor = true;
            this.BtnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // FrmEmbotelladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BtnVerificar);
            this.Controls.Add(this.TxtNivelLlenado);
            this.Controls.Add(this.LblNivelLlenado);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "FrmEmbotelladora";
            this.Text = "Embotelladora Ceceña";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNivelLlenado;
        private System.Windows.Forms.TextBox TxtNivelLlenado;
        private System.Windows.Forms.Button BtnVerificar;
    }
}

