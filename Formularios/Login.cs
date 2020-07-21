using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LuiguiBaretta
{
    public partial class Login : Form
    {

        public bool Encendido { get; set; }

        public Login()
        {
            ConsultasBaseDeDatos.Creacion_base_de_datos();
            InitializeComponent();
            Encendido = false;
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.comboboxUser.DataSource = ConsultasBaseDeDatos.loginarametre("select name from master.sys.syslogins where dbname = 'LuiguiBaretta'");
            this.comboboxUser.DisplayMember = "name";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objcon = new SqlConnection("Data Source = ; User ID=" + this.comboboxUser.Text + ";Password=" + this.texboxPassword.Text + ";");
                objcon.Open();
                objcon.Close();
                ConsultasBaseDeDatos.CadenaConexion = "Data Source = ; User ID=" + this.comboboxUser.Text + ";Password=" + this.texboxPassword.Text + ";";
                Encendido = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuario o contraseña incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
