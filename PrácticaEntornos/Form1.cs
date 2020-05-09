using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrácticaEntornos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            string apellidos = tApellidos.Text;
            string telefono = tTelefono.Text;
            tListaSocios.Text = "Datos socio: " + nombre + " " + apellidos + " " + telefono;
        }
    }
}
