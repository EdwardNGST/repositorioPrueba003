using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_insert.c_compraArticulos
{
    public partial class f_comprarArticulos : Form
    {
        public f_comprarArticulos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(txtClaveproducto.Text);
            int idProveedor = Convert.ToInt32(txtClaveproveedor.Text);
            int cantidad = Convert.ToInt32(txtCant.Text);

            var conn = new clsComprarArticulos();

            conn.insertarArticulos(idProducto,idProveedor,cantidad);
        }

        private void f_comprarArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaVerProveedores.verproveedores' Puede moverla o quitarla según sea necesario.
            this.verproveedoresTableAdapter.Fill(this.ferreteriaVerProveedores.verproveedores);
            // TODO: esta línea de código carga datos en la tabla 'ferreteriaVerArticulos.verarticulos' Puede moverla o quitarla según sea necesario.
            this.verarticulosTableAdapter.Fill(this.ferreteriaVerArticulos.verarticulos);

        }
    }
}
