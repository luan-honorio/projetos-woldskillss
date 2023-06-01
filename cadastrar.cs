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
            btncadastrar.Enabled = false;



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


                        sqlcon = @"Data source=DESKTOP-ISNQG64\SQLEXPRESS; integrated security=SSPI; initial catalog=teste01";
                        conn = new SqlConnection(sqlcon);
                        conn.Open();


                        string sql;
                        string sqlexiste;
                      
                        sqlexiste = "select * from usuario where emial = @email ";
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text;

                        cmd.CommandText = sqlexiste;
                        cmd.Connection = conn; 
                        rdr = cmd.ExecuteReader();

                       
                        if (rdr.Read())
                        {
                            MessageBox.Show("emial ja existe");
                            
                        }
                        


                        else
                        {
                            rdr.Close();
                            sql = "INSERT INTO usuario (nome,data_nascimento,timeFavorito,sexo,emial,senha) values (@nome,@data_nascimento,@timeFavorito,@sexo,@email2,@senha)";
                            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text;
                            cmd.Parameters.Add("@data_nascimento", SqlDbType.VarChar).Value = data.Value;
                            cmd.Parameters.Add("@timeFavorito", SqlDbType.VarChar).Value = time.Text;
                            cmd.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                            cmd.Parameters.Add("@email2", SqlDbType.VarChar).Value = txtemail.Text;
                            cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtsenha.Text;

                            cmd.CommandText = sql;
                            cmd.Connection = conn;
                            rdr = cmd.ExecuteReader() ;

                        }



                    }
                    catch (SqlException erro)
                    {
                        MessageBox.Show("" + erro);

                    }
                }



            };
        }

        private void campos()
        {
            if (!string.IsNullOrWhiteSpace(txtnome.Text) && !string.IsNullOrWhiteSpace(txtemail.Text) && !string.IsNullOrWhiteSpace(txtsenha.Text) && !string.IsNullOrWhiteSpace(time.Text)) 
            {
                btncadastrar.Enabled = true;
            }
            else
            {
                btncadastrar.Enabled=false;
            }
        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            campos();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            campos();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            campos();
        }

        private void time_SelectedIndexChanged(object sender, EventArgs e)
        {
            campos();
        }
    }
}



