using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp2
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            pictureBox1.Click += (s, arg) =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(openFileDialog.FileName);



                }

            };
        }
            
 
        private void button1_Click(object sender, EventArgs e)
        {
            
                int id_genero;
                if(masculino.Checked)
            {
                id_genero = 1;
            } else if(feminino.Checked)
            {
                id_genero = 2;
            }
            else
            {
                id_genero= 3;
            }

            int id_perfil;
            if(user.Checked)
            {
                id_perfil = 2;

            }
            else
            {
                id_perfil = 1;
            }



            if(txtnome.Text =="" | txtendereco.Text == "" | txtTelefone.Text == "" | txtsenha.Text == "" | txtemail.Text == "")
            {
                MessageBox.Show("Todos os campos sao obrigatorios");
                return;
            }

            string email = txtemail.Text;
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            bool valido = Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);

            if (valido)
            {
                MessageBox.Show("email invalido");
            }
            else
            {
                try
                {
                    SqlConnection cn;
                    string sqlcon;
                    SqlCommand cmd = new SqlCommand();
                    SqlDataReader dr;


                    sqlcon = @"Data source= DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; Initial catalog=registros ";
                    cn = new SqlConnection(sqlcon);
                    cn.Open();


                    string sql;
                    sql = "INSERT INTO usuario (id_perfil,id_genero,nome,telefone,email,endereco,senha,foto) values (@id_perfil,@id_genero,@nome,@telefone,@email,@endereco,@senha,@foto) ";
                    cmd.Parameters.Add("@id_perfil", SqlDbType.Int).Value = id_perfil;
                    cmd.Parameters.Add("@id_genero", SqlDbType.Int).Value = id_genero;
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtnome.Text;
                    cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = txtTelefone.Text;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtemail.Text;
                    cmd.Parameters.Add("@endereco", SqlDbType.VarChar).Value = txtendereco.Text;
                    cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = txtsenha.Text;
                    cmd.Parameters.Add("@foto", SqlDbType.Image).Value = foto();

                    cmd.CommandText = sql;
                    cmd.Connection = cn;
                    dr = cmd.ExecuteReader();




                    MessageBox.Show("cadastrado");

                }
                catch (SqlException erro)
                {
                    MessageBox.Show(erro.Message);
                }

            }





        }

        private byte[] foto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, pictureBox1.Image.RawFormat);
            return stream.GetBuffer();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
