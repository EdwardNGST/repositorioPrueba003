using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_delete.c_inhabilitarCliente
{
    public partial class f_inhabilitarCliente : Form
    {
        public f_inhabilitarCliente()
        {
            InitializeComponent();
        }

        private void f_inhabilitarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'verClientes.verclientes' Puede moverla o quitarla según sea necesario.
            this.verclientesTableAdapter.Fill(this.verClientes.verclientes);

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            var conn = new clsInhabilitarCliente();
            conn.inhabilitarCliente(txtIDCliente.Text);
        }

        private void f_inhabilitarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_menuEliminar();
            this.Hide();
            form.Show();
        }
    }
}
