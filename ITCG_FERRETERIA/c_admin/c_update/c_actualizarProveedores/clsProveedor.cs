using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace ITCG_FERRETERIA.c_admin.c_update.c_actualizarProveedores
{
    class clsProveedor
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;
        private string nombre, Telefono, Direccion;
        public clsProveedor()
        {
            this.nombre = "";
            this.Telefono = "";
            this.Direccion = "";
        }
        public void obtenerDatos(int id)
        {
            this.nombre = obtenerNombre(id);
            this.Telefono = obtenerTelefono(id);
            this.Direccion = obtenerDireccion(id);
        }
        #region get/set
        public string getNombre()
        {
            return nombre;
        }
        public string getTelefono()
        {
            return Telefono;
        }
        public string getDireccion()
        {
            return Direccion;
        }
        #endregion
        #region comandos
        public string obtenerNombre(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre_P FROM proveedor WHERE Codigo_P={0} and estado='Activo';", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public string obtenerTelefono(int id)
        {
            
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Num_Tel FROM proveedor WHERE Codigo_P={0} AND estado='Activo';", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public string obtenerDireccion(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Direccion FROM proveedor WHERE Codigo_P = {0} AND estado = 'Activo';", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        #endregion
        #region Stored Procedures
        public void actualizarProveedor(int id, string name, string phone, string direccion)
        {
            MySqlCommand comando;

            comando = new MySqlCommand("actualizarProveedor", conector);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@_id", id);
            comando.Parameters.AddWithValue("@_nombre", name);
            comando.Parameters.AddWithValue("@_telefono", phone);
            comando.Parameters.AddWithValue("@_direccion", direccion);

            conector.Open();

            int res = comando.ExecuteNonQuery();

            if (res == 1)
            {
            }
            conector.Close();
            MessageBox.Show("Actualizacion Realizada Correctamente!!");
        }
        #endregion
    }
}