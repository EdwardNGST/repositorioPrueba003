using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace ITCG_FERRETERIA.c_admin.c_update.c_actualizarClientes
{
    class clsCliente
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;
        private string nombre, telefono, estado;
        public clsCliente() {
            nombre = "";
            telefono = "";
            estado = "";
        }
        public void obtenerDatos(int id)
        {
            this.nombre = obtenerNombre(id);
            this.telefono = obtenerTelefono(id);
            this.estado = obtenerEstado(id);
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public string getEstado()
        {
            return estado;
        }
        public string obtenerNombre(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre_C FROM clientes WHERE Codigo_C = {0};", id), conector);

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

            comando = new MySqlCommand(string.Format("SELECT Num_Tel FROM clientes WHERE Codigo_C = {0};", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public string obtenerEstado(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT estado FROM clientes WHERE Codigo_C = {0};", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public void actualizarCliente(int _id, string _name, string _phone, string _estado)
        {
            MySqlCommand comando;

            comando = new MySqlCommand("actualizarCliente", conector);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@_codigoCliente", _id);
            comando.Parameters.AddWithValue("@_nombre", _name);
            comando.Parameters.AddWithValue("@_numTel", _phone);
            comando.Parameters.AddWithValue("@_estado", _estado);

            conector.Open();

            int res = comando.ExecuteNonQuery();

            if (res == 1)
            {
            }
            conector.Close();
            MessageBox.Show("Actualizacion Realizada Correctamente!!");
        }
    }
}