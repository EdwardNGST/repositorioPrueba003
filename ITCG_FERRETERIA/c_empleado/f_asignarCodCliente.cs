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
    public partial class f_asignarCodCliente : Form
    {
        public f_asignarCodCliente()
        {
            InitializeComponent();
        }

        private void f_asignarCodCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCodClie.Text);
            var cliente = new clsCliente();
            cliente.insertarCliente(id);
            if (cliente.idCompleto() == true) {
                var form = new f_nuevoproducto();
                this.Hide();
                form.Show();
            }
        }

        private void f_asignarCodCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
