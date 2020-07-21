using System;
using System.Windows.Forms;
using LuiguiBaretta.Clases;

namespace LuiguiBaretta.Formularios
{
    public partial class FormRegistro_de_ventas : Form
    {
        Registro_de_ventas Registro_De_Ventas = new Registro_de_ventas();

        public FormRegistro_de_ventas(ref ToolStripTextBox Filtro)
        {
            InitializeComponent();
            Registro_De_Ventas.EstablecerDatos(ref DatagridViewRegistroDeVentas);
            Filtro.KeyPress += new KeyPressEventHandler(this.Filtrar);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            ToolStripTextBox filtro = (ToolStripTextBox)sender;
            Registro_De_Ventas.EstablecerFiltro(ref DatagridViewRegistroDeVentas, filtro.Text);
        }

        private void ButtonDeudores_Click(object sender, EventArgs e)
        {
            Registro_De_Ventas.EstablecerDeudores(ref DatagridViewRegistroDeVentas);
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
                this.Registro_De_Ventas.EstablecerRango_fecha(ref DatagridViewRegistroDeVentas, this.DateTimePickerRango1.Text);
                this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Rango;
            }
            else if (this.CheckBoxRango1.Checked && this.CheckBoxRango2.Checked)
            {
                Registro_De_Ventas.EstablecerRango_fecha(ref DatagridViewRegistroDeVentas, this.DateTimePickerRango1.Text, this.DateTimePickerRango2.Text);
                this.DatagridViewRegistroDeVentas.DataSource = Registro_De_Ventas.Rango;
            }
        }

        private void ButtonTodos_Click(object sender, EventArgs e)
        {
            Registro_De_Ventas.EstablecerDatos(ref DatagridViewRegistroDeVentas);
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
            if (deuda > 0)
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
            Registro_De_Ventas.EstablecerDatos(ref DatagridViewRegistroDeVentas);
            MessageBox.Show("Pago Realizado con éxito", "Pago Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormRegistro_de_ventas_Load(object sender, EventArgs e)
        {
            Registro_De_Ventas.EstablecerDatos(ref DatagridViewRegistroDeVentas);
        }
    }
}
