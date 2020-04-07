using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuiguiBaretta.Clases;

namespace LuiguiBaretta
{
    public partial class Editar_Cliente : Form
    {
        private int id_cliente = 0;

        public Editar_Cliente(String metodo)
        {
            InitializeComponent();
            this.LabelTitulo.Text = metodo + " Cliente";
        }

        public Editar_Cliente(String metodo, ref DataGridView dataGridView)
        {
            InitializeComponent();
            this.LabelTitulo.Text = metodo + " Cliente";
            this.id_cliente = int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
            this.TextBoxNombre.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            this.TextBoxDireccion.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            this.TextBoxTelefono.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            this.TextBoxRUC.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            this.TextBoxRazonSocial.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if(this.LabelTitulo.Text == "Registrar Cliente")
            {
                ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("Exec RegistrarCliente '" +
                    this.TextBoxNombre.Text + "', '" +
                    this.TextBoxDireccion.Text + "', '" +
                    this.TextBoxTelefono.Text + "', '" +
                    this.TextBoxRUC.Text + "', '" +
                    this.TextBoxRazonSocial.Text + "'");
                MessageBox.Show("Registro Realiado con éxito", "Finalizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                ConsultasBaseDeDatos.EjecutarProcedimientoEnBDLuiguiBaretta("Exec EditarCliente '" +
                    this.id_cliente + "', '" +
                    this.TextBoxNombre.Text + "', '" +
                    this.TextBoxDireccion.Text + "', '" +
                    this.TextBoxTelefono.Text + "', '" +
                    this.TextBoxRUC.Text + "', '" +
                    this.TextBoxRazonSocial.Text + "'");
                MessageBox.Show("Edicion Realiada con éxito", "Finalizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
