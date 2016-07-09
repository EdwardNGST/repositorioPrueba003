using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_select.c_verEmpleados
{
    public partial class f_verEmpleados : Form
    {
        public f_verEmpleados()
        {
            InitializeComponent();
        }

        private void f_verEmpleados_Load(object sender, EventArgs e)
        {
            dgvEmpleados.DataMember = "verempleados";
            dgvEmpleados.DataSource = verEmpleados1;
            verempleadosTableAdapter1.Fill(verEmpleados1.verempleados);
        }
    }
}
