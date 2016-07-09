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
    public partial class f_nuevoProducto : Form
    {
        public f_nuevoProducto()
        {
            InitializeComponent();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new c_nuevoArticulo.cls_articulo();
                int clave = Convert.ToInt32(txtCP.Text);
                string nombre = Convert.ToString(txtNombre.Text);
                string tipo = Convert.ToString(cbTipo.Text);
                double precio = Convert.ToDouble(txtPrecio.Text);
                if (conn.verificarExistencia(clave, nombre) == "")
                {
                    conn.insertarArticulo(clave, nombre, tipo, precio);
                    if (conn.verificarExistencia(clave, nombre) != "")
                    {
                        MessageBox.Show("Articulo Registrado Correctamente");
                        txtCP.Text = "";
                        txtNombre.Text = "";
                        txtPrecio.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El id o nombre de articulo que intentas registrar ya existe");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error en la inserccion de datos");
            }
        }
    }
}
