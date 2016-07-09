using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_select.c_verClientes
{
    public partial class f_verClientes : Form
    {
        public f_verClientes()
        {
            InitializeComponent();
        }

        private void f_verClientes_Load(object sender, EventArgs e)
        {
            dgvVerClientes.DataMember = "verclientes";
            dgvVerClientes.DataSource = verClientes1;
            verclientesTableAdapter1.Fill(verClientes1.verclientes);
        }
    }
}
