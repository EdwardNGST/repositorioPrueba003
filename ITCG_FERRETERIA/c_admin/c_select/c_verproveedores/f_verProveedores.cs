using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_select.c_verproveedores
{
    public partial class f_verProveedores : Form
    {
        public f_verProveedores()
        {
            InitializeComponent();
        }

        private void f_verProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataMember = "verproveedores";
            dgvProveedores.DataSource = ferreteriaVerProveedores1;
            verproveedoresTableAdapter1.Fill(ferreteriaVerProveedores1.verproveedores);
        }
    }
}
