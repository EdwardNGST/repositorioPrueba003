using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA
{
    public partial class f_inicioSesion : Form
    {
        public f_inicioSesion()
        {
            InitializeComponent();
        }
        private void f_inicioSesion_Load(object sender, EventArgs e)
        {

        }
        public bool comprobarCampos()
        {
            if (!String.IsNullOrWhiteSpace(txtID.Text) || !String.IsNullOrWhiteSpace(txtContraseña.Text) || !String.IsNullOrWhiteSpace(cbUsuarios.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var conn = new c_conexion();
                if (comprobarCampos() == true)
                {
                    if (cbUsuarios.Text == "Administrador" && txtID.Text == "Admin")
                    {
                        if (txtContraseña.Text == conn.buscarAdministrador())
                        {
                            this.Hide();
                            var form = new c_admin.c_delete.f_menuAdmin();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("Contraseña Incorrecta");
                        }
                    }
                    else if (cbUsuarios.Text == "Empleado")
                    {
                        int id = Convert.ToInt32(txtID.Text);
                        if (conn.verificarEmpleado(id) != 0)
                        {
                            if (conn.getContraseñaEmpleado(id) == txtContraseña.Text)
                            {
                                this.Hide();
                                var form = new c_empleado.f_asignarCodCliente();
                                form.Show();
                            }
                            else
                            {
                                MessageBox.Show("Contraseña Incorrecta");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario no existe");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Te falta rellenar algun campo");
                }
            }
            catch
            {
                MessageBox.Show("Campo no insertado o incorrecto");
            }
}

        private void f_inicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
