using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ITCG_FERRETERIA.c_admin.c_insert.c_compraArticulos
{
    class clsComprarArticulos
    {
        //Objeto de la clase MySQLConnection que permite conectarse con el servidor
        MySqlConnection conector;
        //Permite ejecutar comandos IDE-Servidor
        MySqlCommand comando;
        //Permite recibir resultados de los comandos realizados
        MySqlDataReader Lector;
        //La variable cadena guarda la cadena de conexion
        string cadena = Properties.Settings.Default.cadenaConn;
        public void insertarArticulos(int idProducto, int idProveedor, int cantidad)
        {
            if (verificarProducto(idProducto) != "" )
            {
                if (verificarProveedor(idProveedor) != "")
                {
                    int cantProducto = obtenerCantidad(idProducto);
                    int actualizarCant = cantidad + cantProducto;
                    insertarArticulo(idProducto,idProveedor,cantidad);
                    actualizarStock(idProducto,actualizarCant);
                    MessageBox.Show("Compra Registrada Exitosamente");
                }
                else
                {
                    MessageBox.Show("El proveedor al que intentas registrar este producto no existe");
                }
            }
            else
            {
                MessageBox.Show("El producto que intentas ingresar no existe, registrelo primero");
            }
        }
        public string verificarProducto(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre FROM articulos WHERE Codigo_A={0};",id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public string verificarProveedor(int id)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre_P FROM proveedor WHERE Codigo_P={0};",id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        
        public int obtenerCantidad(int id)
        {
            conector = new MySqlConnection(cadena);
            MySqlCommand comando;
            MySqlDataReader Lector;

            int Dato = 0;

            conector.Open();
            comando = new MySqlCommand(string.Format("SELECT Stock FROM articulos WHERE Codigo_A={0};", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetInt32(0);
            }
            conector.Close();

            return Dato;
        }
        public void insertarArticulo(int cProducto, int cProveedor, int cantidad)
        {
            conector = new MySqlConnection(cadena);
            conector.Open();
            comando = new MySqlCommand(string.Format("INSERT INTO compras(CProducto,Codigo_P,Cantidad)VALUES({0},{1},{2});",cProducto,cProveedor,cantidad), conector);
            Lector = comando.ExecuteReader();
            while (Lector.Read())
            {
            }
            conector.Close();
        }
        public void actualizarStock(int idProducto,int cantidad)
        {
            conector = new MySqlConnection(cadena);
            conector.Open();
            comando = new MySqlCommand(string.Format("UPDATE articulos SET Stock={0} WHERE Codigo_A={1};",cantidad,idProducto), conector);
            Lector = comando.ExecuteReader();
            while (Lector.Read())
            {
            }
            conector.Close();
        }
    }
}
