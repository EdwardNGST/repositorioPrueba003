using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_delete.c_inhabilitarProducto
{
    public partial class f_inhabilitarProducto : Form
    {
        public f_inhabilitarProducto()
        {
            InitializeComponent();
        }

        private void f_inhabilitarProducto_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'verProductos.verarticulos' Puede moverla o quitarla según sea necesario.
            this.verarticulosTableAdapter.Fill(this.verProductos.verarticulos);

        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            var conn = new clsInhabilitarProducto();
            conn.inhabilitarProducto(txtIDProducto.Text);
        }

        private void f_inhabilitarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_menuEliminar();
            this.Hide();
            form.Show();
        }
    }
}
