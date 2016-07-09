using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_insert
{
    public partial class menuInsertar : Form
    {
        public menuInsertar()
        {
            InitializeComponent();
        }

        private void btnInsertarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void menuInsertar_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new c_delete.f_menuAdmin();
            this.Hide();
            form.Show();
        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {

        }
    }
}
