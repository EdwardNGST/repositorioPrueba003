using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoEmpleado
{
    public partial class f_nuevoEmpleado : Form
    {
        public f_nuevoEmpleado()
        {
            InitializeComponent();
        }

        private void f_nuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int clave = Convert.ToInt32(txtClaveEmp.Text);
            string nombre = Convert.ToString(txtNombreEmp.Text);
            string puesto = Convert.ToString(cbPuesto.Text);
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            string contraseña = txtContraseña.Text;
            var conn = new c_nuevoEmpleado.clsNuevoEmpleado();
            conn.insertarNuevoEmpleado(clave,nombre,puesto,telefono,direccion,contraseña);
        }
    }
}
