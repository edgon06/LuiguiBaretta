using System;
using System.Windows.Forms;
using LuiguiBaretta.Clases;

namespace LuiguiBaretta
{
    public partial class Ventana_Prinsipal : Form
    {
        
        Registro_de_ventas Registro_De_Ventas = new Registro_de_ventas();
        Cliente Cliente = new Cliente();
        Producto Producto = new Producto();

        public Ventana_Prinsipal()
        {
            InitializeComponent();
            this.ButtonAnadirVenta.Click += new EventHandler(NumericUpDownCantidad_Llenar);
            this.ButtonDeshacer.Click += new EventHandler(NumericUpDownCantidad_Llenar);
            this.DataGridViewVentas.Columns[3].DefaultCellStyle.Format = "C2";
        }

        private void Ventana_Prinsipal_Load(object sender, EventArgs e)
        {
            login Inicio = new login();
            Inicio.ShowDialog();
            if (ConsultasBaseDeDatos.CadenaConexion == null)
                this.Close();
            
        }

        private void Ventana_Prinsipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.ButtonGenerarVenta.Enabled)
                if (MessageBox.Show("Estás en medio de una transaccion ¿Seguro que quieres cerrar el programa?",
                    "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            this.PanelVentas.Visible = true;
            this.PanelBotonesVentas.Visible = true;
            this.PanelRegistroDeVentas.Visible = false;
            this.PanelBotonesRegisroDeVentas.Visible = false;
            this.PanelCliente.Visible = false;
            this.PanelBotonesCliente.Visible = false;
            this.PanelInventario.Visible = false;
            this.PanelBotonesInventario.Visible = false;
        }

        private void buttonRegistroDeVentas_Click(object sender, EventArgs e)
        {
            this.PanelVentas.Visible = false;
            this.PanelBotonesVentas.Visible = false;
            this.PanelRegistroDeVentas.Visible = true;
            this.PanelBotonesRegisroDeVentas.Visible = true;
            this.PanelCliente.Visible = false;
            this.PanelBotonesCliente.Visible = false;
            this.PanelInventario.Visible = false;
            this.PanelBotonesInventario.Visible = false;
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            this.PanelVentas.Visible = false;
            this.PanelBotonesVentas.Visible = false;
            this.PanelRegistroDeVentas.Visible = false;
            this.PanelBotonesRegisroDeVentas.Visible = false;
            this.PanelCliente.Visible = true;
            this.PanelBotonesCliente.Visible = true;
            this.PanelInventario.Visible = false;
            this.PanelBotonesInventario.Visible = false;
        }

        private void buttonInventario_Click(object sender, EventArgs e)
        {
            this.PanelVentas.Visible = false;
            this.PanelBotonesVentas.Visible = false;
            this.PanelRegistroDeVentas.Visible = false;
            this.PanelBotonesRegisroDeVentas.Visible = false;
            this.PanelCliente.Visible = false;
            this.PanelBotonesCliente.Visible = false;
            this.PanelInventario.Visible = true;
            this.PanelBotonesInventario.Visible = true;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Ventas

        private void ButtonGenerarVenta_Click(object sender, EventArgs e)
        {
            this.ComboBoxAlmacen.Enabled = true;
            this.ComboBoxDireccion.Enabled = true;
            this.NumericUpDownCantidad.Enabled = true;
            this.ComboBoxTalla.Enabled = true;
            this.ComboBoxDescripcionDelProducto.Enabled = true;
            this.ButtonGenerarVenta.Enabled = false;
            this.ButtonCancelarVenta.Enabled = true;
        }

        private void ButtonCancelarVenta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpiarVenta();
            }
        }

        private void ComboBoxAlmacen_Llenar(object sender, EventArgs e)
        {
            if (this.ComboBoxAlmacen.Enabled)
            {
                this.ComboBoxAlmacen.DataSource = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select Almacen From Cliente Group By Almacen");
                this.ComboBoxAlmacen.DisplayMember = "Almacen";
            }
            else
            {
                this.ComboBoxAlmacen.DataSource = null;
            }
        }

        private void ComboBoxDireccion_Llenar(object sender, EventArgs e)
        {
            if (this.ComboBoxDireccion.Enabled)
            {
                this.ComboBoxDireccion.DataSource = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select Direccion From Cliente Where Almacen Like '" +
                    this.ComboBoxAlmacen.Text + "'");
                this.ComboBoxDireccion.DisplayMember = "Direccion";
            }
            else
            {
                this.ComboBoxDireccion.DataSource = null;
            }
        }

        private void ComboBoxDescripcionDelProducto_Llenar(object sender, EventArgs e)
        {
            if (this.ComboBoxDescripcionDelProducto.Enabled)
            {
                this.ComboBoxDescripcionDelProducto.DataSource = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select Descripcion From Producto Group By Descripcion");
                this.ComboBoxDescripcionDelProducto.DisplayMember = "Descripcion";
            }
            else
            {
                this.ComboBoxDescripcionDelProducto.DataSource = null;
            }
        }

        private void ComboBoxTalla_Llenar(object sender, EventArgs e)
        {
            if (this.ComboBoxTalla.Enabled)
            {
                this.ComboBoxTalla.DataSource = ConsultasBaseDeDatos.ObtenerTablaDeBDLuiguibaretta("Select Talla From Producto Where Descripcion Like '" +
                    this.ComboBoxDescripcionDelProducto.Text + "'");
                this.ComboBoxTalla.DisplayMember = "Talla";
            }
            else
            {
                this.ComboBoxTalla.DataSource = null;
            }

        }

        private void NumericUpDownCantidad_Llenar(object sender, EventArgs e)
        {
            if (this.NumericUpDownCantidad.Enabled)
            {
                this.NumericUpDownCantidad.Maximum = (decimal)(ConsultasBaseDeDatos.ObtenerValorFloatDeBDLuiguiBaretta("Select Cantidad From Producto Where Descripcion Like '"
                    + this.ComboBoxDescripcionDelProducto.Text + "' And Talla Like '" + this.ComboBoxTalla.Text + "'") - Valor_paraNumericdecimal());
                if (this.NumericUpDownCantidad.Maximum > 0)
                {
                    this.NumericUpDownCantidad.Minimum = 1;
                    this.LabelCantidadMax.Text = "Max " + this.NumericUpDownCantidad.Maximum;
                    this.LabelError.Visible = false;
                    this.ButtonAnadirVenta.Enabled = true;
                }
                else
                {
                    this.LabelError.Text = "La cantidad del producto seleccionado es 0";
                    this.LabelCantidadMax.Text = "Max 0";
                    this.LabelError.Visible = true;
                    this.ButtonAnadirVenta.Enabled = false;
                }
            }
            else
            {
                this.NumericUpDownCantidad.Maximum = 0;
            }
        }

        private void ButtonAnadirVenta_Click(object sender, EventArgs e)
        {
            float Precio = ConsultasBaseDeDatos.ObtenerValorFloatDeBDLuiguiBaretta("Select (PrecioVenta * GrupoPaquete) From Producto Where Descripcion Like '" +
                ComboBoxDescripcionDelProducto.Text + "' And Talla Like '" + ComboBoxTalla.Text + "'");
            Precio *= (float)NumericUpDownCantidad.Value;
            this.DataGridViewVentas.Rows.Add(ComboBoxDescripcionDelProducto.Text, ComboBoxTalla.Text, NumericUpDownCantidad.Value, Precio);
            this.ButtonDeshacer.Enabled = true;
            this.TextBoxPagar.Enabled = true;
            EstablecerValoresTotales();
        }

        private void ButtonDeshacer_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewVentas.Rows.Count > 0)
            {
                this.DataGridViewVentas.Rows.RemoveAt(this.DataGridViewVentas.Rows.Count - 1);
                EstablecerValoresTotales();
                if (this.DataGridViewVentas.Rows.Count == 0)
                {
                    this.ButtonDeshacer.Enabled = false;
                    this.ButtonPagar.Enabled = false;
                    this.TextBoxPagar.Enabled = false;
                }
            }
            else
            {
                this.ButtonDeshacer.Enabled = false;
                this.ButtonPagar.Enabled = false;
                this.TextBoxPagar.Enabled = false;
            }
        }

        private void TextBoxPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void TextBoxPagar_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(TextBoxPagar.Text, out _))
                ButtonPagar.Enabled = true;
            else
                ButtonPagar.Enabled = false;
            if(decimal.TryParse(this.TextBoxPagar.Text, out _))
            {
                if (decimal.Parse(this.LabelTotalNum.Text) - decimal.Parse(this.TextBoxPagar.Text) < 0)
                {
                    decimal cambio = decimal.Parse(this.LabelTotalNum.Text) - decimal.Parse(this.TextBoxPagar.Text);
                    cambio *= -1;
                    this.LabelNumCambio.Text = (cambio.ToString("C2"));
                }
            }
            else
            {
                this.LabelNumCambio.Text = "B/.0.00";
            }
        }

        private void ButtonPagar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("Exec RegistrarVenta '" +
                    this.ComboBoxAlmacen.Text + "', '" +
                    this.ComboBoxDireccion.Text + "', '" +
                    DateTime.Now.ToString("yyyy-MM-dd") + "', " +
                    this.LabelTotalNum.Text + ", " +
                    this.TextBoxPagar.Text);

                int ID_Venta = (int)ConsultasBaseDeDatos.ObtenerValorEnteroDeBDLuiguiBaretta("Select Max(ID_Venta) from Venta");
                for (int x = 0; x < this.DataGridViewVentas.Rows.Count; x++)
                {
                    ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("Exec RegistrarVentaProducto " +
                        ID_Venta + ", '" +
                        this.DataGridViewVentas.Rows[x].Cells[0].Value + "', " +
                        this.DataGridViewVentas.Rows[x].Cells[1].Value + ", " +
                        this.DataGridViewVentas.Rows[x].Cells[2].Value);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Venta terminada con éxito", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarVenta();
            }

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Registro de ventas

        private void PanelRegistroDeVentas_VisibleChanged(object sender, EventArgs e)
        {
            if (PanelRegistroDeVentas.Visible)
            {
                Registro_De_Ventas.EstablecerDatos(ref DatagridViewRegistroDeVentas);
                TextBoxNuevoPago.Text = "";
                PanelNuevoPago.Visible = false;
            }
        }

        private void TextBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (PanelRegistroDeVentas.Visible)
            {
                Registro_De_Ventas.EstablecerFiltro(this.TextBoxBuscar.Text);
                this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Filtro;
            }

            if (PanelCliente.Visible)
            {
                Cliente.EstablecerFiltro(this.TextBoxBuscar.Text);
                this.DataGridViewClientes.DataSource = Cliente.Filtro;
            }

            if (PanelInventario.Visible)
            {
                Producto.EstablecerFiltro(this.TextBoxBuscar.Text);
                this.DataGridViewInventario.DataSource = Producto.Filtro;
            }
        }

        private void ButtonDeudores_Click(object sender, EventArgs e)
        {
            this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Deudores;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.DateTimePickerRango1.Enabled = this.CheckBoxRango1.Checked;
            this.CheckBoxRango2.Enabled = this.CheckBoxRango1.Checked;
            this.CheckBoxRango2.Checked = false;
        }

        private void CheckBoxRango2_CheckedChanged(object sender, EventArgs e)
        {
            this.DateTimePickerRango2.Enabled = this.CheckBoxRango2.Checked;
        }

        private void ButtonBuscarRango_Click(object sender, EventArgs e)
        {
            if (this.CheckBoxRango1.Checked && !this.CheckBoxRango2.Checked)
            {
                this.Registro_De_Ventas.EstablecerRango_fecha(this.DateTimePickerRango1.Text);
                this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Rango;
            }
            else if (this.CheckBoxRango1.Checked && this.CheckBoxRango2.Checked)
            {
                Registro_De_Ventas.EstablecerRango_fecha(this.DateTimePickerRango1.Text, this.DateTimePickerRango2.Text);
                this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Rango;
            }
        }

        private void ButtonTodos_Click(object sender, EventArgs e)
        {
            this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Datos;
        }

        private void DatagridViewRegistroDeVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridViewRegistroDeVentas.CurrentRow.Selected = true;
            Registro_De_Ventas.EstableceProductos(ref this.DataGridViewRegVentaProd, int.Parse(this.DatagridViewRegistroDeVentas.CurrentRow.Cells[0].Value.ToString()));
            TextBoxNuevoPago.Text = "";
            PanelNuevoPago.Visible = false;
        }

        private void DatagridViewRegistroDeVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            float deuda = float.Parse(DatagridViewRegistroDeVentas.CurrentRow.Cells[4].Value.ToString()) - float.Parse(DatagridViewRegistroDeVentas.CurrentRow.Cells[5].Value.ToString());
            if(deuda > 0)
            {
                LabelNumDeuda.Text = deuda.ToString("0.00");
                PanelNuevoPago.Visible = true;
            }
            
        }

        private void TextBoxNuevoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void TextBoxNuevoPago_TextChanged(object sender, EventArgs e)
        {                
            if (float.TryParse(this.TextBoxNuevoPago.Text, out _))
            {
                if (float.Parse(this.LabelNumDeuda.Text) - float.Parse(this.TextBoxNuevoPago.Text) < 0)
                {
                    decimal deuda = decimal.Parse(this.LabelNumDeuda.Text) - decimal.Parse(this.TextBoxNuevoPago.Text);
                    deuda *= -1;
                    this.LabelNumCambioNuevoPago.Text = (deuda.ToString("C2"));
                }
                        ButtonActualizarPago.Enabled = true;
                    }
            else
            {
                LabelNumCambioNuevoPago.Text = "B/.0.00";
                ButtonActualizarPago.Enabled = false;
            }
        }

        private void DatagridViewRegistroDeVentas_DataSourceChanged(object sender, EventArgs e)
        {
            TextBoxNuevoPago.Text = "";
            PanelNuevoPago.Visible = false;
        }

        private void ButtonActualizarPago_Click(object sender, EventArgs e)
        {
            ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("exec pago_opc1 '" + 
                TextBoxNuevoPago.Text + "', '" +
                DatagridViewRegistroDeVentas.CurrentRow.Cells[0].Value.ToString() + "', '" +
                LabelNumDeuda.Text + "'");
            DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Datos;
            MessageBox.Show("Pago Realizado con éxito", "Pago Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Cliente

        private void PanelCliente_VisibleChanged(object sender, EventArgs e)
        {
            if(PanelCliente.Visible)
                this.DataGridViewClientes.DataSource = Cliente.Datos;
        }

        private void ButtonNuevoCliente_Click(object sender, EventArgs e)
        {
            Editar_Cliente NuevoCliente = new Editar_Cliente("Registrar");
            NuevoCliente.ShowDialog();
            this.DataGridViewClientes.DataSource = Cliente.Datos;
        }

        private void ButtonEditarCliente_Click(object sender, EventArgs e)
        {
            Editar_Cliente EditarCliente = new Editar_Cliente("Editar", ref this.DataGridViewClientes);
            EditarCliente.ShowDialog();
            this.DataGridViewClientes.DataSource = Cliente.Datos;
        }

        private void DataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewClientes.CurrentRow.Selected = true;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Inventario

        private void PanelInventario_VisibleChanged(object sender, EventArgs e)
        {
            if(PanelInventario.Visible)
                this.DataGridViewInventario.DataSource = Producto.Datos;
        }

        private void ButtonNuevoProducto_Click(object sender, EventArgs e)
        {
            AnadirEditatProducto anadirEditatProducto = new AnadirEditatProducto("Agregar");
            anadirEditatProducto.ShowDialog();
            this.DataGridViewInventario.DataSource = Producto.Datos;
        }

        private void ButtonEditarProducto_Click(object sender, EventArgs e)
        {
            AnadirEditatProducto anadirEditatProducto = new AnadirEditatProducto("Editar", ref this.DataGridViewInventario);
            anadirEditatProducto.ShowDialog();
            this.DataGridViewInventario.DataSource = Producto.Datos;
        }

        private void DataGridViewInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DataGridViewInventario.CurrentRow.Selected = true;
        }

        private void ButtonProductosAgotados_Click(object sender, EventArgs e)
        {
            this.DataGridViewInventario.DataSource = Producto.ProductosAgotandose;
        }

        private void ButtonVerTodosLosProductos_Click(object sender, EventArgs e)
        {
            this.DataGridViewInventario.DataSource = Producto.Datos;
        }

        private void ButtonProductosAgotados_Click_1(object sender, EventArgs e)
        {
            this.DataGridViewInventario.DataSource = Producto.ProductosAgotados;
        }
    }
}
