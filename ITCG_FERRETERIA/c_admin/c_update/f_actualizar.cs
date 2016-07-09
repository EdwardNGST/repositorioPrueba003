using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_update
{
    public partial class f_actualizar : Form
    {
        public f_actualizar()
        {
            InitializeComponent();
        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            c_actualizarClientes.f_actualizarClientes form = new c_actualizarClientes.f_actualizarClientes();
            this.Hide();
            form.Show();
        }

        private void btnActualizarProduco_Click(object sender, EventArgs e)
        {
            c_actualizarProveedores.f_actualizarProveedores form = new c_actualizarProveedores.f_actualizarProveedores();
            this.Hide();
            form.Show();
        }

        private void f_actualizar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new c_admin.c_delete.f_menuAdmin();
            this.Hide();
            form.Show();
        }

        private void f_actualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
