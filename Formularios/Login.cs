using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using LuiguiBaretta.Clases;
using System.Data.Sql;



namespace LuiguiBaretta
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            SqlDataSourceEnumerator servidores = SqlDataSourceEnumerator.Instance;

            this.comboBoxServidores.DataSource = servidores.GetDataSources();
            this.comboBoxServidores.DisplayMember = "ServerName";

            this.comboboxUser.DataSource = ConsultasBaseDeDatos.loginarametre("select name from master.sys.syslogins where dbname = 'LuiguiBaretta'");
            this.comboboxUser.DisplayMember = "name";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objcon = new SqlConnection("Data Source = "+ System.Environment.MachineName + "; User ID=" + this.comboboxUser.Text + ";Password=" + this.texboxPassword.Text + ";");
                objcon.Open();
                objcon.Close();
                ConsultasBaseDeDatos.ServerName = this.comboBoxServidores.Text;
                ConsultasBaseDeDatos.CadenaConexion = "Data Source = " + this.comboBoxServidores.Text + "; User ID=" + this.comboboxUser.Text + ";Password=" + this.texboxPassword.Text + ";";
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuario o contraseña incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
