using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTeladeLogin : Form
    {


        SqlConnection Conexao = new SqlConnection(@"Data Source=000810al29;Initial Catalog=LoginCharp;Integrated Security=True");
        public frmTeladeLogin()
        {
            InitializeComponent();
            txtUsuario.Select();
        }

        private void pctExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Conexao.Open();
            string query = "SELECT * FROM Usuario WHERE Username = '" + txtUsuario.Text + "' AND Password = '" + txtSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                frmAcessodoAluno principal = new frmAcessodoAluno();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou Senha está incorreto", "OOPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTeladeLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
