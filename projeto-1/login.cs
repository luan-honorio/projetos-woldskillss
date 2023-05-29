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

namespace WindowsFormsApp2
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

           

            if (txtEmail.Text.Trim() == "" | txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("todos os campos obrigatorios");
                return;
            }
            else
            {
                SqlConnection cn;
                string sqlcon;
                SqlCommand cmd = new SqlCommand();
                SqlDataReader dr;

                sqlcon = @"Data source= DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; Initial catalog=registros ";
                cn = new SqlConnection(sqlcon);
                cn.Open();



                string sql;
                sql = "select id_perfil,id_usuario, email , senha from usuario where email = @email ";


                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Connection = cn;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                dr.Read();

                string id_usuario = dr["id_usuario"].ToString();
                string id_perfil = dr["id_perfil"].ToString();  
                string email = dr["email"].ToString();
                string senha = dr["senha"].ToString();

                
                
                    if (txtEmail.Text != email)
                    {
                        MessageBox.Show("email invalido");
                    }
                    else if (txtSenha.Text != senha)
                    {
                        MessageBox.Show("senha incorreta  ");
                    }

                    else
                    {
                        if(id_perfil == "1")
                        {   
                        this.Hide();
                        homeAdm homeAdm = new homeAdm(id_usuario);
                        homeAdm.ShowDialog();
                        }
                        else
                    {
                        this.Hide();
                        homeUser homeUser = new homeUser(id_usuario);
                        homeUser.ShowDialog();
                    }
                    }
                

               

              
               
            

              
               


                }







            }
          


        }
    }

