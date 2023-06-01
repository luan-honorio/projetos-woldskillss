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
    public partial class Addnotificacao : Form
    {
        public Addnotificacao()
        {
            InitializeComponent();
            btnsalvar.Enabled = true;




            btnsalvar.Click += (s,e)=>{
                try
                {
                    SqlConnection conn;
                    string sqlcon;

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader rdr;


                    sqlcon = @"Data source=DESKTOP-ISNQG64\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
                    conn = new SqlConnection(sqlcon);
                    conn.Open();

                    string sql;
                    sql = "INSERT INTO notificacao (titulo,descricao,timeFavorito,grau,data) values (@titulo,@descricao,@timeFavorito,@grau,@data)";
                    cmd.Parameters.Add("@titulo",SqlDbType.VarChar).Value = titulo.Text;
                    cmd.Parameters.Add("@descricao",SqlDbType.VarChar).Value = descricao.Text ;
                    cmd.Parameters.Add("@timeFavorito", SqlDbType.VarChar).Value =grau.Text;
                    cmd.Parameters.Add("@grau", SqlDbType.VarChar).Value = grau.Text ;
                    cmd.Parameters.Add("@data", SqlDbType.VarChar).Value = data.Value ;
                    



                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    rdr = cmd.ExecuteReader();

                    MessageBox.Show("notificaçao adicionada");


                }
                catch (SqlException erro) {
                    MessageBox.Show(""+erro);
                
                }

            };
        }
    }
}
