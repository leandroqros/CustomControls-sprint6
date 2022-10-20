using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class SWTextbox : TextBox
    {

        public SWTextbox()
        {
            InitializeComponent();
        }

        public enum tipoDato
        {
            Numero,
            Texto,
            Codigo
        }

        private tipoDato _datoPermitido;

        public tipoDato datoPermitido
        {
            get { return _datoPermitido; }
            set { _datoPermitido = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);
            this.ResumeLayout(false);

        }

        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        public bool _obligatorio = false;
        public bool obligatorio
        {
            get { return _obligatorio; }
            set
            {
                _obligatorio = value;
               
            }
        }

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rgxNum = new Regex(@"^[0-9]{1,}$");
            Regex rgxLetra = new Regex(@"^[a-zA-Z]{1,}$");
            Regex rgxCodigo = new Regex(@"^[^AEIOU]{4}\-\d{3}\/[13579][AEIOU]$");
            bool correcto;

            if (_obligatorio && this.Text.Length == 0)
            {
                MessageBox.Show("Ese campo no puede estar vacio");
                this.Focus();
            }
            else
            {
                if (datoPermitido is tipoDato.Numero)
                {
                    correcto = rgxNum.IsMatch(this.Text);
                    if (!correcto)
                    {
                        this.Clear();
                        this.Focus();
                    }
                }

                if (datoPermitido is tipoDato.Texto)
                {
                    correcto = rgxLetra.IsMatch(this.Text);
                    if (!correcto)
                    {
                        this.Clear();
                        this.Focus();
                    }
                }

                if (datoPermitido is tipoDato.Codigo)
                {
                    correcto = rgxCodigo.IsMatch(this.Text);
                    if (!correcto)
                    {
                        this.Clear();
                        this.Focus();
                    }
                }
            }

            
            TextBox frmUno = (TextBox)sender;
            Form frm = frmUno.FindForm();
            if (string.IsNullOrEmpty(Text))
            {
                foreach (Control item in frmUno.Controls)
                {
                    if (item.Name.Equals(_buscador))
                    {
                        item.Text = this.Text;
                    }
                }

            }
            else
            {
                this.Text = Text;
            }
            
        }

        public enum esForanea
        {
            Simplem,
            Foranea
        }

        private esForanea _esForanea;

        public esForanea claveForanea
        {
            get { return _esForanea; }
            set { _esForanea = value; }
        }

        public string _buscador;
        public string buscardor
        {
            get { return _buscador; }
            set { _buscador = value; }
        }
    }
}