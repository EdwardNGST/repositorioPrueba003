using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_update.c_actualizarClientes
{
    public partial class f_actualizarClientes : Form
    {
        c_delete.c_inhabilitarCliente.clsInhabilitarCliente connVerificarCliente = new c_delete.c_inhabilitarCliente.clsInhabilitarCliente();
        clsCliente cliente = new clsCliente();
        public f_actualizarClientes()
        {
            InitializeComponent();
        }

        private void f_actualizarClientes_Load(object sender, EventArgs e)
        {
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtEstado.Enabled = false;

            dgvClientes.DataMember = "verclientes";
            dgvClientes.DataSource = verClientes1;
            verclientesTableAdapter1.Fill(verClientes1.verclientes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (connVerificarCliente.verificarCliente(id) != "")
            {
                gbActualizar.Enabled = true;
                cliente.obtenerDatos(id);
                txtNombre.Text = cliente.getNombre();
                txtTelefono.Text = cliente.getTelefono();
                txtEstado.Text = cliente.getEstado();
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

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstado.Checked == true)
            {
                txtEstado.Enabled = true;
            }
            else
            {
                txtEstado.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            cliente.actualizarCliente(id, txtNombre.Text, txtTelefono.Text, txtEstado.Text);
            txtId.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
        }

        private void f_actualizarClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_actualizar();
            this.Hide();
            form.Show();
        }
    }
}