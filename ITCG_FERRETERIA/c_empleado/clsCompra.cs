using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace ITCG_FERRETERIA.c_empleado
{
    class clsCompra
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


        private int idCliente;
        private int idProducto;
        private double precio;
        private double subtotal;
        private double total;
        public clsCompra() {
            idCliente = 0;
            idProducto = 0;
            precio = 0.0;
            subtotal = 0.0;
            total = 0.0;
        }
        public void nuevoProducto(int idclie, int idProd) {
            if (verificarProducto(idProd) != "")
            {
                idCliente = idclie;
                idProducto = idProd;
                precio = obtenerPrecio(idProducto);
                subtotal = subtotal + precio;
                compraEnProceso(idCliente, idProducto);
            }
            else
            {
                MessageBox.Show("Codigo de Producto Incorrecto");
            }
        }
        public void compraFinalizada(int idclie, int idProd)
        {
            if (verificarProducto(idProd) != "")
            {
                idCliente = idclie;
                idProducto = idProd;
                precio = obtenerPrecio(idProducto);
                subtotal = subtotal + precio;
                double IVA = subtotal * .16;
                double total = subtotal + IVA;
                compraFinalizada(idCliente, idProducto, subtotal, IVA, total);
            }
            else
            {
                MessageBox.Show("Codigo de Producto Incorrecto");
            }
        }
        public void compraEnProceso(int idClie,int idprod)
        {
            MySqlCommand comando;

            comando = new MySqlCommand("ventaenProceso", conector);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@_codCliente", idClie);
            comando.Parameters.AddWithValue("@_codProducto", idprod);

            conector.Open();

            int res = comando.ExecuteNonQuery();

            if (res == 1)
            {
            }
            conector.Close();
        }
        public void compraFinalizada(int idClie,int idprod, double subtotal, double iva, double total)
        {
            MySqlCommand comando;

            comando = new MySqlCommand("ventaFinalizada", conector);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@_idClie", idClie);
            comando.Parameters.AddWithValue("@_idProd", idprod);
            comando.Parameters.AddWithValue("@_subtotal", subtotal);
            comando.Parameters.AddWithValue("@_IVA", iva);
            comando.Parameters.AddWithValue("@_total", total);

            conector.Open();

            int res = comando.ExecuteNonQuery();

            if (res == 1)
            {
            }
            conector.Close();
        }
        public string verificarProducto(int idProducto)
        {
            conector = new MySqlConnection(cadena);

            conector.Open();

            string Dato = "";

            comando = new MySqlCommand(string.Format("SELECT Nombre FROM ferreteria.articulos WHERE Codigo_A={0} and Estado='Activo';", idProducto), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetString(0);
            }
            conector.Close();
            return Dato;
        }
        public double obtenerPrecio(int id)
        {
            conector = new MySqlConnection(cadena);
            MySqlCommand comando;
            MySqlDataReader Lector;

            double Dato = 0.0;

            conector.Open();
            comando = new MySqlCommand(string.Format("SELECT Precio FROM articulos WHERE Codigo_A={0};", id), conector);

            Lector = comando.ExecuteReader();

            while (Lector.Read())
            {
                Dato = Lector.GetDouble(0);
            }
            conector.Close();

            return Dato;
        }
        public double getSubtotal()
        {
            return subtotal;
        }
    }
}
