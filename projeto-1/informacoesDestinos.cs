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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class informacoesDestinos : Form
    {
        public informacoesDestinos(string nome, string id_destino, string descricao, string data, string endereco, PictureBox pic,string id_usuario)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


            label1.Text = nome;
            label2.Text = descricao;
            label4.Text = data;
            label5.Text = endereco;
            pictureBox1.Image = pic.BackgroundImage;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            SqlConnection cn;
            string sqlcon;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;


            try
            {
                sqlcon = @"Data source= DESKTOP-B8E4I0L\SQLEXPRESS; integrated security=SSPI; Initial catalog=registros ";
                cn = new SqlConnection(sqlcon);
                cn.Open();
                

                string sql;
                sql = @"select descricao from avaliacao where id_destino = @id_destino; ";
                cmd.Parameters.Add(@"id_destino", SqlDbType.Int).Value = Convert.ToInt32(id_destino);

                cmd.Connection = cn;
                cmd.CommandText = sql;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                   
                    Label label41 = new Label();
                    label41.Text = dr["descricao"].ToString();
                    label41.BorderStyle = BorderStyle.FixedSingle;
                    label41.Width = 100;
                    label41.Height = 20;
                    label41.TextAlign = ContentAlignment.MiddleCenter;

                    flowLayoutPanel1.Controls.Add(label41);
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show("" + erro);
            }


            button1.Click += (s, e) =>
            {
                this.Hide();
                avaliar avaliar = new avaliar(id_destino,id_usuario);
                avaliar.ShowDialog();
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

        private void informacoesDestinos_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
