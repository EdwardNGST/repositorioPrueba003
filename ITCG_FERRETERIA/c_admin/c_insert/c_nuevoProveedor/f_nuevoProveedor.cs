using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoProveedor
{
    public partial class f_nuevoProveedor : Form
    {
        public f_nuevoProveedor()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var conn = new clsNuevoProveedor();
            conn.insertarNuevoProveedor(txtNombre.Text,txtTelefono.Text,txtDireccion.Text);
        }
    }
}
