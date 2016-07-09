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
    public partial class f_menuAdmin : Form
    {
        public f_menuAdmin()
        {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var form = new c_insert.menuInsertar();
            this.Hide();
            form.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var form = new c_delete.f_menuEliminar();
            this.Hide();
            form.Show();
        }

        private void f_menuAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void f_menuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c_update.f_actualizar form = new c_update.f_actualizar();
            this.Hide();
            form.Show();
        }
    }
}
