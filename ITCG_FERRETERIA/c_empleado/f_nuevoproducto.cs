using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_empleado
{
    public partial class f_nuevoproducto : Form
    {
        clsCompra claseCompra = new clsCompra();
        clsCliente claseCliente = new clsCliente();
        public f_nuevoproducto()
        {
            InitializeComponent();
        }

        private void f_nuevoproducto_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoProd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtProductos.Text))
            {
                int idCliente = claseCliente.getCliente();
                int idProducto = Convert.ToInt32(txtProductos.Text);
                claseCompra.nuevoProducto(idCliente, idProducto);
                double subtotalD = claseCompra.getSubtotal();
                string subtotalS = Convert.ToString(subtotalD);
                txtSubtotal.Text = subtotalS;
                txtProductos.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese algún codigo de producto");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtProductos.Text))
            {
                int idCliente = claseCliente.getCliente();
                int idProducto = Convert.ToInt32(txtProductos.Text);
                claseCompra.compraFinalizada(idCliente, idProducto);
                double subtotalD = claseCompra.getSubtotal();
                string subtotalS = Convert.ToString(subtotalD);
                txtSubtotal.Text = subtotalS;
                txtProductos.Text = "";
                txtSubtotal.Text = "";
                MessageBox.Show("Compra Finalizada Exitosamente");
                var form = new f_asignarCodCliente();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Ingrese algún codigo de producto");
            }
        }

        private void f_nuevoproducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = new f_asignarCodCliente();
            this.Hide();
            form.Show();
        }
    }
}
