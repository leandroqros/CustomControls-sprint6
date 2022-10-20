namespace SWCodigo
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxExtenso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(3, 3);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodigo.TabIndex = 0;
            this.txtBoxCodigo.Leave += new System.EventHandler(this.txtBoxCodigo_Leave);
            this.txtBoxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCodigo_Validating);
            // 
            // txtBoxExtenso
            // 
            this.txtBoxExtenso.Enabled = false;
            this.txtBoxExtenso.Location = new System.Drawing.Point(109, 3);
            this.txtBoxExtenso.Name = "txtBoxExtenso";
            this.txtBoxExtenso.Size = new System.Drawing.Size(399, 20);
            this.txtBoxExtenso.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBoxExtenso);
            this.Controls.Add(this.txtBoxCodigo);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(513, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxExtenso;
    }
}
