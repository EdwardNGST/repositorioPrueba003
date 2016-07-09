using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_delete.c_inhabilitarProveedor
{
    public partial class f_inhabilitarProveedor : Form
    {
        public f_inhabilitarProveedor()
        {
            InitializeComponent();
        }

        private void f_inhabilitarProveedor_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataMember = "verproveedores";
            dgvProveedores.DataSource = ferreteriaVerProveedores1;
            verproveedoresTableAdapter1.Fill(ferreteriaVerProveedores1.verproveedores);

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            var conn = new clsInhabilitarProveedor();
            conn.inhabilitarProveedor(txtIdProveedor.Text);
        }

        private void f_inhabilitarProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_menuEliminar();
            this.Hide();
            form.Show();
        }
    }
}