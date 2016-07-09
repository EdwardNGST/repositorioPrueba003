using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace ITCG_FERRETERIA.c_admin.c_delete.c_inhabilitarCliente
{
    class clsInhabilitarCliente
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;
        public void inhabilitarCliente(string id)
        {
            int idI = Convert.ToInt32(id);
            if (verificarCliente(idI) != "")
            {
                storeProcedureInhabilitar(idI);
                MessageBox.Show("Cliente Inhabilitado Exitosamente");
            }
            else
            {
                MessageBox.Show("El cliente no existe");
            }
        }
        public string verificarCliente(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre_C FROM clientes WHERE Codigo_C={0};", id), conector);

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

            comando = new MySqlCommand("inhabilitarCliente", conector);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@_idCliente", id);

            conector.Open();

            int res = comando.ExecuteNonQuery();

            if (res == 1)
            {
            }
            conector.Close();
        }
    }
}
