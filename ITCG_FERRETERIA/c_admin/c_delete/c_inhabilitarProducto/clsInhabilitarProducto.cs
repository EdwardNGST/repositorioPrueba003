using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace ITCG_FERRETERIA.c_admin.c_delete.c_inhabilitarProducto
{
    class clsInhabilitarProducto
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;

        public void inhabilitarProducto(string id)
        {
            int idI = Convert.ToInt32(id);
            if (verificarProducto(idI) != "")
            {
                storeProcedureInhabilitar(idI);
                MessageBox.Show("Producto Inhabilitado Exitosamente");
            }
            else
            {
                MessageBox.Show("El producto no existe");
            }
        }
        public string verificarProducto(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre FROM articulos WHERE Codigo_A={0};", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public void storeProcedureInhabilitar(int id)
        {
            MySqlCommand comando;

            comando = new MySqlCommand("inhabilitarProducto", conector);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@_idProducto", id);

            conector.Open();

            int res = comando.ExecuteNonQuery();

            if (res == 1)
            {
            }
            conector.Close();
        }
    }
}
