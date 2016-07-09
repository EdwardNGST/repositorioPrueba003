using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCG_FERRETERIA.c_admin.c_select.c_verCompras
{
    public partial class f_verCompras : Form
    {
        public f_verCompras()
        {
            InitializeComponent();
        }

        private void f_verCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'verCompras.vercompras' Puede moverla o quitarla según sea necesario.
            this.vercomprasTableAdapter.Fill(this.verCompras.vercompras);
        }
    }
}
