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
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
      


            
            

            label9.Click += (s, e) =>
            {
                this.Hide();
                login login = new login();
                login.ShowDialog();
            };


  
                

            btncadastrar.Click += (s, e) =>
            {

                int sexo;
                if(masculino.Checked)
                {
                    sexo = 1;
                }
                else
                {
                    sexo = 2;
                };


                string senha = txtsenha.Text;
                if(senha.Length< 8){
                    MessageBox.Show("senha fraca");
                    return;
                }
                 
                try
                {

                    SqlConnection conn;
                    string sqlcon;

                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader rdr;


                    sqlcon = @"Data source= DESKTOP-ISNQG64\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
                    conn = new SqlConnection(sqlcon);
                    conn.Open();


                    string sql;
                    sql = "INSERT INTO usuario (nome,data_nascimento,timeFavorito,sexo,emial,senha) values (@nome,@data_nascimento,@timeFavorito,@sexo,@email,@senha)";
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text;
                    cmd.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = data.Value;
                    cmd.Parameters.Add("@timeFavorito", SqlDbType.VarChar).Value = time.Text;
                    cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtsenha.Text;

                    cmd.CommandText = sql;
                    cmd.Connection = conn;
                    rdr = cmd.ExecuteReader();




                    MessageBox.Show("conct");



                }
                catch  (SqlException erro){
                    MessageBox.Show(""+erro);

                }



            };
        }

      

        
    }


}
