using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ITCG_FERRETERIA.c_empleado
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


        public static int idCliente=0;
        public void insertarCliente(int id)
        {
            if (verificarCliente(id) != 0) {
                idCliente = id;
                MessageBox.Show("Cliente Correcto");
            }
            else
            {
                MessageBox.Show("El cliente no existe, favor de registrarlo primero");
            }
        }
        public Boolean idCompleto() {
            if (idCliente != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int verificarCliente(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            int Dato = 0;

            comando = new MySqlCommand(string.Format("SELECT Codigo_C FROM clientes WHERE Codigo_C={0} and estado='Activo';", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetInt32(0);
            }
            conector.Close();
            return Dato;
        }
        public int getCliente() {
            return idCliente;
        }
    }
}
