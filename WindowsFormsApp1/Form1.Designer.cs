
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.swTextbox1 = new ClassLibrary1.SWTextbox();
            this.userControl11 = new SWCodigo.UserControl1();
            this.userControl12 = new panelConectado.UserControl1();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.buscardor = null;
            this.swTextbox1.claveForanea = ClassLibrary1.SWTextbox.esForanea.Simplem;
            this.swTextbox1.datoPermitido = ClassLibrary1.SWTextbox.tipoDato.Numero;
            this.swTextbox1.Location = new System.Drawing.Point(171, 109);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.obligatorio = true;
            this.swTextbox1.Size = new System.Drawing.Size(100, 20);
            this.swTextbox1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(171, 135);
            this.userControl11.Name = "userControl11";
            this.userControl11.nivell = SWCodigo.UserControl1.nivel.GS;
            this.userControl11.obligatorio = true;
            this.userControl11.Size = new System.Drawing.Size(513, 26);
            this.userControl11.TabIndex = 1;
            // 
            // userControl12
            // 
            this.userControl12.Classe = "testeo";
            this.userControl12.Descripcion = "AbrirForm";
            this.userControl12.Formulario = "Form1";
            this.userControl12.Location = new System.Drawing.Point(171, 167);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(242, 107);
            this.userControl12.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.swTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary1.SWTextbox swTextbox1;
        private SWCodigo.UserControl1 userControl11;
        private panelConectado.UserControl1 userControl12;
    }
}