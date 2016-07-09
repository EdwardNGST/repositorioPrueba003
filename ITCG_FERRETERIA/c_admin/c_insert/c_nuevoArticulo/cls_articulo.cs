using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoArticulo
{
    class cls_articulo
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;
        
        public string verificarExistencia(int idProducto,string nombreProducto)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre FROM ferreteria.articulos WHERE Codigo_A={0} OR Nombre='{1}';",idProducto,nombreProducto), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public void insertarArticulo(int cpI,string nombreI, string tipoI, double precioI)
        {
            conector = new MySqlConnection(cadena);
            conector.Open();
            comando = new MySqlCommand(string.Format("INSERT INTO articulos (Codigo_A,Nombre,Tipo,Precio)VALUES({0},'{1}','{2}',{3});",cpI,nombreI,tipoI,precioI), conector);
            Lector = comando.ExecuteReader();
            while (Lector.Read())
            {
            }
            conector.Close();
        }
        
        
    }
}
