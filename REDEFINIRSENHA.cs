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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace testeprova01
{
    public partial class REDEFINIRSENHA : Form
    {
        public REDEFINIRSENHA(string email)
        {
        
            InitializeComponent();
            
       

            alterarsenha.Click += (s, e)=>{

                if (txtnovasenha.Text != txtconfirma.Text)
                {
                    MessageBox.Show("Verifique se as senhas estão iguais");
                }

               else
                {
                    try
                    {
                        SqlConnection conn;
                        string sqlcon;


                        sqlcon = @"Data source=DESKTOP-ISNQG64\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
                        conn = new SqlConnection(sqlcon);
                        conn.Open();

                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader rdr;
                        string sql;
                        sql = "update usuario set  senha=@senha, timeFavorito=@time, data_nascimento=@data  where emial = @email";
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                        cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtconfirma.Text;
                        cmd.Parameters.Add("@time", SqlDbType.VarChar).Value = time.Text;
                        cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = data.Value;


                        cmd.CommandText = sql;
                        cmd.Connection = conn;
                        rdr = cmd.ExecuteReader();

                        rdr.Read();

                        string datanasc = rdr["data_nascimento"].ToString();
                        string timefavorito = rdr["timeFavorito"].ToString();

                      

                        MessageBox.Show("alterado com sucesso");
                    }
                    catch(SqlException erro)
                    {
                        MessageBox.Show("" + erro);
                    }

                };





            };
           




            label5.Click += (s, e) =>
            {
                this.Hide();
                login login = new login();
                login.ShowDialog();
            };
        }

        private void verificar(string email)
        {
            SqlConnection conn;
            string sqlcon;


            sqlcon = @"Data source=DESKTOP-ISNQG64\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
            conn = new SqlConnection(sqlcon);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr;
            string sql;
            sql = "select data_nascimento,timeFavorito from usuario where emial = @emial";

            cmd.CommandText = sql;
            cmd.Connection = conn;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = email;

            if (data.Text != rdr["data_nascimento"].ToString())
            {
               alterarsenha.Enabled = true;
            }
            else
            {
                alterarsenha.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

      
    }
}
