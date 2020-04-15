using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace LuiguiBaretta
{
    class ConsultasBaseDeDatos
    {
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
            catch (Exception ex)
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

        public static void Creacion_base_de_datos()
        {
            if (MessageBox.Show("¿Desea crear la base de datos?", "La Base de datos LuiguiBaretta no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    ProcessStartInfo cmd = new ProcessStartInfo("sqlcmd", " -i \"" + Directory.GetCurrentDirectory() + "\\SQL_Creacion.sql\"");

                    cmd.UseShellExecute = false;
                    cmd.CreateNoWindow = true;
                    cmd.RedirectStandardOutput = true;

                    Process ejecutar = new Process();
                    ejecutar.StartInfo = cmd;
                    ejecutar.Start();
                    ejecutar.StandardOutput.ReadToEnd();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al crear base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static DataTable loginarametre(string Sentencia)
        {

            DataSet DataTabla = new DataSet("Tabla");
            try
            {
                SqlConnection objcon = new SqlConnection("Data Source = ;Initial Catalog=master;Integrated Security=True");
                objcon.Open();
                SqlDataAdapter data = new SqlDataAdapter(Sentencia, objcon);
                objcon.Close();
                data.Fill(DataTabla, "Tabla");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return default;
            }
            return DataTabla.Tables[0];
        }
    }
}

