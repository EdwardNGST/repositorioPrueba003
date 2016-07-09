using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_delete
{
    public partial class f_menuEliminar : Form
    {
        public f_menuEliminar()
        {
            InitializeComponent();
        }

        private void btndespedirEmpleado_Click(object sender, EventArgs e)
        {
            var form = new c_despedirEmpleado.f_despedirEmpleado();
            this.Hide();
            form.Show();
        }

        private void btnInhabilitarCliente_Click(object sender, EventArgs e)
        {
            var form = new c_inhabilitarCliente.f_inhabilitarCliente();
            this.Hide();
            form.Show();
        }

        private void btnInhabilitarProducto_Click(object sender, EventArgs e)
        {
            var form = new c_inhabilitarProducto.f_inhabilitarProducto();
            this.Hide();
            form.Show();
        }

        private void btnInhabilitarProveedor_Click(object sender, EventArgs e)
        {
            var form = new c_inhabilitarProveedor.f_inhabilitarProveedor();
            this.Hide();
            form.Show();
        }

        private void f_menuEliminar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_menuAdmin();
            this.Hide();
            form.Show();
        }

        private void f_menuEliminar_Load(object sender, EventArgs e)
        {

        }
    }
}
