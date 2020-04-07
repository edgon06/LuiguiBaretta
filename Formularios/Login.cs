using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            this.User.DataSource = ConsultasBaseDeDatos.loginarametre("select name from master.sys.syslogins where dbname = 'LuiguiBaretta'");
            this.User.DisplayMember = "name";
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objcon = new SqlConnection("Data Source = "+ System.Environment.MachineName + "; User ID=" + this.User.Text + ";Password=" + this.Password.Text + ";");
                objcon.Open();
                objcon.Close();
                ConsultasBaseDeDatos.CadenaConexion = "Data Source = " + System.Environment.MachineName + "; User ID=" + this.User.Text + ";Password=" + this.Password.Text + ";";
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Usuario o contraseña incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
