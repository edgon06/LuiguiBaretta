using System;
using System.Windows.Forms;

namespace LuiguiBaretta.Formularios.Módulos
{
    public partial class FormInventario : Form
    {
        readonly Producto Producto = new Producto();

        public FormInventario(ref ToolStripTextBox Filtro)
        {
            InitializeComponent();
            this.Producto.EstablecerDatos(ref DataGridViewInventario);
            Filtro.KeyPress += new KeyPressEventHandler(this.Filtrar);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            ToolStripTextBox filtro = (ToolStripTextBox)sender;
            Producto.EstablecerFiltro(ref DataGridViewInventario, filtro.Text);
        }

        private void ButtonNuevoProducto_Click(object sender, EventArgs e)
        {
            AnadirEditatProducto anadirEditatProducto = new AnadirEditatProducto("Agregar");
            anadirEditatProducto.ShowDialog();
            this.Producto.EstablecerDatos(ref DataGridViewInventario);
        }

        private void ButtonEditarProducto_Click(object sender, EventArgs e)
        {
            AnadirEditatProducto anadirEditatProducto = new AnadirEditatProducto("Editar", ref this.DataGridViewInventario);
            anadirEditatProducto.ShowDialog();
            this.Producto.EstablecerDatos(ref DataGridViewInventario);
        }

        private void DataGridViewInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DataGridViewInventario.CurrentRow.Selected = true;
        }

        private void ButtonProductosAgotandose_Click(object sender, EventArgs e)
        {
            this.DataGridViewInventario.DataSource = Producto.ProductosAgotandose;
        }

        private void ButtonVerTodosLosProductos_Click(object sender, EventArgs e)
        {
            this.Producto.EstablecerDatos(ref DataGridViewInventario);
        }

        private void ButtonProductosAgotados_Click(object sender, EventArgs e)
        {
            this.DataGridViewInventario.DataSource = Producto.ProductosAgotados;
        }
    }
}
