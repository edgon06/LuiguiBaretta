using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LuiguiBaretta
{
    class ConsultasBaseDeDatos
    {
        //static string CadenaConexion = "Data = LAPTOP-JEEI4HN0;Initial Catalog=LuiguiBaretta;Integrated Security=True";
        public static string CadenaConexion;

        public static DataTable ObtenerTablaDeBDLuiguibaretta(string Sentencia)
        {
            DataSet DataTabla = new DataSet("Tabla");
            try
            {
                SqlConnection objcon = new SqlConnection(CadenaConexion);
                objcon.Open();
                SqlDataAdapter data = new SqlDataAdapter(Sentencia, objcon);
                objcon.Close();
                data.Fill(DataTabla, "Tabla");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
            return DataTabla.Tables[0];
        }

        public static float ObtenerValorFloatDeBDLuiguiBaretta(string Sentencia)
        {
            SqlCommand Comando = null;
            SqlDataReader Lectura = null;
            float Valor = 0;
            try
            {
                SqlConnection objcon = new SqlConnection(CadenaConexion);
                objcon.Open();
                Comando = new SqlCommand(Sentencia, objcon);
                Lectura = Comando.ExecuteReader();
                if (Lectura.Read())
                {
                    Valor = float.Parse(Lectura.GetValue(0).ToString());
                }
                objcon.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, Sentencia, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return Valor;
        }

        public static int ObtenerValorEnteroDeBDLuiguiBaretta(string Sentencia)
        {
            SqlCommand Comando = null;
            SqlDataReader Lectura = null;
            int Valor = 0;
            try
            {
                SqlConnection objcon = new SqlConnection(CadenaConexion);
                objcon.Open();
                Comando = new SqlCommand(Sentencia, objcon);
                Lectura = Comando.ExecuteReader();
                if (Lectura.Read())
                {
                    Valor = (int)Lectura.GetValue(0);
                }
                objcon.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, Sentencia, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            return Valor;
        }

        public static void EjecutarProcedimientoEnBDLuiguiBaretta(string Sentencia)

        {
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            try
            {
                SqlCommand Comando = new SqlCommand(Sentencia, conexion);
                conexion.Open();
                Comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(Sentencia + "Error: " + e.Message, "Error al ejecutar consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool Creacion_base_de_datos()
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + System.Environment.MachineName + ";Initial Catalog=LuiguiBaretta;Integrated Security=True");
            try
            {
                conexion.Open();
                conexion.Close();
            }
            catch (Exception)
            {
                if (MessageBox.Show("¿Desea crear la base de datos?", "No hay base de datos existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    conexion = new SqlConnection("Data Source=" + System.Environment.MachineName + ";Initial Catalog=master;Integrated Security=True");
                    try
                    {
                        SqlCommand creación = new SqlCommand("Create database LuiguiBaretta", conexion);
                        conexion.Open();
                        creación.ExecuteNonQuery();
                        conexion.Close();
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        //conexion = new SqlConnection("Data Source=" + System.Environment.MachineName + ";Initial Catalog=LuiguiBaretta;Integrated Security=True");
                        //SqlCommand creacion = new SqlCommand("Create Table Producto( " +
                        //        "Id_Producto int Primary key not null, " +
                        //        "Codigo varchar(20), " +
                        //        "Referencia varchar(10), " +
                        //        "Descripcion varchar(50), " +
                        //        "Talla varchar(5), " +
                        //        "PrecioVenta Decimal Default 0, " +
                        //        "GrupoPrimavera Decimal Default 0, " +
                        //        "CasaFaska Decimal Default 0, " +
                        //        "Cantidad Decimal Default 0, " +
                        //        "CantidadPaquete Decimal Default 0, " +
                        //        "GrupoPaquete int Default 0) " +
                        //    "Create Table ProveerProducto( " +
                        //        "ID_Recarga int Primary key not null, " +
                        //        "ID_Producto int, " +
                        //        "Cantidad Decimal Default 0, " +
                        //        "Fecha Date " +
                        //        "Foreign key(ID_Producto) references Producto(ID_Producto)) " +
                        //    "Create table Cliente( " +
                        //        "ID_Cliente int Primary key not null, " +
                        //        "Almacen Varchar(50), " +
                        //        "Direccion Varchar(50), " +
                        //        "Telefono Varchar(50), " +
                        //        "RUC text, " +
                        //        "Razon_Social text) " +
                        //    "Create Table Venta( " +
                        //        "ID_Venta int IDENTITY(0, 1) Primary key not null, " +
                        //        "Cliente int, " +
                        //        "Fecha date, " +
                        //        "Total Decimal Default 0, " +
                        //        "Pago Decimal Default 0 " +
                        //        "Foreign key(Cliente) references Cliente(ID_Cliente)) " +
                        //    "Create Table VentaProducto( " +
                        //        "ID_Venta int, " +
                        //        "ID_Producto int, " +
                        //        "Cantidad int Default 0 " +
                        //        "Foreign key(ID_Producto) references Producto(ID_Producto), " +
                        //        "Foreign key(ID_Venta) references Venta(ID_Venta)) ", conexion);
                        //conexion.Open();
                        //creacion.ExecuteNonQuery();
                        //conexion.Close();
                        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        //"Insert into ProveerProducto(ID_Recarga, Id_Producto, Cantidad, Fecha) values (0,0,0,'" + DateTime.Now.ToString("yyyy-MM-dd") + "'); " +
                        //creacion = new SqlCommand("Insert into Producto(Id_producto, Codigo, Referencia, Descripcion, Talla, PrecioVenta, GrupoPrimavera, CasaFaska, Cantidad, CantidadPaquete, GrupoPaquete) values (0,'Desconocido','Desconocido','Desconocido','Desco',0,0,0,0,0,0); " +
                        //    "Insert into Cliente(Id_cliente, Almacen, Direccion, Telefono, RUC, Razon_Social) values (0,'Desconocido','Desconocido','Desconocido','Desconocido','Desconocido'); ", conexion);
                        //conexion.Open();
                        //creacion.ExecuteNonQuery();
                        //conexion.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error al crear base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conexion.Close();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static DataTable loginarametre(string Sentencia)
        {

            DataSet DataTabla = new DataSet("Tabla");
            try
            {
                SqlConnection objcon = new SqlConnection("Data Source = " + System.Environment.MachineName + ";Initial Catalog=master;Integrated Security=True");
                objcon.Open();
                SqlDataAdapter data = new SqlDataAdapter(Sentencia, objcon);
                objcon.Close();
                data.Fill(DataTabla, "Tabla");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
            return DataTabla.Tables[0];
        }
    }
}

