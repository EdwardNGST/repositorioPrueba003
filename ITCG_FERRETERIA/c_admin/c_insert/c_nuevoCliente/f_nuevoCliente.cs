using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoCliente
{
    public partial class f_nuevoCliente : Form
    {
        public f_nuevoCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String nombre = Convert.ToString(txtNombre.Text);
            String telefono = Convert.ToString(txtTel.Text);

            try
            {
                var conn = new cls_nuevoCliente();

                if (conn.verificarExistencia(nombre) == "")
                {
                    conn.insertarCliente(nombre, telefono);
                    if (conn.verificarExistencia(nombre) != "")
                    {
                        MessageBox.Show("El cliente se ha registrado con exito");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un problema registrando al cliente");
                    }
                }
                else
                {
                    MessageBox.Show("El Cliente que intentas registrar ya existe");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema con el registro del cliente");
            }
        }

        private void f_nuevoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
