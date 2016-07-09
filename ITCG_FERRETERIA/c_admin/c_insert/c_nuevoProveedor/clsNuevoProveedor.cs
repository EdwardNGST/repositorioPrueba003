using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoProveedor
{
    class clsNuevoProveedor
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;

        //SELECT Nombre_P FROM proveedor WHERE Nombre_P = 'Alan' AND estado = 'Activo';
        //SELECT Nombre_P FROM proveedor WHERE Codigo_P = 123 AND estado = 'Activo';
        //INSERT INTO proveedor(Nombre_P, Num_Tel, Direccion)VALUES('Josue','24135','Otra Casa');
        public void insertarNuevoProveedor(string nombre, string tel, string direccion)
        {
            if (verificarNombreProveedor(nombre) == "")
            {
                insertar(nombre,tel,direccion);
                MessageBox.Show("Proveedor Registrado con Exito");
            }
            else
            {
                MessageBox.Show("El proveedor que intentas registrar ya esta registrado");
            }
        }
        public string verificarNombreProveedor(string nombre)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre_P FROM proveedor WHERE Nombre_P = '{0}' AND estado = 'Activo';",nombre), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public void insertar(string nombre, string tel, string direccion)
        {
            conector = new MySqlConnection(cadena);
            conector.Open();
            comando = new MySqlCommand(string.Format("INSERT INTO proveedor(Nombre_P, Num_Tel, Direccion)VALUES('{0}','{1}','{2}');",nombre, tel, direccion), conector);
            Lector = comando.ExecuteReader();
            while (Lector.Read())
            {
            }
            conector.Close();
        }
    }
}
