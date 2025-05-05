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
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Complete el " + lblNombre.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else
            {
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Complete el " + lblApellido.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                }
                else
                {
                    if (mskTelefono.Text == "")
                    {
                        MessageBox.Show("Complete el " + lblTelefono.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mskTelefono.Focus();
                    }
                    else
                    {

                        if (txtCorreo.Text == "")
                        {
                            MessageBox.Show("Complete el " + lblCorreo.Text, "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCorreo.Focus();
                        }
                        else
                        {
                            if (cmbCategoria.SelectedIndex == -1)
                            {
                                MessageBox.Show("Elija una " + lblCategoria.Text, "Categoría no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                cmbCategoria.Focus();
                            }
                            else
                            {
                                MessageBox.Show("Datos registrados correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ObjContactos.RegistrarContacto(txtNombre.Text, txtApellido.Text, mskTelefono.Text, txtCorreo.Text,
                                 cmbCategoria.SelectedItem.ToString());

                                txtNombre.Text = "";
                                txtApellido.Text = "";
                                mskTelefono.Text = "";
                                txtCorreo.Text = "";
                                cmbCategoria.Text = "";
                            }
                        }
                    }
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ObjContactos.CargarCategorias(dgvMostrar);
        }
    }
}
