using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_select.c_verProductos
{
    public partial class f_verArticulos : Form
    {
        public f_verArticulos()
        {
            InitializeComponent();
        }

        private void f_verArticulos_Load(object sender, EventArgs e)
        {
            verArticulos.DataMember = "verarticulos";
            verArticulos.DataSource = ferreteriaVerArticulos1;
            verarticulosTableAdapter1.Fill(ferreteriaVerArticulos1.verarticulos);
        }
    }
}
