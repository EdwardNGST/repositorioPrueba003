using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ITCG_FERRETERIA
{
    class c_conexion
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;
        //Esta clase te permite verificar la contraseña del administrador
        public string buscarAdministrador()
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT contraseña FROM ferreteria.administrador WHERE id=1;"), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public int verificarEmpleado(int id)
        {
            conector = new MySqlConnection(cadena);
            MySqlCommand comando;
            MySqlDataReader Lector;

            int Dato = 0;

            conector.Open();
            comando = new MySqlCommand(string.Format("SELECT CC FROM empleados WHERE CC={0};",id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetInt32(0);
            }
            conector.Close();

            return Dato;
        }
        //Esta clase te permite obtener la contraseña del empleado
        public string getContraseñaEmpleado(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Contraseña FROM empleados WHERE CC={0} AND Puesto='Cajero' and Estado='Activo';", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
    }
}
