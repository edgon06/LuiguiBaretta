using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuiguiBaretta.Formularios.Módulos
{
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
            this.ButtonAnadirVenta.Click += new EventHandler(NumericUpDownCantidad_Llenar);
            this.ButtonDeshacer.Click += new EventHandler(NumericUpDownCantidad_Llenar);
            this.DataGridViewVentas.Columns[3].DefaultCellStyle.Format = "C2";
        }

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
            if (decimal.TryParse(this.TextBoxPagar.Text, out _))
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
    }
}
