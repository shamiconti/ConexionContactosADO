using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryContiConexionContactosBD
{
    public partial class frmRegistrarContactos : Form
    {
        public frmRegistrarContactos()
        {
            InitializeComponent();
        }

        clsContactos ObjContactos = new clsContactos();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ObjContactos.RegistrarContacto(txtNombre.Text, txtApellido.Text, mskTelefono.Text, txtCorreo.Text, 
                cmbCategoria.SelectedItem.ToString());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ObjContactos.CargarCategorias(dgvMostrar);
        }
    }
}
