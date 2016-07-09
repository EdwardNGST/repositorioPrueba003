using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_update.c_actualizarProveedores
{
    public partial class f_actualizarProveedores : Form
    {
        c_delete.c_inhabilitarProveedor.clsInhabilitarProveedor connVerificarProveedor = new c_delete.c_inhabilitarProveedor.clsInhabilitarProveedor();
        clsProveedor proveedor = new clsProveedor();
        public f_actualizarProveedores()
        {
            InitializeComponent();
        }
        private void f_actualizarProveedores_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;

            dgvProveedores.DataMember = "verproveedores";
            dgvProveedores.DataSource = ferreteriaVerProveedores1;
            verproveedoresTableAdapter1.Fill(ferreteriaVerProveedores1.verproveedores);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (connVerificarProveedor.verificarProveedor(id) != "")
            {
                gbActualizar.Enabled = true;
                proveedor.obtenerDatos(id);
                txtNombre.Text = proveedor.getNombre();
                txtTelefono.Text = proveedor.getTelefono();
                txtDireccion.Text = proveedor.getDireccion();
            }
            else
            {
                MessageBox.Show("El usuario que quiere buscar no existe");
            }
        }

        private void chkNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNombre.Checked == true)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }
        private void chkNum_tel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNum_tel.Checked == true)
            {
                txtTelefono.Enabled = true;
            }
            else
            {
                txtTelefono.Enabled = false;
            }
        }
        private void chkDireccion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDireccion.Checked == true)
            {
                txtDireccion.Enabled = true;
            }
            else
            {
                txtDireccion.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            proveedor.actualizarProveedor(id, txtNombre.Text, txtTelefono.Text, txtDireccion.Text);
            txtDireccion.Text = "";
            txtId.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        private void f_actualizarProveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_actualizar();
            this.Hide();
            form.Show();
        }
    }
}
