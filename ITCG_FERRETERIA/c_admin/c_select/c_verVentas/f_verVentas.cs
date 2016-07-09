using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_select.c_verVentas
{
    public partial class f_verVentas : Form
    {
        public f_verVentas()
        {
            InitializeComponent();
        }

        private void f_verVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'verVentas.verventas' Puede moverla o quitarla según sea necesario.
            this.verventasTableAdapter.Fill(this.verVentas.verventas);
        }
    }
}
