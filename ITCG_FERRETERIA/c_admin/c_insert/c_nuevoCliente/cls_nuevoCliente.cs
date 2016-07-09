using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoCliente
{
    class cls_nuevoCliente
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;

        public string verificarExistencia(string nombreClie)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre_C FROM clientes WHERE Nombre_C='{0}' AND estado='Activo';", nombreClie), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public void insertarCliente(string nombre, string tel)
        {
            conector = new MySqlConnection(cadena);
            conector.Open();
            comando = new MySqlCommand(string.Format("INSERT INTO clientes (Nombre_C,Num_Tel)VALUES('{0}','{1}');", nombre, tel), conector);
            Lector = comando.ExecuteReader();
            while (Lector.Read())
            {
            }
            conector.Close();
        }
    }
}
