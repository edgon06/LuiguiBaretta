﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LuiguiBaretta
{
    class Producto
    {
        private DataTable TablaFiltro;


        public DataTable Datos
        {
            get { return ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * From Producto"); }
        }

        public DataTable ProductosAgotandose
        {
            get { return ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from Producto where cantidad < 10 and cantidad > 0"); }
        }

        public DataTable ProductosAgotados
        {
            get { return ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from Producto where cantidad = 0"); }
        }

        public DataTable Filtro
        {
            get { return TablaFiltro; }
            set { TablaFiltro = value; }
        }

        public void EstablecerFiltro(String Cadena)
        {
            string salida_de_datos = "";
            string[] palabras_busqueda = Cadena.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_de_datos.Length == 0)
                {
                    salida_de_datos = "(Cast(ID_Producto As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Codigo Like '%" + palabra + "%' OR " +
                        "Referencia Like '%" + palabra + "%' OR " +
                        "Descripcion Like '%" + palabra + "%' OR " +
                        "Talla Like '%" + palabra + "%' OR " +
                        "Cast(PrecioVenta As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(GrupoPrimavera As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(CasaFaska As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(Cantidad As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(CantidadPaquete As varchar(30)) Like '%" + palabra + "%')";
                }
                else
                {
                    salida_de_datos += "And (Cast(ID_Producto As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Codigo Like '%" + palabra + "%' OR " +
                        "Referencia Like '%" + palabra + "%' OR " +
                        "Descripcion Like '%" + palabra + "%' OR " +
                        "Talla Like '%" + palabra + "%' OR " +
                        "Cast(PrecioVenta As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(GrupoPrimavera As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(CasaFaska As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(Cantidad As varchar(30)) Like '%" + palabra + "%' OR " +
                        "Cast(CantidadPaquete As varchar(30)) Like '%" + palabra + "%')";
                }
            }
            Filtro = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select * from Producto where " + salida_de_datos);
        }
    }
}
