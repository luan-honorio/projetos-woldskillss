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

namespace testeprova01
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();





            btnentrar.Click += (s, e) =>
            {

                SqlConnection conn;
                string sqlcon;

                SqlCommand cmd = new SqlCommand();
                SqlDataReader rdr;


                sqlcon = @"Data source=DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
                conn = new SqlConnection(sqlcon);
                conn.Open();



                string sql;
                sql = "select senha from usuario where email = @email";
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text;


                cmd.CommandText = sql;
                cmd.Connection = conn;
                rdr = cmd.ExecuteReader();

                rdr.Read();
                string email = txtemail.Text;
                if(txtsenha.Text != rdr["senha"].ToString())
                {
                    MessageBox.Show("senha incorreta");
                }


                esqueceu.Click += (ss, args )=>
                {
                    this.Hide();
                    REDEFINIRSENHA rEDEFINIRSENHA = new REDEFINIRSENHA(email);
                    rEDEFINIRSENHA.ShowDialog();

                };
            };

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrar cadastrar = new cadastrar();
            cadastrar.ShowDialog();
        }

        private void esqueceu_Click(object sender, EventArgs e)
        {
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
