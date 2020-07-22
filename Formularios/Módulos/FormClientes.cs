using System;
using System.Windows.Forms;

namespace LuiguiBaretta.Formularios.Módulos
{
    public partial class FormClientes : Form
    {
        Cliente Cliente = new Cliente();

        public FormClientes(ref ToolStripTextBox Filtro)
        {
            InitializeComponent();
            Cliente.EstablecerDatos(ref DataGridViewClientes);
            Filtro.KeyPress += new KeyPressEventHandler(this.Filtrar);
        }

        private void Filtrar(object sender, EventArgs e)
        {
            ToolStripTextBox filtro = (ToolStripTextBox)sender;
            Cliente.EstablecerFiltro(ref DataGridViewClientes, filtro.Text);
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
    }
}
