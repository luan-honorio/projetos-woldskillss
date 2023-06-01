using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

                string[] nomes = txtnome.Text.Trim().Split(' ');
                if (nomes.Length < 2)
                {
                    MessageBox.Show("Digite pelo menos 2 nomes");
                    return;
                }



                else if (txtsenha.Text == "" | txtnome.Text == "" | txtemail.Text == "" | time.Text == "")
                {
                    MessageBox.Show("Todos os campos sao obrigatórios!!");
                    return;
                }


                if (!txtemail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("email invalido, adicione (@gmail.com)");
                }

                if (txtsenha.Text.Length < 8 | !txtsenha.Text.Any(char.IsLower) | !txtsenha.Text.Any(char.IsUpper)| !txtsenha.Text.Any(c => !char.IsLetterOrDigit(c))| !Regex.IsMatch(txtsenha.Text, @"\d{1,}"))
                {
                    MessageBox.Show("a senha tem que conter no minimo 8 caracteres, letra maiuscula e minuscula, numeros e caracter especial");
                }

               
               


                else
                {
                    int sexo;
                    if (masculino.Checked)
                    {
                        sexo = 1;
                    }
                    else
                    {
                        sexo = 2;
                    };


                    try
                    {

                        SqlConnection conn;
                        string sqlcon;

                        SqlCommand cmd = new SqlCommand();
                        SqlDataReader rdr;


                        sqlcon = @"Data source=DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
                        conn = new SqlConnection(sqlcon);
                        conn.Open();


                        string sql;
                        sql = "INSERT INTO usuario (nome,data_nascimento,timeFavorino,sexo,email,senha) values (@nome,@data_nascimento,@timeFavorito,@sexo,@email,@senha)";
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
                    catch (SqlException erro)
                    {
                        MessageBox.Show("" + erro);

                    }
                }



            };
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }



    }
}



