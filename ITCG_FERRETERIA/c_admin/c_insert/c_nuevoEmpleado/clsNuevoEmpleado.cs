using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ITCG_FERRETERIA.c_admin.c_insert.c_nuevoEmpleado
{
    class clsNuevoEmpleado
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;

        public void insertarNuevoEmpleado(int clave, string nombre, string puesto, string telefono, string direccion, string contraseña)
        {
            if (verificarClaveEmpleado(clave) == "" && verificarNombreEmpleado(nombre)=="")
            {
                insertarEmpleado(clave,nombre,puesto,telefono,direccion,contraseña);
                MessageBox.Show("Empleado registrado Exitosamente");
            }
            else
            {
                MessageBox.Show("El empleado que intentas insertar ya existe en la base de datos");
            }
        }
        public string verificarClaveEmpleado(int clave)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre FROM empleados WHERE CC={0} AND estado='Activo';",clave), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public string verificarNombreEmpleado(string nombre)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre FROM empleados WHERE Nombre='{0}' AND estado='Activo';", nombre), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public void insertarEmpleado(int clave, string nombre, string puesto, string telefono, string direccion, string contraseña)
        {
            conector = new MySqlConnection(cadena);
            conector.Open();
            comando = new MySqlCommand(string.Format("INSERT INTO empleados(CC,Nombre,Puesto,Num_Tel,Direccion,Contraseña)VALUES({0},'{1}','{2}','{3}','{4}','{5}');",clave,nombre,puesto,telefono,direccion,contraseña), conector);
            Lector = comando.ExecuteReader();
            while (Lector.Read())
            {
            }
            conector.Close();
        }
    }
}
