using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace panelConectado
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string Formulario
        {
            get;
            set;
        }

        public string Classe
        {
            get;
            set;
        }

        public string Descripcion
        {
            get;
            set;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(@""+Classe+".dll");
            Object dllBD;
            Type tipus;
            tipus = ensamblat.GetType(Classe+"."+Formulario);
            dllBD = Activator.CreateInstance(tipus);
            ((Form)dllBD).Show();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            button1.Text = Descripcion;
        }
    }
}
