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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void registrarContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarContactos frmRegistrarContactos = new frmRegistrarContactos();
            frmRegistrarContactos.ShowDialog();
        }
    }
}
