using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_delete.c_despedirEmpleado
{
    public partial class f_despedirEmpleado : Form
    {
        public f_despedirEmpleado()
        {
            InitializeComponent();
        }

        private void f_despedirEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'verEmpleados.verempleados' Puede moverla o quitarla según sea necesario.
            this.verempleadosTableAdapter.Fill(this.verEmpleados.verempleados);

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            var conn = new clsDespedirEmpleado();
            conn.inhabilitarEmpleado(txtIdEmpleado.Text);
        }

        private void f_despedirEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_menuEliminar();
            this.Hide();
            form.Show();
        }
    }
}
