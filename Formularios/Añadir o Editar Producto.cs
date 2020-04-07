using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuiguiBaretta
{
    public partial class AnadirEditatProducto : Form
    {
        private int ID = 0;

        public AnadirEditatProducto(String metodo)
        {
            InitializeComponent();
            this.LabelTitulo.Text = metodo + " Producto";
        }

        public AnadirEditatProducto(String metodo, ref DataGridView dataGridView)
        {
            InitializeComponent();
            this.LabelTitulo.Text = metodo + " Producto";
            this.ID = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
            this.TextBoxCodigo.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            this.TextBoxReferencia.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            this.TextBoxDescripcion.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            this.TextBoxTalla.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            this.TextBoxPrecioVenta.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            this.TextBoxGrupoPrimavera.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            this.TextBoxCasaFaska.Text = dataGridView.CurrentRow.Cells[7].Value.ToString();
            this.TextBoxCantidad.Text = dataGridView.CurrentRow.Cells[8].Value.ToString();
            this.TextBoxCantidadPaquete.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
            this.TextBoxGrupoDePaquete.Text = dataGridView.CurrentRow.Cells[10].Value.ToString();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (this.LabelTitulo.Text == "Agregar Producto")
            {
                ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("exec RegistrarProducto '" +
                    this.TextBoxCodigo.Text + "', '" +
                    this.TextBoxReferencia.Text + "', '" +
                    this.TextBoxDescripcion.Text + "', '" +
                    this.TextBoxTalla.Text + "', " +
                    this.TextBoxPrecioVenta.Text + ", " +
                    this.TextBoxGrupoPrimavera.Text + ", " +
                    this.TextBoxCasaFaska.Text + ", " +
                    this.TextBoxCantidad.Text + ", " +
                    this.TextBoxCantidadPaquete.Text + ", " +
                    this.TextBoxGrupoDePaquete.Text);
                MessageBox.Show("Registro Realiado con éxito", "Finalizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("exec EditarProducto " +
                    this.ID + ", '" +
                    this.TextBoxCodigo.Text + "', '" +
                    this.TextBoxReferencia.Text + "', '" +
                    this.TextBoxDescripcion.Text + "', '" +
                    this.TextBoxTalla.Text + "', " +
                    this.TextBoxPrecioVenta.Text + ", " +
                    this.TextBoxGrupoPrimavera.Text + ", " +
                    this.TextBoxCasaFaska.Text + ", " +
                    this.TextBoxCantidad.Text + ", " +
                    this.TextBoxCantidadPaquete.Text + ", " +
                    this.TextBoxGrupoDePaquete.Text);
                MessageBox.Show("Edicion Realiada con éxito", "Finalizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
