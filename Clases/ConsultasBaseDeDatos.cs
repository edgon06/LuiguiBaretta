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
        //public static string CadenaConexion = "Data Source=" + System.Environment.MachineName + ";Initial Catalog=LuiguiBaretta;Integrated Security=True";
        public static string CadenaConexion;
        public static string ServerName;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Sentencia, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, Sentencia, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlConnection conexion = new SqlConnection("Data Source=" + ServerName + ";Initial Catalog=LuiguiBaretta;Integrated Security=True");
            try
            {
                conexion.Open();
                conexion.Close();
            }
            catch (Exception)
            {
                if (MessageBox.Show("¿Desea crear la base de datos?", "No hay base de datos existente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    conexion = new SqlConnection("Data Source=" + ServerName + ";Initial Catalog=master;Integrated Security=True");
                    try
                    {
                        SqlCommand creación = new SqlCommand("Create database LuiguiBaretta", conexion);
                        conexion.Open();
                        creación.ExecuteNonQuery();
                        conexion.Close();
                        
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
                SqlConnection objcon = new SqlConnection("Data Source = " + ServerName + ";Initial Catalog=master;Integrated Security=True");
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

