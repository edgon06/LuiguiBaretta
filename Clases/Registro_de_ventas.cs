using System;
using System.Windows.Forms;
using System.Data;

namespace LuiguiBaretta.Clases
{
    public class Registro_de_ventas
    {
        public DataTable Datos
        {
            get { return ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from VistaVenta"); }
        }

        public DataTable Deudores
        {
            get { return ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from VistaVenta where Pago < Total"); }
        }

        public DataTable Filtro { get; set; }

        public DataTable Rango { get; set; }

        public DataTable Productos { get; set; }

        public void EstablecerRango_fecha(ref DataGridView vacio, string fecha1)
        {
            Rango = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from VistaVenta where fecha = '" + fecha1 + "'");
            vacio.DataSource = Rango;
            PintarDeudores(ref vacio);
        }

        public void EstablecerRango_fecha(ref DataGridView vacio, string fecha1, string fecha2)
        {
            Rango = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from VistaVenta where fecha between '" + fecha1 + "' and '" + fecha2 + "'");
            vacio.DataSource = Rango;
            PintarDeudores(ref vacio);
        }

        public void EstablecerFiltro(ref DataGridView vacio, String Cadena)
        {
            string salida_de_datos = "";
            string[] palabras_busqueda = Cadena.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_de_datos.Length == 0)
                {
                    salida_de_datos = "(Cast(ID_Venta As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Almacen Like '%" + palabra + "%' OR " +
                        "Direccion Like '%" + palabra + "%' OR " +
                        "Fecha Like '%" + palabra + "%' OR " +
                        "Cast(Total As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(Pago As varchar(30)) Like '%" + palabra + "%')";
                }
                else
                {
                    salida_de_datos += " And (Cast(ID_Venta As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Almacen Like '%" + palabra + "%' OR " +
                        "Direccion Like '%" + palabra + "%' OR " +
                        "Fecha Like '%" + palabra + "%' OR " +
                        "Cast(Total As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(Pago As varchar(30)) Like '%" + palabra + "%')";
                }
            }
            Filtro = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from VistaVenta where " + salida_de_datos);
            vacio.DataSource = Filtro;
            PintarDeudores(ref vacio);
        }

        public void EstablecerDeudores(ref DataGridView vacio)
        {
            vacio.DataSource = Deudores;
            PintarDeudores(ref vacio);
        }

        public void EstableceProductos(ref DataGridView dataGridView , int id_Venta)
        {
            Productos = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("SELECT dbo.Producto.Descripcion, dbo.VentaProducto.Cantidad FROM dbo.Producto " +
                "INNER JOIN dbo.VentaProducto ON dbo.Producto.Id_Producto = dbo.VentaProducto.ID_Producto and ID_Venta = " + id_Venta);
            dataGridView.DataSource = Productos;
            dataGridView.Columns[0].Width = 147;
            dataGridView.Columns[1].Width = 45;
        }

        public void EstablecerDatos(ref DataGridView vacio)
        {
            try
            {
                vacio.DataSource = this.Datos;
                vacio.Columns[0].Visible = false;
                vacio.Columns[4].DefaultCellStyle.Format = "C2";
                vacio.Columns[5].DefaultCellStyle.Format = "C2";
                vacio.Columns[1].Width = 110;
                vacio.Columns[2].Width = 115;
                vacio.Columns[3].Width = 70;
                vacio.Columns[4].Width = 80;
                vacio.Columns[5].Width = 80;
            }
            catch
            {

            }

            PintarDeudores(ref vacio);
        }

        public void PintarDeudores(ref DataGridView vacio)
        {
            for (int x = 0; x < vacio.RowCount; x++)
            {
                if (float.Parse(vacio.Rows[x].Cells[4].Value.ToString()) > float.Parse(vacio.Rows[x].Cells[5].Value.ToString()))
                {
                    vacio.Rows[x].DefaultCellStyle.BackColor = System.Drawing.Color.Salmon;
                }
            }
        }
    }
}
