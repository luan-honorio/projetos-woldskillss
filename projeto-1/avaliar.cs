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
    public partial class avaliar : Form
    {

        public avaliar(string id_destino, string id_usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            button1.Click += (s, e) =>
            {

                int ponto;
                if (checkBox1.Checked)
                {
                    ponto = 1;
                }
                else if (checkBox2.Checked)
                {
                    ponto = 2;
                }
                else if (checkBox3.Checked)
                {
                    ponto = 3;
                }
                else if (checkBox4.Checked)
                {
                    ponto = 4;
                }
                else if (checkBox5.Checked)
                {
                    ponto = 5;
                }
                else
                {
                    ponto = 0;
                }



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
                    sql = "insert into avaliacao (id_destino, id_usuario, descricao, pontuacao) values (@id_destino,@id_usuario,@descricao,@pontos);";
                    cmd.Parameters.Add("@id_destino", SqlDbType.Int).Value = Convert.ToInt32(id_destino);
                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int).Value = Convert.ToInt32(id_usuario);
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = descricao.Text;
                    cmd.Parameters.Add("@pontos", SqlDbType.Int).Value = ponto;

                    cmd.Connection = cn;
                    cmd.CommandText = sql;
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("alaviacao enviada");
                }
                catch (SqlException erro)
                {


                    MessageBox.Show("nao " + erro);


                }
            };

            button3.Click += (s, e) =>
            {
                this.Hide();
                homeUser homeUser = new homeUser(id_usuario);
                homeUser.ShowDialog();
            };
            button2.Click += (s, e) => { 
                this.Hide();
                perfilUser perfilUser = new perfilUser(id_usuario);
                perfilUser.ShowDialog();   
            
            
            };



        }

        private void avaliar_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
