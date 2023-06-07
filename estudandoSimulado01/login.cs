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

namespace estudandoSimulado01
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                string sqlcon;
                sqlcon = @"DATA SOURCE=DESKTOP-ISNQG64\SQLEXPRESS ; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=Sessao5";
                con = new SqlConnection(sqlcon);
                cmd.Connection = con;
                cmd.CommandText = sqlcon;
                con.Open();
                

                string sql;
                sql = "select Senha, Email from Usuarios where Email = @email";
                cmd.Parameters.Add("@email",SqlDbType.VarChar).Value = txtemail.Text;
                cmd.CommandText = sql;
                cmd.Connection = con;
                dr = cmd.ExecuteReader();

                if (!dr.Read())
                {
                    MessageBox.Show("email não cadastrado");
                }else if (dr["Senha"].ToString() != txtsenha.Text)
                {
                    MessageBox.Show("Senha incorreta");
                    recuperar(dr["Email"].ToString());
                    
                }

               
            }
            catch (SqlException erro)
            {
                MessageBox.Show("" + erro);
            }
           
        }

        private void recuperar(string email)
        {
            btnsenhanova.Click += (s, ev) =>
            {
                this.Hide();
                redefinirsenha redefinirsenha = new redefinirsenha(email);
                redefinirsenha.ShowDialog();
            };
        }

        private void btncadastrese_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastro cadastro = new cadastro();
            cadastro.ShowDialog();
        }
    }
}
