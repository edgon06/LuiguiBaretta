using System.Data;
using System.Windows.Forms;

namespace LuiguiBaretta
{
    class Cliente
    {
        public DataTable Datos
        {
            get { return ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * From Cliente"); }
        }

        public DataTable Filtro { get; set; }

        public void EstablecerFiltro(ref DataGridView vacio, string Cadena)
        {
            string salida_de_datos = "";
            string[] palabras_busqueda = Cadena.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_de_datos.Length == 0)
                {
                    salida_de_datos = "(Cast(ID_Cliente As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Almacen Like '%" + palabra + "%' OR " +
                        "Direccion Like '%" + palabra + "%' OR " +
                        "Telefono Like '%" + palabra + "%' OR " +
                        "RUC Like '%" + palabra + "%')";
                }
                else
                {
                    salida_de_datos += " And (Cast(ID_Cliente As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Almacen Like '%" + palabra + "%' OR " +
                        "Direccion Like '%" + palabra + "%' OR " +
                        "Telefono Like '%" + palabra + "%' OR " +
                        "RUC Like '%" + palabra + "%')";
                }
            }
            Filtro = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from Cliente where " + salida_de_datos);
            vacio.DataSource = Filtro;
        }
    }
}
