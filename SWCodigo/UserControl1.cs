using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWCodigo
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
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
        public enum nivel
        {
            GM,
            GS
        }

        private nivel _nivell;

        public nivel nivell
        {
            get { return _nivell; }
            set { _nivell = value; }
        }

        private void txtBoxCodigo_Validating(object sender, CancelEventArgs e)
        {       
            
        }

        private void txtBoxCodigo_Leave(object sender, EventArgs e)
        {
            ValidaCodi();
        }

        private void ValidaCodi()
        {
            if (_nivell.Equals(nivel.GS))
            {
                if (_obligatorio && txtBoxCodigo.Text.Length == 0)
                {
                    MessageBox.Show("Ese campo no puede estar vacio");
                    this.Focus();
                }
                else
                {
                    if (txtBoxCodigo.Text.Equals("S2AM"))
                    {
                        txtBoxExtenso.Text = "Desenvolupament aplicacions multiplataforma";
                    }
                    else if (txtBoxCodigo.Text.Equals("S2SX"))
                    {
                        txtBoxExtenso.Text = "Administració de sistemes Informatics en xarxa";
                    }
                    else
                    {
                        txtBoxExtenso.Text = "Codi incorrecte";
                        txtBoxCodigo.Focus();
                    }
                }
            }
            else if (_nivell.Equals(nivel.GM))
            {
                if (_obligatorio && txtBoxCodigo.Text.Length == 0)
                {
                    MessageBox.Show("Ese campo no puede estar vacio");
                    this.Focus();
                }
                else
                {
                    if (txtBoxCodigo.Text.Equals("M2SX"))
                    {
                        txtBoxExtenso.Text = "Sistemes MicroInformatics i Xarxes";
                    }
                    else
                    {
                        txtBoxExtenso.Text = "Codi incorrecte";
                        txtBoxCodigo.Focus();
                    }
                }

            }
        }
    }
}
